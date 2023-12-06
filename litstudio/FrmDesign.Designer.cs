namespace litstudio
{
    partial class FrmDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDesign));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.activityPanel = new System.Windows.Forms.Panel();
            this.scRight = new System.Windows.Forms.SplitContainer();
            this.pagePanel = new System.Windows.Forms.Panel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenLastProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenDir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRebot = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecover = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMerge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRunSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowAllActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowNoFrontActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowCrossActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTestSpeed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTestSpeed0s = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTestSpeed05s = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTestSpeed1s = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCaptureImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWebSite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmilineUpdate = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tssSaveRun = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRun = new System.Windows.Forms.ToolStripButton();
            this.tsbPause = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tssStopVar = new System.Windows.Forms.ToolStripSeparator();
            this.tsbVariable = new System.Windows.Forms.ToolStripButton();
            this.tsbSelecter = new System.Windows.Forms.ToolStripButton();
            this.nfcMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowMain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmAutoSave = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).BeginInit();
            this.scRight.Panel1.SuspendLayout();
            this.scRight.Panel2.SuspendLayout();
            this.scRight.SuspendLayout();
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 50);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.activityPanel);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scRight);
            this.scMain.Size = new System.Drawing.Size(807, 503);
            this.scMain.SplitterDistance = 199;
            this.scMain.TabIndex = 5;
            // 
            // activityPanel
            // 
            this.activityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityPanel.Location = new System.Drawing.Point(0, 0);
            this.activityPanel.Name = "activityPanel";
            this.activityPanel.Size = new System.Drawing.Size(199, 503);
            this.activityPanel.TabIndex = 1;
            // 
            // scRight
            // 
            this.scRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRight.Location = new System.Drawing.Point(0, 0);
            this.scRight.Name = "scRight";
            this.scRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scRight.Panel1
            // 
            this.scRight.Panel1.Controls.Add(this.pagePanel);
            // 
            // scRight.Panel2
            // 
            this.scRight.Panel2.Controls.Add(this.tbLog);
            this.scRight.Panel2MinSize = 0;
            this.scRight.Size = new System.Drawing.Size(604, 503);
            this.scRight.SplitterDistance = 448;
            this.scRight.TabIndex = 2;
            // 
            // pagePanel
            // 
            this.pagePanel.AutoScroll = true;
            this.pagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePanel.Location = new System.Drawing.Point(0, 0);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(604, 448);
            this.pagePanel.TabIndex = 1;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(0, 0);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(604, 51);
            this.tbLog.TabIndex = 0;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.编辑ToolStripMenuItem,
            this.tsmiView,
            this.tsmiTool,
            this.tsmiHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(807, 25);
            this.msMain.TabIndex = 8;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.tsmiExport,
            this.toolStripMenuItem2,
            this.tsmiOpenLastProject,
            this.toolStripMenuItem7,
            this.tsmiOpenDir,
            this.toolStripMenuItem1,
            this.tsmiRebot,
            this.tsmiQuit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(58, 21);
            this.tsmiFile.Text = "文件(&F)";
            this.tsmiFile.DropDownOpening += new System.EventHandler(this.tsmiFile_DropDownOpening);
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(177, 22);
            this.tsmiNew.Text = "新建(&N)";
            this.tsmiNew.Click += new System.EventHandler(this.TsbNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(177, 22);
            this.tsmiOpen.Text = "打开(&O)";
            this.tsmiOpen.Click += new System.EventHandler(this.TsbOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(177, 22);
            this.tsmiSave.Text = "保存(&S)";
            this.tsmiSave.Click += new System.EventHandler(this.TsbSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(177, 22);
            this.tsmiSaveAs.Text = "另存为(&A)...";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // tsmiExport
            // 
            this.tsmiExport.Name = "tsmiExport";
            this.tsmiExport.Size = new System.Drawing.Size(177, 22);
            this.tsmiExport.Text = "导出流程至本地(E)";
            this.tsmiExport.Click += new System.EventHandler(this.tsmiExport_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmiOpenLastProject
            // 
            this.tsmiOpenLastProject.Name = "tsmiOpenLastProject";
            this.tsmiOpenLastProject.Size = new System.Drawing.Size(177, 22);
            this.tsmiOpenLastProject.Text = "最近打开的项目(&P)";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmiOpenDir
            // 
            this.tsmiOpenDir.Name = "tsmiOpenDir";
            this.tsmiOpenDir.Size = new System.Drawing.Size(177, 22);
            this.tsmiOpenDir.Text = "打开程序文件夹(&D)";
            this.tsmiOpenDir.Click += new System.EventHandler(this.tsmiOpenDir_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmiRebot
            // 
            this.tsmiRebot.Name = "tsmiRebot";
            this.tsmiRebot.Size = new System.Drawing.Size(177, 22);
            this.tsmiRebot.Text = "重启(&B)";
            this.tsmiRebot.Click += new System.EventHandler(this.tsmiRebot_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(177, 22);
            this.tsmiQuit.Text = "退出(&X)";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiDelete,
            this.toolStripMenuItem12,
            this.tsmiUndo,
            this.tsmiRecover,
            this.tsmiMerge,
            this.toolStripMenuItem10,
            this.tsmiRunSelect,
            this.tsmiProject});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(140, 22);
            this.tsmiCopy.Text = "复制(&C)";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(140, 22);
            this.tsmiPaste.Text = "粘帖(&P)";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(140, 22);
            this.tsmiDelete.Text = "删除(&D)";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.Size = new System.Drawing.Size(140, 22);
            this.tsmiUndo.Text = "撤销(&Z)";
            this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
            // 
            // tsmiRecover
            // 
            this.tsmiRecover.Name = "tsmiRecover";
            this.tsmiRecover.Size = new System.Drawing.Size(140, 22);
            this.tsmiRecover.Text = "恢复(&Y)";
            this.tsmiRecover.Click += new System.EventHandler(this.tsmiRecover_Click);
            // 
            // tsmiMerge
            // 
            this.tsmiMerge.Name = "tsmiMerge";
            this.tsmiMerge.Size = new System.Drawing.Size(140, 22);
            this.tsmiMerge.Text = "合并(&M)";
            this.tsmiMerge.Click += new System.EventHandler(this.tsmiMerge_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiRunSelect
            // 
            this.tsmiRunSelect.Name = "tsmiRunSelect";
            this.tsmiRunSelect.Size = new System.Drawing.Size(140, 22);
            this.tsmiRunSelect.Text = "运行选中(&R)";
            this.tsmiRunSelect.Click += new System.EventHandler(this.tsmiRunSelect_Click);
            // 
            // tsmiProject
            // 
            this.tsmiProject.Name = "tsmiProject";
            this.tsmiProject.Size = new System.Drawing.Size(140, 22);
            this.tsmiProject.Text = "项目属性(&A)";
            this.tsmiProject.Click += new System.EventHandler(this.tsmiProject_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowAllActivity,
            this.tsmiShowNoFrontActivity,
            this.tsmiShowCrossActivity,
            this.toolStripMenuItem5,
            this.tsmiTestSpeed});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(60, 21);
            this.tsmiView.Text = "视图(&V)";
            // 
            // tsmiShowAllActivity
            // 
            this.tsmiShowAllActivity.Name = "tsmiShowAllActivity";
            this.tsmiShowAllActivity.Size = new System.Drawing.Size(176, 22);
            this.tsmiShowAllActivity.Text = "显示所有组件(&A)";
            this.tsmiShowAllActivity.Click += new System.EventHandler(this.tsmiShowAllActivity_Click);
            // 
            // tsmiShowNoFrontActivity
            // 
            this.tsmiShowNoFrontActivity.Name = "tsmiShowNoFrontActivity";
            this.tsmiShowNoFrontActivity.Size = new System.Drawing.Size(176, 22);
            this.tsmiShowNoFrontActivity.Text = "显示后台组件(&B)";
            this.tsmiShowNoFrontActivity.Click += new System.EventHandler(this.tsmiShowNoFrontActivity_Click);
            // 
            // tsmiShowCrossActivity
            // 
            this.tsmiShowCrossActivity.Name = "tsmiShowCrossActivity";
            this.tsmiShowCrossActivity.Size = new System.Drawing.Size(176, 22);
            this.tsmiShowCrossActivity.Text = "显示跨平台组件(&C)";
            this.tsmiShowCrossActivity.Click += new System.EventHandler(this.tsmiShowCrossActivity_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(173, 6);
            // 
            // tsmiTestSpeed
            // 
            this.tsmiTestSpeed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTestSpeed0s,
            this.tsmiTestSpeed05s,
            this.tsmiTestSpeed1s});
            this.tsmiTestSpeed.Name = "tsmiTestSpeed";
            this.tsmiTestSpeed.Size = new System.Drawing.Size(176, 22);
            this.tsmiTestSpeed.Text = "测试时节点速度(&S)";
            this.tsmiTestSpeed.DropDownOpening += new System.EventHandler(this.tsmiTestSpeed_DropDownOpening);
            // 
            // tsmiTestSpeed0s
            // 
            this.tsmiTestSpeed0s.Name = "tsmiTestSpeed0s";
            this.tsmiTestSpeed0s.Size = new System.Drawing.Size(125, 22);
            this.tsmiTestSpeed0s.Text = "快(0秒)";
            this.tsmiTestSpeed0s.Click += new System.EventHandler(this.tsmiTestSpeed0s_Click);
            // 
            // tsmiTestSpeed05s
            // 
            this.tsmiTestSpeed05s.Name = "tsmiTestSpeed05s";
            this.tsmiTestSpeed05s.Size = new System.Drawing.Size(125, 22);
            this.tsmiTestSpeed05s.Text = "中(0.3秒)";
            this.tsmiTestSpeed05s.Click += new System.EventHandler(this.tsmiTestSpeed05s_Click);
            // 
            // tsmiTestSpeed1s
            // 
            this.tsmiTestSpeed1s.Name = "tsmiTestSpeed1s";
            this.tsmiTestSpeed1s.Size = new System.Drawing.Size(125, 22);
            this.tsmiTestSpeed1s.Text = "慢(0.5秒)";
            this.tsmiTestSpeed1s.Click += new System.EventHandler(this.tsmiTestSpeed1s_Click);
            // 
            // tsmiTool
            // 
            this.tsmiTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCaptureImage,
            this.toolStripMenuItem4,
            this.tsmiOption});
            this.tsmiTool.Name = "tsmiTool";
            this.tsmiTool.Size = new System.Drawing.Size(59, 21);
            this.tsmiTool.Text = "工具(&T)";
            // 
            // tsmiCaptureImage
            // 
            this.tsmiCaptureImage.Name = "tsmiCaptureImage";
            this.tsmiCaptureImage.Size = new System.Drawing.Size(151, 22);
            this.tsmiCaptureImage.Text = "流程图截图(&S)";
            this.tsmiCaptureImage.Click += new System.EventHandler(this.tsmiCaptureImage_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(148, 6);
            // 
            // tsmiOption
            // 
            this.tsmiOption.Name = "tsmiOption";
            this.tsmiOption.Size = new System.Drawing.Size(151, 22);
            this.tsmiOption.Text = "选项(&O)";
            this.tsmiOption.Click += new System.EventHandler(this.tsmiOption_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWebSite,
            this.tsmilineUpdate,
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelp.Text = "帮助(&H)";
            // 
            // tsmiWebSite
            // 
            this.tsmiWebSite.Name = "tsmiWebSite";
            this.tsmiWebSite.Size = new System.Drawing.Size(144, 22);
            this.tsmiWebSite.Text = "打开网站(&W)";
            this.tsmiWebSite.Click += new System.EventHandler(this.tsmiWebSite_Click);
            // 
            // tsmilineUpdate
            // 
            this.tsmilineUpdate.Name = "tsmilineUpdate";
            this.tsmilineUpdate.Size = new System.Drawing.Size(141, 6);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(144, 22);
            this.tsmiAbout.Text = "关于产品(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // ssMain
            // 
            this.ssMain.Location = new System.Drawing.Point(0, 553);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(807, 22);
            this.ssMain.TabIndex = 9;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.tssSaveRun,
            this.tsbRun,
            this.tsbPause,
            this.tsbStop,
            this.tssStopVar,
            this.tsbVariable,
            this.tsbSelecter});
            this.tsMain.Location = new System.Drawing.Point(0, 25);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(807, 25);
            this.tsMain.TabIndex = 10;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = global::litstudio.Properties.Resources.新建;
            this.tsbNew.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(52, 22);
            this.tsbNew.Text = "新建";
            this.tsbNew.Click += new System.EventHandler(this.TsbNew_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::litstudio.Properties.Resources.打开;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(52, 22);
            this.tsbOpen.Text = "打开";
            this.tsbOpen.Click += new System.EventHandler(this.TsbOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::litstudio.Properties.Resources.保存;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.TsbSave_Click);
            // 
            // tssSaveRun
            // 
            this.tssSaveRun.Name = "tssSaveRun";
            this.tssSaveRun.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRun
            // 
            this.tsbRun.Image = global::litstudio.Properties.Resources.开始;
            this.tsbRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRun.Name = "tsbRun";
            this.tsbRun.Size = new System.Drawing.Size(52, 22);
            this.tsbRun.Text = "运行";
            this.tsbRun.Click += new System.EventHandler(this.TsbRun_Click);
            // 
            // tsbPause
            // 
            this.tsbPause.Image = global::litstudio.Properties.Resources.暂停;
            this.tsbPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPause.Name = "tsbPause";
            this.tsbPause.Size = new System.Drawing.Size(52, 22);
            this.tsbPause.Text = "暂停";
            this.tsbPause.Click += new System.EventHandler(this.TsbPause_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.Image = global::litstudio.Properties.Resources.停止;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(52, 22);
            this.tsbStop.Text = "停止";
            this.tsbStop.Click += new System.EventHandler(this.TsbStop_Click);
            // 
            // tssStopVar
            // 
            this.tssStopVar.Name = "tssStopVar";
            this.tssStopVar.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbVariable
            // 
            this.tsbVariable.Image = global::litstudio.Properties.Resources.变量;
            this.tsbVariable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVariable.Name = "tsbVariable";
            this.tsbVariable.Size = new System.Drawing.Size(52, 22);
            this.tsbVariable.Text = "变量";
            this.tsbVariable.Click += new System.EventHandler(this.TsbVariable_Click);
            // 
            // tsbSelecter
            // 
            this.tsbSelecter.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelecter.Image")));
            this.tsbSelecter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelecter.Name = "tsbSelecter";
            this.tsbSelecter.Size = new System.Drawing.Size(76, 22);
            this.tsbSelecter.Text = "元素分析";
            this.tsbSelecter.Click += new System.EventHandler(this.tsbSelecter_Click);
            // 
            // nfcMain
            // 
            this.nfcMain.ContextMenuStrip = this.cmsMain;
            this.nfcMain.Text = "notifyIcon1";
            this.nfcMain.Visible = true;
            this.nfcMain.DoubleClick += new System.EventHandler(this.nfcMain_DoubleClick);
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowMain,
            this.toolStripMenuItem3,
            this.tsmiQuit2});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(117, 54);
            // 
            // tsmiShowMain
            // 
            this.tsmiShowMain.Name = "tsmiShowMain";
            this.tsmiShowMain.Size = new System.Drawing.Size(116, 22);
            this.tsmiShowMain.Text = "显示(&V)";
            this.tsmiShowMain.Click += new System.EventHandler(this.tsmiShowMain_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(113, 6);
            // 
            // tsmiQuit2
            // 
            this.tsmiQuit2.Name = "tsmiQuit2";
            this.tsmiQuit2.Size = new System.Drawing.Size(116, 22);
            this.tsmiQuit2.Text = "退出(&X)";
            this.tsmiQuit2.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // tmAutoSave
            // 
            this.tmAutoSave.Enabled = true;
            this.tmAutoSave.Interval = 60000;
            this.tmAutoSave.Tick += new System.EventHandler(this.tmAutoSave_Tick);
            // 
            // FrmDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 575);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "litrpa流程设计器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDesign_FormClosing);
            this.Load += new System.EventHandler(this.FrmDesign_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDesign_KeyDown);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scRight.Panel1.ResumeLayout(false);
            this.scRight.Panel2.ResumeLayout(false);
            this.scRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).EndInit();
            this.scRight.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Panel pagePanel;
        private System.Windows.Forms.Panel activityPanel;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator tssSaveRun;
        private System.Windows.Forms.ToolStripButton tsbRun;
        private System.Windows.Forms.ToolStripButton tsbPause;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool;
        private System.Windows.Forms.ToolStripSeparator tssStopVar;
        private System.Windows.Forms.ToolStripButton tsbVariable;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenLastProject;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;

        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.NotifyIcon nfcMain;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowMain;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit2;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.SplitContainer scRight;
        private System.Windows.Forms.ToolStripMenuItem tsmiCaptureImage;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripButton tsbSelecter;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;

        private System.Windows.Forms.ToolStripMenuItem tsmiWebSite;
        private System.Windows.Forms.ToolStripSeparator tsmilineUpdate;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem tsmiRunSelect;
        private System.Windows.Forms.ToolStripMenuItem tsmiOption;
        private System.Windows.Forms.ToolStripMenuItem tsmiRebot;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenDir;
        private System.Windows.Forms.Timer tmAutoSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowAllActivity;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowNoFrontActivity;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowCrossActivity;
        private System.Windows.Forms.ToolStripMenuItem tsmiProject;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmiTestSpeed;
        private System.Windows.Forms.ToolStripMenuItem tsmiTestSpeed0s;
        private System.Windows.Forms.ToolStripMenuItem tsmiTestSpeed05s;
        private System.Windows.Forms.ToolStripMenuItem tsmiTestSpeed1s;
        private System.Windows.Forms.ToolStripMenuItem tsmiExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecover;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem tsmiMerge;
    }
}