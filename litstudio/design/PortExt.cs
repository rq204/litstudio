using litcore;
using litsdk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litstudio
{
    internal static class PortExt
    {
        public static Brush GetBackBrush(this litsdk.Port port)
        {
            if (port.GetType() == typeof(NextPort))
            {
                return new SolidBrush(Color.FromArgb(100, Color.Blue));
            }

            if (port.GetType() == typeof(TruePort))
            {
                return new SolidBrush(Color.FromArgb(100, Color.Green));
            }

            if (port.GetType() == typeof(FalsePort))
            {
                return new SolidBrush(Color.FromArgb(100, Color.Red));
            }

            return null;
        }

        public static void UpdateBounds(this litsdk.Port port, Rectangle r)
        {
            var portPoint = port.GetOffset(r);
            var portSize = new Size(PageRenderOptions.GridSize, PageRenderOptions.GridSize);
            portPoint.Offset(-portSize.Width / 2, -portSize.Height / 2);
            var portBounds = new Rectangle(portPoint, portSize);
            port.Bounds = portBounds;
        }

        public static GraphicsPath Render(this litsdk.Port port, Graphics g, Rectangle r, NodeStyle o)
        {
            port.UpdateBounds(r);
            g.FillEllipse(port.GetBackBrush(), port.Bounds);
            var portPath = new GraphicsPath();
            portPath.StartFigure();
            portPath.AddEllipse(port.Bounds);
            portPath.CloseFigure();
            return portPath;
        }
    }
}
