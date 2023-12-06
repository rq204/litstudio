namespace litstudio
{
    partial class FrmSequence2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSequence2));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scLeft = new System.Windows.Forms.SplitContainer();
            this.lbActivitys = new System.Windows.Forms.ListBox();
            this.cmsUpDown = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.llbRun = new System.Windows.Forms.LinkLabel();
            this.llbDelete = new System.Windows.Forms.LinkLabel();
            this.llbAdd = new System.Windows.Forms.LinkLabel();
            this.gbMultThread = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.selectMultVarName1 = new litsdk.SelectMultVarName();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHelp = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbActivityName = new System.Windows.Forms.TextBox();
            this.cbMultThread = new System.Windows.Forms.CheckBox();
            this.cmsActivity = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pCaption = new System.Windows.Forms.Panel();
            this.llbHelp = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLeft)).BeginInit();
            this.scLeft.Panel1.SuspendLayout();
            this.scLeft.Panel2.SuspendLayout();
            this.scLeft.SuspendLayout();
            this.cmsUpDown.SuspendLayout();
            this.gbMultThread.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pCaption.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(3, 38);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scLeft);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.gbMultThread);
            this.scMain.Panel2.Controls.Add(this.lbHelp);
            this.scMain.Panel2.Controls.Add(this.lbName);
            this.scMain.Panel2.Controls.Add(this.tbActivityName);
            this.scMain.Panel2.Controls.Add(this.cbMultThread);
            this.scMain.Size = new System.Drawing.Size(684, 271);
            this.scMain.SplitterDistance = 110;
            this.scMain.TabIndex = 0;
            // 
            // scLeft
            // 
            this.scLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scLeft.Location = new System.Drawing.Point(0, 0);
            this.scLeft.Name = "scLeft";
            this.scLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scLeft.Panel1
            // 
            this.scLeft.Panel1.Controls.Add(this.lbActivitys);
            // 
            // scLeft.Panel2
            // 
            this.scLeft.Panel2.Controls.Add(this.llbRun);
            this.scLeft.Panel2.Controls.Add(this.llbDelete);
            this.scLeft.Panel2.Controls.Add(this.llbAdd);
            this.scLeft.Size = new System.Drawing.Size(110, 271);
            this.scLeft.SplitterDistance = 242;
            this.scLeft.TabIndex = 0;
            // 
            // lbActivitys
            // 
            this.lbActivitys.ContextMenuStrip = this.cmsUpDown;
            this.lbActivitys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbActivitys.FormattingEnabled = true;
            this.lbActivitys.ItemHeight = 12;
            this.lbActivitys.Location = new System.Drawing.Point(0, 0);
            this.lbActivitys.Name = "lbActivitys";
            this.lbActivitys.Size = new System.Drawing.Size(110, 242);
            this.lbActivitys.TabIndex = 0;
            this.lbActivitys.SelectedIndexChanged += new System.EventHandler(this.lbActivitys_SelectedIndexChanged);
            // 
            // cmsUpDown
            // 
            this.cmsUpDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTop,
            this.tsmiUp,
            this.tsmiDown,
            this.tsmiBottom,
            this.toolStripMenuItem1,
            this.tsmiCopy,
            this.tsmiPaste});
            this.cmsUpDown.Name = "cmsUpDown";
            this.cmsUpDown.Size = new System.Drawing.Size(181, 164);
            this.cmsUpDown.Opening += new System.ComponentModel.CancelEventHandler(this.cmsUpDown_Opening);
            // 
            // tsmiTop
            // 
            this.tsmiTop.Name = "tsmiTop";
            this.tsmiTop.Size = new System.Drawing.Size(180, 22);
            this.tsmiTop.Text = "置顶";
            this.tsmiTop.Click += new System.EventHandler(this.tsmiTop_Click);
            // 
            // tsmiUp
            // 
            this.tsmiUp.Name = "tsmiUp";
            this.tsmiUp.Size = new System.Drawing.Size(180, 22);
            this.tsmiUp.Text = "上移";
            this.tsmiUp.Click += new System.EventHandler(this.tsmiUp_Click);
            // 
            // tsmiDown
            // 
            this.tsmiDown.Name = "tsmiDown";
            this.tsmiDown.Size = new System.Drawing.Size(180, 22);
            this.tsmiDown.Text = "下移";
            this.tsmiDown.Click += new System.EventHandler(this.tsmiDown_Click);
            // 
            // tsmiBottom
            // 
            this.tsmiBottom.Name = "tsmiBottom";
            this.tsmiBottom.Size = new System.Drawing.Size(180, 22);
            this.tsmiBottom.Text = "底部";
            this.tsmiBottom.Click += new System.EventHandler(this.tsmiBottom_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(180, 22);
            this.tsmiCopy.Text = "复制";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(180, 22);
            this.tsmiPaste.Text = "粘贴";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // llbRun
            // 
            this.llbRun.AutoSize = true;
            this.llbRun.Location = new System.Drawing.Point(41, 5);
            this.llbRun.Name = "llbRun";
            this.llbRun.Size = new System.Drawing.Size(29, 12);
            this.llbRun.TabIndex = 1;
            this.llbRun.TabStop = true;
            this.llbRun.Text = "运行";
            this.llbRun.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRun_LinkClicked);
            // 
            // llbDelete
            // 
            this.llbDelete.AutoSize = true;
            this.llbDelete.Enabled = false;
            this.llbDelete.Location = new System.Drawing.Point(79, 5);
            this.llbDelete.Name = "llbDelete";
            this.llbDelete.Size = new System.Drawing.Size(29, 12);
            this.llbDelete.TabIndex = 0;
            this.llbDelete.TabStop = true;
            this.llbDelete.Text = "删除";
            this.llbDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDelete_LinkClicked);
            // 
            // llbAdd
            // 
            this.llbAdd.AutoSize = true;
            this.llbAdd.Location = new System.Drawing.Point(6, 5);
            this.llbAdd.Name = "llbAdd";
            this.llbAdd.Size = new System.Drawing.Size(29, 12);
            this.llbAdd.TabIndex = 0;
            this.llbAdd.TabStop = true;
            this.llbAdd.Text = "添加";
            this.llbAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAdd_LinkClicked);
            // 
            // gbMultThread
            // 
            this.gbMultThread.Controls.Add(this.checkBox2);
            this.gbMultThread.Controls.Add(this.checkBox3);
            this.gbMultThread.Controls.Add(this.selectMultVarName1);
            this.gbMultThread.Controls.Add(this.numericUpDown2);
            this.gbMultThread.Controls.Add(this.numericUpDown3);
            this.gbMultThread.Controls.Add(this.numericUpDown1);
            this.gbMultThread.Controls.Add(this.label2);
            this.gbMultThread.Controls.Add(this.label3);
            this.gbMultThread.Controls.Add(this.label1);
            this.gbMultThread.Location = new System.Drawing.Point(30, 57);
            this.gbMultThread.Name = "gbMultThread";
            this.gbMultThread.Size = new System.Drawing.Size(522, 152);
            this.gbMultThread.TabIndex = 5;
            this.gbMultThread.TabStop = false;
            this.gbMultThread.Text = "多线程选项";
            this.gbMultThread.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 116);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(252, 16);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "当整个流程完成时，等待当前所有线程完成";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(21, 85);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(288, 16);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "当等候队列数达到指定值时，暂时不进入下一流程";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // selectMultVarName1
            // 
            this.selectMultVarName1.Location = new System.Drawing.Point(281, 47);
            this.selectMultVarName1.Name = "selectMultVarName1";
            this.selectMultVarName1.Size = new System.Drawing.Size(213, 23);
            this.selectMultVarName1.TabIndex = 5;
            this.selectMultVarName1.VarNames = ((System.Collections.Generic.List<string>)(resources.GetObject("selectMultVarName1.VarNames")));
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(368, 21);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(43, 21);
            this.numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(311, 82);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(43, 21);
            this.numericUpDown3.TabIndex = 3;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(91, 22);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 21);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "同线程间两次执行时间间隔毫秒数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "指定传入参数，不指定会复制当前所有变量传入";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "线程数设定";
            // 
            // lbHelp
            // 
            this.lbHelp.ForeColor = System.Drawing.Color.Green;
            this.lbHelp.Location = new System.Drawing.Point(28, 220);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(524, 40);
            this.lbHelp.TabIndex = 1;
            this.lbHelp.Text = "序列可以将多个操作合并到一个列表当中，减少流程图中大多的细节操作，多线程开启后。当前序列的运行不会对变量产生写的操作。如果整个流程变量数据比较大，多线程复制变量将" +
    "占用较多内存，请指定传入参数，能极大减少内存使用。有些组件可能不支持多线程调用，请谨慎使用。";
            this.lbHelp.Visible = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(28, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(53, 12);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "序列名称";
            // 
            // tbActivityName
            // 
            this.tbActivityName.Location = new System.Drawing.Point(87, 18);
            this.tbActivityName.Name = "tbActivityName";
            this.tbActivityName.Size = new System.Drawing.Size(184, 21);
            this.tbActivityName.TabIndex = 0;
            this.tbActivityName.TextChanged += new System.EventHandler(this.tbActivityName_TextChanged);
            // 
            // cbMultThread
            // 
            this.cbMultThread.AutoSize = true;
            this.cbMultThread.Location = new System.Drawing.Point(296, 21);
            this.cbMultThread.Name = "cbMultThread";
            this.cbMultThread.Size = new System.Drawing.Size(156, 16);
            this.cbMultThread.TabIndex = 2;
            this.cbMultThread.Text = "当前序列启用多线程支持";
            this.cbMultThread.UseVisualStyleBackColor = true;
            this.cbMultThread.Visible = false;
            // 
            // cmsActivity
            // 
            this.cmsActivity.Name = "cmsActivity";
            this.cmsActivity.Size = new System.Drawing.Size(61, 4);
            // 
            // pCaption
            // 
            this.pCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCaption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pCaption.Controls.Add(this.llbHelp);
            this.pCaption.Controls.Add(this.lbClose);
            this.pCaption.Controls.Add(this.lbTitle);
            this.pCaption.Location = new System.Drawing.Point(6, 4);
            this.pCaption.Name = "pCaption";
            this.pCaption.Size = new System.Drawing.Size(679, 33);
            this.pCaption.TabIndex = 2;
            this.pCaption.Paint += new System.Windows.Forms.PaintEventHandler(this.pCaption_Paint);
            this.pCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pCaption_MouseDown);
            this.pCaption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCaption_MouseMove);
            // 
            // llbHelp
            // 
            this.llbHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbHelp.BackColor = System.Drawing.Color.Transparent;
            this.llbHelp.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llbHelp.ForeColor = System.Drawing.SystemColors.Window;
            this.llbHelp.Location = new System.Drawing.Point(628, 0);
            this.llbHelp.Name = "llbHelp";
            this.llbHelp.Size = new System.Drawing.Size(24, 33);
            this.llbHelp.TabIndex = 3;
            this.llbHelp.Text = "?";
            this.llbHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbHelp.Click += new System.EventHandler(this.llbHelp_Click);
            this.llbHelp.MouseEnter += new System.EventHandler(this.llbHelp_MouseEnter);
            this.llbHelp.MouseLeave += new System.EventHandler(this.llbHelp_MouseLeave);
            // 
            // lbClose
            // 
            this.lbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClose.BackColor = System.Drawing.Color.Transparent;
            this.lbClose.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbClose.ForeColor = System.Drawing.SystemColors.Window;
            this.lbClose.Location = new System.Drawing.Point(652, 0);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(24, 33);
            this.lbClose.TabIndex = 1;
            this.lbClose.Text = "X";
            this.lbClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            this.lbClose.MouseEnter += new System.EventHandler(this.lbClose_MouseEnter);
            this.lbClose.MouseLeave += new System.EventHandler(this.lbClose_MouseLeave);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTitle.Location = new System.Drawing.Point(4, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(56, 16);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "label1";
            // 
            // FrmSequence2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pCaption);
            this.Controls.Add(this.scMain);
            this.Name = "FrmSequence2";
            this.Size = new System.Drawing.Size(690, 309);
            this.Disposed += new System.EventHandler(this.FrmSequence_FormClosing);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scLeft.Panel1.ResumeLayout(false);
            this.scLeft.Panel2.ResumeLayout(false);
            this.scLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLeft)).EndInit();
            this.scLeft.ResumeLayout(false);
            this.cmsUpDown.ResumeLayout(false);
            this.gbMultThread.ResumeLayout(false);
            this.gbMultThread.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pCaption.ResumeLayout(false);
            this.pCaption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scLeft;
        private System.Windows.Forms.ListBox lbActivitys;
        private System.Windows.Forms.LinkLabel llbDelete;
        private System.Windows.Forms.LinkLabel llbAdd;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbActivityName;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.ContextMenuStrip cmsActivity;
        private System.Windows.Forms.ContextMenuStrip cmsUpDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiTop;
        private System.Windows.Forms.ToolStripMenuItem tsmiUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiBottom;
        private System.Windows.Forms.CheckBox cbMultThread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox gbMultThread;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private litsdk.SelectMultVarName selectMultVarName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel pCaption;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.LinkLabel llbRun;
        private System.Windows.Forms.Label llbHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
    }
}