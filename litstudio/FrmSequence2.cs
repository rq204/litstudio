using litsdk;
using Newtonsoft.Json;
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
    internal partial class FrmSequence2 : UserControl
    {
        private List<ActivityInfo> activityInfos = litcore.ActivityLoader.GetActivityInfos();
        private litcore.activity.SequenceActivity sequenceActivity = null;
        public FrmSequence2(litcore.activity.SequenceActivity sequenceActivity)
        {
            InitializeComponent();
            this.sequenceActivity = sequenceActivity;
            this.Text = this.tbActivityName.Text = this.lbTitle.Text = this.sequenceActivity.Name;

            this.lbActivitys.SelectedIndexChanged -= lbActivitys_SelectedIndexChanged;
            foreach (litsdk.Activity ac in this.sequenceActivity.Activities) this.lbActivitys.Items.Add(new UIItem(ac));
            this.lbActivitys.SelectedIndexChanged += lbActivitys_SelectedIndexChanged;
            string[] names = "常规操作,UI自动化,浏览器,Excel,变量操作,文件处理,数据库,人工智能,网络,手机,其它".Split(',');

            for (int i = 0; i <= 10; i++)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Text = names[i];
                this.cmsActivity.Items.Add(tsmi);

                int gid = i;
                if (i == 2) gid = 20;
                this.addItem(gid, tsmi);
                if (gid == 20)
                {
                    ToolStripMenuItem tsmi21 = new ToolStripMenuItem();
                    tsmi21.Text = "IE浏览器";
                    tsmi.DropDownItems.Add(tsmi21);
                    this.addItem(21, tsmi21);

                    ToolStripMenuItem tsmi22 = new ToolStripMenuItem();
                    tsmi22.Text = "MiniBlink";
                    tsmi.DropDownItems.Add(tsmi22);
                    this.addItem(22, tsmi22);

                    ToolStripMenuItem tsmi23 = new ToolStripMenuItem();
                    tsmi23.Text = "谷歌浏览器";
                    tsmi.DropDownItems.Add(tsmi23);
                    this.addItem(23, tsmi23);
                }
                else if (gid == 3)
                {
                    ToolStripMenuItem tsmi31 = new ToolStripMenuItem();
                    tsmi31.Text = "CSV操作";
                    tsmi.DropDownItems.Add(tsmi31);
                    this.addItem(31, tsmi31);
                }
                else if (gid == 1)
                {
                    ToolStripMenuItem tsmi11 = new ToolStripMenuItem();
                    tsmi11.Text = "系统功能";
                    tsmi.DropDownItems.Add(tsmi11);
                    this.addItem(11, tsmi11);
                }
            }

            this.pCaption.Location = new Point(0, 0);
            this.pCaption.Width = this.Width;
            //https://docs.microsoft.com/zh-cn/dotnet/api/system.windows.systemcolors?view=netframework-4.8
            this.pCaption.BackColor = SystemColors.ActiveCaption;
            this.lbClose.Location = new Point(this.Width - this.lbClose.Width, 0);
        }

        private void addItem(int gid, ToolStripMenuItem tsmi)
        {
            List<Activity> activities = litcore.ActivityLoader.GetActivities().FindAll((c) => (int)c.Group == gid);

            List<ActivityInfo> activityInfos = litcore.ActivityLoader.GetActivityInfos().FindAll((f) => f.InSequence && activities.Find((m) => m.GetType().FullName == f.ActivityFullName) != null);
            activityInfos = activityInfos.OrderBy(o => o.Index).ToList();

            foreach (ActivityInfo info in activityInfos)
            {
                Activity act = activities.Find((f) => f.GetType().FullName == info.ActivityFullName);
                if ((act is litsdk.ProcessActivity) && !(act is litcore.activity.SequenceActivity))
                {
                    Activity activity = litcore.ActivityLoader.GetInstance(info.ActivityFullName);
                    ToolStripMenuItem tsmi2 = new ToolStripMenuItem();
                    tsmi2.Text = activity.Name;
                    tsmi2.Click += tsmi_Click;
                    tsmi2.Tag = info;
                    tsmi.DropDownItems.Add(tsmi2);
                }
            }

            //foreach (Activity act in activities)
            //{
            //    ActivityInfo info = this.activityInfos.Find((f) => f.ActivityFullName == act.GetType().FullName);
            //    if ((act is litsdk.ProcessActivity) && !(act is litcore.activity.SequenceActivity))
            //    {
            //        Activity activity = litcore.ActivityLoader.GetInstance(info.ActivityFullName);
            //        ToolStripMenuItem tsmi2 = new ToolStripMenuItem();
            //        tsmi2.Text = activity.Name;
            //        tsmi2.Click += tsmi_Click;
            //        tsmi2.Tag = info;
            //        tsmi.DropDownItems.Add(tsmi2);
            //    }
            //}
        }

        private ILitUI iPipeUI1 = null;
        public void ShowLitUI(litsdk.Activity activity, litsdk.ILitUI litUI)
        {
            if (this.scMain.Panel2.Controls.Count == 1)
            {
                this.scMain.Panel2.Controls[0].Dispose();
            }
            this.scMain.Panel2.Controls.Clear();

            this.iPipeUI1 = litUI;
            this.Text = this.lbTitle.Text = this.sequenceActivity.Name + " - " + activity.Name;

            string fi = activity.GetType().Namespace;
            if (fi.StartsWith("litcef")) this.lbTitle.Text += "(内置谷歌)";
            else if (fi.StartsWith("litie")) this.lbTitle.Text += "(内置IE)";
            else if (fi.StartsWith("litmbcef")) this.lbTitle.Text += "(MiniBlink)";
            else if (fi.StartsWith("litchrome")) this.lbTitle.Text += "(谷歌浏览器)";

            this.iPipeUI1.SetActivity(activity);
            this.iPipeUI1.Dock = DockStyle.Fill;
            this.scMain.Panel2.Controls.Add(this.iPipeUI1);
            this.iPipeUI1.CloseForm = new Action(() =>
            {
                if (this.lbActivitys.SelectedIndex != -1)
                {
                    this.lbActivitys.Items[this.lbActivitys.SelectedIndex] = new UIItem(activity);
                }
                this.scMain.Panel2.Controls.Clear();
                this.scMain.Panel2.Controls.Add(this.tbActivityName);
                this.scMain.Panel2.Controls.Add(this.lbHelp);
                this.scMain.Panel2.Controls.Add(this.lbName);
            });
            this.iPipeUI1.Show();
        }

        private void llbAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.cmsActivity.Show(this.llbAdd, new Point(8, 8));
        }


        private void tsmi_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            ActivityInfo activityInfo = tsmi.Tag as ActivityInfo;
            Activity activity = litcore.ActivityLoader.GetInstance(activityInfo.ActivityFullName);
            this.lbActivitys.Items.Add(new UIItem(activity));
            this.lbActivitys.SelectedIndex = this.lbActivitys.Items.Count - 1;
        }

        private void tbActivityName_TextChanged(object sender, EventArgs e)
        {
            this.sequenceActivity.Name = this.Text = this.tbActivityName.Text.Trim();
        }

        internal class UIItem
        {
            public UIItem(litsdk.Activity activity) { this.Activity = activity; }
            public litsdk.Activity Activity = null;
            public override string ToString()
            {
                return this.Activity.Name;
            }
        }

        private void FrmSequence_FormClosing(object sender, EventArgs e)
        {
            if (this.sequenceActivity.Name == "") this.sequenceActivity.Name = "序列";
            this.sequenceActivity.Activities.Clear();
            foreach (UIItem uI in this.lbActivitys.Items)
            {
                this.sequenceActivity.Activities.Add(uI.Activity as ProcessActivity);
            }
        }

        private void lbActivitys_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.llbDelete.Enabled = this.llbRun.Enabled = this.lbActivitys.SelectedIndex != -1;
            if (this.lbActivitys.SelectedItem != null)
            {
                UIItem uI = this.lbActivitys.SelectedItem as UIItem;
                uI.Activity.ShowConfig();
                this.llbHelp.Tag = uI.Activity.GetType().FullName;
            }
            else
            {
                this.scMain.Panel2.Controls.Clear();
                this.scMain.Panel2.Controls.Add(this.tbActivityName);
                this.scMain.Panel2.Controls.Add(this.lbHelp);
                this.scMain.Panel2.Controls.Add(this.lbName);
                this.llbHelp.Tag = null;
            }
        }

        private void llbEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbActivitys_SelectedIndexChanged(null, null);
        }

        private void llbDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.lbActivitys.SelectedItem != null)
            {
                this.lbActivitys.Items.Remove(this.lbActivitys.SelectedItem);
            }
        }

        private void cmsUpDown_Opening(object sender, CancelEventArgs e)
        {
            if (this.lbActivitys.SelectedItem != null)
            {
                this.cmsUpDown.Enabled = true;
                foreach (ToolStripItem toolStripi in this.cmsUpDown.Items)
                {
                    if (toolStripi is ToolStripMenuItem toolStrip)
                    {
                        toolStrip.Enabled = true;
                    }
                }
                this.tsmiTop.Enabled = this.tsmiUp.Enabled = this.lbActivitys.SelectedIndex > 0;
                this.tsmiBottom.Enabled = this.tsmiDown.Enabled = this.lbActivitys.Items.Count > 1 && this.lbActivitys.SelectedIndex != this.lbActivitys.Items.Count - 1;
            }
            else
            {
                this.cmsUpDown.Enabled = false;
            }
            this.tsmiPaste.Enabled = this.tsmiPaste.Tag != null;
            this.tsmiCopy.Enabled = this.lbActivitys.SelectedItem != null;
        }

        private void tsmiTop_Click(object sender, EventArgs e)
        {
            int select = this.lbActivitys.SelectedIndex;
            object obj = this.lbActivitys.Items[select];
            this.lbActivitys.Items.RemoveAt(select);
            this.lbActivitys.Items.Insert(0, obj);
            this.lbActivitys.SelectedItem = obj;
        }

        private void tsmiUp_Click(object sender, EventArgs e)
        {
            int select = this.lbActivitys.SelectedIndex;
            object obj = this.lbActivitys.Items[select];
            this.lbActivitys.Items.RemoveAt(select);
            this.lbActivitys.Items.Insert(select - 1, obj);
            this.lbActivitys.SelectedItem = obj;
        }

        private void tsmiDown_Click(object sender, EventArgs e)
        {
            int select = this.lbActivitys.SelectedIndex + 1;
            object obj = this.lbActivitys.Items[select];
            this.lbActivitys.Items.RemoveAt(select);
            this.lbActivitys.Items.Insert(select - 1, obj);
            this.lbActivitys.SelectedIndex = select;
        }

        private void tsmiBottom_Click(object sender, EventArgs e)
        {
            int select = this.lbActivitys.SelectedIndex;
            object obj = this.lbActivitys.Items[select];
            this.lbActivitys.Items.Add(obj);
            this.lbActivitys.Items.RemoveAt(select);
            this.lbActivitys.SelectedItem = obj;
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

        public Action<litsdk.Node> f5action;
        private void llbRun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.lbActivitys.SelectedItem == null) return;
            UIItem ue = this.lbActivitys.SelectedItem as UIItem;

            litsdk.Node node = new litcore.ProcessNode(ue.Activity);
            this.f5action(node);
        }

        private void llbHelp_Click(object sender, EventArgs e)
        {
            if (this.llbHelp.Tag != null)
            {
                FrmActivityConfig2.GoHelp(this.llbHelp.Tag.ToString());
            }
            else
            {
                FrmActivityConfig2.GoHelp("litcore.activity.SequenceActivity");
            }
        }

        private void llbHelp_MouseEnter(object sender, EventArgs e)
        {
            if (this.llbHelp.Tag != null) this.llbHelp.BackColor = Color.Red;
        }

        private void llbHelp_MouseLeave(object sender, EventArgs e)
        {
            if (this.llbHelp.Tag != null) this.llbHelp.BackColor = Color.Transparent;
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            if (this.lbActivitys.SelectedItem == null) return;
            UIItem uI = this.lbActivitys.SelectedItem as UIItem;
            this.tsmiPaste.Tag = uI;
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            if (tsmiPaste.Tag != null)
            {
                UIItem uI = this.tsmiPaste.Tag as UIItem;
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(uI.Activity, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
                litsdk.Activity activity = Newtonsoft.Json.JsonConvert.DeserializeObject<litsdk.Activity>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
                activity.Name += " 复制";
                UIItem add = new UIItem(activity);
                this.lbActivitys.Items.Add(add);
            }
        }
    }
}