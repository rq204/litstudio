namespace litapps
{
    partial class SelectIOUI
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
            this.ivTitle = new litsdk.InsertVarName();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMustSelect = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbSelectFile = new System.Windows.Forms.RadioButton();
            this.rbSelectDir = new System.Windows.Forms.RadioButton();
            this.cbFileCanMultSelect = new System.Windows.Forms.CheckBox();
            this.cbFileMustMultSelect = new System.Windows.Forms.CheckBox();
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
            this.scActivityUI.Panel1.Controls.Add(this.rbSelectDir);
            this.scActivityUI.Panel1.Controls.Add(this.rbSelectFile);
            this.scActivityUI.Panel1.Controls.Add(this.cbFileMustMultSelect);
            this.scActivityUI.Panel1.Controls.Add(this.cbFileCanMultSelect);
            this.scActivityUI.Panel1.Controls.Add(this.cbMustSelect);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.linkLabel1);
            this.scActivityUI.Panel1.Controls.Add(this.tbFilter);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.ivTitle);
            this.scActivityUI.Panel1.Controls.Add(this.tbTitle);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // ivTitle
            // 
            this.ivTitle.Location = new System.Drawing.Point(516, 52);
            this.ivTitle.Name = "ivTitle";
            this.ivTitle.Size = new System.Drawing.Size(16, 16);
            this.ivTitle.TabIndex = 13;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(108, 51);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(401, 21);
            this.tbTitle.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "弹窗标题";
            // 
            // cbMustSelect
            // 
            this.cbMustSelect.AutoSize = true;
            this.cbMustSelect.Location = new System.Drawing.Point(107, 173);
            this.cbMustSelect.Name = "cbMustSelect";
            this.cbMustSelect.Size = new System.Drawing.Size(144, 16);
            this.cbMustSelect.TabIndex = 26;
            this.cbMustSelect.Text = "必须选中文件或文件夹";
            this.cbMustSelect.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(302, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "多个类型格式形如 *.jpg|*.txt";
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(107, 130);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(174, 23);
            this.svSaveVarName.TabIndex = 23;
            this.svSaveVarName.VarName = "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(264, 93);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(11, 12);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "|";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(107, 89);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(148, 21);
            this.tbFilter.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "其它选项";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "存入变量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "文件筛选";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "操作类型";
            // 
            // rbSelectFile
            // 
            this.rbSelectFile.AutoSize = true;
            this.rbSelectFile.Location = new System.Drawing.Point(108, 19);
            this.rbSelectFile.Name = "rbSelectFile";
            this.rbSelectFile.Size = new System.Drawing.Size(71, 16);
            this.rbSelectFile.TabIndex = 27;
            this.rbSelectFile.TabStop = true;
            this.rbSelectFile.Text = "选择文件";
            this.rbSelectFile.UseVisualStyleBackColor = true;
            this.rbSelectFile.CheckedChanged += new System.EventHandler(this.rbSelectFile_CheckedChanged);
            // 
            // rbSelectDir
            // 
            this.rbSelectDir.AutoSize = true;
            this.rbSelectDir.Location = new System.Drawing.Point(193, 19);
            this.rbSelectDir.Name = "rbSelectDir";
            this.rbSelectDir.Size = new System.Drawing.Size(83, 16);
            this.rbSelectDir.TabIndex = 27;
            this.rbSelectDir.TabStop = true;
            this.rbSelectDir.Text = "选择文件夹";
            this.rbSelectDir.UseVisualStyleBackColor = true;
            // 
            // cbFileCanMultSelect
            // 
            this.cbFileCanMultSelect.AutoSize = true;
            this.cbFileCanMultSelect.Location = new System.Drawing.Point(302, 132);
            this.cbFileCanMultSelect.Name = "cbFileCanMultSelect";
            this.cbFileCanMultSelect.Size = new System.Drawing.Size(96, 16);
            this.cbFileCanMultSelect.TabIndex = 26;
            this.cbFileCanMultSelect.Text = "文件可以多选";
            this.cbFileCanMultSelect.UseVisualStyleBackColor = true;
            this.cbFileCanMultSelect.CheckedChanged += new System.EventHandler(this.cbMultSelect_CheckedChanged);
            // 
            // cbFileMustMultSelect
            // 
            this.cbFileMustMultSelect.AutoSize = true;
            this.cbFileMustMultSelect.Location = new System.Drawing.Point(413, 132);
            this.cbFileMustMultSelect.Name = "cbFileMustMultSelect";
            this.cbFileMustMultSelect.Size = new System.Drawing.Size(96, 16);
            this.cbFileMustMultSelect.TabIndex = 26;
            this.cbFileMustMultSelect.Text = "文件必须多选";
            this.cbFileMustMultSelect.UseVisualStyleBackColor = true;
            this.cbFileMustMultSelect.CheckedChanged += new System.EventHandler(this.cbMultSelect_CheckedChanged);
            // 
            // SelectIOUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SelectIOUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private litsdk.InsertVarName ivTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSelectDir;
        private System.Windows.Forms.RadioButton rbSelectFile;
        private System.Windows.Forms.CheckBox cbMustSelect;
        private System.Windows.Forms.Label label3;
        private litsdk.SelectVarName svSaveVarName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbFileCanMultSelect;
        private System.Windows.Forms.CheckBox cbFileMustMultSelect;
    }
}
