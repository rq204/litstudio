using litcore.activity;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace litstudio
{
    internal class HttpRequestUI : ILitUI
    {
        private System.Windows.Forms.TextBox tbAddress;
        private ComboBox cbEncoding;
        private Label label7;
        private SelectVarName svSaveToVar;
        private Button btnTest;
        private ComboBox cbMethod;
        private SplitContainer scMain;
        private SplitContainer scDetail;
        private CheckBox cbAllowAutoRedirect;
        private NumericUpDown nudTimeOut;
        private Label label2;
        private InsertVarName ivAddress;
        private Label label3;
        private ContextMenuStrip cmsListView;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem tsmiAdd;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem tsmiDelete;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem tsmiUp;
        private TabControl tcDetail;
        private TabPage tpHeader;
        private ListView lsvHeader;
        private ColumnHeader cbHeaderKey;
        private ColumnHeader cbHeaderValue;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem tsmiImport;
        private TabPage tpBody;
        private TabControl tcBody;
        private TabPage tbNone;
        private Label label10;
        private TabPage tpUrlencode;
        private ListView lsvUrlEncode;
        private ColumnHeader chUrlencodeKey;
        private ColumnHeader chUrlencodeValue;
        private TabPage tpFormData;
        private ListView lsvFromData;
        private ColumnHeader chPostType;
        private ColumnHeader chFormDataKey;
        private ColumnHeader chFormDataValue;
        private TabPage tpRaw;
        private ComboBox cbRawType;
        private InsertVarName ivRaw;
        private TextBox tbRaw;
        private TabPage tpBinary;
        private LinkLabel llbCurrentDir;
        private InsertVarName ivBinaryPath;
        private TextBox tbBinaryFilePath;
        private Label label8;
        private TabPage tpAttachDown;
        private CheckBox cbNotAttachDownIfNot200;
        private InsertVarName ivAttachPath;
        private TextBox tbAttachPath;
        private Label label5;
        private CheckBox cbAttachDown;
        private Label label14;
        private Label label9;
        private LinkLabel llbExt;
        private LinkLabel llbOriginalName;
        private SelectVarName svSaveToFileVar;
        private LinkLabel llbCurDir;
        private TabPage tpOption;
        private SelectVarName svPostTableVar;
        private SelectVarName svHttpStatusVarName;
        private Label llbeps;
        private Label label15;
        private Label label13;
        private Label label6;
        private Label label4;
        private SelectVarName svResponseHeaderSaveToVar;
        private SelectVarName svCookieVarName;
        private TabPage tpSetting;
        private Panel pSetting;
        private Button btnCancel;
        private Button btnOK;
        private CheckBox cbIsFile;
        private LinkLabel llbValueDir;
        private InsertVarName ivValue;
        private InsertVarName ivKey;
        private TextBox tbValue;
        private TextBox tbKey;
        private Label lbepais;
        private Label label11;
        private ToolStripMenuItem tsmiConvertVar;
        private LinkLabel llbRand;
        private ToolStripMenuItem tsmiAddProxy;
        private ToolStripMenuItem tsmiToPaste;
        private ToolStripMenuItem tsmiDown;

        public HttpRequestUI()
        {
            this.InitializeComponent();
            string[] EncodingsArr = new string[] { "UTF-8", "GBK", "GB2312", "BIG5" };
            foreach (string a in EncodingsArr)
            {
                this.cbEncoding.Items.Add(a);
            }
            this.cbRawType.SelectedIndex = 0;
            this.cbEncoding.SelectedIndex = 0;
            this.ivAddress.ShowVarName(true, false, true, this.tbAddress);
            this.svSaveToVar.ShowVarName(true, false, false);
            this.svCookieVarName.ShowVarName(true, false, false);
            this.svSaveToFileVar.ShowVarName(true, false, false);
            this.svResponseHeaderSaveToVar.ShowVarName(true, false, false);
            this.ivRaw.ShowVarName(true, false, true, this.tbRaw);
            this.ivBinaryPath.ShowVarName(true, false, true, this.tbBinaryFilePath);
            this.ivKey.ShowVarName(true, false, true, this.tbKey);
            this.ivValue.ShowVarName(true, false, true, this.tbValue);
            this.ivAttachPath.ShowVarName(true, false, true, this.tbAttachPath);
            this.tpSetting.Controls.Remove(this.pSetting);
            this.tcDetail.TabPages.Remove(this.tpSetting);
            this.svHttpStatusVarName.ShowVarName(false, false, true);
            this.svPostTableVar.ShowVarName(false, false, false, true);

            base.SaveActivity = new Action(() =>
            {
                ToActivity(ha);
            });
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.cbEncoding = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.svSaveToVar = new litsdk.SelectVarName();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scDetail = new System.Windows.Forms.SplitContainer();
            this.ivAddress = new litsdk.InsertVarName();
            this.tcDetail = new System.Windows.Forms.TabControl();
            this.tpHeader = new System.Windows.Forms.TabPage();
            this.lsvHeader = new System.Windows.Forms.ListView();
            this.cbHeaderKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConvertVar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddProxy = new System.Windows.Forms.ToolStripMenuItem();
            this.tpBody = new System.Windows.Forms.TabPage();
            this.tcBody = new System.Windows.Forms.TabControl();
            this.tbNone = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.tpUrlencode = new System.Windows.Forms.TabPage();
            this.lsvUrlEncode = new System.Windows.Forms.ListView();
            this.chUrlencodeKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUrlencodeValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpFormData = new System.Windows.Forms.TabPage();
            this.lsvFromData = new System.Windows.Forms.ListView();
            this.chPostType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFormDataKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFormDataValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpRaw = new System.Windows.Forms.TabPage();
            this.cbRawType = new System.Windows.Forms.ComboBox();
            this.ivRaw = new litsdk.InsertVarName();
            this.tbRaw = new System.Windows.Forms.TextBox();
            this.tpBinary = new System.Windows.Forms.TabPage();
            this.llbCurrentDir = new System.Windows.Forms.LinkLabel();
            this.ivBinaryPath = new litsdk.InsertVarName();
            this.tbBinaryFilePath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpAttachDown = new System.Windows.Forms.TabPage();
            this.llbRand = new System.Windows.Forms.LinkLabel();
            this.cbNotAttachDownIfNot200 = new System.Windows.Forms.CheckBox();
            this.ivAttachPath = new litsdk.InsertVarName();
            this.tbAttachPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAttachDown = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.llbExt = new System.Windows.Forms.LinkLabel();
            this.llbOriginalName = new System.Windows.Forms.LinkLabel();
            this.svSaveToFileVar = new litsdk.SelectVarName();
            this.llbCurDir = new System.Windows.Forms.LinkLabel();
            this.tpOption = new System.Windows.Forms.TabPage();
            this.svPostTableVar = new litsdk.SelectVarName();
            this.svHttpStatusVarName = new litsdk.SelectVarName();
            this.llbeps = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.svResponseHeaderSaveToVar = new litsdk.SelectVarName();
            this.svCookieVarName = new litsdk.SelectVarName();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.pSetting = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbIsFile = new System.Windows.Forms.CheckBox();
            this.llbValueDir = new System.Windows.Forms.LinkLabel();
            this.ivValue = new litsdk.InsertVarName();
            this.ivKey = new litsdk.InsertVarName();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lbepais = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbAllowAutoRedirect = new System.Windows.Forms.CheckBox();
            this.nudTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDetail)).BeginInit();
            this.scDetail.Panel1.SuspendLayout();
            this.scDetail.Panel2.SuspendLayout();
            this.scDetail.SuspendLayout();
            this.tcDetail.SuspendLayout();
            this.tpHeader.SuspendLayout();
            this.cmsListView.SuspendLayout();
            this.tpBody.SuspendLayout();
            this.tcBody.SuspendLayout();
            this.tbNone.SuspendLayout();
            this.tpUrlencode.SuspendLayout();
            this.tpFormData.SuspendLayout();
            this.tpRaw.SuspendLayout();
            this.tpBinary.SuspendLayout();
            this.tpAttachDown.SuspendLayout();
            this.tpOption.SuspendLayout();
            this.tpSetting.SuspendLayout();
            this.pSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.scMain);
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(82, 3);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(409, 21);
            this.tbAddress.TabIndex = 1;
            // 
            // cbEncoding
            // 
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.Location = new System.Drawing.Point(263, 3);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(63, 20);
            this.cbEncoding.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "源码存入";
            // 
            // svSaveToVar
            // 
            this.svSaveToVar.Location = new System.Drawing.Point(59, 3);
            this.svSaveToVar.Name = "svSaveToVar";
            this.svSaveToVar.Size = new System.Drawing.Size(142, 23);
            this.svSaveToVar.TabIndex = 4;
            this.svSaveToVar.VarName = "";
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.cbMethod.Location = new System.Drawing.Point(3, 3);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(69, 20);
            this.cbMethod.TabIndex = 5;
            this.cbMethod.SelectedIndexChanged += new System.EventHandler(this.cbMethod_SelectedIndexChanged);
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(518, 1);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(60, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scDetail);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.cbAllowAutoRedirect);
            this.scMain.Panel2.Controls.Add(this.nudTimeOut);
            this.scMain.Panel2.Controls.Add(this.label2);
            this.scMain.Panel2.Controls.Add(this.svSaveToVar);
            this.scMain.Panel2.Controls.Add(this.label7);
            this.scMain.Panel2.Controls.Add(this.cbEncoding);
            this.scMain.Panel2.Controls.Add(this.label3);
            this.scMain.Size = new System.Drawing.Size(580, 238);
            this.scMain.SplitterDistance = 209;
            this.scMain.TabIndex = 7;
            // 
            // scDetail
            // 
            this.scDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDetail.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scDetail.Location = new System.Drawing.Point(0, 0);
            this.scDetail.Name = "scDetail";
            this.scDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scDetail.Panel1
            // 
            this.scDetail.Panel1.Controls.Add(this.ivAddress);
            this.scDetail.Panel1.Controls.Add(this.tbAddress);
            this.scDetail.Panel1.Controls.Add(this.cbMethod);
            this.scDetail.Panel1.Controls.Add(this.btnTest);
            // 
            // scDetail.Panel2
            // 
            this.scDetail.Panel2.Controls.Add(this.tcDetail);
            this.scDetail.Size = new System.Drawing.Size(580, 209);
            this.scDetail.SplitterDistance = 25;
            this.scDetail.TabIndex = 8;
            // 
            // ivAddress
            // 
            this.ivAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivAddress.Location = new System.Drawing.Point(494, 4);
            this.ivAddress.Name = "ivAddress";
            this.ivAddress.Size = new System.Drawing.Size(16, 16);
            this.ivAddress.TabIndex = 7;
            // 
            // tcDetail
            // 
            this.tcDetail.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcDetail.Controls.Add(this.tpHeader);
            this.tcDetail.Controls.Add(this.tpBody);
            this.tcDetail.Controls.Add(this.tpAttachDown);
            this.tcDetail.Controls.Add(this.tpOption);
            this.tcDetail.Controls.Add(this.tpSetting);
            this.tcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDetail.Location = new System.Drawing.Point(0, 0);
            this.tcDetail.Name = "tcDetail";
            this.tcDetail.SelectedIndex = 0;
            this.tcDetail.Size = new System.Drawing.Size(580, 180);
            this.tcDetail.TabIndex = 0;
            // 
            // tpHeader
            // 
            this.tpHeader.Controls.Add(this.lsvHeader);
            this.tpHeader.Location = new System.Drawing.Point(4, 25);
            this.tpHeader.Name = "tpHeader";
            this.tpHeader.Padding = new System.Windows.Forms.Padding(3);
            this.tpHeader.Size = new System.Drawing.Size(572, 151);
            this.tpHeader.TabIndex = 0;
            this.tpHeader.Text = "请求头";
            this.tpHeader.UseVisualStyleBackColor = true;
            // 
            // lsvHeader
            // 
            this.lsvHeader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cbHeaderKey,
            this.cbHeaderValue});
            this.lsvHeader.ContextMenuStrip = this.cmsListView;
            this.lsvHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvHeader.FullRowSelect = true;
            this.lsvHeader.HideSelection = false;
            this.lsvHeader.Location = new System.Drawing.Point(3, 3);
            this.lsvHeader.Name = "lsvHeader";
            this.lsvHeader.Size = new System.Drawing.Size(566, 145);
            this.lsvHeader.TabIndex = 0;
            this.lsvHeader.UseCompatibleStateImageBehavior = false;
            this.lsvHeader.View = System.Windows.Forms.View.Details;
            this.lsvHeader.DoubleClick += new System.EventHandler(this.lsv_DoubleClick);
            // 
            // cbHeaderKey
            // 
            this.cbHeaderKey.Text = "Key";
            this.cbHeaderKey.Width = 105;
            // 
            // cbHeaderValue
            // 
            this.cbHeaderValue.Text = "Value";
            this.cbHeaderValue.Width = 417;
            // 
            // cmsListView
            // 
            this.cmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiEdit,
            this.tsmiDelete,
            this.toolStripMenuItem1,
            this.tsmiUp,
            this.tsmiDown,
            this.toolStripMenuItem2,
            this.tsmiImport,
            this.tsmiConvertVar,
            this.tsmiToPaste,
            this.tsmiAddProxy});
            this.cmsListView.Name = "cmsListView";
            this.cmsListView.Size = new System.Drawing.Size(149, 214);
            this.cmsListView.Opening += new System.ComponentModel.CancelEventHandler(this.cmsListView_Opening);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(148, 22);
            this.tsmiAdd.Text = "添加";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(148, 22);
            this.tsmiEdit.Text = "编辑";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(148, 22);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmiUp
            // 
            this.tsmiUp.Name = "tsmiUp";
            this.tsmiUp.Size = new System.Drawing.Size(148, 22);
            this.tsmiUp.Text = "上移";
            this.tsmiUp.Click += new System.EventHandler(this.tsmiUp_Click);
            // 
            // tsmiDown
            // 
            this.tsmiDown.Name = "tsmiDown";
            this.tsmiDown.Size = new System.Drawing.Size(148, 22);
            this.tsmiDown.Text = "下移";
            this.tsmiDown.Click += new System.EventHandler(this.tsmiDown_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmiImport
            // 
            this.tsmiImport.Name = "tsmiImport";
            this.tsmiImport.Size = new System.Drawing.Size(148, 22);
            this.tsmiImport.Text = "剪贴板导入";
            this.tsmiImport.Click += new System.EventHandler(this.tsmiImport_Click);
            // 
            // tsmiConvertVar
            // 
            this.tsmiConvertVar.Name = "tsmiConvertVar";
            this.tsmiConvertVar.Size = new System.Drawing.Size(148, 22);
            this.tsmiConvertVar.Text = "转化为变量";
            this.tsmiConvertVar.Click += new System.EventHandler(this.tsmiConvertVar_Click);
            // 
            // tsmiToPaste
            // 
            this.tsmiToPaste.Name = "tsmiToPaste";
            this.tsmiToPaste.Size = new System.Drawing.Size(148, 22);
            this.tsmiToPaste.Text = "复制至剪贴板";
            this.tsmiToPaste.Click += new System.EventHandler(this.tsmiToPaste_Click);
            // 
            // tsmiAddProxy
            // 
            this.tsmiAddProxy.Name = "tsmiAddProxy";
            this.tsmiAddProxy.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddProxy.Text = "添加代理";
            this.tsmiAddProxy.Click += new System.EventHandler(this.tsmiAddProxy_Click);
            // 
            // tpBody
            // 
            this.tpBody.Controls.Add(this.tcBody);
            this.tpBody.Location = new System.Drawing.Point(4, 25);
            this.tpBody.Name = "tpBody";
            this.tpBody.Padding = new System.Windows.Forms.Padding(3);
            this.tpBody.Size = new System.Drawing.Size(572, 151);
            this.tpBody.TabIndex = 1;
            this.tpBody.Text = "请求体";
            this.tpBody.UseVisualStyleBackColor = true;
            // 
            // tcBody
            // 
            this.tcBody.Controls.Add(this.tbNone);
            this.tcBody.Controls.Add(this.tpUrlencode);
            this.tcBody.Controls.Add(this.tpFormData);
            this.tcBody.Controls.Add(this.tpRaw);
            this.tcBody.Controls.Add(this.tpBinary);
            this.tcBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBody.Location = new System.Drawing.Point(3, 3);
            this.tcBody.Name = "tcBody";
            this.tcBody.SelectedIndex = 0;
            this.tcBody.Size = new System.Drawing.Size(566, 145);
            this.tcBody.TabIndex = 2;
            // 
            // tbNone
            // 
            this.tbNone.Controls.Add(this.label10);
            this.tbNone.Location = new System.Drawing.Point(4, 22);
            this.tbNone.Name = "tbNone";
            this.tbNone.Padding = new System.Windows.Forms.Padding(3);
            this.tbNone.Size = new System.Drawing.Size(558, 119);
            this.tbNone.TabIndex = 5;
            this.tbNone.Text = "none";
            this.tbNone.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(228, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "当前请求不发送任何请求体";
            // 
            // tpUrlencode
            // 
            this.tpUrlencode.Controls.Add(this.lsvUrlEncode);
            this.tpUrlencode.Location = new System.Drawing.Point(4, 22);
            this.tpUrlencode.Name = "tpUrlencode";
            this.tpUrlencode.Padding = new System.Windows.Forms.Padding(3);
            this.tpUrlencode.Size = new System.Drawing.Size(558, 119);
            this.tpUrlencode.TabIndex = 0;
            this.tpUrlencode.Text = "x-www-form-urlencode";
            this.tpUrlencode.UseVisualStyleBackColor = true;
            // 
            // lsvUrlEncode
            // 
            this.lsvUrlEncode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUrlencodeKey,
            this.chUrlencodeValue});
            this.lsvUrlEncode.ContextMenuStrip = this.cmsListView;
            this.lsvUrlEncode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvUrlEncode.FullRowSelect = true;
            this.lsvUrlEncode.HideSelection = false;
            this.lsvUrlEncode.Location = new System.Drawing.Point(3, 3);
            this.lsvUrlEncode.Name = "lsvUrlEncode";
            this.lsvUrlEncode.Size = new System.Drawing.Size(552, 113);
            this.lsvUrlEncode.TabIndex = 1;
            this.lsvUrlEncode.UseCompatibleStateImageBehavior = false;
            this.lsvUrlEncode.View = System.Windows.Forms.View.Details;
            this.lsvUrlEncode.DoubleClick += new System.EventHandler(this.lsv_DoubleClick);
            // 
            // chUrlencodeKey
            // 
            this.chUrlencodeKey.Text = "Key";
            this.chUrlencodeKey.Width = 101;
            // 
            // chUrlencodeValue
            // 
            this.chUrlencodeValue.Text = "Value";
            this.chUrlencodeValue.Width = 405;
            // 
            // tpFormData
            // 
            this.tpFormData.Controls.Add(this.lsvFromData);
            this.tpFormData.Location = new System.Drawing.Point(4, 22);
            this.tpFormData.Name = "tpFormData";
            this.tpFormData.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormData.Size = new System.Drawing.Size(558, 119);
            this.tpFormData.TabIndex = 1;
            this.tpFormData.Text = "form-data";
            this.tpFormData.UseVisualStyleBackColor = true;
            // 
            // lsvFromData
            // 
            this.lsvFromData.CheckBoxes = true;
            this.lsvFromData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPostType,
            this.chFormDataKey,
            this.chFormDataValue});
            this.lsvFromData.ContextMenuStrip = this.cmsListView;
            this.lsvFromData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvFromData.FullRowSelect = true;
            this.lsvFromData.HideSelection = false;
            this.lsvFromData.Location = new System.Drawing.Point(3, 3);
            this.lsvFromData.Name = "lsvFromData";
            this.lsvFromData.Size = new System.Drawing.Size(552, 113);
            this.lsvFromData.TabIndex = 2;
            this.lsvFromData.UseCompatibleStateImageBehavior = false;
            this.lsvFromData.View = System.Windows.Forms.View.Details;
            this.lsvFromData.DoubleClick += new System.EventHandler(this.lsv_DoubleClick);
            this.lsvFromData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lsvFromData_MouseDown);
            // 
            // chPostType
            // 
            this.chPostType.Text = "File";
            this.chPostType.Width = 52;
            // 
            // chFormDataKey
            // 
            this.chFormDataKey.Text = "Key";
            this.chFormDataKey.Width = 95;
            // 
            // chFormDataValue
            // 
            this.chFormDataValue.Text = "Value";
            this.chFormDataValue.Width = 391;
            // 
            // tpRaw
            // 
            this.tpRaw.Controls.Add(this.cbRawType);
            this.tpRaw.Controls.Add(this.ivRaw);
            this.tpRaw.Controls.Add(this.tbRaw);
            this.tpRaw.Location = new System.Drawing.Point(4, 22);
            this.tpRaw.Name = "tpRaw";
            this.tpRaw.Size = new System.Drawing.Size(558, 119);
            this.tpRaw.TabIndex = 2;
            this.tpRaw.Text = "raw";
            this.tpRaw.UseVisualStyleBackColor = true;
            // 
            // cbRawType
            // 
            this.cbRawType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRawType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRawType.FormattingEnabled = true;
            this.cbRawType.Items.AddRange(new object[] {
            "Text",
            "JavaScript",
            "JSON",
            "HTML",
            "XML",
            "X-WWW-FORM-URLENCODE"});
            this.cbRawType.Location = new System.Drawing.Point(485, 5);
            this.cbRawType.Name = "cbRawType";
            this.cbRawType.Size = new System.Drawing.Size(70, 20);
            this.cbRawType.TabIndex = 4;
            // 
            // ivRaw
            // 
            this.ivRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ivRaw.Location = new System.Drawing.Point(488, 95);
            this.ivRaw.Name = "ivRaw";
            this.ivRaw.Size = new System.Drawing.Size(16, 16);
            this.ivRaw.TabIndex = 3;
            // 
            // tbRaw
            // 
            this.tbRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRaw.Location = new System.Drawing.Point(3, 3);
            this.tbRaw.MaxLength = 327670;
            this.tbRaw.Multiline = true;
            this.tbRaw.Name = "tbRaw";
            this.tbRaw.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbRaw.Size = new System.Drawing.Size(477, 113);
            this.tbRaw.TabIndex = 2;
            // 
            // tpBinary
            // 
            this.tpBinary.Controls.Add(this.llbCurrentDir);
            this.tpBinary.Controls.Add(this.ivBinaryPath);
            this.tpBinary.Controls.Add(this.tbBinaryFilePath);
            this.tpBinary.Controls.Add(this.label8);
            this.tpBinary.Location = new System.Drawing.Point(4, 22);
            this.tpBinary.Name = "tpBinary";
            this.tpBinary.Size = new System.Drawing.Size(558, 119);
            this.tpBinary.TabIndex = 4;
            this.tpBinary.Text = "binary";
            this.tpBinary.UseVisualStyleBackColor = true;
            // 
            // llbCurrentDir
            // 
            this.llbCurrentDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbCurrentDir.AutoSize = true;
            this.llbCurrentDir.Location = new System.Drawing.Point(461, 19);
            this.llbCurrentDir.Name = "llbCurrentDir";
            this.llbCurrentDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurrentDir.TabIndex = 7;
            this.llbCurrentDir.TabStop = true;
            this.llbCurrentDir.Text = "[当前目录]";
            this.llbCurrentDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurrentDir_LinkClicked);
            // 
            // ivBinaryPath
            // 
            this.ivBinaryPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivBinaryPath.Location = new System.Drawing.Point(437, 16);
            this.ivBinaryPath.Name = "ivBinaryPath";
            this.ivBinaryPath.Size = new System.Drawing.Size(20, 23);
            this.ivBinaryPath.TabIndex = 6;
            // 
            // tbBinaryFilePath
            // 
            this.tbBinaryFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBinaryFilePath.Location = new System.Drawing.Point(72, 16);
            this.tbBinaryFilePath.Name = "tbBinaryFilePath";
            this.tbBinaryFilePath.Size = new System.Drawing.Size(354, 21);
            this.tbBinaryFilePath.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "文件地址";
            // 
            // tpAttachDown
            // 
            this.tpAttachDown.Controls.Add(this.llbRand);
            this.tpAttachDown.Controls.Add(this.cbNotAttachDownIfNot200);
            this.tpAttachDown.Controls.Add(this.ivAttachPath);
            this.tpAttachDown.Controls.Add(this.tbAttachPath);
            this.tpAttachDown.Controls.Add(this.label5);
            this.tpAttachDown.Controls.Add(this.cbAttachDown);
            this.tpAttachDown.Controls.Add(this.label14);
            this.tpAttachDown.Controls.Add(this.label9);
            this.tpAttachDown.Controls.Add(this.llbExt);
            this.tpAttachDown.Controls.Add(this.llbOriginalName);
            this.tpAttachDown.Controls.Add(this.svSaveToFileVar);
            this.tpAttachDown.Controls.Add(this.llbCurDir);
            this.tpAttachDown.Location = new System.Drawing.Point(4, 25);
            this.tpAttachDown.Name = "tpAttachDown";
            this.tpAttachDown.Padding = new System.Windows.Forms.Padding(3);
            this.tpAttachDown.Size = new System.Drawing.Size(572, 151);
            this.tpAttachDown.TabIndex = 4;
            this.tpAttachDown.Text = "文件下载";
            this.tpAttachDown.UseVisualStyleBackColor = true;
            // 
            // llbRand
            // 
            this.llbRand.AutoSize = true;
            this.llbRand.Location = new System.Drawing.Point(487, 68);
            this.llbRand.Name = "llbRand";
            this.llbRand.Size = new System.Drawing.Size(77, 12);
            this.llbRand.TabIndex = 21;
            this.llbRand.TabStop = true;
            this.llbRand.Text = "[随机文件名]";
            this.llbRand.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRand_LinkClicked);
            // 
            // cbNotAttachDownIfNot200
            // 
            this.cbNotAttachDownIfNot200.AutoSize = true;
            this.cbNotAttachDownIfNot200.Location = new System.Drawing.Point(205, 87);
            this.cbNotAttachDownIfNot200.Name = "cbNotAttachDownIfNot200";
            this.cbNotAttachDownIfNot200.Size = new System.Drawing.Size(174, 16);
            this.cbNotAttachDownIfNot200.TabIndex = 19;
            this.cbNotAttachDownIfNot200.Text = "Http状态码非200不下载文件";
            this.cbNotAttachDownIfNot200.UseVisualStyleBackColor = true;
            // 
            // ivAttachPath
            // 
            this.ivAttachPath.Location = new System.Drawing.Point(394, 52);
            this.ivAttachPath.Name = "ivAttachPath";
            this.ivAttachPath.Size = new System.Drawing.Size(16, 16);
            this.ivAttachPath.TabIndex = 18;
            // 
            // tbAttachPath
            // 
            this.tbAttachPath.Location = new System.Drawing.Point(72, 50);
            this.tbAttachPath.Name = "tbAttachPath";
            this.tbAttachPath.Size = new System.Drawing.Size(316, 21);
            this.tbAttachPath.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "地址存入";
            // 
            // cbAttachDown
            // 
            this.cbAttachDown.AutoSize = true;
            this.cbAttachDown.Location = new System.Drawing.Point(72, 18);
            this.cbAttachDown.Name = "cbAttachDown";
            this.cbAttachDown.Size = new System.Drawing.Size(324, 16);
            this.cbAttachDown.TabIndex = 17;
            this.cbAttachDown.Text = "返回内容以二进制方式存入本地文件，忽略源码存入变量";
            this.cbAttachDown.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "启用下载";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "保存地址";
            // 
            // llbExt
            // 
            this.llbExt.AutoSize = true;
            this.llbExt.Location = new System.Drawing.Point(417, 68);
            this.llbExt.Name = "llbExt";
            this.llbExt.Size = new System.Drawing.Size(65, 12);
            this.llbExt.TabIndex = 14;
            this.llbExt.TabStop = true;
            this.llbExt.Text = "[原扩展名]";
            this.llbExt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbExt_LinkClicked);
            // 
            // llbOriginalName
            // 
            this.llbOriginalName.AutoSize = true;
            this.llbOriginalName.Location = new System.Drawing.Point(487, 39);
            this.llbOriginalName.Name = "llbOriginalName";
            this.llbOriginalName.Size = new System.Drawing.Size(77, 12);
            this.llbOriginalName.TabIndex = 14;
            this.llbOriginalName.TabStop = true;
            this.llbOriginalName.Text = "[原文件全名]";
            this.llbOriginalName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOriginalName_LinkClicked);
            // 
            // svSaveToFileVar
            // 
            this.svSaveToFileVar.Location = new System.Drawing.Point(72, 84);
            this.svSaveToFileVar.Name = "svSaveToFileVar";
            this.svSaveToFileVar.Size = new System.Drawing.Size(118, 23);
            this.svSaveToFileVar.TabIndex = 15;
            this.svSaveToFileVar.VarName = "";
            // 
            // llbCurDir
            // 
            this.llbCurDir.AutoSize = true;
            this.llbCurDir.Location = new System.Drawing.Point(417, 39);
            this.llbCurDir.Name = "llbCurDir";
            this.llbCurDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurDir.TabIndex = 14;
            this.llbCurDir.TabStop = true;
            this.llbCurDir.Text = "[当前目录]";
            this.llbCurDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurDir_LinkClicked);
            // 
            // tpOption
            // 
            this.tpOption.Controls.Add(this.svPostTableVar);
            this.tpOption.Controls.Add(this.svHttpStatusVarName);
            this.tpOption.Controls.Add(this.llbeps);
            this.tpOption.Controls.Add(this.label15);
            this.tpOption.Controls.Add(this.label13);
            this.tpOption.Controls.Add(this.label6);
            this.tpOption.Controls.Add(this.label4);
            this.tpOption.Controls.Add(this.svResponseHeaderSaveToVar);
            this.tpOption.Controls.Add(this.svCookieVarName);
            this.tpOption.Location = new System.Drawing.Point(4, 25);
            this.tpOption.Name = "tpOption";
            this.tpOption.Padding = new System.Windows.Forms.Padding(3);
            this.tpOption.Size = new System.Drawing.Size(572, 151);
            this.tpOption.TabIndex = 2;
            this.tpOption.Text = "其它";
            this.tpOption.UseVisualStyleBackColor = true;
            // 
            // svPostTableVar
            // 
            this.svPostTableVar.Location = new System.Drawing.Point(360, 48);
            this.svPostTableVar.Name = "svPostTableVar";
            this.svPostTableVar.Size = new System.Drawing.Size(113, 23);
            this.svPostTableVar.TabIndex = 14;
            this.svPostTableVar.VarName = "";
            // 
            // svHttpStatusVarName
            // 
            this.svHttpStatusVarName.Location = new System.Drawing.Point(360, 18);
            this.svHttpStatusVarName.Name = "svHttpStatusVarName";
            this.svHttpStatusVarName.Size = new System.Drawing.Size(113, 23);
            this.svHttpStatusVarName.TabIndex = 13;
            this.svHttpStatusVarName.VarName = "";
            // 
            // label16
            // 
            this.llbeps.AutoSize = true;
            this.llbeps.Location = new System.Drawing.Point(253, 52);
            this.llbeps.Name = "label16";
            this.llbeps.Size = new System.Drawing.Size(101, 12);
            this.llbeps.TabIndex = 11;
            this.llbeps.Text = "POST使用表单表格";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(265, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 11;
            this.label15.Text = "Http状态码存入";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "返回头存入";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(25, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(542, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "可以将返回头信息作为字任串存入变量，Cookie是将请求和返回合并后存入变量。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "COOKIE保存";
            // 
            // svResponseHeaderSaveToVar
            // 
            this.svResponseHeaderSaveToVar.Location = new System.Drawing.Point(97, 47);
            this.svResponseHeaderSaveToVar.Name = "svResponseHeaderSaveToVar";
            this.svResponseHeaderSaveToVar.Size = new System.Drawing.Size(119, 23);
            this.svResponseHeaderSaveToVar.TabIndex = 10;
            this.svResponseHeaderSaveToVar.VarName = "";
            // 
            // svCookieVarName
            // 
            this.svCookieVarName.Location = new System.Drawing.Point(97, 18);
            this.svCookieVarName.Name = "svCookieVarName";
            this.svCookieVarName.Size = new System.Drawing.Size(119, 23);
            this.svCookieVarName.TabIndex = 10;
            this.svCookieVarName.VarName = "";
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.pSetting);
            this.tpSetting.Location = new System.Drawing.Point(4, 25);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpSetting.Size = new System.Drawing.Size(572, 151);
            this.tpSetting.TabIndex = 3;
            this.tpSetting.Text = "Setting";
            this.tpSetting.UseVisualStyleBackColor = true;
            // 
            // pSetting
            // 
            this.pSetting.Controls.Add(this.btnCancel);
            this.pSetting.Controls.Add(this.btnOK);
            this.pSetting.Controls.Add(this.cbIsFile);
            this.pSetting.Controls.Add(this.llbValueDir);
            this.pSetting.Controls.Add(this.ivValue);
            this.pSetting.Controls.Add(this.ivKey);
            this.pSetting.Controls.Add(this.tbValue);
            this.pSetting.Controls.Add(this.tbKey);
            this.pSetting.Controls.Add(this.lbepais);
            this.pSetting.Controls.Add(this.label11);
            this.pSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSetting.Location = new System.Drawing.Point(3, 3);
            this.pSetting.Name = "pSetting";
            this.pSetting.Size = new System.Drawing.Size(566, 145);
            this.pSetting.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(495, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(413, 108);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbIsFile
            // 
            this.cbIsFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIsFile.AutoSize = true;
            this.cbIsFile.Location = new System.Drawing.Point(434, 13);
            this.cbIsFile.Name = "cbIsFile";
            this.cbIsFile.Size = new System.Drawing.Size(96, 16);
            this.cbIsFile.TabIndex = 9;
            this.cbIsFile.Text = "该表单是文件";
            this.cbIsFile.UseVisualStyleBackColor = true;
            // 
            // llbValueDir
            // 
            this.llbValueDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbValueDir.AutoSize = true;
            this.llbValueDir.Location = new System.Drawing.Point(432, 49);
            this.llbValueDir.Name = "llbValueDir";
            this.llbValueDir.Size = new System.Drawing.Size(65, 12);
            this.llbValueDir.TabIndex = 8;
            this.llbValueDir.TabStop = true;
            this.llbValueDir.Text = "[当前目录]";
            this.llbValueDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbValueDir_LinkClicked);
            // 
            // ivValue
            // 
            this.ivValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivValue.Location = new System.Drawing.Point(404, 49);
            this.ivValue.Name = "ivValue";
            this.ivValue.Size = new System.Drawing.Size(16, 16);
            this.ivValue.TabIndex = 2;
            // 
            // ivKey
            // 
            this.ivKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivKey.Location = new System.Drawing.Point(404, 13);
            this.ivKey.Name = "ivKey";
            this.ivKey.Size = new System.Drawing.Size(16, 16);
            this.ivKey.TabIndex = 2;
            // 
            // tbValue
            // 
            this.tbValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValue.Location = new System.Drawing.Point(50, 45);
            this.tbValue.Multiline = true;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(347, 89);
            this.tbValue.TabIndex = 1;
            // 
            // tbKey
            // 
            this.tbKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKey.Location = new System.Drawing.Point(50, 11);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(347, 21);
            this.tbKey.TabIndex = 1;
            // 
            // label12
            // 
            this.lbepais.AutoSize = true;
            this.lbepais.Location = new System.Drawing.Point(9, 49);
            this.lbepais.Name = "label12";
            this.lbepais.Size = new System.Drawing.Size(35, 12);
            this.lbepais.TabIndex = 0;
            this.lbepais.Text = "Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Key";
            // 
            // cbAllowAutoRedirect
            // 
            this.cbAllowAutoRedirect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAllowAutoRedirect.AutoSize = true;
            this.cbAllowAutoRedirect.Location = new System.Drawing.Point(499, 5);
            this.cbAllowAutoRedirect.Name = "cbAllowAutoRedirect";
            this.cbAllowAutoRedirect.Size = new System.Drawing.Size(72, 16);
            this.cbAllowAutoRedirect.TabIndex = 3;
            this.cbAllowAutoRedirect.Text = "自动跳转";
            this.cbAllowAutoRedirect.UseVisualStyleBackColor = true;
            // 
            // nudTimeOut
            // 
            this.nudTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTimeOut.Location = new System.Drawing.Point(432, 3);
            this.nudTimeOut.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudTimeOut.Name = "nudTimeOut";
            this.nudTimeOut.Size = new System.Drawing.Size(50, 21);
            this.nudTimeOut.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "请求超时(秒)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "网页编码";
            // 
            // HttpRequestUI
            // 
            this.Name = "HttpRequestUI";
            this.Controls.SetChildIndex(this.scActivityUI, 0);
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scDetail.Panel1.ResumeLayout(false);
            this.scDetail.Panel1.PerformLayout();
            this.scDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDetail)).EndInit();
            this.scDetail.ResumeLayout(false);
            this.tcDetail.ResumeLayout(false);
            this.tpHeader.ResumeLayout(false);
            this.cmsListView.ResumeLayout(false);
            this.tpBody.ResumeLayout(false);
            this.tcBody.ResumeLayout(false);
            this.tbNone.ResumeLayout(false);
            this.tbNone.PerformLayout();
            this.tpUrlencode.ResumeLayout(false);
            this.tpFormData.ResumeLayout(false);
            this.tpRaw.ResumeLayout(false);
            this.tpRaw.PerformLayout();
            this.tpBinary.ResumeLayout(false);
            this.tpBinary.PerformLayout();
            this.tpAttachDown.ResumeLayout(false);
            this.tpAttachDown.PerformLayout();
            this.tpOption.ResumeLayout(false);
            this.tpOption.PerformLayout();
            this.tpSetting.ResumeLayout(false);
            this.pSetting.ResumeLayout(false);
            this.pSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOut)).EndInit();
            this.ResumeLayout(false);

        }

        public override void SetActivity(Activity activity)
        {
            ha = activity as HttpRequestActivity;
            this.tbAddress.Text = ha.Address;
            this.cbEncoding.Text = ha.Encoding;
            this.cbMethod.Text = ha.Method;
            this.cbAllowAutoRedirect.Checked = ha.AllowAutoRedirect;
            this.nudTimeOut.Value = ha.TimeOutSecond;
            this.svSaveToVar.VarName = ha.SaveToVarName;
            this.tbActivityName.Text = ha.Name;
            this.svCookieVarName.VarName = ha.CookieVarName;
            this.svPostTableVar.VarName = ha.PostTableVar;

            foreach (KeyValuePair<string, string> kv in ha.RequestHeaders)
            {
                ListViewItem lvi = new ListViewItem() { Text = kv.Key };
                lvi.SubItems.Add(kv.Value);
                this.lsvHeader.Items.Add(lvi);
            }

            foreach (KeyValuePair<string, string> kv in ha.FormUrlEncodes)
            {
                ListViewItem lvi = new ListViewItem() { Text = kv.Key };
                lvi.SubItems.Add(kv.Value);
                this.lsvUrlEncode.Items.Add(lvi);
            }

            foreach (KeyValuePair<string, string> kv in ha.FormDatas)
            {
                ListViewItem lvi = new ListViewItem() { };
                lvi.SubItems.Add(kv.Key);
                lvi.SubItems.Add(kv.Value);
                if (ha.FormFileKeys.Contains(kv.Key)) lvi.Checked = true;
                this.lsvFromData.Items.Add(lvi);
            }

            this.tbRaw.Text = ha.RawContent;
            this.cbRawType.Text = ha.RawType;
            this.tbBinaryFilePath.Text = ha.BinaryFilePath;

            this.svResponseHeaderSaveToVar.VarName = ha.ResponseHeaderSaveToVar;
            this.svCookieVarName.VarName = ha.CookieVarName;
            this.svSaveToFileVar.VarName = ha.SaveToFileVar;
            this.cbAttachDown.Checked = ha.AttachDown;
            this.tcBody.SelectedIndex = (int)ha.BodyType;

            this.tbAttachPath.Text = ha.AttachPath;
            this.svHttpStatusVarName.VarName = ha.HttpStatusVarName;
            this.cbNotAttachDownIfNot200.Checked = ha.NotAttachDownIfNot200;
        }

        HttpRequestActivity ha = null;

        private void ToActivity(HttpRequestActivity haa)
        {
            haa.Address = this.tbAddress.Text;
            haa.Encoding = this.cbEncoding.Text.Trim();
            haa.SaveToVarName = this.svSaveToVar.VarName;
            haa.Method = this.cbMethod.Text;
            haa.TimeOutSecond = (int)this.nudTimeOut.Value;
            haa.AllowAutoRedirect = this.cbAllowAutoRedirect.Checked;
            haa.AttachDown = this.cbAttachDown.Checked;
            haa.Name = base.tbActivityName.Text;

            haa.RequestHeaders.Clear();
            foreach (ListViewItem lvi in this.lsvHeader.Items)
            {
                haa.RequestHeaders.Add(new KeyValuePair<string, string>(lvi.Text, lvi.SubItems[1].Text));
            }

            haa.FormUrlEncodes.Clear();
            foreach (ListViewItem lvi in this.lsvUrlEncode.Items)
            {
                haa.FormUrlEncodes.Add(new KeyValuePair<string, string>(lvi.Text, lvi.SubItems[1].Text));
            }

            haa.FormDatas.Clear();
            haa.FormFileKeys.Clear();
            foreach (ListViewItem lvi in this.lsvFromData.Items)
            {
                haa.FormDatas.Add(new KeyValuePair<string, string>(lvi.SubItems[1].Text, lvi.SubItems[2].Text));
                if (lvi.Checked) haa.FormFileKeys.Add(lvi.SubItems[1].Text);
            }

            haa.RawContent = this.tbRaw.Text;
            haa.RawType = this.cbRawType.Text;
            haa.BinaryFilePath = this.tbBinaryFilePath.Text;

            haa.ResponseHeaderSaveToVar = this.svResponseHeaderSaveToVar.VarName;
            haa.CookieVarName = this.svCookieVarName.VarName;
            haa.SaveToFileVar = this.svSaveToFileVar.VarName;

            haa.BodyType = (litcore.type.BodyType)this.tcBody.SelectedIndex;
            haa.AttachPath = this.tbAttachPath.Text.Trim();
            haa.HttpStatusVarName = this.svHttpStatusVarName.VarName;
            haa.NotAttachDownIfNot200 = this.cbNotAttachDownIfNot200.Checked;
            haa.PostTableVar = this.svPostTableVar.VarName;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            HttpRequestActivity http = new HttpRequestActivity();
            ToActivity(http);
            http.SaveToVarName = "html" + Guid.NewGuid().ToString();
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            litsdk.Variable htmlvar = new litsdk.Variable() { Name = http.SaveToVarName, StrValue = "" };
            context.Variables.Add(htmlvar);
            this.btnTest.Enabled = false;
            new System.Threading.Thread(() =>
            {
                try
                {
                    http.Validate(context);
                    http.Execute(context);
                    string data = context.GetStr(http.SaveToVarName);
                    string testlog = AppDomain.CurrentDomain.BaseDirectory + "temp.txt";
                    System.IO.File.WriteAllText(testlog, data, System.Text.Encoding.UTF8);
                    System.Diagnostics.Process.Start(testlog);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "测试出错");
                }
                finally
                {
                    context.Variables.Remove(htmlvar);
                    try
                    {
                        this.Invoke((EventHandler)delegate
                        {
                            this.btnTest.Enabled = true;
                        });
                    }
                    catch { }
                }
            }).Start();
        }

        private void cbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.tbPostData.Enabled = this.cbMethod.SelectedIndex == 1;
        }

        private void cmsListView_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.cmsListView.Tag = this.cmsListView.SourceControl;
            ListView lsv = this.cmsListView.SourceControl as ListView;

            this.tsmiEdit.Enabled = lsv.SelectedItems.Count == 1;
            this.tsmiUp.Enabled = lsv.Items.Count > 0 && lsv.SelectedItems.Count == 1 && lsv.Items.IndexOf(lsv.SelectedItems[0]) > 0;
            this.tsmiDown.Enabled = lsv.Items.Count > 0 && lsv.SelectedItems.Count == 1 && lsv.Items.IndexOf(lsv.SelectedItems[0]) < lsv.Items.Count - 1;
            this.tsmiDelete.Enabled = this.tsmiConvertVar.Enabled = lsv.SelectedItems.Count > 0;

            this.tsmiAddProxy.Visible = lsv.Equals(lsvHeader);

            this.tsmiToPaste.Visible = lsv.SelectedItems.Count > 0 && ((this.tcDetail.SelectedTab == tpBody && this.tcBody.SelectedTab == this.tpUrlencode) || this.tcDetail.SelectedTab == this.tpHeader);
        }

        private void llbCurrentDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbBinaryFilePath, this.llbCurrentDir.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ListView lsv = this.cmsListView.Tag as ListView;
            this.AddKV(lsv);
            this.pSetting.Parent.Controls.Remove(this.pSetting);
        }

        private void AddKV(ListView lsv)
        {
            string key = this.tbKey.Text.Trim();
            string value = this.tbValue.Text;
            ListViewItem lfind = null;
            foreach (ListViewItem lvi in lsv.Items)
            {
                if (lsv.Columns.Count == 3)
                {
                    if (lvi.SubItems[1].Text.Equals(key, StringComparison.OrdinalIgnoreCase))
                    {
                        lvi.SubItems[2].Text = value;
                        lvi.Checked = this.cbIsFile.Checked;
                        lfind = lvi;
                        break;
                    }
                }
                else if (lvi.Text.Equals(key, StringComparison.OrdinalIgnoreCase))
                {
                    lvi.SubItems[1].Text = value;
                    lvi.Checked = this.cbIsFile.Checked;
                    lfind = lvi;
                    break;
                }
            }
            if (lfind == null)
            {
                lfind = new ListViewItem();
                if (lsv.Columns.Count == 3)
                {
                    lfind.Checked = this.cbIsFile.Checked;
                    lfind.SubItems.Add(key);
                    lfind.SubItems.Add(value);
                }
                else
                {
                    lfind.Text = key;
                    lfind.SubItems.Add(value);
                }
                lsv.Items.Add(lfind);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.pSetting.Parent.Controls.Remove(this.pSetting);
        }

        private void llbValueDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbValue, this.llbValueDir.Text);
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            ListView lsv = this.cmsListView.Tag as ListView;
            this.tbKey.Clear();
            this.tbValue.Clear();
            this.cbIsFile.Visible = lsv.Columns.Count == 3;
            this.cbIsFile.Checked = false;
            this.scDetail.Panel2.Controls.Add(pSetting);
            pSetting.BringToFront();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            ListView lsv = this.cmsListView.Tag as ListView;
            if (lsv.Columns.Count == 3)
            {
                this.tbKey.Text = lsv.SelectedItems[0].SubItems[1].Text;
                this.tbValue.Text = lsv.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                this.tbKey.Text = lsv.SelectedItems[0].Text;
                this.tbValue.Text = lsv.SelectedItems[0].SubItems[1].Text;
            }
            this.cbIsFile.Visible = lsv.Columns.Count == 3;
            this.cbIsFile.Checked = lsv.Columns.Count == 3 && lsv.SelectedItems[0].Checked;
            this.scDetail.Panel2.Controls.Add(pSetting);
            pSetting.BringToFront();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            ListView lsv = this.cmsListView.Tag as ListView;
            List<ListViewItem> lvis = new List<ListViewItem>();
            foreach (ListViewItem lvi in lsv.SelectedItems) lvis.Add(lvi);
            foreach (ListViewItem lvi in lvis) lvi.Remove();
        }

        private void tsmiUp_Click(object sender, EventArgs e)
        {
            ListView lsv = this.cmsListView.Tag as ListView;
            ListViewItem lvi = lsv.SelectedItems[0];
            int pos = lsv.Items.IndexOf(lvi);
            lvi.Remove();
            lsv.Items.Insert(pos - 1, lvi);
        }

        private void tsmiDown_Click(object sender, EventArgs e)
        {
            ListView lsv = this.cmsListView.Tag as ListView;
            ListViewItem lvi = lsv.SelectedItems[0];
            int pos = lsv.Items.IndexOf(lvi);
            lvi.Remove();
            lsv.Items.Insert(pos + 1, lvi);
        }

        private void lsv_DoubleClick(object sender, EventArgs e)
        {
            this.cmsListView.Tag = sender;
            tsmiEdit_Click(null, null);
        }

        private void llbCurDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbAttachPath, this.llbCurDir.Text);
        }

        private void llbOriginalName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbAttachPath, this.llbOriginalName.Text);
        }

        private void llbExt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbAttachPath, this.llbExt.Text);
        }

        private void tsmiImport_Click(object sender, EventArgs e)
        {
            string txt = Clipboard.GetText();
            try
            {
                HttpRequestActivity http = new HttpRequestActivity();
                ToActivity(http);

                if (txt == "") throw new Exception("剪贴板为空");
                List<string> names = new List<string>();

                if (this.tcDetail.SelectedTab == this.tpHeader)
                {
                    foreach (KeyValuePair<string, string> kv in http.RequestHeaders) names.Add(kv.Key);

                    List<string> lines = txt.Replace("\r", "").Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries)[0].Split('\n').ToList();
                    foreach (string l in lines)
                    {
                        if (l.EndsWith("HTTP/1.1") || l.EndsWith("HTTP/1.0") || l.EndsWith("HTTP/1.2"))
                        {
                            string[] marr = l.Split(' ');
                            if (marr.Length == 3)
                            {
                                if (this.cbMethod.Items.Contains(marr[0])) this.cbMethod.Text = marr[0];
                                this.tbAddress.Text = marr[1];
                            }
                            continue;
                        }
                        string[] kvv = l.Split(':');
                        if (kvv.Length >= 2)
                        {
                            string kvname = kvv[0].Trim();
                            if (kvname.Equals("Host", StringComparison.OrdinalIgnoreCase)) continue;
                            if (kvname.Equals("Content-Length", StringComparison.OrdinalIgnoreCase)) continue;
                            if (kvname.Equals("Content-Type", StringComparison.OrdinalIgnoreCase)) continue;

                            if (names.Contains(kvname, StringComparer.OrdinalIgnoreCase)) continue;
                            List<string> lss = new List<string>();
                            for (int i = 1; i < kvv.Length; i++) lss.Add(kvv[i]);
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = kvname;
                            lvi.SubItems.Add(string.Join(":", lss.ToArray()).TrimStart());// kvv[1].Trim());// ;
                            this.lsvHeader.Items.Add(lvi);
                            names.Add(kvname);
                        }
                    }
                }
                else if (this.tcDetail.SelectedTab == this.tpBody)
                {
                    if (this.tcBody.SelectedTab == this.tpUrlencode)
                    {
                        foreach (KeyValuePair<string, string> kv in http.FormUrlEncodes) names.Add(kv.Key);
                        if (txt.StartsWith("{") && txt.EndsWith("}"))
                        {
                            Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(txt);
                            foreach (Newtonsoft.Json.Linq.JProperty token in jObject.Properties())
                            {
                                string tkname = token.Name.Trim();
                                if (names.Contains(tkname, StringComparer.OrdinalIgnoreCase)) continue;
                                ListViewItem lvi = new ListViewItem(tkname);
                                lvi.SubItems.Add(token.Value.ToString().Trim());
                                this.lsvUrlEncode.Items.Add(lvi);
                                names.Add(tkname);
                            }
                        }
                        else
                        {
                            List<string> ls = txt.Split('&').ToList();
                            foreach (string s in ls)
                            {
                                int pos = s.IndexOf("=");
                                if (pos > 0)
                                {
                                    string name = s.Substring(0, pos).Trim();
                                    string value = s.Substring(pos + 1, s.Length - 1 - pos);
                                    System.Text.Encoding ed = System.Text.Encoding.UTF8;
                                    if (!string.IsNullOrEmpty(http.Encoding)) ed = System.Text.Encoding.GetEncoding(http.Encoding);
                                    value = System.Web.HttpUtility.UrlDecode(value, ed);
                                    name = System.Web.HttpUtility.UrlDecode(name, ed);
                                    if (names.Contains(name, StringComparer.OrdinalIgnoreCase)) continue;
                                    ListViewItem lvi = new ListViewItem(name);
                                    lvi.SubItems.Add(value.Trim());
                                    this.lsvUrlEncode.Items.Add(lvi);
                                    names.Add(name);
                                }
                            }
                        }
                    }
                    else if (this.tcBody.SelectedTab == this.tpFormData)
                    {
                        foreach (KeyValuePair<string, string> kv in http.FormDatas) names.Add(kv.Key);
                        if (txt.StartsWith("{") && txt.EndsWith("}"))
                        {
                            Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(txt);
                            foreach (Newtonsoft.Json.Linq.JProperty token in jObject.Properties())
                            {
                                string tname = token.Name.Trim();
                                if (names.Contains(tname, StringComparer.OrdinalIgnoreCase)) continue;
                                ListViewItem lvi = new ListViewItem();
                                lvi.Checked = false;
                                lvi.SubItems.Add(tname);
                                lvi.SubItems.Add(token.Value.ToString().Trim());
                                this.lsvFromData.Items.Add(lvi);
                                names.Add(tname);
                            }
                        }
                        else
                        {
                            System.Text.RegularExpressions.MatchCollection mc = System.Text.RegularExpressions.Regex.Matches(txt, "form-data;\\s+name=\"(\\w+?)\"\\s?(; filename=\".*?\"\\r?\\n)?(Content-Type: .*?\\r?\\n)?(\\r?\\n[\\s\\S]*?\\r?\\n)\\-\\-\\-\\-");//form-data; name="file"; filename="chrome.png"
                            foreach (System.Text.RegularExpressions.Match m in mc)
                            {
                                try
                                {
                                    bool ifile = m.Groups[0].Value.Contains("filename=");
                                    string name = m.Groups[1].Value.Trim();
                                    if (name == "") continue;
                                    string value = ifile ? m.Groups[2].Value.Trim().Replace("\"", "").Trim(';').Replace("filename=", "").Trim() : m.Groups[4].Value.Trim();

                                    System.Text.Encoding ed = System.Text.Encoding.UTF8;
                                    if (!string.IsNullOrEmpty(http.Encoding)) ed = System.Text.Encoding.GetEncoding(http.Encoding);
                                    value = System.Web.HttpUtility.UrlDecode(value, ed);
                                    if (names.Contains(name, StringComparer.OrdinalIgnoreCase)) continue;
                                    ListViewItem lvi = new ListViewItem();
                                    lvi.Checked = ifile;
                                    lvi.SubItems.Add(name);
                                    lvi.SubItems.Add(value.Trim());
                                    this.lsvFromData.Items.Add(lvi);
                                    names.Add(name);
                                }
                                catch { }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        private void tsmiConvertVar_Click(object sender, EventArgs e)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            if (this.tcDetail.SelectedTab == tpBody)
            {
                if (this.tcBody.SelectedTab == this.tpUrlencode)
                {
                    foreach (ListViewItem lvi in lsvUrlEncode.SelectedItems) items.Add(lvi);
                }
                else if (this.tcBody.SelectedTab == this.tpFormData)
                {
                    foreach (ListViewItem lvi in lsvFromData.SelectedItems) items.Add(lvi);
                }
            }
            else if (this.tcDetail.SelectedTab == this.tpHeader)
            {
                foreach (ListViewItem lvi in lsvHeader.SelectedItems) items.Add(lvi);
            }

            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            foreach (ListViewItem lvi in items)
            {
                string name = lvi.SubItems.Count == 3 ? lvi.SubItems[1].Text : lvi.Text;
                string value = lvi.SubItems.Count == 3 ? lvi.SubItems[2].Text : lvi.SubItems[1].Text;

                if (!System.Text.RegularExpressions.Regex.IsMatch(name, "^[\\w（）\\-]*?$")) return;

                if (value.StartsWith("{-var.") && value.EndsWith("-}")) continue;
                if (name.StartsWith("{-var.") && name.EndsWith("-}")) continue;
                if (!context.ContainsStr(name))
                {
                    litsdk.Variable add = new Variable() { Name = name, VariableType = VariableType.String, InitStrValue = value, StrValue = value };
                    context.Variables.Add(add);
                }
                string rep = "{-var." + name + "-}";
                if (lvi.SubItems.Count == 3) lvi.SubItems[2].Text = rep;
                else lvi.SubItems[1].Text = rep;
            }
        }

        private void llbRand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbAttachPath, this.llbRand.Text);
        }

        private void tsmiAddProxy_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in this.lsvHeader.Items)
            {
                if (lvi.Text == "proxy") return;
            }
            ListViewItem lvadd = new ListViewItem("proxy");
            lvadd.SubItems.Add("127.0.0.1:8888");
            this.lsvHeader.Items.Add(lvadd);
        }

        private void tsmiToPaste_Click(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            string txt = "";
            if (this.tcDetail.SelectedTab == tpBody)
            {
                if (this.tcBody.SelectedTab == this.tpUrlencode)
                {
                    foreach (ListViewItem lvi in lsvUrlEncode.SelectedItems)
                    {
                        result.Add($"{lvi.Text}={lvi.SubItems[1].Text}");
                    }
                    txt = string.Join("&", result.ToArray());
                }
            }
            else if (this.tcDetail.SelectedTab == this.tpHeader)
            {
                foreach (ListViewItem lvi in lsvHeader.SelectedItems)
                {
                    result.Add($"{lvi.Text}:{lvi.SubItems[1].Text}");
                }
                txt = string.Join("\r\n", result.ToArray());
            }

            Clipboard.SetText(txt);
        }

        private void lsvFromData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks > 1)
            {
                ListViewItem lvi = this.lsvFromData.GetItemAt(e.X, e.Y);
                if (null == lvi) return;
                lvi.Checked = !lvi.Checked;
            }
        }
    }
}