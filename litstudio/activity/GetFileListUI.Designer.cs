namespace litstudio
{
    partial class GetFileListUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbDirPath = new System.Windows.Forms.TextBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.svListVarName = new litsdk.SelectVarName();
            this.ivPath = new litsdk.InsertVarName();
            this.llbDir = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOnlyFileName = new System.Windows.Forms.CheckBox();
            this.cbOnlyFileNameWithoutExt = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDirList = new System.Windows.Forms.CheckBox();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
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
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.cbDirList);
            this.scActivityUI.Panel1.Controls.Add(this.cbOnlyFileNameWithoutExt);
            this.scActivityUI.Panel1.Controls.Add(this.cbOnlyFileName);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.llbDir);
            this.scActivityUI.Panel1.Controls.Add(this.ivPath);
            this.scActivityUI.Panel1.Controls.Add(this.svListVarName);
            this.scActivityUI.Panel1.Controls.Add(this.linkLabel1);
            this.scActivityUI.Panel1.Controls.Add(this.tbFilter);
            this.scActivityUI.Panel1.Controls.Add(this.tbDirPath);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "选择目录";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "文件筛选";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "存入变量";
            // 
            // tbDirPath
            // 
            this.tbDirPath.Location = new System.Drawing.Point(104, 27);
            this.tbDirPath.Name = "tbDirPath";
            this.tbDirPath.Size = new System.Drawing.Size(314, 21);
            this.tbDirPath.TabIndex = 1;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(104, 69);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(188, 21);
            this.tbFilter.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(298, 73);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(11, 12);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "|";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // svListVarName
            // 
            this.svListVarName.Location = new System.Drawing.Point(104, 111);
            this.svListVarName.Name = "svListVarName";
            this.svListVarName.Size = new System.Drawing.Size(215, 23);
            this.svListVarName.TabIndex = 3;
            this.svListVarName.VarName = "";
            // 
            // ivPath
            // 
            this.ivPath.Location = new System.Drawing.Point(424, 27);
            this.ivPath.Name = "ivPath";
            this.ivPath.Size = new System.Drawing.Size(20, 23);
            this.ivPath.TabIndex = 4;
            // 
            // llbDir
            // 
            this.llbDir.AutoSize = true;
            this.llbDir.Location = new System.Drawing.Point(451, 32);
            this.llbDir.Name = "llbDir";
            this.llbDir.Size = new System.Drawing.Size(65, 12);
            this.llbDir.TabIndex = 5;
            this.llbDir.TabStop = true;
            this.llbDir.Text = "[当前目录]";
            this.llbDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDir_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(321, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "多个类型格式形如 *.jpg|*.txt";
            // 
            // cbOnlyFileName
            // 
            this.cbOnlyFileName.AutoSize = true;
            this.cbOnlyFileName.Location = new System.Drawing.Point(104, 157);
            this.cbOnlyFileName.Name = "cbOnlyFileName";
            this.cbOnlyFileName.Size = new System.Drawing.Size(96, 16);
            this.cbOnlyFileName.TabIndex = 7;
            this.cbOnlyFileName.Text = "只保留文件名";
            this.cbOnlyFileName.UseVisualStyleBackColor = true;
            // 
            // cbOnlyFileNameWithoutExt
            // 
            this.cbOnlyFileNameWithoutExt.AutoSize = true;
            this.cbOnlyFileNameWithoutExt.Location = new System.Drawing.Point(219, 157);
            this.cbOnlyFileNameWithoutExt.Name = "cbOnlyFileNameWithoutExt";
            this.cbOnlyFileNameWithoutExt.Size = new System.Drawing.Size(156, 16);
            this.cbOnlyFileNameWithoutExt.TabIndex = 7;
            this.cbOnlyFileNameWithoutExt.Text = "只保留文件名并去扩展名";
            this.cbOnlyFileNameWithoutExt.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "其它选项";
            // 
            // cbDirList
            // 
            this.cbDirList.AutoSize = true;
            this.cbDirList.Location = new System.Drawing.Point(392, 156);
            this.cbDirList.Name = "cbDirList";
            this.cbDirList.Size = new System.Drawing.Size(120, 16);
            this.cbDirList.TabIndex = 7;
            this.cbDirList.Text = "获取目录下文件夹";
            this.cbDirList.UseVisualStyleBackColor = true;
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(522, 32);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 9;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // GetFileListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GetFileListUI";
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
        private litsdk.SelectVarName svListVarName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.TextBox tbDirPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llbDir;
        private litsdk.InsertVarName ivPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbOnlyFileName;
        private System.Windows.Forms.CheckBox cbOnlyFileNameWithoutExt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbDirList;
        private System.Windows.Forms.LinkLabel llbOpen;
    }
}
