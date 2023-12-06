using litcore.activity;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace litstudio
{
    internal sealed class FrmActivity : Form
    {
        private Panel activityPanel;
        private TreeView activityTreeView;
        private TextBox activityTextBox;

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Process Node");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Decision Node?");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Activities", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.activityPanel = new System.Windows.Forms.Panel();
            this.activityTreeView = new System.Windows.Forms.TreeView();
            this.activityTextBox = new System.Windows.Forms.TextBox();
            this.activityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // activityPanel
            // 
            this.activityPanel.BackColor = System.Drawing.Color.White;
            this.activityPanel.Controls.Add(this.activityTreeView);
            this.activityPanel.Controls.Add(this.activityTextBox);
            this.activityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityPanel.Location = new System.Drawing.Point(0, 0);
            this.activityPanel.Name = "activityPanel";
            this.activityPanel.Padding = new System.Windows.Forms.Padding(5);
            this.activityPanel.Size = new System.Drawing.Size(434, 311);
            this.activityPanel.TabIndex = 0;
            // 
            // activityTreeView
            // 
            this.activityTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activityTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityTreeView.FullRowSelect = true;
            this.activityTreeView.HotTracking = true;
            this.activityTreeView.Location = new System.Drawing.Point(5, 28);
            this.activityTreeView.Name = "activityTreeView";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Process Node";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Decision Node?";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Activities";
            this.activityTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.activityTreeView.ShowLines = false;
            this.activityTreeView.Size = new System.Drawing.Size(424, 278);
            this.activityTreeView.TabIndex = 1;
            this.activityTreeView.TabStop = false;
            // 
            // activityTextBox
            // 
            this.activityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activityTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.activityTextBox.Location = new System.Drawing.Point(5, 5);
            this.activityTextBox.Name = "activityTextBox";
            this.activityTextBox.Size = new System.Drawing.Size(424, 23);
            this.activityTextBox.TabIndex = 0;
            this.activityTextBox.TabStop = false;
            // 
            // FrmActivity
            // 
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.activityPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ActivityForm_Load);
            this.activityPanel.ResumeLayout(false);
            this.activityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private FrmActivity() => this.InitializeComponent();
        public static FrmActivity Instance = null;

        public static Panel Create()
        {
            var form = new FrmActivity();
            Instance = form;
            SetWindowTheme(form.activityTreeView.Handle, "explorer", null);
            form.activityTreeView.ItemDrag += TreeView1_ItemDrag;
            form.activityTextBox.TextChanged += (sender, e) => form.FilterTreeView();
            form.FilterTreeView();
            return form.activityPanel;
        }

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);


        private static void TreeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var treeView = sender as TreeView;
            TreeNode node = (TreeNode)e.Item;
            if (node.Level > 0 && !string.IsNullOrEmpty(node.Name)) treeView.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private static List<string> UserSelectOpen = new List<string>();

        private void FilterTreeView()
        {
            this.activityTreeView.BeginUpdate(); // avoid flickering.
            this.activityTreeView.Nodes.Clear();

            // internal activities
            var generalActivities = this.activityTreeView.Nodes.Add("常规操作");
            generalActivities.Nodes.Add(typeof(LoopStartActivity).FullName, "循环").EnsureVisible();
            generalActivities.Nodes.Add(typeof(SequenceActivity).FullName, "序列").EnsureVisible();
            generalActivities.Nodes.Add(typeof(litcore.activity.SleepActivity).FullName, "暂停等待").EnsureVisible();
            generalActivities.Nodes.Add(typeof(litcore.activity.ErrorCatchActivity).FullName, "异常捕获?").EnsureVisible();
            generalActivities.Nodes.Add(typeof(litcore.activity.ProjectActivity).FullName, "流程引用").EnsureVisible();
            generalActivities.Nodes.Add(typeof(EndActivity).FullName, "结束流程").EnsureVisible();
            generalActivities.ExpandAll();

            var filterText = this.activityTextBox.Text.ToLower().Replace(" ", string.Empty);

            if (iswinform)
            {
                //UI自动化
                this.AddNodeGroup(this.activityTreeView.Nodes, "UI自动化", ActivityGroup.UIAutomation, filterText).Expand();

                this.AddNodeGroup(this.activityTreeView.Nodes, "谷歌浏览器", ActivityGroup.Chrome, filterText).Expand();
            }

            //Excel
            this.AddNodeGroup(this.activityTreeView.Nodes, "Excel", ActivityGroup.Excel, filterText).Expand();

            //Variable
            this.AddNodeGroup(this.activityTreeView.Nodes, "变量操作", ActivityGroup.Variable, filterText).ExpandAll();

            //File
            this.AddNodeGroup(this.activityTreeView.Nodes, "文件处理", ActivityGroup.File, filterText).Expand();

            //网络
            this.AddNodeGroup(this.activityTreeView.Nodes, "网络", ActivityGroup.NetWork, filterText).Expand();

            this.activityTreeView.EndUpdate();
        }


        private TreeNode AddNodeGroup(TreeNodeCollection parent, string groupKey, ActivityGroup activityGroup, string filterText)
        {
            TreeNode treeNode = parent.Add(groupKey);
            List<Activity> activities = litcore.ActivityLoader.GetActivities().FindAll((c) => c.Group == activityGroup);
            List<ActivityInfo> activityInfos = litcore.ActivityLoader.GetActivityInfos().FindAll((f) => activities.Find((m) => m.GetType().FullName == f.ActivityFullName) != null);
            activityInfos = activityInfos.OrderBy(o => o.Index).ToList();

            foreach (ActivityInfo af in activityInfos)
            {
                Activity act = activities.Find((f) => f.GetType().FullName == af.ActivityFullName);
                if (af.IsWinForm && !this.iswinform) continue;
                if (af.IsFront && !this.isfront) continue;
                if (af.IsLinux && !this.islinux) continue;
                if (act.Name.ToLower().Contains(filterText) || af.Search.Contains(filterText))
                {
                    var nodeText = act.Name;
                    if (act is DecisionActivity)
                    {
                        nodeText += "?";
                    }
                    treeNode.Nodes.Add(act.GetType().FullName, nodeText);
                }
            }

            return treeNode;
        }


        public void ReloadTree()
        {
            this.activityTextBox.Clear();
            this.iswinform = true;
            this.islinux = true;
            this.isfront = true;
            this.FilterTreeView();
        }

        private bool iswinform = true, islinux = true, isfront = true;

        public void ReloadTreeSelect(bool winform,bool front, bool linux)
        {
            this.activityTextBox.Clear();
            this.iswinform = winform;
            this.islinux = linux;
            this.isfront = front;
            this.FilterTreeView();
        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {

        }
    }
}