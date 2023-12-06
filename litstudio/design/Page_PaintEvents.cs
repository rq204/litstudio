using litcore;
using litsdk;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace litstudio
{
    internal partial class Page
    {
        private Panel Canvas { get; set; }

        internal HashSet<Node> SelectedNodes { get; set; }

        private Dictionary<Node, GraphicsPath> RenderedNodes { get; set; }

        private Node GetNodeFromPoint(Point pt)
        {
            if (this.RenderedNodes.FirstOrDefault(x => x.Value.IsVisible(pt.X, pt.Y)) is KeyValuePair<Node, GraphicsPath> item)
            {
                return item.Key;
            }
            return null;
        }

        public void Show(Panel parent)
        {
            parent.Controls.Clear();
            this.Canvas.Parent = parent;
            this.OldUndoStr = Newtonsoft.Json.JsonConvert.SerializeObject(this.Nodes, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            this.Canvas.Invalidate();
        }

        private void Initialize_Events()
        {
            this.Canvas = new Panel();
            this.Canvas.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(this.Canvas, true);
            this.Canvas.Paint += Canvas_Paint;
            this.Canvas.MouseDown += Canvas_MouseDown;
            this.Canvas.KeyDown += Canvas_KeyDown;
            this.Canvas.AllowDrop = true;
            this.Canvas.DragEnter += Canvas_DragEnter;
            this.Canvas.DragDrop += Canvas_DragDrop;
            this.SelectedNodes = new HashSet<Node>();
            this.RenderedNodes = new Dictionary<Node, GraphicsPath>();
        }

        internal Action OnPaint = null;
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            this.RenderBackground(g, (sender as Control).ClientRectangle);

            this.RenderNodes(g);
            this.RenderLines(g);
            this.RenderPorts(g);

            if (this.SelectNodeRect != Rectangle.Empty)
            {
                e.Graphics.FillRectangle(PageRenderOptions.SelectionBackBrush, this.SelectNodeRect);
            }
            if (OnPaint != null) OnPaint();
        }

        private void RenderBackground(Graphics g, Rectangle r)
        {
            g.Clear(PageRenderOptions.BackColor);
            for (var y = 0; y < r.Height; y += PageRenderOptions.GridSize)
            {
                g.DrawLine(PageRenderOptions.GridPen, 0, y, r.Width, y);
            }
            for (var x = 0; x < r.Width; x += PageRenderOptions.GridSize)
            {
                g.DrawLine(PageRenderOptions.GridPen, x, 0, x, r.Height);
            }
        }

        private void RenderPorts(Graphics g)
        {
            if (this.MoveNodeOffsetPoint == Point.Empty)
            {
                var o = new NodeStyle();
                foreach (var node in this.SelectedNodes)
                {
                    node.RenderedPorts.Clear();
                    var nodePath = this.RenderedNodes[node];
                    foreach (var port in node.Ports)
                    {
                        var portPath = port.Render(g, node.Bounds, o);
                        node.RenderedPorts.Add(port, portPath);
                        nodePath.FillMode = FillMode.Winding;
                        nodePath.AddPath(portPath, false);
                    }
                }
            }
        }

        private void RenderLines(Graphics g)
        {
            var o = new NodeStyle();
            var f = new PathFinder(this.Nodes);
            foreach (var node in this.Nodes)
            {
                foreach (var port in node.Ports)
                {
                    o.LinePenWithArrow.Brush = port.GetBackBrush();
                    if (this.LinkNodeEndPoint != Point.Empty && this.LinkNodeStartPort == port)
                    {
                        g.DrawLine(o.LinePenWithArrow, port.Bounds.Center.X, port.Bounds.Center.Y, this.LinkNodeEndPoint.X, this.LinkNodeEndPoint.Y);
                    }
                    else if (this.GetNodeById(port.NextNodeId) is Node linkedNode)
                    {
                        g.DrawPath(o.LinePenWithArrow, f.GetPath(port.Bounds.Center, linkedNode.Bounds.CenterTop));
                    }
                }
            }
        }

        private void RenderNodes(Graphics g)
        {
            var width = this.Canvas.Parent.ClientSize.Width;
            var height = this.Canvas.Parent.ClientSize.Height;

            this.RenderedNodes.Clear();
            foreach (var node in this.Nodes)
            {
                var r = node.Bounds;
                var o = new NodeStyle();
                if (this.SelectedNodes.Contains(node))
                {
                    o.BorderPen = PageRenderOptions.SelectedNodeBorderPen;
                    r.X += this.MoveNodeOffsetPoint.X;
                    r.Y += this.MoveNodeOffsetPoint.Y;
                }
                if (this.currentNode == node)
                {
                    o.BackBrush = PageRenderOptions.DebugNodeBackBrush;
                }
                this.RenderedNodes.Add(node, node.Render(g, r, o));
                node.RenderText(g, r, o);

                // update width and height
                width = Math.Max(width, r.Right + PageRenderOptions.GridSize * 5);
                height = Math.Max(height, r.Bottom + PageRenderOptions.GridSize * 5);
            }

            this.Canvas.Size = new Size(width, height);
        }

        public Bitmap CreateBitmap()
        {
            //获取左上角和右下角，左上角减去40，右下角增加40
            int minX = this.Canvas.Width, minY = this.Canvas.Height, maxX = 0, maxY = 0;
            foreach (Node node in this.Nodes)
            {
                if (node.Bounds.X < minX) minX = node.Bounds.X;
                if (node.Bounds.Y < minY) minY = node.Bounds.Y;
                if (node.Bounds.X + node.Bounds.Width > maxX) maxX = node.Bounds.X + node.Bounds.Width;
                if (node.Bounds.Y + node.Bounds.Height > maxY) maxY = node.Bounds.Y + node.Bounds.Height;
            }
            int left = PageRenderOptions.GridSize * 2;
            if (minX < left) left = minX;
            int top = PageRenderOptions.GridSize * 2;
            if (minY < top) top = minY;

            int border = PageRenderOptions.GridSize * 2;

            //取全图，再截取 https://www.cnblogs.com/kehaocheng/p/7126690.html
            Bitmap bigImage = new Bitmap(this.Canvas.Width, this.Canvas.Height);
            this.Canvas.DrawToBitmap(bigImage, new System.Drawing.Rectangle(0, 0, this.Canvas.Width, this.Canvas.Height));

            Bitmap bmSmall = new Bitmap(maxX - minX + border + left, maxY - minY + border + top);
            //Bitmap bmSmall = new Bitmap(rect.Width, rect.Height, source.PixelFormat);
            using (Graphics grSmall = Graphics.FromImage(bmSmall))
            {
                //https://blog.csdn.net/weixin_30319097/article/details/94919686
                grSmall.SmoothingMode = SmoothingMode.HighQuality;
                grSmall.CompositingQuality = CompositingQuality.HighQuality;
                grSmall.InterpolationMode = InterpolationMode.HighQualityBicubic;
                grSmall.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                grSmall.DrawImage(bigImage, 0, 0, new Rectangle(minX - left, minY - top, bmSmall.Width, bmSmall.Height), GraphicsUnit.Pixel);
            }

            return bmSmall;
        }
    }
}