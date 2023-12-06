using litsdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litstudio
{
    internal partial class FrmActivityConfig2 : UserControl
    {
        private FrmActivityConfig2()
        {
            InitializeComponent();
        }

        private ILitUI iPipeUI1 = null;
        public FrmActivityConfig2(litsdk.Activity activity, litsdk.ILitUI litUI)
        {
            InitializeComponent();
            this.pCaption.Location = new Point(0, 0);
            this.pCaption.Width = this.Width;
            //https://docs.microsoft.com/zh-cn/dotnet/api/system.windows.systemcolors?view=netframework-4.8
            this.pCaption.BackColor = SystemColors.ActiveCaption;
            this.lbClose.Location = new Point(this.Width - this.lbClose.Width, 0);
            this.iPipeUI1 = litUI;
            this.iPipeUI1.Location = new Point(0, 34);
            if (this.iPipeUI1.Size.Width < this.Width && this.iPipeUI1.Size.Height < this.Height - 34)
            {
                this.iPipeUI1.Size = new Size(this.Width, this.Height - 34);
            }
            else
            {
                this.Width = this.iPipeUI1.Width;
                this.Height = this.iPipeUI1.Height + 34;
            }
            this.Text = activity.Name;

            this.lbHelp.Tag = activity.GetType().FullName;

            this.lbTitle.Text = activity.Name;
            string fi = activity.GetType().Namespace;
            if (fi.StartsWith("litcef")) this.lbTitle.Text += "(内置谷歌)";
            else if (fi.StartsWith("litie")) this.lbTitle.Text += "(内置IE)";
            else if (fi.StartsWith("litmbcef")) this.lbTitle.Text += "(MiniBlink)";
            else if (fi.StartsWith("litchrome")) this.lbTitle.Text += "(谷歌浏览器)";

            this.iPipeUI1.SetActivity(activity);
            //this.iPipeUI1.Dock = DockStyle.Fill;
            this.Controls.Add(this.iPipeUI1);
            this.iPipeUI1.CloseForm = new Action(() => this.Dispose());
            this.iPipeUI1.Show();
        }


        private Point mouse_offset;
        /// <summary>
        /// https://blog.csdn.net/yanleigis/article/details/1819429
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pCaption_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void pCaption_MouseMove(object sender, MouseEventArgs e)
        {
            ((Control)sender).Cursor = Cursors.Arrow;//设置拖动时鼠标箭头
            if (e.Button == MouseButtons.Left && this.Parent.ClientRectangle.Contains(this.Parent.PointToClient(Control.MousePosition)))
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);//设置偏移
                this.Location = this.Parent.PointToClient(mousePos);
            }
        }

        private void pCaption_Paint(object sender, PaintEventArgs e)
        {
            //https://blog.csdn.net/qq_32025005/article/details/70224917
            e.Graphics.DrawRectangle(Pens.LightGray, 0, 0, this.Width - 1, this.Height - 1);
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lbClose_MouseEnter(object sender, EventArgs e)
        {
            this.lbClose.BackColor = Color.Red;
        }

        private void lbClose_MouseLeave(object sender, EventArgs e)
        {
            this.lbClose.BackColor = Color.Transparent;
        }

        private void lbHelp_Click(object sender, EventArgs e)
        {
            string name = this.lbHelp.Tag.ToString();
            GoHelp(name);
        }

        public static void GoHelp(string name)
        {
            if (name.StartsWith("litie.") || name.StartsWith("litcef.") || name.StartsWith("litmbcef.") || name.StartsWith("litchrome."))
            {
                if (name.EndsWith("Commond")) name = "litcore.iecef.Commond";
                else if (name.EndsWith("Cookies")) name = "litcore.iecef.Cookies";
                else if (name.EndsWith("Exist")) name = "litcore.iecef.Exist";
                else if (name.EndsWith("FormState")) name = "litcore.iecef.FormState";
                else if (name.EndsWith("Navigate")) name = "litcore.iecef.Navigate";
                else if (name.EndsWith("PageInfo")) name = "litcore.iecef.PageInfo";
                else if (name.EndsWith("Proxy")) name = "litcore.iecef.Proxy";
                else if (name.EndsWith("RunJs")) name = "litcore.iecef.RunJs";
                else if (name.EndsWith("ScreenShot")) name = "litcore.iecef.ScreenShot";
                else if (name.EndsWith("Scroll")) name = "litcore.iecef.Scroll";
                else if (name.EndsWith("SwitchTab")) name = "litcore.iecef.SwitchTab";
                else if (name.EndsWith("ToPdf")) name = "litcore.iecef.ToPdf";
                else if (name.EndsWith("Wait")) name = "litcore.iecef.Wait";
                else if (name.EndsWith("XPath")) name = "litcore.iecef.XPath";
            }
            string url = "https://www.yuque.com/litrpa/activity/" + name;

            System.Diagnostics.Process.Start(url);
        }

        private void lbHelp_MouseEnter(object sender, EventArgs e)
        {
            this.lbHelp.BackColor = Color.Red; 
        }

        private void lbHelp_MouseLeave(object sender, EventArgs e)
        {
            this.lbHelp.BackColor = Color.Transparent;
        }
    }
}
