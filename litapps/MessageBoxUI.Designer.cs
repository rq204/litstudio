namespace litapps
{
    partial class MessageBoxUI
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
            this.tbCaption = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.ivCaption = new litsdk.InsertVarName();
            this.ivText = new litsdk.InsertVarName();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbInformation = new System.Windows.Forms.RadioButton();
            this.rbWarning = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.nudTimeOutSeconds = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOutSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.nudTimeOutSeconds);
            this.scActivityUI.Panel1.Controls.Add(this.rbError);
            this.scActivityUI.Panel1.Controls.Add(this.rbWarning);
            this.scActivityUI.Panel1.Controls.Add(this.rbInformation);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.ivText);
            this.scActivityUI.Panel1.Controls.Add(this.ivCaption);
            this.scActivityUI.Panel1.Controls.Add(this.tbText);
            this.scActivityUI.Panel1.Controls.Add(this.tbCaption);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
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
            this.label2.Text = "弹窗标题";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "弹窗内容";
            // 
            // tbCaption
            // 
            this.tbCaption.Location = new System.Drawing.Point(83, 20);
            this.tbCaption.Name = "tbCaption";
            this.tbCaption.Size = new System.Drawing.Size(401, 21);
            this.tbCaption.TabIndex = 1;
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(82, 57);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(402, 69);
            this.tbText.TabIndex = 1;
            // 
            // ivCaption
            // 
            this.ivCaption.Location = new System.Drawing.Point(491, 22);
            this.ivCaption.Name = "ivCaption";
            this.ivCaption.Size = new System.Drawing.Size(16, 16);
            this.ivCaption.TabIndex = 2;
            // 
            // ivText
            // 
            this.ivText.Location = new System.Drawing.Point(491, 57);
            this.ivText.Name = "ivText";
            this.ivText.Size = new System.Drawing.Size(16, 16);
            this.ivText.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(35, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(515, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "弹窗有两个选项，确认和取消，确认为True。超时关闭设置大于0时起效，超时后的结果为取消。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "提示方式";
            // 
            // rbInformation
            // 
            this.rbInformation.AutoSize = true;
            this.rbInformation.Location = new System.Drawing.Point(83, 142);
            this.rbInformation.Name = "rbInformation";
            this.rbInformation.Size = new System.Drawing.Size(47, 16);
            this.rbInformation.TabIndex = 4;
            this.rbInformation.TabStop = true;
            this.rbInformation.Text = "提示";
            this.rbInformation.UseVisualStyleBackColor = true;
            // 
            // rbWarning
            // 
            this.rbWarning.AutoSize = true;
            this.rbWarning.Location = new System.Drawing.Point(135, 142);
            this.rbWarning.Name = "rbWarning";
            this.rbWarning.Size = new System.Drawing.Size(47, 16);
            this.rbWarning.TabIndex = 4;
            this.rbWarning.TabStop = true;
            this.rbWarning.Text = "警告";
            this.rbWarning.UseVisualStyleBackColor = true;
            // 
            // rbError
            // 
            this.rbError.AutoSize = true;
            this.rbError.Location = new System.Drawing.Point(188, 142);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(47, 16);
            this.rbError.TabIndex = 4;
            this.rbError.TabStop = true;
            this.rbError.Text = "错误";
            this.rbError.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "超时关闭（秒）";
            // 
            // nudTimeOutSeconds
            // 
            this.nudTimeOutSeconds.Location = new System.Drawing.Point(425, 140);
            this.nudTimeOutSeconds.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.nudTimeOutSeconds.Name = "nudTimeOutSeconds";
            this.nudTimeOutSeconds.Size = new System.Drawing.Size(59, 21);
            this.nudTimeOutSeconds.TabIndex = 5;
            // 
            // MessageBoxUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MessageBoxUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOutSeconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCaption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbText;
        private litsdk.InsertVarName ivText;
        private litsdk.InsertVarName ivCaption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.RadioButton rbWarning;
        private System.Windows.Forms.RadioButton rbInformation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudTimeOutSeconds;
        private System.Windows.Forms.Label label6;
    }
}
