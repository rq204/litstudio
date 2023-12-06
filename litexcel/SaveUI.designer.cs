namespace litexcel
{
    partial class SaveUI
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
            this.lbSaveAs = new System.Windows.Forms.Label();
            this.cbExcelName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCloseAfterSave = new System.Windows.Forms.CheckBox();
            this.tbSaveAsPath = new System.Windows.Forms.TextBox();
            this.ivSaveAs = new litsdk.InsertVarName();
            this.label3 = new System.Windows.Forms.Label();
            this.rbSave = new System.Windows.Forms.RadioButton();
            this.rbSaveAs = new System.Windows.Forms.RadioButton();
            this.rbOnlyClose = new System.Windows.Forms.RadioButton();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            this.llbCurrentDir = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.llbCurrentDir);
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.rbOnlyClose);
            this.scActivityUI.Panel1.Controls.Add(this.rbSaveAs);
            this.scActivityUI.Panel1.Controls.Add(this.rbSave);
            this.scActivityUI.Panel1.Controls.Add(this.ivSaveAs);
            this.scActivityUI.Panel1.Controls.Add(this.tbSaveAsPath);
            this.scActivityUI.Panel1.Controls.Add(this.cbCloseAfterSave);
            this.scActivityUI.Panel1.Controls.Add(this.cbExcelName);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.lbSaveAs);
            // 
            // lbSaveAs
            // 
            this.lbSaveAs.AutoSize = true;
            this.lbSaveAs.Location = new System.Drawing.Point(40, 104);
            this.lbSaveAs.Name = "lbSaveAs";
            this.lbSaveAs.Size = new System.Drawing.Size(41, 12);
            this.lbSaveAs.TabIndex = 0;
            this.lbSaveAs.Text = "另存为";
            // 
            // cbExcelName
            // 
            this.cbExcelName.FormattingEnabled = true;
            this.cbExcelName.Location = new System.Drawing.Point(86, 23);
            this.cbExcelName.Name = "cbExcelName";
            this.cbExcelName.Size = new System.Drawing.Size(148, 20);
            this.cbExcelName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Excel对象";
            // 
            // cbCloseAfterSave
            // 
            this.cbCloseAfterSave.AutoSize = true;
            this.cbCloseAfterSave.Location = new System.Drawing.Point(298, 63);
            this.cbCloseAfterSave.Name = "cbCloseAfterSave";
            this.cbCloseAfterSave.Size = new System.Drawing.Size(84, 16);
            this.cbCloseAfterSave.TabIndex = 7;
            this.cbCloseAfterSave.Text = "保存后关闭";
            this.cbCloseAfterSave.UseVisualStyleBackColor = true;
            // 
            // tbSaveAsPath
            // 
            this.tbSaveAsPath.Location = new System.Drawing.Point(86, 100);
            this.tbSaveAsPath.Name = "tbSaveAsPath";
            this.tbSaveAsPath.Size = new System.Drawing.Size(346, 21);
            this.tbSaveAsPath.TabIndex = 8;
            // 
            // ivSaveAs
            // 
            this.ivSaveAs.Location = new System.Drawing.Point(438, 101);
            this.ivSaveAs.Name = "ivSaveAs";
            this.ivSaveAs.Size = new System.Drawing.Size(16, 16);
            this.ivSaveAs.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "操作方式";
            // 
            // rbSave
            // 
            this.rbSave.AutoSize = true;
            this.rbSave.Location = new System.Drawing.Point(86, 63);
            this.rbSave.Name = "rbSave";
            this.rbSave.Size = new System.Drawing.Size(47, 16);
            this.rbSave.TabIndex = 10;
            this.rbSave.TabStop = true;
            this.rbSave.Text = "保存";
            this.rbSave.UseVisualStyleBackColor = true;
            this.rbSave.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSaveAs
            // 
            this.rbSaveAs.AutoSize = true;
            this.rbSaveAs.Location = new System.Drawing.Point(139, 63);
            this.rbSaveAs.Name = "rbSaveAs";
            this.rbSaveAs.Size = new System.Drawing.Size(59, 16);
            this.rbSaveAs.TabIndex = 10;
            this.rbSaveAs.TabStop = true;
            this.rbSaveAs.Text = "另存为";
            this.rbSaveAs.UseVisualStyleBackColor = true;
            this.rbSaveAs.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbOnlyClose
            // 
            this.rbOnlyClose.AutoSize = true;
            this.rbOnlyClose.Location = new System.Drawing.Point(205, 63);
            this.rbOnlyClose.Name = "rbOnlyClose";
            this.rbOnlyClose.Size = new System.Drawing.Size(59, 16);
            this.rbOnlyClose.TabIndex = 10;
            this.rbOnlyClose.TabStop = true;
            this.rbOnlyClose.Text = "仅关闭";
            this.rbOnlyClose.UseVisualStyleBackColor = true;
            this.rbOnlyClose.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(529, 103);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 11;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // llbCurrentDir
            // 
            this.llbCurrentDir.AutoSize = true;
            this.llbCurrentDir.Location = new System.Drawing.Point(459, 104);
            this.llbCurrentDir.Name = "llbCurrentDir";
            this.llbCurrentDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurrentDir.TabIndex = 12;
            this.llbCurrentDir.TabStop = true;
            this.llbCurrentDir.Text = "[当前目录]";
            this.llbCurrentDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurrentDir_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(251, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "Excel对象为空时，请先新建打开Excel流程";
            // 
            // SaveUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SaveUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSaveAs;
        private litsdk.InsertVarName ivSaveAs;
        private System.Windows.Forms.TextBox tbSaveAsPath;
        private System.Windows.Forms.CheckBox cbCloseAfterSave;
        private System.Windows.Forms.ComboBox cbExcelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbOnlyClose;
        private System.Windows.Forms.RadioButton rbSaveAs;
        private System.Windows.Forms.RadioButton rbSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llbOpen;
        private System.Windows.Forms.LinkLabel llbCurrentDir;
        private System.Windows.Forms.Label label7;
    }
}
