using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CSharpWin_JD.CaptureImage
{
    public partial class ColorSelector : UserControl
    {
        #region Fields

        private CaptureImageToolColorTable _colorTable;

        private static readonly Color InnerBorderColor = 
            Color.FromArgb(200, 255, 255, 255);
        private static readonly object EventColorChanged = new object();
        private static readonly object EventFontSizeChanged = new object();

        #endregion

        #region Constructors

        public ColorSelector()
        {
            InitializeComponent();
            Init();

            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        #endregion

        #region Events

        public event EventHandler ColorChanged
        {
            add { base.Events.AddHandler(EventColorChanged, value); }
            remove { base.Events.RemoveHandler(EventColorChanged, value); }
        }

        public event EventHandler FontSizeChanged
        {
            add { base.Events.AddHandler(EventFontSizeChanged, value); }
            remove { base.Events.RemoveHandler(EventFontSizeChanged, value); }
        }

        #endregion

        #region Properties

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CaptureImageToolColorTable ColorTable
        {
            get
            {
                if (_colorTable == null)
                {
                    _colorTable = new CaptureImageToolColorTable();
                }
                return _colorTable;
            }
            set
            {
                _colorTable = value;
                base.Invalidate();
                SetColorLabelBorderColor(ColorTable.BorderColor);
            }
        }

        [Browsable(false)]
        public Color SelectedColor
        {
            get { return colorLabelSelected.BackColor; }
        }

        [Browsable(false)]
        public int FontSize
        {
            get { return int.Parse(comboBoxFontSize.Text); }
        }

        #endregion

        #region Public Methods

        public void Reset()
        {
            colorLabelSelected.BackColor = Color.Red;
            comboBoxFontSize.Text = "12";

            panelLeft.Visible = false;
            Width = 189;
        }

        public void ChangeToFontStyle()
        {
            colorLabelSelected.BackColor = Color.Red;
            comboBoxFontSize.Text = "12";

            panelLeft.Visible = true;
            Width = 268;
        }

        #endregion

        #region OverideMethods

        protected virtual void OnColorChanged(EventArgs e)
        {
            EventHandler handler = base.Events[EventColorChanged] as EventHandler;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnFontSizeChanged(EventArgs e)
        {
            EventHandler handler = base.Events[EventFontSizeChanged] as EventHandler;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetRegion();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            SetRegion();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RenderBackgroundInternal(
                g,
                ClientRectangle,
                ColorTable.BackColorHover,
                ColorTable.BorderColor,
                InnerBorderColor,
                RoundStyle.All,
                true,
                true,
                LinearGradientMode.Vertical);
        }

        #endregion

        #region Draw Help Methods

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

        #endregion

        #region Private Methods

        private void SetRegion()
        {
            using (GraphicsPath path = GraphicsPathHelper.CreatePath(
                ClientRectangle, 8, RoundStyle.All, false))
            {
                if (base.Region != null)
                {
                    base.Region.Dispose();
                }
                base.Region = new Region(path);
            }
        }

        private void Init()
        {
            panelLeft.Visible = false;
            Width = 189;

            comboBoxFontSize.Text = "12";

            colorLabelSelected.BackColor = Color.Red;

            colorLabel1.BackColor = Color.Black;
            colorLabel2.BackColor = Color.FromArgb(153, 153, 153);
            colorLabel3.BackColor = Color.FromArgb(128, 0, 0);
            colorLabel4.BackColor = Color.FromArgb(128, 128, 0);
            colorLabel5.BackColor = Color.FromArgb(0, 128, 0);
            colorLabel6.BackColor = Color.FromArgb(0, 0, 128);
            colorLabel7.BackColor = Color.FromArgb(128, 0, 128);
            colorLabel8.BackColor = Color.FromArgb(0, 128, 128);

            colorLabel9.BackColor = Color.White;
            colorLabel10.BackColor = Color.FromArgb(192, 192, 192);
            colorLabel11.BackColor = Color.FromArgb(255, 0, 0);
            colorLabel12.BackColor = Color.FromArgb(255, 255, 0);
            colorLabel13.BackColor = Color.FromArgb(0, 255, 0);
            colorLabel14.BackColor = Color.FromArgb(0, 0, 255);
            colorLabel15.BackColor = Color.FromArgb(255, 0, 255);
            colorLabel16.BackColor = Color.FromArgb(0, 255, 255);

            colorLabel1.Click += new EventHandler(ColorLabelClick);
            colorLabel2.Click += new EventHandler(ColorLabelClick);
            colorLabel3.Click += new EventHandler(ColorLabelClick);
            colorLabel4.Click += new EventHandler(ColorLabelClick);
            colorLabel5.Click += new EventHandler(ColorLabelClick);
            colorLabel6.Click += new EventHandler(ColorLabelClick);
            colorLabel7.Click += new EventHandler(ColorLabelClick);
            colorLabel8.Click += new EventHandler(ColorLabelClick);

            colorLabel9.Click += new EventHandler(ColorLabelClick);
            colorLabel10.Click += new EventHandler(ColorLabelClick);
            colorLabel11.Click += new EventHandler(ColorLabelClick);
            colorLabel12.Click += new EventHandler(ColorLabelClick);
            colorLabel13.Click += new EventHandler(ColorLabelClick);
            colorLabel14.Click += new EventHandler(ColorLabelClick);
            colorLabel15.Click += new EventHandler(ColorLabelClick);
            colorLabel16.Click += new EventHandler(ColorLabelClick);

            comboBoxFontSize.SelectedIndexChanged += new EventHandler(
                ComboBoxFontSizeSelectedIndexChanged);
        }

        private void ComboBoxFontSizeSelectedIndexChanged(object sender, EventArgs e)
        {
            OnFontSizeChanged(e);
        }

        private void ColorLabelClick(object sender, EventArgs e)
        {
            Control control = sender as Control;
            colorLabelSelected.BackColor = control.BackColor;
            OnColorChanged(e);
        }

        private void SetColorLabelBorderColor(Color borderColor)
        {
            colorLabel1.BorderColor = borderColor;
            colorLabel2.BorderColor = borderColor;
            colorLabel3.BorderColor = borderColor;
            colorLabel4.BorderColor = borderColor;
            colorLabel5.BorderColor = borderColor;
            colorLabel6.BorderColor = borderColor;
            colorLabel7.BorderColor = borderColor;
            colorLabel8.BorderColor = borderColor;

            colorLabel9.BorderColor = borderColor;
            colorLabel10.BorderColor = borderColor;
            colorLabel11.BorderColor = borderColor;
            colorLabel12.BorderColor = borderColor;
            colorLabel13.BorderColor = borderColor;
            colorLabel14.BorderColor = borderColor;
            colorLabel15.BorderColor = borderColor;
            colorLabel16.BorderColor = borderColor;
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

        #endregion
    }
}
