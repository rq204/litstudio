namespace litui
{
    partial class ScreenShotUI
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
            this.lbSavePath = new System.Windows.Forms.Label();
            this.svImgSaveVarName = new litsdk.SelectVarName();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPng = new System.Windows.Forms.RadioButton();
            this.rbJpg = new System.Windows.Forms.RadioButton();
            this.rbBmp = new System.Windows.Forms.RadioButton();
            this.cbUseTempPath = new System.Windows.Forms.CheckBox();
            this.cbSaveToClipboard = new System.Windows.Forms.CheckBox();
            this.cbFullScreen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.cbFullScreen);
            this.scActivityUI.Panel1.Controls.Add(this.cbSaveToClipboard);
            this.scActivityUI.Panel1.Controls.Add(this.cbUseTempPath);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.panel1);
            this.scActivityUI.Panel1.Controls.Add(this.svImgSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.lbSavePath);
            // 
            // lbSavePath
            // 
            this.lbSavePath.AutoSize = true;
            this.lbSavePath.Location = new System.Drawing.Point(16, 154);
            this.lbSavePath.Name = "lbSavePath";
            this.lbSavePath.Size = new System.Drawing.Size(53, 12);
            this.lbSavePath.TabIndex = 7;
            this.lbSavePath.Text = "保存路径";
            // 
            // svImgSaveVarName
            // 
            this.svImgSaveVarName.Location = new System.Drawing.Point(79, 150);
            this.svImgSaveVarName.Name = "svImgSaveVarName";
            this.svImgSaveVarName.Size = new System.Drawing.Size(136, 23);
            this.svImgSaveVarName.TabIndex = 8;
            this.svImgSaveVarName.VarName = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "图片格式";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPng);
            this.panel1.Controls.Add(this.rbJpg);
            this.panel1.Controls.Add(this.rbBmp);
            this.panel1.Location = new System.Drawing.Point(79, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 23);
            this.panel1.TabIndex = 10;
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
            // cbUseTempPath
            // 
            this.cbUseTempPath.AutoSize = true;
            this.cbUseTempPath.Location = new System.Drawing.Point(251, 153);
            this.cbUseTempPath.Name = "cbUseTempPath";
            this.cbUseTempPath.Size = new System.Drawing.Size(156, 16);
            this.cbUseTempPath.TabIndex = 12;
            this.cbUseTempPath.Text = "使用系统临时文件名保存";
            this.cbUseTempPath.UseVisualStyleBackColor = true;
            // 
            // cbSaveToClipboard
            // 
            this.cbSaveToClipboard.AutoSize = true;
            this.cbSaveToClipboard.Location = new System.Drawing.Point(342, 120);
            this.cbSaveToClipboard.Name = "cbSaveToClipboard";
            this.cbSaveToClipboard.Size = new System.Drawing.Size(96, 16);
            this.cbSaveToClipboard.TabIndex = 13;
            this.cbSaveToClipboard.Text = "保存至剪切板";
            this.cbSaveToClipboard.UseVisualStyleBackColor = true;
            this.cbSaveToClipboard.CheckedChanged += new System.EventHandler(this.cbSaveToClipboard_CheckedChanged);
            // 
            // cbFullScreen
            // 
            this.cbFullScreen.AutoSize = true;
            this.cbFullScreen.Location = new System.Drawing.Point(251, 120);
            this.cbFullScreen.Name = "cbFullScreen";
            this.cbFullScreen.Size = new System.Drawing.Size(72, 16);
            this.cbFullScreen.TabIndex = 14;
            this.cbFullScreen.Text = "截取全屏";
            this.cbFullScreen.UseVisualStyleBackColor = true;
            // 
            // ScreenShotUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ScreenShotUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSavePath;
        private litsdk.SelectVarName svImgSaveVarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPng;
        private System.Windows.Forms.RadioButton rbJpg;
        private System.Windows.Forms.RadioButton rbBmp;
        private System.Windows.Forms.CheckBox cbUseTempPath;
        private System.Windows.Forms.CheckBox cbSaveToClipboard;
        private System.Windows.Forms.CheckBox cbFullScreen;
    }
}
