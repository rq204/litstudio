using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Text;

namespace CSharpWin_JD.CaptureImage
{
    public class ToolStripRendererEx : ToolStripRenderer
    {
        private CaptureImageToolColorTable _colorTable;

        private static readonly int OffsetMargin = 24;
        private const string MenuLogoString = "";//"csharpwin.com";

        public ToolStripRendererEx() : base()
        {
        }

        public ToolStripRendererEx(CaptureImageToolColorTable colorTable)
            : base()
        {
            _colorTable = colorTable;
        }

        protected virtual CaptureImageToolColorTable ColorTable
        {
            get 
            {
                if (_colorTable == null)
                {
                    _colorTable = new CaptureImageToolColorTable();
                }
                return _colorTable;
            }
        }

        protected override void OnRenderToolStripBackground(
            ToolStripRenderEventArgs e)
        {
            Color baseColor = ColorTable.BackColorNormal;
            ToolStrip toolStrip = e.ToolStrip;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (toolStrip is ToolStripDropDown)
            {
                RegionHelper.CreateRegion(e.ToolStrip, e.AffectedBounds);

                Rectangle rect = e.AffectedBounds;

                using (GraphicsPath path = GraphicsPathHelper.CreatePath(
                    rect, 8, RoundStyle.All, false))
                {
                    using (SolidBrush brush = new SolidBrush(ColorTable.BackColorNormal))
                    {
                        g.FillPath(brush, path);
                    }
                    using (Pen pen = new Pen(ColorTable.BorderColor))
                    {
                        g.DrawPath(pen, path);

                        using (GraphicsPath innerPath = GraphicsPathHelper.CreatePath(
                            rect, 8, RoundStyle.All, true))
                        {
                            g.DrawPath(pen, innerPath);
                        }
                    }
                }
            }
            else
            {
                LinearGradientMode mode =
                        e.ToolStrip.Orientation == Orientation.Horizontal ?
                        LinearGradientMode.Vertical : LinearGradientMode.Horizontal;
                RenderBackgroundInternal(
                   g,
                   e.AffectedBounds,
                   ColorTable.BackColorHover,
                   ColorTable.BorderColor,
                   ColorTable.BackColorNormal,
                   RoundStyle.All,
                   false,
                   true,
                   mode);
            }
        }

        protected override void OnRenderButtonBackground(
            ToolStripItemRenderEventArgs e)
        {
            ToolStripButton item = e.Item as ToolStripButton;
            if (item != null)
            {
                LinearGradientMode mode =
                    e.ToolStrip.Orientation == Orientation.Horizontal ?
                    LinearGradientMode.Vertical : LinearGradientMode.Horizontal;
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle bounds = new Rectangle(Point.Empty, item.Size);

                if (item.BackgroundImage != null)
                {
                    Rectangle clipRect = item.Selected ? item.ContentRectangle : bounds;
                    ControlPaintEx.DrawBackgroundImage(
                        g,
                        item.BackgroundImage,
                        ColorTable.BackColorNormal,
                        item.BackgroundImageLayout,
                        bounds,
                        clipRect);
                }

                if (item.CheckState == CheckState.Unchecked)
                {
                    if (item.Selected)
                    {
                        Color color = ColorTable.BackColorHover;
                        if (item.Pressed)
                        {
                            color = ColorTable.BackColorPressed;
                        }
                        RenderBackgroundInternal(
                            g,
                            bounds,
                            color,
                            ColorTable.BorderColor,
                            ColorTable.BackColorNormal,
                            RoundStyle.All,
                            true,
                            true,
                            mode);
                        return;
                    }
                    else
                    {
                        if (e.ToolStrip is ToolStripOverflow)
                        {
                            using (Brush brush = new SolidBrush(ColorTable.BackColorNormal))
                            {
                                g.FillRectangle(brush, bounds);
                            }
                            return;
                        }
                    }
                }
                else
                {
                    Color color = ControlPaint.Light(ColorTable.BackColorHover);
                    if (item.Selected)
                    {
                        color = ColorTable.BackColorHover;
                    }
                    if (item.Pressed)
                    {
                        color = ColorTable.BackColorPressed;
                    }
                    RenderBackgroundInternal(
                        e.Graphics,
                        bounds,
                        color,
                        ColorTable.BorderColor,
                        ColorTable.BackColorNormal,
                        RoundStyle.All,
                        true,
                        true,
                        mode);
                    return;
                }
            }

            base.OnRenderButtonBackground(e);
        }

