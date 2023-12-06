using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace litstudio
{
    internal partial class Page
    {
        public System.Action<litsdk.Node> F5Action = null;
        public System.Action F6Action = null;

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.DeleteNode();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                this.SelectAllNodes();
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.F5Run();
            }
            else if (e.KeyCode == Keys.F6)
            {
                this.F6Stop();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                this.CtrlC();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
            {
                this.CtrlV();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.M)
            {
                this.CtrlM();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                this.Undo();
            }
            else if(e.Modifiers== Keys.Control && e.KeyCode == Keys.Y)
            {
                this.Redo();
            }
        }

        private void F6Stop()
        {
            if (F6Action != null) F6Action();
        }

        internal void CtrlV()
        {
            string json = Clipboard.GetText();

            if (!string.IsNullOrEmpty(json) && json.StartsWith("{"))
            {
                List<string> names = new List<string>();
                foreach (litsdk.Node n in this.Nodes) names.Add(n.Activity.Name);

                try
                {
                    Dictionary<Guid, Guid> olds2news = new Dictionary<Guid, Guid>();
                    Dictionary<Guid, Guid> news2olds = new Dictionary<Guid, Guid>();
                    HashSet<litsdk.Node> adds = Newtonsoft.Json.JsonConvert.DeserializeObject<HashSet<litsdk.Node>>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
                    foreach (litsdk.Node add in adds)
                    {
                        Guid old = add.Id;
                        add.Id = System.Guid.NewGuid();
                        olds2news.Add(old, add.Id);
                        news2olds.Add(add.Id, old);
                    }

                    List<litcore.LoopStartNode> loopStarts = new List<litcore.LoopStartNode>();
                    List<litcore.LoopEndNode> loopEnds = new List<litcore.LoopEndNode>();
                    foreach (litsdk.Node add in adds)
                    {
                        if(add is litcore.LoopStartNode startloop)
                        {
                            loopStarts.Add(startloop);
                        }
                        else if(add is litcore.LoopEndNode endloop)
                        {
                            loopEnds.Add(endloop);
                        }

                        foreach (var p in add.Ports)
                        {
                            if (olds2news.ContainsKey(p.NextNodeId))
                            {
                                p.NextNodeId = olds2news[p.NextNodeId];
                            }
                            else
                            {
                                p.NextNodeId = Guid.Empty;
                            }
                            p.ReSetId();
                        }
                        add.RenderedPorts.Clear();
                        if (names.Contains(add.Activity.Name)) add.Activity.Name += " - 复制";
                        add.SetBounds(new litsdk.Rect(add.Bounds.X + 100, add.Bounds.Y, add.Bounds.Width, add.Bounds.Height));
                        this.Nodes.Add(add);
                    }

                    #region 循环要成对复制
                    while (loopStarts.Count > 0)
                    {
                        litcore.LoopStartNode start = loopStarts[0];
                        loopStarts.Remove(start);
                        litcore.LoopEndNode end = loopEnds.Find((f) => f.LoopStartNodeId == news2olds[start.Id]);
                        if (end != null)
                        {
                            end.LoopStartNodeId = start.Id;
                            start.LoopEndNodeId = end.Id;
                            loopEnds.Remove(end);
                        }
                        else
                        {
                            //没有复制进来
                            litcore.LoopEndNode node = this.Nodes.Find((m) => m is litcore.LoopEndNode le && le.LoopStartNodeId == news2olds[start.Id]) as litcore.LoopEndNode;
                            litcore.LoopEndNode nodenew = Newtonsoft.Json.JsonConvert.DeserializeObject<litcore.LoopEndNode>(Newtonsoft.Json.JsonConvert.SerializeObject(node, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All }), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
                            nodenew.Id = Guid.NewGuid();
                            nodenew.LoopStartNodeId = start.Id;
                            start.LoopEndNodeId = nodenew.Id;

                            nodenew.RenderedPorts.Clear();

                            nodenew.Activity.Name = start.Activity.Name;
                            nodenew.SetBounds(new litsdk.Rect(nodenew.Bounds.X + 100, nodenew.Bounds.Y, nodenew.Bounds.Width, nodenew.Bounds.Height));

                            adds.Add(nodenew);
                            this.Nodes.Add(nodenew);
                        }
                    }
                    //添加空的开始
                    while (loopEnds.Count > 0)
                    {
                        litcore.LoopEndNode end = loopEnds[0];
                        loopEnds.Remove(end);

                        litcore.LoopStartNode node = this.Nodes.Find((m) => m is litcore.LoopStartNode le && le.LoopEndNodeId == news2olds[end.Id]) as litcore.LoopStartNode;
                        litcore.LoopStartNode nodenew = Newtonsoft.Json.JsonConvert.DeserializeObject<litcore.LoopStartNode>(Newtonsoft.Json.JsonConvert.SerializeObject(node, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All }), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
                        nodenew.Id = Guid.NewGuid();
                        nodenew.LoopEndNodeId = end.Id;

                        foreach (var p in nodenew.Ports)
                        {
                            if (olds2news.ContainsKey(p.NextNodeId))
                            {
                                p.NextNodeId = olds2news[p.NextNodeId];
                            }
                            else
                            {
                                p.NextNodeId = Guid.Empty;
                            }
                            p.ReSetId();
                        }

                        end.LoopStartNodeId = nodenew.Id;
                        nodenew.RenderedPorts.Clear();
                        nodenew.Activity.Name = end.Activity.Name;
                        nodenew.SetBounds(new litsdk.Rect(nodenew.Bounds.X + 100, nodenew.Bounds.Y, nodenew.Bounds.Width, nodenew.Bounds.Height));

                        adds.Add(nodenew);
                        this.Nodes.Add(nodenew);
                    }
                    #endregion
                    this.PageUndoChange();
                    this.Canvas.Invalidate();
                }
                catch { }
            }
        }

        internal void CtrlC()
        {
            if (this.SelectedNodes.Count > 0)
            {
                if (F5Action != null)
                {
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(this.SelectedNodes, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
                    Clipboard.SetText(json);
                }
            }
        }

        internal void F5Run()
        {
            if (this.SelectedNodes.Count == 1)
            {
                litsdk.Node node = null;
                foreach (var selectedNode in this.SelectedNodes)
                {
                    node = selectedNode;
                    break;
                }
                if (node != null && F5Action != null) F5Action(node);
            }
        }


        internal void DeleteNode()
        {
            foreach (var selectedNode in this.SelectedNodes)
            {
                if (selectedNode == this.currentNode)
                {
                    this.currentNode = null;
                }
                this.RemoveNode(selectedNode);
            }
            this.SelectedNodes.Clear();
            this.PageUndoChange();
            this.Canvas.Invalidate();
        }

        internal void SelectAllNodes()
        {
            this.SelectedNodes.Clear();
            foreach (var node in this.Nodes)
            {
                this.SelectedNodes.Add(node);
            }
            this.Canvas.Invalidate();
        }

        /// <summary>
        /// 合并流程,有一个序列的话，添至这个序列，没有新添
        /// </summary>
        internal void CtrlM()
        {
            litsdk.Node first = null;
            litcore.activity.SequenceActivity sequence = null;
            List<litsdk.Node> nodes = new List<litsdk.Node>();

            foreach (var selectedNode in this.SelectedNodes)
            {
                if (selectedNode.Activity is litcore.activity.SequenceActivity)
                {
                    if (sequence == null) sequence = selectedNode.Activity as litcore.activity.SequenceActivity;
                    else
                    {
                        MessageBox.Show("流程合所选节点最多只能有一个序列", "请重新选择");
                        return;
                    }
                }
                else if (selectedNode.Activity is litsdk.ProcessActivity)
                {
                    if (first == null) first = selectedNode;
                    nodes.Add(selectedNode);
                }
                else
                {
                    MessageBox.Show("流程合所选节点必须全为功能组件", "请重新选择");
                    return;
                }
            }

            if (nodes.Count == 0)
            {
                MessageBox.Show("流程合所选节点功能组件不能为空", "请重新选择");
                return;
            }

            if (sequence == null)
            {
                sequence = new litcore.activity.SequenceActivity() { Name = "合并序列" };
                litcore.ProcessNode node = new litcore.ProcessNode(sequence);
                node.Bounds = first.Bounds;
                node.Ports = first.Ports;
                this.Nodes.Add(node);
            }

            foreach (var selectedNode in nodes)
            {
                sequence.Activities.Add(selectedNode.Activity as litsdk.ProcessActivity);
                this.RemoveNode(selectedNode);
            }

            this.SelectedNodes.Clear();
            this.PageUndoChange();
            this.Canvas.Invalidate();
        }
    }
}