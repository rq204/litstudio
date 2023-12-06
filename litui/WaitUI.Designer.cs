namespace litui
{
    partial class WaitUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.rbAppear = new System.Windows.Forms.RadioButton();
            this.rbDisAppear = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.rbWaitValue = new System.Windows.Forms.RadioButton();
            this.tbWaitValue = new System.Windows.Forms.TextBox();
            this.ivWaitValue = new litsdk.InsertVarName();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.ivWaitValue);
            this.scActivityUI.Panel1.Controls.Add(this.tbWaitValue);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.nudTimeOut);
            this.scActivityUI.Panel1.Controls.Add(this.rbWaitValue);
            this.scActivityUI.Panel1.Controls.Add(this.rbDisAppear);
            this.scActivityUI.Panel1.Controls.Add(this.rbAppear);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "等待方式";
            // 
            // rbAppear
            // 
            this.rbAppear.AutoSize = true;
            this.rbAppear.Location = new System.Drawing.Point(79, 114);
            this.rbAppear.Name = "rbAppear";
            this.rbAppear.Size = new System.Drawing.Size(71, 16);
            this.rbAppear.TabIndex = 10;
            this.rbAppear.TabStop = true;
            this.rbAppear.Text = "等待出现";
            this.rbAppear.UseVisualStyleBackColor = true;
            // 
            // rbDisAppear
            // 
            this.rbDisAppear.AutoSize = true;
            this.rbDisAppear.Location = new System.Drawing.Point(158, 114);
            this.rbDisAppear.Name = "rbDisAppear";
            this.rbDisAppear.Size = new System.Drawing.Size(71, 16);
            this.rbDisAppear.TabIndex = 10;
            this.rbDisAppear.TabStop = true;
            this.rbDisAppear.Text = "等待消失";
            this.rbDisAppear.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "等待超时";
            // 
            // nudTimeOut
            // 
            this.nudTimeOut.Location = new System.Drawing.Point(77, 147);
            this.nudTimeOut.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.nudTimeOut.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTimeOut.Name = "nudTimeOut";
            this.nudTimeOut.Size = new System.Drawing.Size(84, 21);
            this.nudTimeOut.TabIndex = 11;
            this.nudTimeOut.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "毫秒";
            // 
            // rbWaitValue
            // 
            this.rbWaitValue.AutoSize = true;
            this.rbWaitValue.Location = new System.Drawing.Point(241, 114);
            this.rbWaitValue.Name = "rbWaitValue";
            this.rbWaitValue.Size = new System.Drawing.Size(107, 16);
            this.rbWaitValue.TabIndex = 10;
            this.rbWaitValue.TabStop = true;
            this.rbWaitValue.Text = "等待出现且值为";
            this.rbWaitValue.UseVisualStyleBackColor = true;
            // 
            // tbWaitValue
            // 
            this.tbWaitValue.Location = new System.Drawing.Point(354, 112);
            this.tbWaitValue.Name = "tbWaitValue";
            this.tbWaitValue.Size = new System.Drawing.Size(100, 21);
            this.tbWaitValue.TabIndex = 13;
            // 
            // ivWaitValue
            // 
            this.ivWaitValue.Location = new System.Drawing.Point(461, 114);
            this.ivWaitValue.Name = "ivWaitValue";
            this.ivWaitValue.Size = new System.Drawing.Size(16, 16);
            this.ivWaitValue.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(241, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "超时后将发生异常，请使用异常处理组件";
            // 
            // WaitUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "WaitUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTimeOut;
        private System.Windows.Forms.RadioButton rbDisAppear;
        private System.Windows.Forms.RadioButton rbAppear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbWaitValue;
        private System.Windows.Forms.RadioButton rbWaitValue;
        private litsdk.InsertVarName ivWaitValue;
        private System.Windows.Forms.Label label7;
    }
}
