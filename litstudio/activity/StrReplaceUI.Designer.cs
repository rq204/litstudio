namespace litstudio
{
    partial class StrReplaceUI
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
            this.tbNewStr = new System.Windows.Forms.TextBox();
            this.tbOldStr = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.svStrVarName = new litsdk.SelectVarName();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.svStrSaveVarName = new litsdk.SelectVarName();
            this.cbIsRegex = new System.Windows.Forms.CheckBox();
            this.lbReplaceEmo = new System.Windows.Forms.LinkLabel();
            this.ivOldStr = new litsdk.InsertVarName();
            this.ivNewStr = new litsdk.InsertVarName();
            this.llbTrimInvalName = new System.Windows.Forms.LinkLabel();
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
            this.scActivityUI.Panel1.Controls.Add(this.llbTrimInvalName);
            this.scActivityUI.Panel1.Controls.Add(this.ivNewStr);
            this.scActivityUI.Panel1.Controls.Add(this.ivOldStr);
            this.scActivityUI.Panel1.Controls.Add(this.lbReplaceEmo);
            this.scActivityUI.Panel1.Controls.Add(this.cbIsRegex);
            this.scActivityUI.Panel1.Controls.Add(this.svStrSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.svStrVarName);
            this.scActivityUI.Panel1.Controls.Add(this.tbNewStr);
            this.scActivityUI.Panel1.Controls.Add(this.tbOldStr);
            this.scActivityUI.Panel1.Controls.Add(this.label37);
            this.scActivityUI.Panel1.Controls.Add(this.label17);
            // 
            // tbNewStr
            // 
            this.tbNewStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewStr.Location = new System.Drawing.Point(80, 96);
            this.tbNewStr.Multiline = true;
            this.tbNewStr.Name = "tbNewStr";
            this.tbNewStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbNewStr.Size = new System.Drawing.Size(339, 66);
            this.tbNewStr.TabIndex = 98;
            // 
            // tbOldStr
            // 
            this.tbOldStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOldStr.Location = new System.Drawing.Point(80, 14);
            this.tbOldStr.Multiline = true;
            this.tbOldStr.Name = "tbOldStr";
            this.tbOldStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOldStr.Size = new System.Drawing.Size(339, 66);
            this.tbOldStr.TabIndex = 97;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(31, 97);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 12);
            this.label37.TabIndex = 94;
            this.label37.Text = "替换为";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 95;
            this.label17.Text = "原字符";
            // 
            // svStrVarName
            // 
            this.svStrVarName.Location = new System.Drawing.Point(80, 193);
            this.svStrVarName.Name = "svStrVarName";
            this.svStrVarName.Size = new System.Drawing.Size(145, 23);
            this.svStrVarName.TabIndex = 99;
            this.svStrVarName.VarName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 100;
            this.label2.Text = "操作变量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 100;
            this.label3.Text = "结果保存至";
            // 
            // svStrSaveVarName
            // 
            this.svStrSaveVarName.Location = new System.Drawing.Point(309, 193);
            this.svStrSaveVarName.Name = "svStrSaveVarName";
            this.svStrSaveVarName.Size = new System.Drawing.Size(145, 23);
            this.svStrSaveVarName.TabIndex = 101;
            this.svStrSaveVarName.VarName = "";
            // 
            // cbIsRegex
            // 
            this.cbIsRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIsRegex.AutoSize = true;
            this.cbIsRegex.Location = new System.Drawing.Point(427, 145);
            this.cbIsRegex.Name = "cbIsRegex";
            this.cbIsRegex.Size = new System.Drawing.Size(108, 16);
            this.cbIsRegex.TabIndex = 102;
            this.cbIsRegex.Text = "使用正则表达式";
            this.cbIsRegex.UseVisualStyleBackColor = true;
            this.cbIsRegex.CheckedChanged += new System.EventHandler(this.cbIsRegex_CheckedChanged);
            // 
            // lbReplaceEmo
            // 
            this.lbReplaceEmo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReplaceEmo.AutoSize = true;
            this.lbReplaceEmo.Location = new System.Drawing.Point(425, 68);
            this.lbReplaceEmo.Name = "lbReplaceEmo";
            this.lbReplaceEmo.Size = new System.Drawing.Size(101, 12);
            this.lbReplaceEmo.TabIndex = 103;
            this.lbReplaceEmo.TabStop = true;
            this.lbReplaceEmo.Text = "去除所有表情字符";
            this.lbReplaceEmo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbReplaceEmo_LinkClicked);
            // 
            // ivOldStr
            // 
            this.ivOldStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivOldStr.Location = new System.Drawing.Point(428, 18);
            this.ivOldStr.Name = "ivOldStr";
            this.ivOldStr.Size = new System.Drawing.Size(16, 16);
            this.ivOldStr.TabIndex = 104;
            // 
            // ivNewStr
            // 
            this.ivNewStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivNewStr.Location = new System.Drawing.Point(427, 97);
            this.ivNewStr.Name = "ivNewStr";
            this.ivNewStr.Size = new System.Drawing.Size(16, 16);
            this.ivNewStr.TabIndex = 105;
            // 
            // llbTrimInvalName
            // 
            this.llbTrimInvalName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbTrimInvalName.AutoSize = true;
            this.llbTrimInvalName.Location = new System.Drawing.Point(425, 46);
            this.llbTrimInvalName.Name = "llbTrimInvalName";
            this.llbTrimInvalName.Size = new System.Drawing.Size(101, 12);
            this.llbTrimInvalName.TabIndex = 106;
            this.llbTrimInvalName.TabStop = true;
            this.llbTrimInvalName.Text = "去除非文件名字符";
            this.llbTrimInvalName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTrimInvalName_LinkClicked);
            // 
            // StrReplaceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "StrReplaceUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewStr;
        private System.Windows.Forms.TextBox tbOldStr;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label17;
        private litsdk.SelectVarName svStrVarName;
        private litsdk.SelectVarName svStrSaveVarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbIsRegex;
        private System.Windows.Forms.LinkLabel lbReplaceEmo;
        private litsdk.InsertVarName ivNewStr;
        private litsdk.InsertVarName ivOldStr;
        private System.Windows.Forms.LinkLabel llbTrimInvalName;
    }
}
