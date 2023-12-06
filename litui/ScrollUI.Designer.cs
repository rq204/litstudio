namespace litui
{
    partial class ScrollUI
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
            this.label5 = new System.Windows.Forms.Label();
            this.nudScrollLine = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.svScrollVarName = new litsdk.SelectVarName();
            this.cbReverse = new System.Windows.Forms.CheckBox();
            this.cbCurLocation = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScrollLine)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.cbCurLocation);
            this.scActivityUI.Panel1.Controls.Add(this.cbReverse);
            this.scActivityUI.Panel1.Controls.Add(this.svScrollVarName);
            this.scActivityUI.Panel1.Controls.Add(this.nudScrollLine);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "滚动行数";
            // 
            // nudScrollLine
            // 
            this.nudScrollLine.Location = new System.Drawing.Point(79, 121);
            this.nudScrollLine.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudScrollLine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScrollLine.Name = "nudScrollLine";
            this.nudScrollLine.Size = new System.Drawing.Size(63, 21);
            this.nudScrollLine.TabIndex = 11;
            this.nudScrollLine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "使用变量";
            // 
            // svScrollVarName
            // 
            this.svScrollVarName.Location = new System.Drawing.Point(218, 121);
            this.svScrollVarName.Name = "svScrollVarName";
            this.svScrollVarName.Size = new System.Drawing.Size(136, 23);
            this.svScrollVarName.TabIndex = 12;
            this.svScrollVarName.VarName = "";
            // 
            // cbReverse
            // 
            this.cbReverse.AutoSize = true;
            this.cbReverse.Location = new System.Drawing.Point(367, 123);
            this.cbReverse.Name = "cbReverse";
            this.cbReverse.Size = new System.Drawing.Size(72, 16);
            this.cbReverse.TabIndex = 13;
            this.cbReverse.Text = "向上滚动";
            this.cbReverse.UseVisualStyleBackColor = true;
            // 
            // cbCurLocation
            // 
            this.cbCurLocation.AutoSize = true;
            this.cbCurLocation.Location = new System.Drawing.Point(79, 161);
            this.cbCurLocation.Name = "cbCurLocation";
            this.cbCurLocation.Size = new System.Drawing.Size(216, 16);
            this.cbCurLocation.TabIndex = 12;
            this.cbCurLocation.Text = "使用当前光标位置（不用选择元素）";
            this.cbCurLocation.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "滚动选项";
            // 
            // ScrollUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ScrollUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudScrollLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudScrollLine;
        private litsdk.SelectVarName svScrollVarName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbReverse;
        private System.Windows.Forms.CheckBox cbCurLocation;
        private System.Windows.Forms.Label label7;
    }
}
