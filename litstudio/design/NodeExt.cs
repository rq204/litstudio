using litcore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litstudio
{
    internal static class NodeExt
    {
        public static GraphicsPath Render(this litsdk.Node node, Graphics g, litsdk.Rect r, NodeStyle o)
        {
            var path = new GraphicsPath();
            path.StartFigure();

            if (node.GetType() == typeof(litcore.LoopStartNode))
            {
                path.AddPolygon(new Point[]
                {
                new Point(r.X + PageRenderOptions.GridSize, r.Y),
                new Point(r.Right - PageRenderOptions.GridSize, r.Y),
                new Point(r.Right, r.Y + PageRenderOptions.GridSize),
                new Point(r.Right, r.Bottom),
                new Point(r.X, r.Bottom),
                new Point(r.X, r.Y + PageRenderOptions.GridSize)
                });
            }
            else if (node.GetType() == typeof(litcore.LoopEndNode))
            {
                path.AddPolygon(new Point[]
                {
                new Point(r.X, r.Y),
                new Point(r.Right, r.Y),
                new Point(r.Right, r.Bottom - PageRenderOptions.GridSize),
                new Point(r.Right - PageRenderOptions.GridSize, r.Bottom),
                new Point(r.X + PageRenderOptions.GridSize, r.Bottom),
                new Point(r.X, r.Bottom - PageRenderOptions.GridSize)
                });
            }
            else if (node.GetType() == typeof(litcore.DecisionNode))
            {
                path.AddPolygon(new Point[]
                {
                r.CenterTop,
                r.CenterRight,
                r.CenterBottom,
                r.CenterLeft
                });
            }
            else if (node.GetType() == typeof(litcore.EndNode))
            {
                var leftRect = new Rectangle(r.X, r.Y, r.Height, r.Height);
                var rightRect = new Rectangle(r.Right - r.Height, r.Y, r.Height, r.Height);

                path.AddArc(leftRect, 90, 180);
                path.AddArc(rightRect, -90, 180);
            }
            else if (node.GetType() == typeof(litcore.StartNode))
            {
                var leftRect = new Rectangle(r.X, r.Y, r.Height, r.Height);
                var rightRect = new Rectangle(r.Right - r.Height, r.Y, r.Height, r.Height);

                path.AddArc(leftRect, 90, 180);
                path.AddArc(rightRect, -90, 180);
            }
            else if (node.GetType() == typeof(litcore.ProcessNode))
            {
                path.AddRectangle(r);
            }

            path.CloseFigure();
            g.FillPath(o.BackBrush, path);
            g.DrawPath(o.BorderPen, path);
            return path;
        }


        public static void RenderText(this litsdk.Node node, Graphics g, litsdk.Rect r, NodeStyle o)
        {
            g.DrawString(node.Activity.Name, o.Font, o.FontBrush, r, o.StringFormat);
        }

        public static void SetBounds(this litsdk.Node node, litsdk.Rect rect)
        {
            rect.X = Math.Max(0, (rect.X / PageRenderOptions.GridSize) * PageRenderOptions.GridSize);
            rect.Y = Math.Max(0, (rect.Y / PageRenderOptions.GridSize) * PageRenderOptions.GridSize);
            foreach (var port in node.Ports)
            {
                port.UpdateBounds(rect);
            }
            node.Bounds = rect;
        }

        public static litsdk.Port GetPortFromPoint(this litsdk.Node node, Point pt)
        {
            foreach (KeyValuePair<litsdk.Port, object> item in node.RenderedPorts)
            {
                GraphicsPath path = item.Value as GraphicsPath;
                if (path.IsVisible(pt.X, pt.Y)) return item.Key;
            }
            return null;
        }

    }
}
