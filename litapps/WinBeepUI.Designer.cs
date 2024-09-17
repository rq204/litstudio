namespace litapps
{
    partial class WinBeepUI
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
            this.rbBeep = new System.Windows.Forms.RadioButton();
            this.rbAsterisk = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPlayTimes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.nudPlayTimes);
            this.scActivityUI.Panel1.Controls.Add(this.rbAsterisk);
            this.scActivityUI.Panel1.Controls.Add(this.rbBeep);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "播放系统声音";
            // 
            // rbBeep
            // 
            this.rbBeep.AutoSize = true;
            this.rbBeep.Location = new System.Drawing.Point(119, 20);
            this.rbBeep.Name = "rbBeep";
            this.rbBeep.Size = new System.Drawing.Size(59, 16);
            this.rbBeep.TabIndex = 1;
            this.rbBeep.TabStop = true;
            this.rbBeep.Text = "蜂鸣声";
            this.rbBeep.UseVisualStyleBackColor = true;
            // 
            // rbAsterisk
            // 
            this.rbAsterisk.AutoSize = true;
            this.rbAsterisk.Location = new System.Drawing.Point(196, 21);
            this.rbAsterisk.Name = "rbAsterisk";
            this.rbAsterisk.Size = new System.Drawing.Size(83, 16);
            this.rbAsterisk.TabIndex = 1;
            this.rbAsterisk.TabStop = true;
            this.rbAsterisk.Text = "系统提示声";
            this.rbAsterisk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "声音播放次数";
            // 
            // nudPlayTimes
            // 
            this.nudPlayTimes.Location = new System.Drawing.Point(119, 60);
            this.nudPlayTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlayTimes.Name = "nudPlayTimes";
            this.nudPlayTimes.Size = new System.Drawing.Size(88, 21);
            this.nudPlayTimes.TabIndex = 2;
            this.nudPlayTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WinBeepUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "WinBeepUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAsterisk;
        private System.Windows.Forms.RadioButton rbBeep;
        private System.Windows.Forms.NumericUpDown nudPlayTimes;
        private System.Windows.Forms.Label label3;
    }
}
