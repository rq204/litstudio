using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace litsdk
{
    /// <summary>
    /// 活动配置基础布局控件
    /// </summary>
    public class ILitUI : UserControl
    {
        /// <summary>
        /// 控件基类
        /// </summary>
        public ILitUI()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// 组件名称
        /// </summary>
        public TextBox tbActivityName;
        private Label label1;
        private Button btnSaveActivity;
        /// <summary>
        /// 
        /// </summary>
        public SplitContainer scActivityUI;

        /// <summary>
        /// 设置Activity
        /// </summary>
        /// <param name="activity"></param>
        public virtual void SetActivity(litsdk.Activity activity) { }
        /// <summary>
        /// 子类中保存配置的方法
        /// </summary>
        public Action SaveActivity;

        /// <summary>
        /// 相关联的Activity名称
        /// </summary>
        public virtual string ActivityType { get; }

        private void InitializeComponent()
        {
            this.scActivityUI = new System.Windows.Forms.SplitContainer();
            this.tbActivityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveActivity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            this.scActivityUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scActivityUI.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scActivityUI.Location = new System.Drawing.Point(0, 0);
            this.scActivityUI.Name = "scActivityUI";
            this.scActivityUI.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scActivityUI.Panel2
            // 
            this.scActivityUI.Panel2.Controls.Add(this.tbActivityName);
            this.scActivityUI.Panel2.Controls.Add(this.label1);
            this.scActivityUI.Panel2.Controls.Add(this.btnSaveActivity);
            this.scActivityUI.Size = new System.Drawing.Size(580, 270);
            this.scActivityUI.SplitterDistance = 238;
            this.scActivityUI.TabIndex = 0;
            // 
            // tbActivityName
            // 
            this.tbActivityName.Location = new System.Drawing.Point(62, 4);
            this.tbActivityName.Name = "tbActivityName";
            this.tbActivityName.Size = new System.Drawing.Size(185, 21);
            this.tbActivityName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "节点名称";
            // 
            // btnSaveActivity
            // 
            this.btnSaveActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveActivity.Location = new System.Drawing.Point(497, 3);
            this.btnSaveActivity.Name = "btnSaveActivity";
            this.btnSaveActivity.Size = new System.Drawing.Size(74, 23);
            this.btnSaveActivity.TabIndex = 3;
            this.btnSaveActivity.Text = "确认";
            this.btnSaveActivity.UseVisualStyleBackColor = true;
            this.btnSaveActivity.Click += new System.EventHandler(this.btnSaveAction_Click);
            // 
            // ILitUI
            // 
            this.Controls.Add(this.scActivityUI);
            this.Name = "ILitUI";
            this.Size = new System.Drawing.Size(580, 270);
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        /// <summary>
        /// 关闭窗口时事件
        /// </summary>
        public Action CloseForm;
        /// <summary>
        /// 保存按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void btnSaveAction_Click(object sender, EventArgs e)
        {
            this.tbActivityName.Text = this.tbActivityName.Text.Trim();
            if (this.tbActivityName.Text == "")
            {
                MessageBox.Show("组件名称不得为空，请修改", "错误"); return;
            }

            this.SaveActivity();
            this.CloseForm();
        }
    }
}