        protected override void OnRenderSeparator(
            ToolStripSeparatorRenderEventArgs e)
        {
            Rectangle rect = e.Item.ContentRectangle;
            if (e.ToolStrip is ToolStripDropDown)
            {
                if (e.Item.RightToLeft == RightToLeft.Yes)
                {
                    //rect.X -= OffsetMargin + 4;
                }
                else
                {
                    rect.X += OffsetMargin + 4;
                }
                rect.Width -= OffsetMargin + 8;
            }
            RenderSeparatorLine(
               e.Graphics,
               rect,
               ColorTable.BackColorPressed,
               ColorTable.BackColorNormal,
               SystemColors.ControlLightLight,
               e.Vertical);
        }

        protected override void OnRenderMenuItemBackground(
            ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Enabled)
            {
                return;
            }

            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (e.Item.RightToLeft == RightToLeft.Yes)
            {
                rect.X += 4;
            }
            else
            {
                rect.X += OffsetMargin + 4;
            }
            rect.Width -= OffsetMargin + 8;
            rect.Height--;

            if (e.Item.Selected)
            {
                RenderBackgroundInternal(
                   g,
                   rect,
                   ColorTable.BackColorHover,
                   ColorTable.BorderColor,
                   ColorTable.BackColorNormal,
                   RoundStyle.All,
                   true,
                   true,
                   LinearGradientMode.Vertical);
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }

        protected override void OnRenderImageMargin(
            ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip is ToolStripDropDownMenu)
            {
                Rectangle rect = e.AffectedBounds;
                Graphics g = e.Graphics;
                rect.Width = OffsetMargin;
                if (e.ToolStrip.RightToLeft == RightToLeft.Yes)
                {
                    rect.X -= 2;
                }
                else
                {
                    rect.X += 2;
                }
                rect.Y += 1;
                rect.Height -= 2;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect,
                    ColorTable.BackColorHover,
                    Color.White,
                    90f))
                {
                    Blend blend = new Blend();
                    blend.Positions = new float[] { 0f, .2f, 1f };
                    blend.Factors = new float[] { 0f, 0.1f, .9f };
                    brush.Blend = blend;
                    rect.Y += 1;
                    rect.Height -= 2;
                    using (GraphicsPath path =
                        GraphicsPathHelper.CreatePath(rect, 8, RoundStyle.All, false))
                    {
                        g.FillPath(brush, path);
                    }
                }

                g.TextRenderingHint = TextRenderingHint.AntiAlias;
                StringFormat sf = new StringFormat(StringFormatFlags.NoWrap);
                Font font = new Font(
                    e.ToolStrip.Font.FontFamily, 11, FontStyle.Bold);
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Center;
                sf.Trimming = StringTrimming.EllipsisCharacter;

                g.TranslateTransform(rect.X, rect.Bottom);
                g.RotateTransform(270f);

                if (!string.IsNullOrEmpty(MenuLogoString))
                {
                    Rectangle newRect = new Rectangle(
                        rect.X, rect.Y, rect.Height, rect.Width);

                    using (Brush brush = new SolidBrush(ColorTable.ForeColor))
                    {
                        g.DrawString(
                            MenuLogoString,
                            font,
                            brush,
                            newRect,
                            sf);
                    }
                }

