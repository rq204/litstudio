
namespace litext
{
    partial class FileAttriUI
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
            this.rbGetCreationTime = new System.Windows.Forms.RadioButton();
            this.lbDes = new System.Windows.Forms.Label();
            this.rbSetLastAccessTime = new System.Windows.Forms.RadioButton();
            this.rbSetCreationTime = new System.Windows.Forms.RadioButton();
            this.rbSetLastWriteTime = new System.Windows.Forms.RadioButton();
            this.rbGetLastWriteTime = new System.Windows.Forms.RadioButton();
            this.rbGetLastAccessTime = new System.Windows.Forms.RadioButton();
            this.svOptVarName = new litsdk.SelectVarName();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOptFilePath = new System.Windows.Forms.TextBox();
            this.ivFilePath = new litsdk.InsertVarName();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            this.llbCur = new System.Windows.Forms.LinkLabel();
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
            this.scActivityUI.Panel1.Controls.Add(this.ivFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.llbCur);
            this.scActivityUI.Panel1.Controls.Add(this.tbOptFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.svOptVarName);
            this.scActivityUI.Panel1.Controls.Add(this.rbGetLastAccessTime);
            this.scActivityUI.Panel1.Controls.Add(this.rbGetLastWriteTime);
            this.scActivityUI.Panel1.Controls.Add(this.rbSetLastWriteTime);
            this.scActivityUI.Panel1.Controls.Add(this.rbSetCreationTime);
            this.scActivityUI.Panel1.Controls.Add(this.rbSetLastAccessTime);
            this.scActivityUI.Panel1.Controls.Add(this.rbGetCreationTime);
            this.scActivityUI.Panel1.Controls.Add(this.lbDes);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "操作类型";
            // 
            // rbGetCreationTime
            // 
            this.rbGetCreationTime.AutoSize = true;
            this.rbGetCreationTime.Location = new System.Drawing.Point(84, 25);
            this.rbGetCreationTime.Name = "rbGetCreationTime";
            this.rbGetCreationTime.Size = new System.Drawing.Size(95, 16);
            this.rbGetCreationTime.TabIndex = 1;
            this.rbGetCreationTime.Text = "获取创建时间";
            this.rbGetCreationTime.UseVisualStyleBackColor = true;
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Location = new System.Drawing.Point(24, 167);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(53, 12);
            this.lbDes.TabIndex = 0;
            this.lbDes.Text = "操作变量";
            // 
            // rbSetLastAccessTime
            // 
            this.rbSetLastAccessTime.AutoSize = true;
            this.rbSetLastAccessTime.Location = new System.Drawing.Point(309, 62);
            this.rbSetLastAccessTime.Name = "rbSetLastAccessTime";
            this.rbSetLastAccessTime.Size = new System.Drawing.Size(143, 16);
            this.rbSetLastAccessTime.TabIndex = 2;
            this.rbSetLastAccessTime.Text = "设置最近一次访问时间";
            this.rbSetLastAccessTime.UseVisualStyleBackColor = true;
            // 
            // rbSetCreationTime
            // 
            this.rbSetCreationTime.AutoSize = true;
            this.rbSetCreationTime.Location = new System.Drawing.Point(84, 62);
            this.rbSetCreationTime.Name = "rbSetCreationTime";
            this.rbSetCreationTime.Size = new System.Drawing.Size(95, 16);
            this.rbSetCreationTime.TabIndex = 3;
            this.rbSetCreationTime.Text = "设置创建时间";
            this.rbSetCreationTime.UseVisualStyleBackColor = true;
            // 
            // rbSetLastWriteTime
            // 
            this.rbSetLastWriteTime.AutoSize = true;
            this.rbSetLastWriteTime.Location = new System.Drawing.Point(198, 62);
            this.rbSetLastWriteTime.Name = "rbSetLastWriteTime";
            this.rbSetLastWriteTime.Size = new System.Drawing.Size(95, 16);
            this.rbSetLastWriteTime.TabIndex = 4;
            this.rbSetLastWriteTime.Text = "设置修改时间";
            this.rbSetLastWriteTime.UseVisualStyleBackColor = true;
            // 
            // rbGetLastWriteTime
            // 
            this.rbGetLastWriteTime.AutoSize = true;
            this.rbGetLastWriteTime.Location = new System.Drawing.Point(198, 25);
            this.rbGetLastWriteTime.Name = "rbGetLastWriteTime";
            this.rbGetLastWriteTime.Size = new System.Drawing.Size(95, 16);
            this.rbGetLastWriteTime.TabIndex = 9;
            this.rbGetLastWriteTime.Text = "获取修改时间";
            this.rbGetLastWriteTime.UseVisualStyleBackColor = true;
            // 
            // rbGetLastAccessTime
            // 
            this.rbGetLastAccessTime.AutoSize = true;
            this.rbGetLastAccessTime.Location = new System.Drawing.Point(309, 25);
            this.rbGetLastAccessTime.Name = "rbGetLastAccessTime";
            this.rbGetLastAccessTime.Size = new System.Drawing.Size(143, 16);
            this.rbGetLastAccessTime.TabIndex = 10;
            this.rbGetLastAccessTime.Text = "获取最近一次访问时间";
            this.rbGetLastAccessTime.UseVisualStyleBackColor = true;
            // 
            // svOptVarName
            // 
            this.svOptVarName.Location = new System.Drawing.Point(84, 162);
            this.svOptVarName.Name = "svOptVarName";
            this.svOptVarName.Size = new System.Drawing.Size(145, 23);
            this.svOptVarName.TabIndex = 11;
            this.svOptVarName.VarName = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "文件路径";
            // 
            // tbOptFilePath
            // 
            this.tbOptFilePath.Location = new System.Drawing.Point(84, 124);
            this.tbOptFilePath.Name = "tbOptFilePath";
            this.tbOptFilePath.Size = new System.Drawing.Size(284, 21);
            this.tbOptFilePath.TabIndex = 13;
            // 
            // ivFilePath
            // 
            this.ivFilePath.Location = new System.Drawing.Point(376, 126);
            this.ivFilePath.Name = "ivFilePath";
            this.ivFilePath.Size = new System.Drawing.Size(16, 16);
            this.ivFilePath.TabIndex = 19;
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(469, 127);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 18;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // llbCur
            // 
            this.llbCur.AutoSize = true;
            this.llbCur.Location = new System.Drawing.Point(400, 127);
            this.llbCur.Name = "llbCur";
            this.llbCur.Size = new System.Drawing.Size(65, 12);
            this.llbCur.TabIndex = 17;
            this.llbCur.TabStop = true;
            this.llbCur.Text = "[当前目录]";
            this.llbCur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCur_LinkClicked);
            // 
            // FileAttriUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FileAttriUI";
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
        private System.Windows.Forms.RadioButton rbGetLastAccessTime;
        private System.Windows.Forms.RadioButton rbGetLastWriteTime;
        private System.Windows.Forms.RadioButton rbSetLastWriteTime;
        private System.Windows.Forms.RadioButton rbSetCreationTime;
        private System.Windows.Forms.RadioButton rbSetLastAccessTime;
        private System.Windows.Forms.RadioButton rbGetCreationTime;
        private System.Windows.Forms.Label lbDes;
        private litsdk.SelectVarName svOptVarName;
        private System.Windows.Forms.TextBox tbOptFilePath;
        private System.Windows.Forms.Label label3;
        private litsdk.InsertVarName ivFilePath;
        private System.Windows.Forms.LinkLabel llbOpen;
        private System.Windows.Forms.LinkLabel llbCur;
    }
}
