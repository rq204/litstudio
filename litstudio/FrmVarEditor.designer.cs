namespace litstudio
{
    partial class FrmVarEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVarEditor));
            this.lsvAllVar = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsVar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditVarName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyVarName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyVarValue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExportSelectVar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiValueToInit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIportClipPost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveLine = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiMoveTop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveBotton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnDeleteVar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnClearVar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstbVarName = new System.Windows.Forms.ToolStripTextBox();
            this.tssbtnAddVarStr = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiAddVarInt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddVarList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddVarTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsVarGroup = new System.Windows.Forms.ToolStrip();
            this.tsbtnShowAllVar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnShowStrVar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnShowListVar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnShowIntVar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnShowTableVar = new System.Windows.Forms.ToolStripButton();
            this.dgvVarListData = new System.Windows.Forms.DataGridView();
            this.chId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chVar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plEditVar = new System.Windows.Forms.Panel();
            this.tcVar = new System.Windows.Forms.TabControl();
            this.tpVarStr = new System.Windows.Forms.TabPage();
            this.tbInitVarValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveVar = new System.Windows.Forms.Button();
            this.lbInitValue = new System.Windows.Forms.Label();
            this.lbVarValue = new System.Windows.Forms.Label();
            this.tbVarValue = new System.Windows.Forms.TextBox();
            this.tbVarName = new System.Windows.Forms.TextBox();
            this.tpVarLsv = new System.Windows.Forms.TabPage();
            this.cmsVar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tsVarGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarListData)).BeginInit();
            this.plEditVar.SuspendLayout();
            this.tcVar.SuspendLayout();
            this.tpVarStr.SuspendLayout();
            this.tpVarLsv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvAllVar
            // 
            this.lsvAllVar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chValue,
            this.chType});
            this.lsvAllVar.ContextMenuStrip = this.cmsVar;
            this.lsvAllVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvAllVar.FullRowSelect = true;
            this.lsvAllVar.HideSelection = false;
            this.lsvAllVar.Location = new System.Drawing.Point(3, 3);
            this.lsvAllVar.Name = "lsvAllVar";
            this.lsvAllVar.Size = new System.Drawing.Size(542, 377);
            this.lsvAllVar.TabIndex = 0;
            this.lsvAllVar.UseCompatibleStateImageBehavior = false;
            this.lsvAllVar.View = System.Windows.Forms.View.Details;
            this.lsvAllVar.SelectedIndexChanged += new System.EventHandler(this.lsvAllVar_SelectedIndexChanged);
            this.lsvAllVar.DoubleClick += new System.EventHandler(this.lsvAllVar_DoubleClick);
            // 
            // chName
            // 
            this.chName.Text = "变量名";
            this.chName.Width = 80;
            // 
            // chValue
            // 
            this.chValue.Text = "变量值";
            this.chValue.Width = 380;
            // 
            // chType
            // 
            this.chType.Text = "变量类型";
            // 
            // cmsVar
            // 
            this.cmsVar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditVarName,
            this.tsmiCopyVarName,
            this.tsmiCopyVarValue,
            this.toolStripMenuItem1,
            this.tsmiExportSelectVar,
            this.toolStripMenuItem2,
            this.tsmiValueToInit,
            this.tsmiIportClipPost,
            this.tsmiMoveLine,
            this.tsmiMoveTop,
            this.tsmiMoveUp,
            this.tsmiMoveDown,
            this.tsmiMoveBotton});
            this.cmsVar.Name = "cmsVar";
            this.cmsVar.Size = new System.Drawing.Size(181, 264);
            this.cmsVar.Opening += new System.ComponentModel.CancelEventHandler(this.cmsVar_Opening);
            // 
            // tsmiEditVarName
            // 
            this.tsmiEditVarName.Name = "tsmiEditVarName";
            this.tsmiEditVarName.Size = new System.Drawing.Size(180, 22);
            this.tsmiEditVarName.Text = "编辑初始值";
            this.tsmiEditVarName.Click += new System.EventHandler(this.tsmiEditVarName_Click);
            // 
            // tsmiCopyVarName
            // 
            this.tsmiCopyVarName.Name = "tsmiCopyVarName";
            this.tsmiCopyVarName.Size = new System.Drawing.Size(180, 22);
            this.tsmiCopyVarName.Text = "复制变量名";
            this.tsmiCopyVarName.Click += new System.EventHandler(this.tsmiCopyVarName_Click);
            // 
            // tsmiCopyVarValue
            // 
            this.tsmiCopyVarValue.Name = "tsmiCopyVarValue";
            this.tsmiCopyVarValue.Size = new System.Drawing.Size(180, 22);
            this.tsmiCopyVarValue.Text = "复制变量值";
            this.tsmiCopyVarValue.Click += new System.EventHandler(this.tsmiCopyVarValue_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiExportSelectVar
            // 
            this.tsmiExportSelectVar.Name = "tsmiExportSelectVar";
            this.tsmiExportSelectVar.Size = new System.Drawing.Size(180, 22);
            this.tsmiExportSelectVar.Text = "导出选中变量";
            this.tsmiExportSelectVar.Click += new System.EventHandler(this.tsmiExportSelectVar_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiValueToInit
            // 
            this.tsmiValueToInit.Name = "tsmiValueToInit";
            this.tsmiValueToInit.Size = new System.Drawing.Size(180, 22);
            this.tsmiValueToInit.Text = "值转为初始值";
            this.tsmiValueToInit.Click += new System.EventHandler(this.tsmiValueToInit_Click);
            // 
            // tsmiIportClipPost
            // 
            this.tsmiIportClipPost.Name = "tsmiIportClipPost";
            this.tsmiIportClipPost.Size = new System.Drawing.Size(180, 22);
            this.tsmiIportClipPost.Text = "导入POST数据";
            this.tsmiIportClipPost.Click += new System.EventHandler(this.tsmiIportClip_Click);
            // 
            // tsmiMoveLine
            // 
            this.tsmiMoveLine.Name = "tsmiMoveLine";
            this.tsmiMoveLine.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiMoveTop
            // 
            this.tsmiMoveTop.Name = "tsmiMoveTop";
            this.tsmiMoveTop.Size = new System.Drawing.Size(180, 22);
            this.tsmiMoveTop.Text = "置顶";
            this.tsmiMoveTop.Click += new System.EventHandler(this.tsmiMoveTop_Click);
            // 
            // tsmiMoveUp
            // 
            this.tsmiMoveUp.Name = "tsmiMoveUp";
            this.tsmiMoveUp.Size = new System.Drawing.Size(180, 22);
            this.tsmiMoveUp.Text = "上移";
            this.tsmiMoveUp.Click += new System.EventHandler(this.tsmiMoveUp_Click);
            // 
            // tsmiMoveDown
            // 
            this.tsmiMoveDown.Name = "tsmiMoveDown";
            this.tsmiMoveDown.Size = new System.Drawing.Size(180, 22);
            this.tsmiMoveDown.Text = "下移";
            this.tsmiMoveDown.Click += new System.EventHandler(this.tsmiMoveDown_Click);
            // 
            // tsmiMoveBotton
            // 
            this.tsmiMoveBotton.Name = "tsmiMoveBotton";
            this.tsmiMoveBotton.Size = new System.Drawing.Size(180, 22);
            this.tsmiMoveBotton.Text = "底部";
            this.tsmiMoveBotton.Click += new System.EventHandler(this.tsmiMoveBotton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnDeleteVar,
            this.toolStripSeparator1,
            this.tsbtnClearVar,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.tstbVarName,
            this.tssbtnAddVarStr,
            this.tsbExport,
            this.tsbImport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 418);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(559, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnDeleteVar
            // 
            this.tsbtnDeleteVar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnDeleteVar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDeleteVar.Image")));
            this.tsbtnDeleteVar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDeleteVar.Name = "tsbtnDeleteVar";
            this.tsbtnDeleteVar.Size = new System.Drawing.Size(60, 22);
            this.tsbtnDeleteVar.Text = "删除变量";
            this.tsbtnDeleteVar.Click += new System.EventHandler(this.tsbtnDeleteVar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnClearVar
            // 
            this.tsbtnClearVar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnClearVar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClearVar.Image")));
            this.tsbtnClearVar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClearVar.Name = "tsbtnClearVar";
            this.tsbtnClearVar.Size = new System.Drawing.Size(72, 22);
            this.tsbtnClearVar.Text = "清空变量值";
            this.tsbtnClearVar.Click += new System.EventHandler(this.tsbtnEmptyVar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(62, 22);
            this.toolStripLabel1.Text = "变量名>>";
            // 
            // tstbVarName
            // 
            this.tstbVarName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstbVarName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstbVarName.Name = "tstbVarName";
            this.tstbVarName.Size = new System.Drawing.Size(120, 25);
            // 
            // tssbtnAddVarStr
            // 
            this.tssbtnAddVarStr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssbtnAddVarStr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddVarInt,
            this.tsmiAddVarList,
            this.tsmiAddVarTable});
            this.tssbtnAddVarStr.Image = ((System.Drawing.Image)(resources.GetObject("tssbtnAddVarStr.Image")));
            this.tssbtnAddVarStr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbtnAddVarStr.Name = "tssbtnAddVarStr";
            this.tssbtnAddVarStr.Size = new System.Drawing.Size(96, 22);
            this.tssbtnAddVarStr.Text = "添加字符变量";
            this.tssbtnAddVarStr.ButtonClick += new System.EventHandler(this.tssbtnAddVarStr_ButtonClick);
            // 
            // tsmiAddVarInt
            // 
            this.tsmiAddVarInt.Name = "tsmiAddVarInt";
            this.tsmiAddVarInt.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddVarInt.Text = "添加数字变量";
            this.tsmiAddVarInt.Click += new System.EventHandler(this.tsmiAddVarInt_Click);
            // 
            // tsmiAddVarList
            // 
            this.tsmiAddVarList.Name = "tsmiAddVarList";
            this.tsmiAddVarList.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddVarList.Text = "添加列表变量";
            this.tsmiAddVarList.Click += new System.EventHandler(this.tsmiAddVarList_Click);
            // 
            // tsmiAddVarTable
            // 
            this.tsmiAddVarTable.Name = "tsmiAddVarTable";
            this.tsmiAddVarTable.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddVarTable.Text = "添加表格变量";
            this.tsmiAddVarTable.Click += new System.EventHandler(this.tsmiAddVarTable_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(60, 22);
            this.tsbExport.Text = "导出变量";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // tsbImport
            // 
            this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(60, 22);
            this.tsbImport.Text = "导入变量";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // tsVarGroup
            // 
            this.tsVarGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnShowAllVar,
            this.tsbtnShowStrVar,
            this.tsbtnShowListVar,
            this.tsbtnShowIntVar,
            this.tsbtnShowTableVar});
            this.tsVarGroup.Location = new System.Drawing.Point(0, 0);
            this.tsVarGroup.Name = "tsVarGroup";
            this.tsVarGroup.Size = new System.Drawing.Size(559, 25);
            this.tsVarGroup.TabIndex = 3;
            this.tsVarGroup.Text = "toolStrip2";
            // 
            // tsbtnShowAllVar
            // 
            this.tsbtnShowAllVar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShowAllVar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShowAllVar.Image")));
            this.tsbtnShowAllVar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowAllVar.Name = "tsbtnShowAllVar";
            this.tsbtnShowAllVar.Size = new System.Drawing.Size(60, 22);
            this.tsbtnShowAllVar.Text = "所有变量";
            this.tsbtnShowAllVar.Click += new System.EventHandler(this.tsbtnShowAllVar_Click);
            // 
            // tsbtnShowStrVar
            // 
            this.tsbtnShowStrVar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShowStrVar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShowStrVar.Image")));
            this.tsbtnShowStrVar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowStrVar.Name = "tsbtnShowStrVar";
            this.tsbtnShowStrVar.Size = new System.Drawing.Size(60, 22);
            this.tsbtnShowStrVar.Text = "字符变量";
            this.tsbtnShowStrVar.Click += new System.EventHandler(this.tsbtnShowStrVar_Click);
            // 
            // tsbtnShowListVar
            // 
            this.tsbtnShowListVar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShowListVar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShowListVar.Image")));
            this.tsbtnShowListVar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowListVar.Name = "tsbtnShowListVar";
            this.tsbtnShowListVar.Size = new System.Drawing.Size(60, 22);
            this.tsbtnShowListVar.Text = "列表变量";
            this.tsbtnShowListVar.Click += new System.EventHandler(this.tsbtnShowListVar_Click);
            // 
            // tsbtnShowIntVar
            // 
            this.tsbtnShowIntVar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShowIntVar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShowIntVar.Image")));
            this.tsbtnShowIntVar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowIntVar.Name = "tsbtnShowIntVar";
            this.tsbtnShowIntVar.Size = new System.Drawing.Size(60, 22);
            this.tsbtnShowIntVar.Text = "数字变量";
            this.tsbtnShowIntVar.Click += new System.EventHandler(this.tsbtnShowIntVar_Click);
            // 
            // tsbtnShowTableVar
            // 
            this.tsbtnShowTableVar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShowTableVar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShowTableVar.Image")));
            this.tsbtnShowTableVar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowTableVar.Name = "tsbtnShowTableVar";
            this.tsbtnShowTableVar.Size = new System.Drawing.Size(60, 22);
            this.tsbtnShowTableVar.Text = "表格变量";
            this.tsbtnShowTableVar.Click += new System.EventHandler(this.tsbtnShowTableVar_Click);
            // 
            // dgvVarListData
            // 
            this.dgvVarListData.AllowUserToAddRows = false;
            this.dgvVarListData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarListData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chId,
            this.chVar});
            this.dgvVarListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVarListData.Location = new System.Drawing.Point(0, 0);
            this.dgvVarListData.Name = "dgvVarListData";
            this.dgvVarListData.ReadOnly = true;
            this.dgvVarListData.RowTemplate.Height = 23;
            this.dgvVarListData.Size = new System.Drawing.Size(559, 443);
            this.dgvVarListData.TabIndex = 4;
            // 
            // chId
            // 
            this.chId.HeaderText = "Id";
            this.chId.Name = "chId";
            this.chId.ReadOnly = true;
            // 
            // chVar
            // 
            this.chVar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chVar.HeaderText = "列表变量值";
            this.chVar.Name = "chVar";
            this.chVar.ReadOnly = true;
            // 
            // plEditVar
            // 
            this.plEditVar.Controls.Add(this.tcVar);
            this.plEditVar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plEditVar.Location = new System.Drawing.Point(0, 0);
            this.plEditVar.Name = "plEditVar";
            this.plEditVar.Size = new System.Drawing.Size(559, 443);
            this.plEditVar.TabIndex = 5;
            // 
            // tcVar
            // 
            this.tcVar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcVar.Controls.Add(this.tpVarStr);
            this.tcVar.Controls.Add(this.tpVarLsv);
            this.tcVar.ItemSize = new System.Drawing.Size(0, 1);
            this.tcVar.Location = new System.Drawing.Point(0, 26);
            this.tcVar.Name = "tcVar";
            this.tcVar.SelectedIndex = 0;
            this.tcVar.Size = new System.Drawing.Size(556, 392);
            this.tcVar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcVar.TabIndex = 4;
            // 
            // tpVarStr
            // 
            this.tpVarStr.Controls.Add(this.tbInitVarValue);
            this.tpVarStr.Controls.Add(this.label1);
            this.tpVarStr.Controls.Add(this.btnSaveVar);
            this.tpVarStr.Controls.Add(this.lbInitValue);
            this.tpVarStr.Controls.Add(this.lbVarValue);
            this.tpVarStr.Controls.Add(this.tbVarValue);
            this.tpVarStr.Controls.Add(this.tbVarName);
            this.tpVarStr.Location = new System.Drawing.Point(4, 5);
            this.tpVarStr.Name = "tpVarStr";
            this.tpVarStr.Padding = new System.Windows.Forms.Padding(3);
            this.tpVarStr.Size = new System.Drawing.Size(548, 383);
            this.tpVarStr.TabIndex = 0;
            this.tpVarStr.Text = "变量值";
            this.tpVarStr.UseVisualStyleBackColor = true;
            // 
            // tbInitVarValue
            // 
            this.tbInitVarValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInitVarValue.Location = new System.Drawing.Point(64, 50);
            this.tbInitVarValue.MaxLength = 327670000;
            this.tbInitVarValue.Multiline = true;
            this.tbInitVarValue.Name = "tbInitVarValue";
            this.tbInitVarValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInitVarValue.Size = new System.Drawing.Size(455, 124);
            this.tbInitVarValue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "变量名";
            // 
            // btnSaveVar
            // 
            this.btnSaveVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveVar.Location = new System.Drawing.Point(444, 329);
            this.btnSaveVar.Name = "btnSaveVar";
            this.btnSaveVar.Size = new System.Drawing.Size(75, 23);
            this.btnSaveVar.TabIndex = 3;
            this.btnSaveVar.Text = "保存";
            this.btnSaveVar.UseVisualStyleBackColor = true;
            this.btnSaveVar.Click += new System.EventHandler(this.btnSaveVar_Click);
            // 
            // lbInitValue
            // 
            this.lbInitValue.AutoSize = true;
            this.lbInitValue.Location = new System.Drawing.Point(17, 54);
            this.lbInitValue.Name = "lbInitValue";
            this.lbInitValue.Size = new System.Drawing.Size(41, 12);
            this.lbInitValue.TabIndex = 1;
            this.lbInitValue.Text = "初始值";
            // 
            // lbVarValue
            // 
            this.lbVarValue.AutoSize = true;
            this.lbVarValue.Location = new System.Drawing.Point(17, 199);
            this.lbVarValue.Name = "lbVarValue";
            this.lbVarValue.Size = new System.Drawing.Size(41, 12);
            this.lbVarValue.TabIndex = 1;
            this.lbVarValue.Text = "变量值\r\n";
            // 
            // tbVarValue
            // 
            this.tbVarValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVarValue.Location = new System.Drawing.Point(64, 199);
            this.tbVarValue.MaxLength = 327670000;
            this.tbVarValue.Multiline = true;
            this.tbVarValue.Name = "tbVarValue";
            this.tbVarValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbVarValue.Size = new System.Drawing.Size(455, 114);
            this.tbVarValue.TabIndex = 2;
            // 
            // tbVarName
            // 
            this.tbVarName.Location = new System.Drawing.Point(64, 13);
            this.tbVarName.Name = "tbVarName";
            this.tbVarName.ReadOnly = true;
            this.tbVarName.Size = new System.Drawing.Size(243, 21);
            this.tbVarName.TabIndex = 2;
            // 
            // tpVarLsv
            // 
            this.tpVarLsv.Controls.Add(this.lsvAllVar);
            this.tpVarLsv.Location = new System.Drawing.Point(4, 5);
            this.tpVarLsv.Name = "tpVarLsv";
            this.tpVarLsv.Padding = new System.Windows.Forms.Padding(3);
            this.tpVarLsv.Size = new System.Drawing.Size(548, 383);
            this.tpVarLsv.TabIndex = 1;
            this.tpVarLsv.Text = "变量列表";
            this.tpVarLsv.UseVisualStyleBackColor = true;
            // 
            // FrmVarEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 443);
            this.Controls.Add(this.tsVarGroup);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.plEditVar);
            this.Controls.Add(this.dgvVarListData);
            this.Name = "FrmVarEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "变量编辑器";
            this.Load += new System.EventHandler(this.VarEditor_Load);
            this.cmsVar.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tsVarGroup.ResumeLayout(false);
            this.tsVarGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarListData)).EndInit();
            this.plEditVar.ResumeLayout(false);
            this.tcVar.ResumeLayout(false);
            this.tpVarStr.ResumeLayout(false);
            this.tpVarStr.PerformLayout();
            this.tpVarLsv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvAllVar;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnDeleteVar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnClearVar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstbVarName;
        private System.Windows.Forms.ToolStripSplitButton tssbtnAddVarStr;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddVarInt;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddVarList;
        private System.Windows.Forms.ToolStrip tsVarGroup;
        private System.Windows.Forms.ToolStripButton tsbtnShowAllVar;
        private System.Windows.Forms.ToolStripButton tsbtnShowStrVar;
        private System.Windows.Forms.ToolStripButton tsbtnShowIntVar;
        private System.Windows.Forms.ToolStripButton tsbtnShowListVar;
        private System.Windows.Forms.DataGridView dgvVarListData;
        private System.Windows.Forms.DataGridViewTextBoxColumn chVar;
        private System.Windows.Forms.Panel plEditVar;
        private System.Windows.Forms.Button btnSaveVar;
        private System.Windows.Forms.TextBox tbVarValue;
        private System.Windows.Forms.TextBox tbVarName;
        private System.Windows.Forms.Label lbVarValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcVar;
        private System.Windows.Forms.TabPage tpVarStr;
        private System.Windows.Forms.TabPage tpVarLsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn chId;
        private System.Windows.Forms.ContextMenuStrip cmsVar;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyVarName;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyVarValue;
        private System.Windows.Forms.ToolStripButton tsbtnShowTableVar;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddVarTable;
        private System.Windows.Forms.TextBox tbInitVarValue;
        private System.Windows.Forms.Label lbInitValue;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditVarName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiIportClipPost;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportSelectVar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiValueToInit;
        private System.Windows.Forms.ToolStripSeparator tsmiMoveLine;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveTop;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveBotton;
    }
}