                g.ResetTransform();
                return;
            }

            base.OnRenderImageMargin(e);
        }

        protected override void OnRenderItemImage(
            ToolStripItemImageRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;

            if (e.Item is ToolStripMenuItem)
            {
                ToolStripMenuItem item = (ToolStripMenuItem)e.Item;
                if (item.Checked)
                {
                    return;
                }
                Rectangle rect = e.ImageRectangle;
                if (e.Item.RightToLeft == RightToLeft.Yes)
                {
                    rect.X -= OffsetMargin + 2;
                }
                else
                {
                    rect.X += OffsetMargin + 2;
                }
                ToolStripItemImageRenderEventArgs ne = 
                    new ToolStripItemImageRenderEventArgs(
                    e.Graphics, e.Item, e.Image, rect);
                base.OnRenderItemImage(ne);
                return;
            }

            base.OnRenderItemImage(e);
        }

        protected override void OnRenderItemText(
            ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = ColorTable.ForeColor;

            if (!(e.ToolStrip is MenuStrip) && (e.Item is ToolStripMenuItem))
            {
                Rectangle rect = e.TextRectangle;
                if (e.Item.RightToLeft == RightToLeft.Yes)
                {
                    rect.X -= 16;
                }
                else
                {
                    rect.X += 16;
                }
                e.TextRectangle = rect;
            }

            base.OnRenderItemText(e);
        }

        internal void RenderBackgroundInternal(
            Graphics g,
            Rectangle rect,
            Color baseColor,
            Color borderColor,
            Color innerBorderColor,
            RoundStyle style,
            bool drawBorder,
            bool drawGlass,
            LinearGradientMode mode)
        {
            RenderBackgroundInternal(
                g,
                rect,
                baseColor,
                borderColor,
                innerBorderColor,
                style,
                8,
                drawBorder,
                drawGlass,
                mode);
        }

        internal void RenderBackgroundInternal(
           Graphics g,
           Rectangle rect,
           Color baseColor,
           Color borderColor,
           Color innerBorderColor,
           RoundStyle style,
           int roundWidth,
           bool drawBorder,
           bool drawGlass,
           LinearGradientMode mode)
        {
            RenderBackgroundInternal(
                 g,
                 rect,
                 baseColor,
                 borderColor,
                 innerBorderColor,
                 style,
                 8,
                 0.45f,
                 drawBorder,
                 drawGlass,
                 mode);
        }

        internal void RenderBackgroundInternal(
           Graphics g,
           Rectangle rect,
           Color baseColor,
           Color borderColor,
           Color innerBorderColor,
           RoundStyle style,
           int roundWidth,
           float basePosition,
           bool drawBorder,
           bool drawGlass,
           LinearGradientMode mode)
        {
            if (drawBorder)
            {
                rect.Width--;
                rect.Height--;
            }

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect, Color.Transparent, Color.Transparent, mode))
            {
                Color[] colors = new Color[4];
                colors[0] = GetColor(baseColor, 0, 35, 24, 9);
                colors[1] = GetColor(baseColor, 0, 13, 8, 3);
                colors[2] = baseColor;
                colors[3] = GetColor(baseColor, 0, 68, 69, 54);

                ColorBlend blend = new ColorBlend();
                blend.Positions = new float[] { 0.0f, basePosition, basePosition + 0.05f, 1.0f };
                blend.Colors = colors;
                brush.InterpolationColors = blend;
                if (style != RoundStyle.None)
                {
                    using (GraphicsPath path =
                        GraphicsPathHelper.CreatePath(rect, roundWidth, style, false))
                    {
                        g.FillPath(brush, path);
                    }

                    if (baseColor.A > 80)
                    {
                        Rectangle rectTop = rect;

                        if (mode == LinearGradientMode.Vertical)
                        {
                            rectTop.Height = (int)(rectTop.Height * basePosition);
                        }
                        else
                        {
                            rectTop.Width = (int)(rect.Width * basePosition);
                        }
                        using (GraphicsPath pathTop = GraphicsPathHelper.CreatePath(
                            rectTop, roundWidth, RoundStyle.Top, false))
                        {
                            using (SolidBrush brushAlpha =
                                new SolidBrush(Color.FromArgb(80, 255, 255, 255)))
                            {
                                g.FillPath(brushAlpha, pathTop);
                            }
                        }
                    }

                    if (drawGlass)
                    {
                        RectangleF glassRect = rect;
                        if (mode == LinearGradientMode.Vertical)
                        {
                            glassRect.Y = rect.Y + rect.Height * basePosition;
                            glassRect.Height = (rect.Height - rect.Height * basePosition) * 2;
                        }
                        else
                        {
                            glassRect.X = rect.X + rect.Width * basePosition;
                            glassRect.Width = (rect.Width - rect.Width * basePosition) * 2;
                        }
                        ControlPaintEx.DrawGlass(g, glassRect, 170, 0);
                    }

                    if (drawBorder)
                    {
                        using (GraphicsPath path =
                            GraphicsPathHelper.CreatePath(rect, roundWidth, style, false))
                        {
                            using (Pen pen = new Pen(borderColor))
                            {
                                g.DrawPath(pen, path);
                            }
                        }

                        rect.Inflate(-1, -1);
                        using (GraphicsPath path =
                            GraphicsPathHelper.CreatePath(rect, roundWidth, style, false))
                        {
                            using (Pen pen = new Pen(innerBorderColor))
                            {
                                g.DrawPath(pen, path);
                            }
                        }
                    }
                }
                else
                {
                    g.FillRectangle(brush, rect);
                    if (baseColor.A > 80)
                    {
                        Rectangle rectTop = rect;
                        if (mode == LinearGradientMode.Vertical)
                        {
                            rectTop.Height = (int)(rectTop.Height * basePosition);
                        }
                        else
                        {
                            rectTop.Width = (int)(rect.Width * basePosition);
                        }
                        using (SolidBrush brushAlpha =
                            new SolidBrush(Color.FromArgb(80, 255, 255, 255)))
                        {
                            g.FillRectangle(brushAlpha, rectTop);
                        }
                    }

                    if (drawGlass)
                    {
                        RectangleF glassRect = rect;
                        if (mode == LinearGradientMode.Vertical)
                        {
                            glassRect.Y = rect.Y + rect.Height * basePosition;
                            glassRect.Height = (rect.Height - rect.Height * basePosition) * 2;
                        }
                        else
                        {
                            glassRect.X = rect.X + rect.Width * basePosition;
                            glassRect.Width = (rect.Width - rect.Width * basePosition) * 2;
                        }
                        ControlPaintEx.DrawGlass(g, glassRect, 200, 0);
                    }

                    if (drawBorder)
                    {
                        using (Pen pen = new Pen(borderColor))
                        {
                            g.DrawRectangle(pen, rect);
                        }

                        rect.Inflate(-1, -1);
                        using (Pen pen = new Pen(innerBorderColor))
                        {
                            g.DrawRectangle(pen, rect);
                        }
                    }
                }
            }
        }

        internal void RenderSeparatorLine(
           Graphics g,
           Rectangle rect,
           Color baseColor,
           Color backColor,
           Color shadowColor,
           bool vertical)
        {
            float angle;
            if (vertical)
            {
                angle = 90F;
            }
            else
            {
                angle = 180F;
            }
            using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect,
                    baseColor,
                    backColor,
                    angle))
            {
                Blend blend = new Blend();
                blend.Positions = new float[] { 0f, .3f, .5f, .7f, 1f };
                blend.Factors = new float[] { 1f, .3f, 0f, .3f, 1f };
                brush.Blend = blend;
                using (Pen pen = new Pen(brush))
                {
                    if (vertical)
                    {
                        g.DrawLine(pen, rect.X, rect.Y, rect.X, rect.Bottom);
                    }
                    else
                    {
                        g.DrawLine(pen, rect.X, rect.Y, rect.Right, rect.Y);
                    }

                    brush.LinearColors = new Color[] {
                        shadowColor, backColor };
                    pen.Brush = brush;
                    if (vertical)
                    {
                        g.DrawLine(pen, rect.X + 1, rect.Y, rect.X + 1, rect.Bottom);
                    }
                    else
                    {
                        g.DrawLine(pen, rect.X, rect.Y + 1, rect.Right, rect.Y + 1);
                    }
                }
            }
        }

        private Color GetColor(Color colorBase, int a, int r, int g, int b)
        {
            int a0 = colorBase.A;
            int r0 = colorBase.R;
            int g0 = colorBase.G;
            int b0 = colorBase.B;

            if (a + a0 > 255) { a = 255; } else { a = Math.Max(0, a + a0); }
            if (r + r0 > 255) { r = 255; } else { r = Math.Max(0, r + r0); }
            if (g + g0 > 255) { g = 255; } else { g = Math.Max(0, g + g0); }
            if (b + b0 > 255) { b = 255; } else { b = Math.Max(0, b + b0); }

            return Color.FromArgb(a, r, g, b);
        }
    }
}
