namespace litstudio.iecef
{
    partial class CookiesUI
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
            this.rbExportFile = new System.Windows.Forms.RadioButton();
            this.rbImportFile = new System.Windows.Forms.RadioButton();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.llbCurDir = new System.Windows.Forms.LinkLabel();
            this.ivFilePath = new litsdk.InsertVarName();
            this.rbExportVar = new System.Windows.Forms.RadioButton();
            this.rbImportVar = new System.Windows.Forms.RadioButton();
            this.lbvarName = new System.Windows.Forms.Label();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.label5 = new System.Windows.Forms.Label();
            this.pFilePath = new System.Windows.Forms.Panel();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            this.rbClearUrl = new System.Windows.Forms.RadioButton();
            this.rbClearAll = new System.Windows.Forms.RadioButton();
            this.rbExportABVar = new System.Windows.Forms.RadioButton();
            this.rbClearOtherUrl = new System.Windows.Forms.RadioButton();
            this.lbExportHost = new System.Windows.Forms.Label();
            this.tbExportHost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.pFilePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.tbExportHost);
            this.scActivityUI.Panel1.Controls.Add(this.lbExportHost);
            this.scActivityUI.Panel1.Controls.Add(this.rbClearOtherUrl);
            this.scActivityUI.Panel1.Controls.Add(this.rbExportABVar);
            this.scActivityUI.Panel1.Controls.Add(this.rbClearAll);
            this.scActivityUI.Panel1.Controls.Add(this.rbClearUrl);
            this.scActivityUI.Panel1.Controls.Add(this.pFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.rbImportVar);
            this.scActivityUI.Panel1.Controls.Add(this.rbExportVar);
            this.scActivityUI.Panel1.Controls.Add(this.rbImportFile);
            this.scActivityUI.Panel1.Controls.Add(this.rbExportFile);
            this.scActivityUI.Panel1.Controls.Add(this.lbvarName);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "操作类型";
            // 
            // rbExportFile
            // 
            this.rbExportFile.AutoSize = true;
            this.rbExportFile.Location = new System.Drawing.Point(83, 22);
            this.rbExportFile.Name = "rbExportFile";
            this.rbExportFile.Size = new System.Drawing.Size(119, 16);
            this.rbExportFile.TabIndex = 1;
            this.rbExportFile.TabStop = true;
            this.rbExportFile.Text = "导出Cookie到文件";
            this.rbExportFile.UseVisualStyleBackColor = true;
            this.rbExportFile.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbImportFile
            // 
            this.rbImportFile.AutoSize = true;
            this.rbImportFile.Location = new System.Drawing.Point(83, 57);
            this.rbImportFile.Name = "rbImportFile";
            this.rbImportFile.Size = new System.Drawing.Size(107, 16);
            this.rbImportFile.TabIndex = 1;
            this.rbImportFile.TabStop = true;
            this.rbImportFile.Text = "导入文件Cookie";
            this.rbImportFile.UseVisualStyleBackColor = true;
            this.rbImportFile.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Location = new System.Drawing.Point(5, 8);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(53, 12);
            this.lbFilePath.TabIndex = 0;
            this.lbFilePath.Text = "文件地址";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(67, 4);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(350, 21);
            this.tbFilePath.TabIndex = 2;
            // 
            // llbCurDir
            // 
            this.llbCurDir.AutoSize = true;
            this.llbCurDir.Location = new System.Drawing.Point(445, 8);
            this.llbCurDir.Name = "llbCurDir";
            this.llbCurDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurDir.TabIndex = 3;
            this.llbCurDir.TabStop = true;
            this.llbCurDir.Text = "[当前目录]";
            this.llbCurDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurDir_LinkClicked);
            // 
            // ivFilePath
            // 
            this.ivFilePath.Location = new System.Drawing.Point(423, 6);
            this.ivFilePath.Name = "ivFilePath";
            this.ivFilePath.Size = new System.Drawing.Size(16, 16);
            this.ivFilePath.TabIndex = 4;
            // 
            // rbExportVar
            // 
            this.rbExportVar.AutoSize = true;
            this.rbExportVar.Location = new System.Drawing.Point(229, 22);
            this.rbExportVar.Name = "rbExportVar";
            this.rbExportVar.Size = new System.Drawing.Size(119, 16);
            this.rbExportVar.TabIndex = 1;
            this.rbExportVar.TabStop = true;
            this.rbExportVar.Text = "导出Cookie至变量";
            this.rbExportVar.UseVisualStyleBackColor = true;
            this.rbExportVar.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbImportVar
            // 
            this.rbImportVar.AutoSize = true;
            this.rbImportVar.Location = new System.Drawing.Point(229, 57);
            this.rbImportVar.Name = "rbImportVar";
            this.rbImportVar.Size = new System.Drawing.Size(107, 16);
            this.rbImportVar.TabIndex = 1;
            this.rbImportVar.TabStop = true;
            this.rbImportVar.Text = "导入变量Cookie";
            this.rbImportVar.UseVisualStyleBackColor = true;
            this.rbImportVar.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // lbvarName
            // 
            this.lbvarName.AutoSize = true;
            this.lbvarName.Location = new System.Drawing.Point(21, 177);
            this.lbvarName.Name = "lbvarName";
            this.lbvarName.Size = new System.Drawing.Size(53, 12);
            this.lbvarName.TabIndex = 0;
            this.lbvarName.Text = "变量名称";
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(83, 172);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(156, 23);
            this.svSaveVarName.TabIndex = 5;
            this.svSaveVarName.VarName = "";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(20, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(536, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "默认Cookie格式为: Domain, Only Sent To Creator, Path, Secure(?), Expires, Name, Value。" +
    "\r\n导出a=b;c=d格式时，只导出当前域名下Cookie";
            // 
            // pFilePath
            // 
            this.pFilePath.Controls.Add(this.llbOpen);
            this.pFilePath.Controls.Add(this.tbFilePath);
            this.pFilePath.Controls.Add(this.lbFilePath);
            this.pFilePath.Controls.Add(this.llbCurDir);
            this.pFilePath.Controls.Add(this.ivFilePath);
            this.pFilePath.Location = new System.Drawing.Point(17, 127);
            this.pFilePath.Name = "pFilePath";
            this.pFilePath.Size = new System.Drawing.Size(554, 28);
            this.pFilePath.TabIndex = 8;
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(510, 8);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 10;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // rbClearUrl
            // 
            this.rbClearUrl.AutoSize = true;
            this.rbClearUrl.Location = new System.Drawing.Point(229, 93);
            this.rbClearUrl.Name = "rbClearUrl";
            this.rbClearUrl.Size = new System.Drawing.Size(143, 16);
            this.rbClearUrl.TabIndex = 9;
            this.rbClearUrl.TabStop = true;
            this.rbClearUrl.Text = "清除当前域名下Cookie";
            this.rbClearUrl.UseVisualStyleBackColor = true;
            this.rbClearUrl.Visible = false;
            this.rbClearUrl.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbClearAll
            // 
            this.rbClearAll.AutoSize = true;
            this.rbClearAll.Location = new System.Drawing.Point(84, 93);
            this.rbClearAll.Name = "rbClearAll";
            this.rbClearAll.Size = new System.Drawing.Size(107, 16);
            this.rbClearAll.TabIndex = 9;
            this.rbClearAll.TabStop = true;
            this.rbClearAll.Text = "清除所有Cookie";
            this.rbClearAll.UseVisualStyleBackColor = true;
            this.rbClearAll.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbExportABVar
            // 
            this.rbExportABVar.AutoSize = true;
            this.rbExportABVar.Location = new System.Drawing.Point(383, 21);
            this.rbExportABVar.Name = "rbExportABVar";
            this.rbExportABVar.Size = new System.Drawing.Size(185, 16);
            this.rbExportABVar.TabIndex = 10;
            this.rbExportABVar.TabStop = true;
            this.rbExportABVar.Text = "导出a=b;c=d格式Cookie至变量";
            this.rbExportABVar.UseVisualStyleBackColor = true;
            // 
            // rbClearOtherUrl
            // 
            this.rbClearOtherUrl.AutoSize = true;
            this.rbClearOtherUrl.Location = new System.Drawing.Point(384, 93);
            this.rbClearOtherUrl.Name = "rbClearOtherUrl";
            this.rbClearOtherUrl.Size = new System.Drawing.Size(155, 16);
            this.rbClearOtherUrl.TabIndex = 11;
            this.rbClearOtherUrl.TabStop = true;
            this.rbClearOtherUrl.Text = "清除非当前域名下Cookie";
            this.rbClearOtherUrl.UseVisualStyleBackColor = true;
            this.rbClearOtherUrl.Visible = false;
            // 
            // lbExportHost
            // 
            this.lbExportHost.AutoSize = true;
            this.lbExportHost.Location = new System.Drawing.Point(270, 176);
            this.lbExportHost.Name = "lbExportHost";
            this.lbExportHost.Size = new System.Drawing.Size(53, 12);
            this.lbExportHost.TabIndex = 12;
            this.lbExportHost.Text = "导出域名";
            // 
            // tbExportHost
            // 
            this.tbExportHost.Location = new System.Drawing.Point(334, 172);
            this.tbExportHost.Name = "tbExportHost";
            this.tbExportHost.Size = new System.Drawing.Size(122, 21);
            this.tbExportHost.TabIndex = 13;
            // 
            // CookiesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CookiesUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.pFilePath.ResumeLayout(false);
            this.pFilePath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbImportFile;
        private System.Windows.Forms.RadioButton rbExportFile;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label lbFilePath;
        private litsdk.InsertVarName ivFilePath;
        private System.Windows.Forms.LinkLabel llbCurDir;
        private System.Windows.Forms.RadioButton rbImportVar;
        private System.Windows.Forms.RadioButton rbExportVar;
        private litsdk.SelectVarName svSaveVarName;
        private System.Windows.Forms.Label lbvarName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pFilePath;
        private System.Windows.Forms.RadioButton rbClearUrl;
        private System.Windows.Forms.RadioButton rbClearAll;
        private System.Windows.Forms.LinkLabel llbOpen;
        private System.Windows.Forms.RadioButton rbClearOtherUrl;
        private System.Windows.Forms.RadioButton rbExportABVar;
        private System.Windows.Forms.TextBox tbExportHost;
        private System.Windows.Forms.Label lbExportHost;
    }
}
