namespace litexcel
{
    partial class OpenUI
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
            this.tbExcelPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbExcelName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ivExcelPath = new litsdk.InsertVarName();
            this.llbCurDir = new System.Windows.Forms.LinkLabel();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSheetName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ivExcelName = new litsdk.InsertVarName();
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
            this.scActivityUI.Panel1.Controls.Add(this.ivExcelPath);
            this.scActivityUI.Panel1.Controls.Add(this.llbCurDir);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.ivExcelName);
            this.scActivityUI.Panel1.Controls.Add(this.tbSheetName);
            this.scActivityUI.Panel1.Controls.Add(this.tbExcelName);
            this.scActivityUI.Panel1.Controls.Add(this.tbExcelPath);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件路径";
            // 
            // tbExcelPath
            // 
            this.tbExcelPath.Location = new System.Drawing.Point(88, 21);
            this.tbExcelPath.Name = "tbExcelPath";
            this.tbExcelPath.Size = new System.Drawing.Size(291, 21);
            this.tbExcelPath.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "对象保存至";
            // 
            // tbExcelName
            // 
            this.tbExcelName.Location = new System.Drawing.Point(88, 94);
            this.tbExcelName.Name = "tbExcelName";
            this.tbExcelName.Size = new System.Drawing.Size(119, 21);
            this.tbExcelName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(238, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "文件存在时打开，不存在时新建";
            // 
            // ivExcelPath
            // 
            this.ivExcelPath.Location = new System.Drawing.Point(389, 22);
            this.ivExcelPath.Name = "ivExcelPath";
            this.ivExcelPath.Size = new System.Drawing.Size(16, 16);
            this.ivExcelPath.TabIndex = 7;
            // 
            // llbCurDir
            // 
            this.llbCurDir.AutoSize = true;
            this.llbCurDir.Location = new System.Drawing.Point(414, 25);
            this.llbCurDir.Name = "llbCurDir";
            this.llbCurDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurDir.TabIndex = 6;
            this.llbCurDir.TabStop = true;
            this.llbCurDir.Text = "[当前目录]";
            this.llbCurDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurDir_LinkClicked);
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(485, 25);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 8;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "打开工作表";
            // 
            // tbSheetName
            // 
            this.tbSheetName.Location = new System.Drawing.Point(88, 57);
            this.tbSheetName.Name = "tbSheetName";
            this.tbSheetName.Size = new System.Drawing.Size(119, 21);
            this.tbSheetName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(238, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "值为空时，默认打开第一个工作表";
            // 
            // ivExcelName
            // 
            this.ivExcelName.Location = new System.Drawing.Point(216, 96);
            this.ivExcelName.Name = "ivExcelName";
            this.ivExcelName.Size = new System.Drawing.Size(16, 16);
            this.ivExcelName.TabIndex = 4;
            this.ivExcelName.Visible = false;
            // 
            // OpenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "OpenUI";
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
        private System.Windows.Forms.TextBox tbExcelPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbExcelName;
        private litsdk.InsertVarName ivExcelPath;
        private System.Windows.Forms.LinkLabel llbCurDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel llbOpen;
        private System.Windows.Forms.Label label6;
        private litsdk.InsertVarName ivExcelName;
        private System.Windows.Forms.TextBox tbSheetName;
        private System.Windows.Forms.Label label3;
    }
}
