using litcore;
using litcore.activity;
using litsdk;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace litstudio
{
    internal partial class Page : IDisposable
    {
        public List<Node> Nodes { get; set; }

        public List<T> GetNodes<T>() where T : Node
        {
            return this.Nodes.Where(x => x is T).Cast<T>().ToList();
        }

        private Node currentNode = null;

        public void Page_OnNodeChanged(Node node)
        {
            this.currentNode = node;
            this.Canvas.Invalidate();
            if (node is LoopStartNode || node is LoopEndNode)
                System.Threading.Thread.Sleep(30);
            if (Option.option.DebugSleep > 0) System.Threading.Thread.Sleep(Option.option.DebugSleep);
        }

        internal void Invalidate()
        {
            this.Canvas.Invalidate();
        }

        private Page()
        {
            this.Nodes = new List<Node>();
            this.Initialize_Events();
        }

        public static Page Create()
        {
            var p = new Page();

            p.AddNode(typeof(StartActivity).FullName,
                PageRenderOptions.GridSize * 15,
                PageRenderOptions.GridSize * 5);

            p.AddNode(typeof(EndActivity).FullName,
                PageRenderOptions.GridSize * 15,
                PageRenderOptions.GridSize * 15);

            return p;
        }

        private Node GetNodeById(Guid id)
        {
            return this.Nodes.FirstOrDefault(x => x.Id == id);
        }

        private Node AddNode(string activityId, int x, int y)
        {
            Node node;
            var activity = litcore.ActivityLoader.GetInstance(activityId);
            if (activity is StartActivity)
            {
                node = new StartNode(activity)
                {

                };
            }
            else if (activity is EndActivity)
            {
                node = new EndNode(activity)
                {

                };
            }
            else if (activity is ProcessActivity)
            {
                node = new ProcessNode(activity);
            }
            else if (activity is DecisionActivity)
            {
                node = new DecisionNode(activity);
            }
            else if (activity is LoopStartActivity)
            {
                node = new LoopStartNode(activity)
                {
                    //Name = "开始循环"
                };
                var loopStartNode = node as LoopStartNode;
                var loopEndNode = this.AddNode(typeof(LoopEndActivity).FullName, x, y + PageRenderOptions.GridSize * 10) as LoopEndNode;
                loopStartNode.LoopEndNodeId = loopEndNode.Id;
                loopEndNode.LoopStartNodeId = loopStartNode.Id;
            }
            else if (activity is LoopEndActivity)
            {
                node = new LoopEndNode(activity)
                {
                    //Name = "结束循环"
                };
            }
            else
            {
                throw new NotSupportedException();
            }
            var bounds = node.Bounds;
            bounds.X = x - bounds.Width / 2;
            bounds.Y = y - bounds.Height / 2;
            node.SetBounds(bounds);
            this.Nodes.Add(node);
            return node;
        }

        private void RemoveNode(Node node)
        {
            if (node is StartNode)
            {
                MessageBox.Show("Start activity cannot be deleted.");
            }
            else if (node is LoopStartNode loopStartNode)
            {
                if (this.GetNodeById(loopStartNode.LoopEndNodeId) is Node relatedNode)
                {
                    this.Nodes.Remove(relatedNode);
                }
                this.Nodes.Remove(node);
            }
            else if (node is LoopEndNode loopEndNode)
            {
                if (this.GetNodeById(loopEndNode.LoopStartNodeId) is Node relatedNode)
                {
                    this.Nodes.Remove(relatedNode);
                }
                this.Nodes.Remove(node);
            }
            else
            {
                this.Nodes.Remove(node);
            }
        }


        public void Dispose()
        {

        }

        /// <summary>
        /// 是否在处理undo
        /// </summary>
        public bool UnRedoing = false;
        Stack<UndoCmd> undoStack = new Stack<UndoCmd>();
        Stack<UndoCmd> redoStack = new Stack<UndoCmd>();

        internal void Undo()
        {
            if (this.undoStack.Count == 0) return;
            this.UnRedoing = true;
            try
            {
                UndoCmd com = this.undoStack.Pop();
                com.Undo(this);
                this.redoStack.Push(com);
            }
            finally
            {
                this.UnRedoing = false;
            }
        }

        internal void Redo()
        {
            if (this.redoStack.Count == 0) return;
            this.UnRedoing = true;
            try
            {
                UndoCmd com = this.redoStack.Pop();
                com.Redo(this);
                this.undoStack.Push(com);
            }
            finally
            {
                this.UnRedoing = false;
            }
        }

        private string OldUndoStr = "";

        /// <summary>
        /// 变化的事件
        /// </summary>
        private void PageUndoChange()
        {
            if (!this.UnRedoing)
            {
                string nodeStr = Newtonsoft.Json.JsonConvert.SerializeObject(this.Nodes, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                if (nodeStr == OldUndoStr) return;
                UndoCmd cmd = new UndoCmd() { NewStr = nodeStr, OldStr = OldUndoStr };
                this.undoStack.Push(cmd);
                OldUndoStr = nodeStr;
            }
        }
    }
}