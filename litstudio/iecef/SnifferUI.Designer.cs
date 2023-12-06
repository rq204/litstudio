namespace litstudio.iecef
{
    partial class SnifferUI
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
            this.lbUrls = new System.Windows.Forms.Label();
            this.tbUrls = new System.Windows.Forms.TextBox();
            this.cbUseRegex = new System.Windows.Forms.CheckBox();
            this.lbOptName = new System.Windows.Forms.Label();
            this.svDataVarName = new litsdk.SelectVarName();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDataIsFile = new System.Windows.Forms.CheckBox();
            this.lbencoding = new System.Windows.Forms.Label();
            this.cbEncoding = new System.Windows.Forms.ComboBox();
            this.ivUrls = new litsdk.InsertVarName();
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
            this.scActivityUI.Panel1.Controls.Add(this.ivUrls);
            this.scActivityUI.Panel1.Controls.Add(this.lbencoding);
            this.scActivityUI.Panel1.Controls.Add(this.cbDataIsFile);
            this.scActivityUI.Panel1.Controls.Add(this.cbEncoding);
            this.scActivityUI.Panel1.Controls.Add(this.svDataVarName);
            this.scActivityUI.Panel1.Controls.Add(this.cbUseRegex);
            this.scActivityUI.Panel1.Controls.Add(this.tbUrls);
            this.scActivityUI.Panel1.Controls.Add(this.lbUrls);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.lbOptName);
            // 
            // lbUrls
            // 
            this.lbUrls.AutoSize = true;
            this.lbUrls.Location = new System.Drawing.Point(18, 17);
            this.lbUrls.Name = "lbUrls";
            this.lbUrls.Size = new System.Drawing.Size(53, 24);
            this.lbUrls.TabIndex = 0;
            this.lbUrls.Text = "网址匹配\r\n一行一条\r\n";
            // 
            // tbUrls
            // 
            this.tbUrls.Location = new System.Drawing.Point(79, 17);
            this.tbUrls.Multiline = true;
            this.tbUrls.Name = "tbUrls";
            this.tbUrls.Size = new System.Drawing.Size(380, 83);
            this.tbUrls.TabIndex = 2;
            // 
            // cbUseRegex
            // 
            this.cbUseRegex.AutoSize = true;
            this.cbUseRegex.Location = new System.Drawing.Point(479, 84);
            this.cbUseRegex.Name = "cbUseRegex";
            this.cbUseRegex.Size = new System.Drawing.Size(72, 16);
            this.cbUseRegex.TabIndex = 3;
            this.cbUseRegex.Text = "使用正则";
            this.cbUseRegex.UseVisualStyleBackColor = true;
            // 
            // lbOptName
            // 
            this.lbOptName.AutoSize = true;
            this.lbOptName.Location = new System.Drawing.Point(18, 125);
            this.lbOptName.Name = "lbOptName";
            this.lbOptName.Size = new System.Drawing.Size(53, 12);
            this.lbOptName.TabIndex = 0;
            this.lbOptName.Text = "保存变量";
            // 
            // svDataVarName
            // 
            this.svDataVarName.Location = new System.Drawing.Point(79, 121);
            this.svDataVarName.Name = "svDataVarName";
            this.svDataVarName.Size = new System.Drawing.Size(146, 23);
            this.svDataVarName.TabIndex = 4;
            this.svDataVarName.VarName = "";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(331, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 71);
            this.label5.TabIndex = 0;
            this.label5.Text = "数据缓存是将符合条件的请求返回数据保存至表格变量，表头为访问网址，缓存数据，数据大小。当选择保存为文件时，缓存数据是文件地址（系统临时文件），否则是按指定编码解析" +
    "后的字符串。";
            // 
            // cbDataIsFile
            // 
            this.cbDataIsFile.AutoSize = true;
            this.cbDataIsFile.Location = new System.Drawing.Point(237, 125);
            this.cbDataIsFile.Name = "cbDataIsFile";
            this.cbDataIsFile.Size = new System.Drawing.Size(84, 16);
            this.cbDataIsFile.TabIndex = 8;
            this.cbDataIsFile.Text = "保存为文件";
            this.cbDataIsFile.UseVisualStyleBackColor = true;
            this.cbDataIsFile.CheckedChanged += new System.EventHandler(this.cbDataIsFile_CheckedChanged);
            // 
            // lbencoding
            // 
            this.lbencoding.AutoSize = true;
            this.lbencoding.Location = new System.Drawing.Point(18, 163);
            this.lbencoding.Name = "lbencoding";
            this.lbencoding.Size = new System.Drawing.Size(53, 12);
            this.lbencoding.TabIndex = 6;
            this.lbencoding.Text = "网页编码";
            // 
            // cbEncoding
            // 
            this.cbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.Location = new System.Drawing.Point(79, 159);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(117, 20);
            this.cbEncoding.TabIndex = 7;
            // 
            // ivUrls
            // 
            this.ivUrls.Location = new System.Drawing.Point(479, 17);
            this.ivUrls.Name = "ivUrls";
            this.ivUrls.Size = new System.Drawing.Size(16, 16);
            this.ivUrls.TabIndex = 9;
            // 
            // MBSnifferUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MBSnifferUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private litsdk.SelectVarName svDataVarName;
        private System.Windows.Forms.CheckBox cbUseRegex;
        private System.Windows.Forms.TextBox tbUrls;
        private System.Windows.Forms.Label lbUrls;
        private System.Windows.Forms.Label lbOptName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbencoding;
        private System.Windows.Forms.ComboBox cbEncoding;
        private System.Windows.Forms.CheckBox cbDataIsFile;
        private litsdk.InsertVarName ivUrls;
    }
}
