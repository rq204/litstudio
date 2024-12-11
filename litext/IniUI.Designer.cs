namespace litext
{
    partial class IniUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbIniFile = new System.Windows.Forms.TextBox();
            this.rbRead = new System.Windows.Forms.RadioButton();
            this.rbWrite = new System.Windows.Forms.RadioButton();
            this.lsvIniConfigs = new System.Windows.Forms.ListView();
            this.chSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVarName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.llbEdit = new System.Windows.Forms.LinkLabel();
            this.llbDelete = new System.Windows.Forms.LinkLabel();
            this.llbAdd = new System.Windows.Forms.LinkLabel();
            this.tbSetion = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.svVarName = new litsdk.SelectVarName();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.llbCur = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            this.ivIniPath = new litsdk.InsertVarName();
            this.ivSection = new litsdk.InsertVarName();
            this.ivKey = new litsdk.InsertVarName();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbActivityName
            // 
            this.tbActivityName.TabIndex = 7;
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.ivKey);
            this.scActivityUI.Panel1.Controls.Add(this.ivSection);
            this.scActivityUI.Panel1.Controls.Add(this.ivIniPath);
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.btnSave);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.svVarName);
            this.scActivityUI.Panel1.Controls.Add(this.tbKey);
            this.scActivityUI.Panel1.Controls.Add(this.tbSetion);
            this.scActivityUI.Panel1.Controls.Add(this.llbCur);
            this.scActivityUI.Panel1.Controls.Add(this.llbDelete);
            this.scActivityUI.Panel1.Controls.Add(this.llbAdd);
            this.scActivityUI.Panel1.Controls.Add(this.llbEdit);
            this.scActivityUI.Panel1.Controls.Add(this.lsvIniConfigs);
            this.scActivityUI.Panel1.Controls.Add(this.rbWrite);
            this.scActivityUI.Panel1.Controls.Add(this.rbRead);
            this.scActivityUI.Panel1.Controls.Add(this.tbIniFile);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "操作方式";
            // 
            // tbIniFile
            // 
            this.tbIniFile.Location = new System.Drawing.Point(97, 14);
            this.tbIniFile.Name = "tbIniFile";
            this.tbIniFile.Size = new System.Drawing.Size(322, 21);
            this.tbIniFile.TabIndex = 0;
            // 
            // rbRead
            // 
            this.rbRead.AutoSize = true;
            this.rbRead.Location = new System.Drawing.Point(97, 49);
            this.rbRead.Name = "rbRead";
            this.rbRead.Size = new System.Drawing.Size(47, 16);
            this.rbRead.TabIndex = 1;
            this.rbRead.TabStop = true;
            this.rbRead.Text = "读取";
            this.rbRead.UseVisualStyleBackColor = true;
            // 
            // rbWrite
            // 
            this.rbWrite.AutoSize = true;
            this.rbWrite.Location = new System.Drawing.Point(166, 49);
            this.rbWrite.Name = "rbWrite";
            this.rbWrite.Size = new System.Drawing.Size(47, 16);
            this.rbWrite.TabIndex = 2;
            this.rbWrite.TabStop = true;
            this.rbWrite.Text = "写入";
            this.rbWrite.UseVisualStyleBackColor = true;
            // 
            // lsvIniConfigs
            // 
            this.lsvIniConfigs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSection,
            this.chKey,
            this.chVarName});
            this.lsvIniConfigs.FullRowSelect = true;
            this.lsvIniConfigs.HideSelection = false;
            this.lsvIniConfigs.Location = new System.Drawing.Point(97, 80);
            this.lsvIniConfigs.Name = "lsvIniConfigs";
            this.lsvIniConfigs.Size = new System.Drawing.Size(247, 93);
            this.lsvIniConfigs.TabIndex = 3;
            this.lsvIniConfigs.UseCompatibleStateImageBehavior = false;
            this.lsvIniConfigs.View = System.Windows.Forms.View.Details;
            this.lsvIniConfigs.SelectedIndexChanged += new System.EventHandler(this.lsvIniConfigs_SelectedIndexChanged);
            this.lsvIniConfigs.DoubleClick += new System.EventHandler(this.lsvIniConfigs_DoubleClick);
            // 
            // chSection
            // 
            this.chSection.Text = "节点";
            this.chSection.Width = 73;
            // 
            // chKey
            // 
            this.chKey.Text = "键名";
            this.chKey.Width = 77;
            // 
            // chVarName
            // 
            this.chVarName.Text = "变量名";
            this.chVarName.Width = 89;
            // 
            // llbEdit
            // 
            this.llbEdit.AutoSize = true;
            this.llbEdit.Location = new System.Drawing.Point(315, 189);
            this.llbEdit.Name = "llbEdit";
            this.llbEdit.Size = new System.Drawing.Size(29, 12);
            this.llbEdit.TabIndex = 4;
            this.llbEdit.TabStop = true;
            this.llbEdit.Text = "编辑";
            this.llbEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbEdit_LinkClicked);
            // 
            // llbDelete
            // 
            this.llbDelete.AutoSize = true;
            this.llbDelete.Location = new System.Drawing.Point(95, 189);
            this.llbDelete.Name = "llbDelete";
            this.llbDelete.Size = new System.Drawing.Size(29, 12);
            this.llbDelete.TabIndex = 4;
            this.llbDelete.TabStop = true;
            this.llbDelete.Text = "删除";
            this.llbDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDelete_LinkClicked);
            // 
            // llbAdd
            // 
            this.llbAdd.AutoSize = true;
            this.llbAdd.Location = new System.Drawing.Point(280, 189);
            this.llbAdd.Name = "llbAdd";
            this.llbAdd.Size = new System.Drawing.Size(29, 12);
            this.llbAdd.TabIndex = 4;
            this.llbAdd.TabStop = true;
            this.llbAdd.Text = "添加";
            this.llbAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAdd_LinkClicked);
            // 
            // tbSetion
            // 
            this.tbSetion.Location = new System.Drawing.Point(415, 82);
            this.tbSetion.Name = "tbSetion";
            this.tbSetion.Size = new System.Drawing.Size(100, 21);
            this.tbSetion.TabIndex = 3;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(415, 117);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(100, 21);
            this.tbKey.TabIndex = 4;
            // 
            // svVarName
            // 
            this.svVarName.Location = new System.Drawing.Point(415, 150);
            this.svVarName.Name = "svVarName";
            this.svVarName.Size = new System.Drawing.Size(126, 23);
            this.svVarName.TabIndex = 5;
            this.svVarName.VarName = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "节  点";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "键  名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "变量名";
            // 
            // llbCur
            // 
            this.llbCur.AutoSize = true;
            this.llbCur.Location = new System.Drawing.Point(450, 18);
            this.llbCur.Name = "llbCur";
            this.llbCur.Size = new System.Drawing.Size(65, 12);
            this.llbCur.TabIndex = 4;
            this.llbCur.TabStop = true;
            this.llbCur.Text = "[当前目录]";
            this.llbCur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCur_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(429, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "添加";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(519, 18);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 15;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // ivIniPath
            // 
            this.ivIniPath.Location = new System.Drawing.Point(426, 17);
            this.ivIniPath.Name = "ivIniPath";
            this.ivIniPath.Size = new System.Drawing.Size(16, 16);
            this.ivIniPath.TabIndex = 16;
            // 
            // ivSection
            // 
            this.ivSection.Location = new System.Drawing.Point(521, 85);
            this.ivSection.Name = "ivSection";
            this.ivSection.Size = new System.Drawing.Size(16, 16);
            this.ivSection.TabIndex = 17;
            // 
            // ivKey
            // 
            this.ivKey.Location = new System.Drawing.Point(521, 119);
            this.ivKey.Name = "ivKey";
            this.ivKey.Size = new System.Drawing.Size(16, 16);
            this.ivKey.TabIndex = 18;
            // 
            // IniUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "IniUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llbDelete;
        private System.Windows.Forms.LinkLabel llbAdd;
        private System.Windows.Forms.LinkLabel llbEdit;
        private System.Windows.Forms.ListView lsvIniConfigs;
        private System.Windows.Forms.ColumnHeader chSection;
        private System.Windows.Forms.ColumnHeader chKey;
        private System.Windows.Forms.ColumnHeader chVarName;
        private System.Windows.Forms.RadioButton rbWrite;
        private System.Windows.Forms.RadioButton rbRead;
        private System.Windows.Forms.TextBox tbIniFile;
        private System.Windows.Forms.Label label3;
        private litsdk.SelectVarName svVarName;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbSetion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llbCur;
        private System.Windows.Forms.Button btnSave;
        private litsdk.InsertVarName ivIniPath;
        private System.Windows.Forms.LinkLabel llbOpen;
        private litsdk.InsertVarName ivKey;
        private litsdk.InsertVarName ivSection;
    }
}
