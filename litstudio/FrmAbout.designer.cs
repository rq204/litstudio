namespace litstudio
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.llDes = new System.Windows.Forms.Label();
            this.lbVer = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbZan = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.llbLink = new System.Windows.Forms.LinkLabel();
            this.pbWeixin = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeixin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "简介：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "联系：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "QQ群47234908";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "版本：";
            // 
            // llDes
            // 
            this.llDes.Location = new System.Drawing.Point(68, 20);
            this.llDes.Name = "llDes";
            this.llDes.Size = new System.Drawing.Size(320, 89);
            this.llDes.TabIndex = 0;
            this.llDes.Text = "litrpa是一款针对中小企业及个人的机器人流程自动化工具，它秉承简单易用的宗旨，意在将人从各种重复劳动中解放出来，提高工作效率及企业效益。用户通过可视化的流程图" +
    "设计，就可以完成控件点击，数据提取，浏览器模拟，文件保存，数据库操作等任务，让普通业务工作者也能做到快速的自动化开发及运营。";
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.Location = new System.Drawing.Point(72, 168);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(23, 12);
            this.lbVer.TabIndex = 0;
            this.lbVer.Text = "2.8";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = "";
            this.btnClose.Location = new System.Drawing.Point(123, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "确定";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbZan
            // 
            this.lbZan.AutoSize = true;
            this.lbZan.Location = new System.Drawing.Point(172, 369);
            this.lbZan.Name = "lbZan";
            this.lbZan.Size = new System.Drawing.Size(65, 12);
            this.lbZan.TabIndex = 2;
            this.lbZan.TabStop = true;
            this.lbZan.Text = "给作者点赞";
            this.lbZan.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "网站：";
            // 
            // llbLink
            // 
            this.llbLink.AutoSize = true;
            this.llbLink.Location = new System.Drawing.Point(69, 138);
            this.llbLink.Name = "llbLink";
            this.llbLink.Size = new System.Drawing.Size(89, 12);
            this.llbLink.TabIndex = 3;
            this.llbLink.TabStop = true;
            this.llbLink.Text = "www.litrpa.com";
            this.llbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLink_LinkClicked);
            // 
            // pbWeixin
            // 
            this.pbWeixin.Image = ((System.Drawing.Image)(resources.GetObject("pbWeixin.Image")));
            this.pbWeixin.Location = new System.Drawing.Point(253, 93);
            this.pbWeixin.Name = "pbWeixin";
            this.pbWeixin.Size = new System.Drawing.Size(125, 125);
            this.pbWeixin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWeixin.TabIndex = 4;
            this.pbWeixin.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "联系：  请扫描右侧二维码加微信群";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 238);
            this.Controls.Add(this.pbWeixin);
            this.Controls.Add(this.llbLink);
            this.Controls.Add(this.lbZan);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llDes);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于 litrpa 流程设计器";
            ((System.ComponentModel.ISupportInitialize)(this.pbWeixin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label llDes;
        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lbZan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel llbLink;
        private System.Windows.Forms.PictureBox pbWeixin;
        private System.Windows.Forms.Label label7;
    }
}