namespace litui
{
    partial class ImageBase
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
            this.llbSelectUI = new System.Windows.Forms.LinkLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbIsFullScreen = new System.Windows.Forms.RadioButton();
            this.rbIsActivite = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSimilarity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudRowNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMoveX = new System.Windows.Forms.TextBox();
            this.tbMoveY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimilarity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowNum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.label9);
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.tbMoveY);
            this.scActivityUI.Panel1.Controls.Add(this.tbMoveX);
            this.scActivityUI.Panel1.Controls.Add(this.panel1);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.nudRowNum);
            this.scActivityUI.Panel1.Controls.Add(this.nudSimilarity);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.llbSelectUI);
            this.scActivityUI.Panel1.Controls.Add(this.pbImage);
            // 
            // llbSelectUI
            // 
            this.llbSelectUI.AutoSize = true;
            this.llbSelectUI.Location = new System.Drawing.Point(72, 40);
            this.llbSelectUI.Name = "llbSelectUI";
            this.llbSelectUI.Size = new System.Drawing.Size(53, 12);
            this.llbSelectUI.TabIndex = 10;
            this.llbSelectUI.TabStop = true;
            this.llbSelectUI.Text = "选择图像";
            this.llbSelectUI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSelectUI_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(34, 8);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(137, 74);
            this.pbImage.TabIndex = 11;
            this.pbImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "搜索范围";
            // 
            // rbIsFullScreen
            // 
            this.rbIsFullScreen.AutoSize = true;
            this.rbIsFullScreen.Location = new System.Drawing.Point(4, 5);
            this.rbIsFullScreen.Name = "rbIsFullScreen";
            this.rbIsFullScreen.Size = new System.Drawing.Size(71, 16);
            this.rbIsFullScreen.TabIndex = 13;
            this.rbIsFullScreen.TabStop = true;
            this.rbIsFullScreen.Text = "整个屏幕";
            this.rbIsFullScreen.UseVisualStyleBackColor = true;
            // 
            // rbIsActivite
            // 
            this.rbIsActivite.AutoSize = true;
            this.rbIsActivite.Location = new System.Drawing.Point(122, 5);
            this.rbIsActivite.Name = "rbIsActivite";
            this.rbIsActivite.Size = new System.Drawing.Size(95, 16);
            this.rbIsActivite.TabIndex = 13;
            this.rbIsActivite.TabStop = true;
            this.rbIsActivite.Text = "当前激活窗体";
            this.rbIsActivite.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "相似度";
            // 
            // nudSimilarity
            // 
            this.nudSimilarity.Location = new System.Drawing.Point(253, 56);
            this.nudSimilarity.Name = "nudSimilarity";
            this.nudSimilarity.Size = new System.Drawing.Size(71, 21);
            this.nudSimilarity.TabIndex = 14;
            this.nudSimilarity.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "多图取第";
            this.label5.Visible = false;
            // 
            // nudRowNum
            // 
            this.nudRowNum.Location = new System.Drawing.Point(104, 55);
            this.nudRowNum.Name = "nudRowNum";
            this.nudRowNum.Size = new System.Drawing.Size(41, 21);
            this.nudRowNum.TabIndex = 14;
            this.nudRowNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRowNum.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "个";
            this.label6.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbIsActivite);
            this.panel1.Controls.Add(this.rbIsFullScreen);
            this.panel1.Location = new System.Drawing.Point(250, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 28);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "位置偏移";
            // 
            // tbMoveX
            // 
            this.tbMoveX.Location = new System.Drawing.Point(444, 54);
            this.tbMoveX.Name = "tbMoveX";
            this.tbMoveX.Size = new System.Drawing.Size(38, 21);
            this.tbMoveX.TabIndex = 18;
            // 
            // tbMoveY
            // 
            this.tbMoveY.Location = new System.Drawing.Point(502, 54);
            this.tbMoveY.Name = "tbMoveY";
            this.tbMoveY.Size = new System.Drawing.Size(38, 21);
            this.tbMoveY.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "Y";
            // 
            // ImageBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ImageBase";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimilarity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowNum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel llbSelectUI;
        internal System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.RadioButton rbIsActivite;
        private System.Windows.Forms.RadioButton rbIsFullScreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSimilarity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRowNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMoveY;
        private System.Windows.Forms.TextBox tbMoveX;
        private System.Windows.Forms.Label label7;
    }
}
