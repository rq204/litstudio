namespace litapps
{
    partial class ExplorerOpenUI
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
            this.llbdir = new System.Windows.Forms.LinkLabel();
            this.ivFilePath = new litsdk.InsertVarName();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.cbOpenDirSelectFile = new System.Windows.Forms.CheckBox();
            this.cbOpenFile = new System.Windows.Forms.CheckBox();
            this.cbOpenDir = new System.Windows.Forms.CheckBox();
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
            this.scActivityUI.Panel1.Controls.Add(this.cbOpenDir);
            this.scActivityUI.Panel1.Controls.Add(this.cbOpenFile);
            this.scActivityUI.Panel1.Controls.Add(this.cbOpenDirSelectFile);
            this.scActivityUI.Panel1.Controls.Add(this.llbdir);
            this.scActivityUI.Panel1.Controls.Add(this.ivFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.tbFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "打开选项";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "文件路径";
            // 
            // llbdir
            // 
            this.llbdir.AutoSize = true;
            this.llbdir.Location = new System.Drawing.Point(456, 62);
            this.llbdir.Name = "llbdir";
            this.llbdir.Size = new System.Drawing.Size(65, 12);
            this.llbdir.TabIndex = 10;
            this.llbdir.TabStop = true;
            this.llbdir.Text = "[当前目录]";
            this.llbdir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbdir_LinkClicked);
            // 
            // ivFilePath
            // 
            this.ivFilePath.Location = new System.Drawing.Point(430, 59);
            this.ivFilePath.Name = "ivFilePath";
            this.ivFilePath.Size = new System.Drawing.Size(20, 23);
            this.ivFilePath.TabIndex = 9;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(83, 59);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(341, 21);
            this.tbFilePath.TabIndex = 8;
            // 
            // cbOpenDirSelectFile
            // 
            this.cbOpenDirSelectFile.AutoSize = true;
            this.cbOpenDirSelectFile.Location = new System.Drawing.Point(303, 21);
            this.cbOpenDirSelectFile.Name = "cbOpenDirSelectFile";
            this.cbOpenDirSelectFile.Size = new System.Drawing.Size(144, 16);
            this.cbOpenDirSelectFile.TabIndex = 11;
            this.cbOpenDirSelectFile.Text = "打开文件夹并定位文件";
            this.cbOpenDirSelectFile.UseVisualStyleBackColor = true;
            // 
            // cbOpenFile
            // 
            this.cbOpenFile.AutoSize = true;
            this.cbOpenFile.Location = new System.Drawing.Point(82, 21);
            this.cbOpenFile.Name = "cbOpenFile";
            this.cbOpenFile.Size = new System.Drawing.Size(72, 16);
            this.cbOpenFile.TabIndex = 12;
            this.cbOpenFile.Text = "打开文件";
            this.cbOpenFile.UseVisualStyleBackColor = true;
            // 
            // cbOpenDir
            // 
            this.cbOpenDir.AutoSize = true;
            this.cbOpenDir.Location = new System.Drawing.Point(163, 21);
            this.cbOpenDir.Name = "cbOpenDir";
            this.cbOpenDir.Size = new System.Drawing.Size(132, 16);
            this.cbOpenDir.TabIndex = 12;
            this.cbOpenDir.Text = "打开文件所在文件夹";
            this.cbOpenDir.UseVisualStyleBackColor = true;
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(526, 62);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 14;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // ExplorerOpenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ExplorerOpenUI";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llbdir;
        private litsdk.InsertVarName ivFilePath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.CheckBox cbOpenFile;
        private System.Windows.Forms.CheckBox cbOpenDirSelectFile;
        private System.Windows.Forms.CheckBox cbOpenDir;
        private System.Windows.Forms.LinkLabel llbOpen;
    }
}
