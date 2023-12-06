namespace litui
{
    partial class ImageCutUI
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
            this.svSourceVarName = new litsdk.SelectVarName();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.cbSaveTempPath = new System.Windows.Forms.CheckBox();
            this.cbUseImg = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBasePoint = new System.Windows.Forms.TextBox();
            this.tbCutSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbLeftTop = new System.Windows.Forms.RadioButton();
            this.rbRightBottom = new System.Windows.Forms.RadioButton();
            this.rbLeftBottom = new System.Windows.Forms.RadioButton();
            this.rbRightTop = new System.Windows.Forms.RadioButton();
            this.ivBasePoint = new litsdk.InsertVarName();
            this.ivCutSize = new litsdk.InsertVarName();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPng = new System.Windows.Forms.RadioButton();
            this.rbJpg = new System.Windows.Forms.RadioButton();
            this.rbBmp = new System.Windows.Forms.RadioButton();
            this.llbSelectUI = new System.Windows.Forms.LinkLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudSimilarity = new System.Windows.Forms.NumericUpDown();
            this.lbSimplie = new System.Windows.Forms.Label();
            this.pImage = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimilarity)).BeginInit();
            this.pImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.pImage);
            this.scActivityUI.Panel1.Controls.Add(this.llbSelectUI);
            this.scActivityUI.Panel1.Controls.Add(this.pbImage);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.panel1);
            this.scActivityUI.Panel1.Controls.Add(this.ivCutSize);
            this.scActivityUI.Panel1.Controls.Add(this.ivBasePoint);
            this.scActivityUI.Panel1.Controls.Add(this.rbLeftBottom);
            this.scActivityUI.Panel1.Controls.Add(this.rbRightBottom);
            this.scActivityUI.Panel1.Controls.Add(this.rbRightTop);
            this.scActivityUI.Panel1.Controls.Add(this.rbLeftTop);
            this.scActivityUI.Panel1.Controls.Add(this.tbCutSize);
            this.scActivityUI.Panel1.Controls.Add(this.tbBasePoint);
            this.scActivityUI.Panel1.Controls.Add(this.cbUseImg);
            this.scActivityUI.Panel1.Controls.Add(this.cbSaveTempPath);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.svSourceVarName);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "源图片";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "新图片";
            // 
            // svSourceVarName
            // 
            this.svSourceVarName.Location = new System.Drawing.Point(80, 12);
            this.svSourceVarName.Name = "svSourceVarName";
            this.svSourceVarName.Size = new System.Drawing.Size(125, 23);
            this.svSourceVarName.TabIndex = 1;
            this.svSourceVarName.VarName = "";
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(80, 151);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(125, 23);
            this.svSaveVarName.TabIndex = 2;
            this.svSaveVarName.VarName = "";
            // 
            // cbSaveTempPath
            // 
            this.cbSaveTempPath.AutoSize = true;
            this.cbSaveTempPath.Location = new System.Drawing.Point(234, 152);
            this.cbSaveTempPath.Name = "cbSaveTempPath";
            this.cbSaveTempPath.Size = new System.Drawing.Size(120, 16);
            this.cbSaveTempPath.TabIndex = 3;
            this.cbSaveTempPath.Text = "使用系统临时文件";
            this.cbSaveTempPath.UseVisualStyleBackColor = true;
            // 
            // cbUseImg
            // 
            this.cbUseImg.AutoSize = true;
            this.cbUseImg.Location = new System.Drawing.Point(234, 13);
            this.cbUseImg.Name = "cbUseImg";
            this.cbUseImg.Size = new System.Drawing.Size(144, 16);
            this.cbUseImg.TabIndex = 3;
            this.cbUseImg.Text = "使用图片定位基点坐标";
            this.cbUseImg.UseVisualStyleBackColor = true;
            this.cbUseImg.CheckedChanged += new System.EventHandler(this.cbUseImg_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "截图大小";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "基点坐标";
            // 
            // tbBasePoint
            // 
            this.tbBasePoint.Location = new System.Drawing.Point(80, 48);
            this.tbBasePoint.Name = "tbBasePoint";
            this.tbBasePoint.Size = new System.Drawing.Size(100, 21);
            this.tbBasePoint.TabIndex = 4;
            this.tbBasePoint.Text = "0,0";
            // 
            // tbCutSize
            // 
            this.tbCutSize.Location = new System.Drawing.Point(80, 80);
            this.tbCutSize.Name = "tbCutSize";
            this.tbCutSize.Size = new System.Drawing.Size(100, 21);
            this.tbCutSize.TabIndex = 4;
            this.tbCutSize.Text = "100,100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "截图方向";
            // 
            // rbLeftTop
            // 
            this.rbLeftTop.AutoSize = true;
            this.rbLeftTop.Location = new System.Drawing.Point(293, 82);
            this.rbLeftTop.Name = "rbLeftTop";
            this.rbLeftTop.Size = new System.Drawing.Size(47, 16);
            this.rbLeftTop.TabIndex = 5;
            this.rbLeftTop.TabStop = true;
            this.rbLeftTop.Text = "左上";
            this.rbLeftTop.UseVisualStyleBackColor = true;
            // 
            // rbRightBottom
            // 
            this.rbRightBottom.AutoSize = true;
            this.rbRightBottom.Location = new System.Drawing.Point(462, 82);
            this.rbRightBottom.Name = "rbRightBottom";
            this.rbRightBottom.Size = new System.Drawing.Size(47, 16);
            this.rbRightBottom.TabIndex = 5;
            this.rbRightBottom.TabStop = true;
            this.rbRightBottom.Text = "右下";
            this.rbRightBottom.UseVisualStyleBackColor = true;
            // 
            // rbLeftBottom
            // 
            this.rbLeftBottom.AutoSize = true;
            this.rbLeftBottom.Location = new System.Drawing.Point(412, 82);
            this.rbLeftBottom.Name = "rbLeftBottom";
            this.rbLeftBottom.Size = new System.Drawing.Size(47, 16);
            this.rbLeftBottom.TabIndex = 5;
            this.rbLeftBottom.TabStop = true;
            this.rbLeftBottom.Text = "左下";
            this.rbLeftBottom.UseVisualStyleBackColor = true;
            // 
            // rbRightTop
            // 
            this.rbRightTop.AutoSize = true;
            this.rbRightTop.Location = new System.Drawing.Point(353, 82);
            this.rbRightTop.Name = "rbRightTop";
            this.rbRightTop.Size = new System.Drawing.Size(47, 16);
            this.rbRightTop.TabIndex = 5;
            this.rbRightTop.TabStop = true;
            this.rbRightTop.Text = "右上";
            this.rbRightTop.UseVisualStyleBackColor = true;
            // 
            // ivBasePoint
            // 
            this.ivBasePoint.Location = new System.Drawing.Point(183, 50);
            this.ivBasePoint.Name = "ivBasePoint";
            this.ivBasePoint.Size = new System.Drawing.Size(16, 16);
            this.ivBasePoint.TabIndex = 6;
            // 
            // ivCutSize
            // 
            this.ivCutSize.Location = new System.Drawing.Point(182, 83);
            this.ivCutSize.Name = "ivCutSize";
            this.ivCutSize.Size = new System.Drawing.Size(16, 16);
            this.ivCutSize.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "新图格式";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPng);
            this.panel1.Controls.Add(this.rbJpg);
            this.panel1.Controls.Add(this.rbBmp);
            this.panel1.Location = new System.Drawing.Point(79, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 23);
            this.panel1.TabIndex = 9;
            // 
            // rbPng
            // 
            this.rbPng.AutoSize = true;
            this.rbPng.Location = new System.Drawing.Point(4, 4);
            this.rbPng.Name = "rbPng";
            this.rbPng.Size = new System.Drawing.Size(41, 16);
            this.rbPng.TabIndex = 1;
            this.rbPng.TabStop = true;
            this.rbPng.Text = "png";
            this.rbPng.UseVisualStyleBackColor = true;
            // 
            // rbJpg
            // 
            this.rbJpg.AutoSize = true;
            this.rbJpg.Location = new System.Drawing.Point(51, 4);
            this.rbJpg.Name = "rbJpg";
            this.rbJpg.Size = new System.Drawing.Size(41, 16);
            this.rbJpg.TabIndex = 1;
            this.rbJpg.TabStop = true;
            this.rbJpg.Text = "jpg";
            this.rbJpg.UseVisualStyleBackColor = true;
            // 
            // rbBmp
            // 
            this.rbBmp.AutoSize = true;
            this.rbBmp.Location = new System.Drawing.Point(98, 4);
            this.rbBmp.Name = "rbBmp";
            this.rbBmp.Size = new System.Drawing.Size(41, 16);
            this.rbBmp.TabIndex = 1;
            this.rbBmp.TabStop = true;
            this.rbBmp.Text = "bmp";
            this.rbBmp.UseVisualStyleBackColor = true;
            // 
            // llbSelectUI
            // 
            this.llbSelectUI.AutoSize = true;
            this.llbSelectUI.Location = new System.Drawing.Point(426, 34);
            this.llbSelectUI.Name = "llbSelectUI";
            this.llbSelectUI.Size = new System.Drawing.Size(53, 12);
            this.llbSelectUI.TabIndex = 12;
            this.llbSelectUI.TabStop = true;
            this.llbSelectUI.Text = "选择图像";
            this.llbSelectUI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSelectUI_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(386, 6);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(137, 63);
            this.pbImage.TabIndex = 13;
            this.pbImage.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "%";
            // 
            // nudSimilarity
            // 
            this.nudSimilarity.Location = new System.Drawing.Point(53, 3);
            this.nudSimilarity.Name = "nudSimilarity";
            this.nudSimilarity.Size = new System.Drawing.Size(71, 21);
            this.nudSimilarity.TabIndex = 17;
            this.nudSimilarity.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // lbSimplie
            // 
            this.lbSimplie.AutoSize = true;
            this.lbSimplie.Location = new System.Drawing.Point(6, 7);
            this.lbSimplie.Name = "lbSimplie";
            this.lbSimplie.Size = new System.Drawing.Size(41, 12);
            this.lbSimplie.TabIndex = 16;
            this.lbSimplie.Text = "相似度";
            // 
            // pImage
            // 
            this.pImage.Controls.Add(this.nudSimilarity);
            this.pImage.Controls.Add(this.label8);
            this.pImage.Controls.Add(this.lbSimplie);
            this.pImage.Location = new System.Drawing.Point(231, 43);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(147, 27);
            this.pImage.TabIndex = 19;
            // 
            // ImageCutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ImageCutUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimilarity)).EndInit();
            this.pImage.ResumeLayout(false);
            this.pImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private litsdk.SelectVarName svSaveVarName;
        private litsdk.SelectVarName svSourceVarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbSaveTempPath;
        private System.Windows.Forms.CheckBox cbUseImg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCutSize;
        private System.Windows.Forms.TextBox tbBasePoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbLeftBottom;
        private System.Windows.Forms.RadioButton rbRightBottom;
        private System.Windows.Forms.RadioButton rbRightTop;
        private System.Windows.Forms.RadioButton rbLeftTop;
        private System.Windows.Forms.Label label7;
        private litsdk.InsertVarName ivCutSize;
        private litsdk.InsertVarName ivBasePoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPng;
        private System.Windows.Forms.RadioButton rbJpg;
        private System.Windows.Forms.RadioButton rbBmp;
        private System.Windows.Forms.LinkLabel llbSelectUI;
        internal System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudSimilarity;
        private System.Windows.Forms.Label lbSimplie;
        private System.Windows.Forms.Panel pImage;
    }
}
