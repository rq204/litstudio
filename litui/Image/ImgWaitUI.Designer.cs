namespace litui
{
    partial class ImgWaitUI
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
            this.label7 = new System.Windows.Forms.Label();
            this.rbApper = new System.Windows.Forms.RadioButton();
            this.rbDisApper = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.label9);
            this.scActivityUI.Panel1.Controls.Add(this.nudTimeOut);
            this.scActivityUI.Panel1.Controls.Add(this.label10);
            this.scActivityUI.Panel1.Controls.Add(this.rbDisApper);
            this.scActivityUI.Panel1.Controls.Add(this.rbApper);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "等待方式";
            // 
            // rbApper
            // 
            this.rbApper.AutoSize = true;
            this.rbApper.Location = new System.Drawing.Point(98, 103);
            this.rbApper.Name = "rbApper";
            this.rbApper.Size = new System.Drawing.Size(71, 16);
            this.rbApper.TabIndex = 19;
            this.rbApper.TabStop = true;
            this.rbApper.Text = "等待出现";
            this.rbApper.UseVisualStyleBackColor = true;
            // 
            // rbDisApper
            // 
            this.rbDisApper.AutoSize = true;
            this.rbDisApper.Location = new System.Drawing.Point(188, 103);
            this.rbDisApper.Name = "rbDisApper";
            this.rbDisApper.Size = new System.Drawing.Size(71, 16);
            this.rbDisApper.TabIndex = 19;
            this.rbDisApper.TabStop = true;
            this.rbDisApper.Text = "等待消失";
            this.rbDisApper.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(248, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "超时后将发生异常，请使用异常处理组件";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "毫秒";
            // 
            // nudTimeOut
            // 
            this.nudTimeOut.Location = new System.Drawing.Point(98, 133);
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
            this.nudTimeOut.TabIndex = 21;
            this.nudTimeOut.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "等待超时";
            // 
            // ImgWaitUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ImgWaitUI";
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

        private System.Windows.Forms.RadioButton rbDisApper;
        private System.Windows.Forms.RadioButton rbApper;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudTimeOut;
        private System.Windows.Forms.Label label10;
    }
}
