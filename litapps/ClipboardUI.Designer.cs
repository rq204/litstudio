namespace litapps
{
    partial class ClipboardUI
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
            this.rbSetStrToClipboard = new System.Windows.Forms.RadioButton();
            this.rbGetStrFromClipboard = new System.Windows.Forms.RadioButton();
            this.lbSetGet = new System.Windows.Forms.Label();
            this.svStrVarName = new litsdk.SelectVarName();
            this.rbSetFileToClipboard = new System.Windows.Forms.RadioButton();
            this.rbSaveImageFromClipboard = new System.Windows.Forms.RadioButton();
            this.rbSetImageToClipboard = new System.Windows.Forms.RadioButton();
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
            this.scActivityUI.Panel1.Controls.Add(this.rbSetImageToClipboard);
            this.scActivityUI.Panel1.Controls.Add(this.rbSetFileToClipboard);
            this.scActivityUI.Panel1.Controls.Add(this.rbSaveImageFromClipboard);
            this.scActivityUI.Panel1.Controls.Add(this.svStrVarName);
            this.scActivityUI.Panel1.Controls.Add(this.rbGetStrFromClipboard);
            this.scActivityUI.Panel1.Controls.Add(this.rbSetStrToClipboard);
            this.scActivityUI.Panel1.Controls.Add(this.lbSetGet);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "操作类型";
            // 
            // rbSetStrToClipboard
            // 
            this.rbSetStrToClipboard.AutoSize = true;
            this.rbSetStrToClipboard.Location = new System.Drawing.Point(94, 18);
            this.rbSetStrToClipboard.Name = "rbSetStrToClipboard";
            this.rbSetStrToClipboard.Size = new System.Drawing.Size(119, 16);
            this.rbSetStrToClipboard.TabIndex = 1;
            this.rbSetStrToClipboard.TabStop = true;
            this.rbSetStrToClipboard.Text = "设置文本到剪贴板";
            this.rbSetStrToClipboard.UseVisualStyleBackColor = true;
            this.rbSetStrToClipboard.CheckedChanged += new System.EventHandler(this.rbSet_CheckedChanged);
            // 
            // rbGetStrFromClipboard
            // 
            this.rbGetStrFromClipboard.AutoSize = true;
            this.rbGetStrFromClipboard.Location = new System.Drawing.Point(94, 55);
            this.rbGetStrFromClipboard.Name = "rbGetStrFromClipboard";
            this.rbGetStrFromClipboard.Size = new System.Drawing.Size(107, 16);
            this.rbGetStrFromClipboard.TabIndex = 1;
            this.rbGetStrFromClipboard.TabStop = true;
            this.rbGetStrFromClipboard.Text = "获取剪贴板文本";
            this.rbGetStrFromClipboard.UseVisualStyleBackColor = true;
            this.rbGetStrFromClipboard.CheckedChanged += new System.EventHandler(this.rbGet_CheckedChanged);
            // 
            // lbSetGet
            // 
            this.lbSetGet.AutoSize = true;
            this.lbSetGet.Location = new System.Drawing.Point(10, 112);
            this.lbSetGet.Name = "lbSetGet";
            this.lbSetGet.Size = new System.Drawing.Size(65, 12);
            this.lbSetGet.TabIndex = 0;
            this.lbSetGet.Text = "保存至变量";
            // 
            // svStrVarName
            // 
            this.svStrVarName.Location = new System.Drawing.Point(94, 107);
            this.svStrVarName.Name = "svStrVarName";
            this.svStrVarName.Size = new System.Drawing.Size(159, 23);
            this.svStrVarName.TabIndex = 2;
            this.svStrVarName.VarName = "";
            // 
            // rbSetFileToClipboard
            // 
            this.rbSetFileToClipboard.AutoSize = true;
            this.rbSetFileToClipboard.Location = new System.Drawing.Point(230, 18);
            this.rbSetFileToClipboard.Name = "rbSetFileToClipboard";
            this.rbSetFileToClipboard.Size = new System.Drawing.Size(119, 16);
            this.rbSetFileToClipboard.TabIndex = 3;
            this.rbSetFileToClipboard.TabStop = true;
            this.rbSetFileToClipboard.Text = "设置文件到剪贴板";
            this.rbSetFileToClipboard.UseVisualStyleBackColor = true;
            this.rbSetFileToClipboard.CheckedChanged += new System.EventHandler(this.rbSet_CheckedChanged);
            // 
            // rbSaveImageFromClipboard
            // 
            this.rbSaveImageFromClipboard.AutoSize = true;
            this.rbSaveImageFromClipboard.Location = new System.Drawing.Point(230, 55);
            this.rbSaveImageFromClipboard.Name = "rbSaveImageFromClipboard";
            this.rbSaveImageFromClipboard.Size = new System.Drawing.Size(143, 16);
            this.rbSaveImageFromClipboard.TabIndex = 3;
            this.rbSaveImageFromClipboard.TabStop = true;
            this.rbSaveImageFromClipboard.Text = "保存剪贴板图片至文件";
            this.rbSaveImageFromClipboard.UseVisualStyleBackColor = true;
            this.rbSaveImageFromClipboard.CheckedChanged += new System.EventHandler(this.rbGet_CheckedChanged);
            // 
            // rbSetImageToClipboard
            // 
            this.rbSetImageToClipboard.AutoSize = true;
            this.rbSetImageToClipboard.Location = new System.Drawing.Point(389, 20);
            this.rbSetImageToClipboard.Name = "rbSetImageToClipboard";
            this.rbSetImageToClipboard.Size = new System.Drawing.Size(119, 16);
            this.rbSetImageToClipboard.TabIndex = 3;
            this.rbSetImageToClipboard.TabStop = true;
            this.rbSetImageToClipboard.Text = "设置图片到剪贴板";
            this.rbSetImageToClipboard.UseVisualStyleBackColor = true;
            this.rbSetImageToClipboard.CheckedChanged += new System.EventHandler(this.rbSet_CheckedChanged);
            // 
            // ClipboardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ClipboardUI";
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
        private System.Windows.Forms.RadioButton rbGetStrFromClipboard;
        private System.Windows.Forms.RadioButton rbSetStrToClipboard;
        private System.Windows.Forms.Label lbSetGet;
        private litsdk.SelectVarName svStrVarName;
        private System.Windows.Forms.RadioButton rbSetImageToClipboard;
        private System.Windows.Forms.RadioButton rbSetFileToClipboard;
        private System.Windows.Forms.RadioButton rbSaveImageFromClipboard;
    }
}
