using litsdk;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace litsdk
{
    /// <summary>
    /// 节点配置
    /// </summary>
    public abstract class Node
    {
        public Guid Id { get; set; }

        public Rect Bounds { get; set; }

        public Activity Activity { get; set; }

        public List<Port> Ports { get; set; }

        protected Node()
        {
            this.Ports = new List<Port>();
            this.RenderedPorts = new Dictionary<Port, object>();
        }

        public static int GridSize = 20;
        public Node(Activity activity) : this()
        {
            this.Activity = activity;
            this.Id = Guid.NewGuid();
            this.Bounds = new Rectangle(
                GridSize * 0,
                GridSize * 0,
                GridSize * 4,
                GridSize * 2);
        }

        [JsonIgnore]
        public Dictionary<Port, object> RenderedPorts { get; set; }

        [JsonIgnore]
        public virtual bool CanStartLink => true;

        [JsonIgnore]
        public virtual bool CanEndLink => true;

        //public void SetBounds(Rect rect)
        //{
        //    rect.X = Math.Max(0, (rect.X / PageRenderOptions.GridSize) * PageRenderOptions.GridSize);
        //    rect.Y = Math.Max(0, (rect.Y / PageRenderOptions.GridSize) * PageRenderOptions.GridSize);
        //    foreach (var port in this.Ports)
        //    {
        //        port.UpdateBounds(rect);
        //    }
        //    this.Bounds = rect;
        //}

        //public Port GetPortById(Guid id)
        //{
        //    return this.Ports.FirstOrDefault(x => x.Id == id);
        //}

        //public Port GetPortFromPoint(Point pt)
        //{
        //    if (this.RenderedPorts.FirstOrDefault(x => x.Value.IsVisible(pt.X, pt.Y)) is KeyValuePair<Port, GraphicsPath> item)
        //    {
        //        return item.Key;
        //    }
        //    return null;
        //}

        public abstract Guid Execute(ActivityContext context);

        //public abstract GraphicsPath Render(Graphics g, Rect r, NodeStyle o);

        //public virtual void RenderText(Graphics g, Rect r, NodeStyle o)
        //{
        //    g.DrawString(this.Activity.Name, o.Font, o.FontBrush, r, o.StringFormat);
        //}
    }
}