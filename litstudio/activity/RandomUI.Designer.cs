namespace litstudio
{
    partial class RandomUI
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
            this.cbNumber = new System.Windows.Forms.CheckBox();
            this.cbLetterLower = new System.Windows.Forms.CheckBox();
            this.cbLetterUpper = new System.Windows.Forms.CheckBox();
            this.cbOther = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.svVarName = new litsdk.SelectVarName();
            this.label5 = new System.Windows.Forms.Label();
            this.numListCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numListCount)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.svVarName);
            this.scActivityUI.Panel1.Controls.Add(this.numListCount);
            this.scActivityUI.Panel1.Controls.Add(this.nudLength);
            this.scActivityUI.Panel1.Controls.Add(this.cbOther);
            this.scActivityUI.Panel1.Controls.Add(this.cbLetterUpper);
            this.scActivityUI.Panel1.Controls.Add(this.cbLetterLower);
            this.scActivityUI.Panel1.Controls.Add(this.cbNumber);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "生成来源";
            // 
            // cbNumber
            // 
            this.cbNumber.AutoSize = true;
            this.cbNumber.Location = new System.Drawing.Point(96, 38);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(78, 16);
            this.cbNumber.TabIndex = 1;
            this.cbNumber.Text = "数字(0-9)";
            this.cbNumber.UseVisualStyleBackColor = true;
            // 
            // cbLetterLower
            // 
            this.cbLetterLower.AutoSize = true;
            this.cbLetterLower.Location = new System.Drawing.Point(182, 38);
            this.cbLetterLower.Name = "cbLetterLower";
            this.cbLetterLower.Size = new System.Drawing.Size(102, 16);
            this.cbLetterLower.TabIndex = 1;
            this.cbLetterLower.Text = "小写字母(a-z)";
            this.cbLetterLower.UseVisualStyleBackColor = true;
            // 
            // cbLetterUpper
            // 
            this.cbLetterUpper.AutoSize = true;
            this.cbLetterUpper.Location = new System.Drawing.Point(290, 38);
            this.cbLetterUpper.Name = "cbLetterUpper";
            this.cbLetterUpper.Size = new System.Drawing.Size(102, 16);
            this.cbLetterUpper.TabIndex = 1;
            this.cbLetterUpper.Text = "大写字母(A-Z)";
            this.cbLetterUpper.UseVisualStyleBackColor = true;
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.Location = new System.Drawing.Point(398, 38);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(144, 16);
            this.cbOther.TabIndex = 1;
            this.cbOther.Text = "其它字符(非空白字符)";
            this.cbOther.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "生成长度";
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(96, 81);
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(63, 21);
            this.nudLength.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "存入变量";
            // 
            // svVarName
            // 
            this.svVarName.Location = new System.Drawing.Point(96, 125);
            this.svVarName.Name = "svVarName";
            this.svVarName.Size = new System.Drawing.Size(166, 23);
            this.svVarName.TabIndex = 3;
            this.svVarName.VarName = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "生成个数";
            // 
            // numListCount
            // 
            this.numListCount.Location = new System.Drawing.Point(96, 170);
            this.numListCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numListCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numListCount.Name = "numListCount";
            this.numListCount.Size = new System.Drawing.Size(63, 21);
            this.numListCount.TabIndex = 2;
            this.numListCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(180, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "当保存为列表变量时，需要指定生成的元素个数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(180, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "当生成结果存入数字变量时，生成来源可以为空";
            // 
            // RandomUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RandomUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numListCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private litsdk.SelectVarName svVarName;
        private System.Windows.Forms.NumericUpDown numListCount;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.CheckBox cbOther;
        private System.Windows.Forms.CheckBox cbLetterUpper;
        private System.Windows.Forms.CheckBox cbLetterLower;
        private System.Windows.Forms.CheckBox cbNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}
