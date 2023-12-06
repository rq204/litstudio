namespace litstudio
{
    partial class ProjectUI
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.llbDir = new System.Windows.Forms.LinkLabel();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBak = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUseAsyn = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudNumofAsyn = new System.Windows.Forms.NumericUpDown();
            this.cbOnlyUserLog = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumofAsyn)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.cbOnlyUserLog);
            this.scActivityUI.Panel1.Controls.Add(this.nudNumofAsyn);
            this.scActivityUI.Panel1.Controls.Add(this.cbUseAsyn);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.llbDir);
            this.scActivityUI.Panel1.Controls.Add(this.tbBak);
            this.scActivityUI.Panel1.Controls.Add(this.tbFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "流程文件";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(82, 18);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(335, 21);
            this.tbFilePath.TabIndex = 1;
            // 
            // llbDir
            // 
            this.llbDir.AutoSize = true;
            this.llbDir.Location = new System.Drawing.Point(426, 23);
            this.llbDir.Name = "llbDir";
            this.llbDir.Size = new System.Drawing.Size(65, 12);
            this.llbDir.TabIndex = 3;
            this.llbDir.TabStop = true;
            this.llbDir.Text = "[当前目录]";
            this.llbDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDir_LinkClicked);
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(491, 23);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 3;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(81, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "该组件可以将当前流程的变量的当前值，作为引用流程的初始值，来执行引用流程，执行完引用流程后，相应的变量值会返回修改当前的变量值。启用异步执行后，引用流程不会修改当" +
    "前流程的变量值，引用流程不能包含桌面及浏览器操作。注意引用流程同步执行时出问题会出异常，请使用异常捕获进行处理。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "备   注";
            // 
            // tbBak
            // 
            this.tbBak.Location = new System.Drawing.Point(82, 50);
            this.tbBak.Multiline = true;
            this.tbBak.Name = "tbBak";
            this.tbBak.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBak.Size = new System.Drawing.Size(468, 89);
            this.tbBak.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "异步执行";
            // 
            // cbUseAsyn
            // 
            this.cbUseAsyn.AutoSize = true;
            this.cbUseAsyn.Location = new System.Drawing.Point(83, 207);
            this.cbUseAsyn.Name = "cbUseAsyn";
            this.cbUseAsyn.Size = new System.Drawing.Size(96, 16);
            this.cbUseAsyn.TabIndex = 7;
            this.cbUseAsyn.Text = "启用异步执行";
            this.cbUseAsyn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "最大线程数";
            // 
            // nudNumofAsyn
            // 
            this.nudNumofAsyn.Location = new System.Drawing.Point(264, 206);
            this.nudNumofAsyn.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumofAsyn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumofAsyn.Name = "nudNumofAsyn";
            this.nudNumofAsyn.Size = new System.Drawing.Size(47, 21);
            this.nudNumofAsyn.TabIndex = 8;
            this.nudNumofAsyn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbOnlyUserLog
            // 
            this.cbOnlyUserLog.AutoSize = true;
            this.cbOnlyUserLog.Location = new System.Drawing.Point(338, 208);
            this.cbOnlyUserLog.Name = "cbOnlyUserLog";
            this.cbOnlyUserLog.Size = new System.Drawing.Size(120, 16);
            this.cbOnlyUserLog.TabIndex = 9;
            this.cbOnlyUserLog.Text = "只输出自定义日志";
            this.cbOnlyUserLog.UseVisualStyleBackColor = true;
            // 
            // ProjectUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProjectUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumofAsyn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llbOpen;
        private System.Windows.Forms.LinkLabel llbDir;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNumofAsyn;
        private System.Windows.Forms.CheckBox cbUseAsyn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbOnlyUserLog;
    }
}
