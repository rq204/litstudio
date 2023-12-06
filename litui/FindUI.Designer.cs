namespace litui
{
    partial class FindUI
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
            this.svXpathVarName = new litsdk.SelectVarName();
            this.label7 = new System.Windows.Forms.Label();
            this.cbReverse = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.cbReverse);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.svXpathVarName);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "保存XPath";
            this.label5.Visible = false;
            // 
            // svXpathVarName
            // 
            this.svXpathVarName.Location = new System.Drawing.Point(82, 116);
            this.svXpathVarName.Name = "svXpathVarName";
            this.svXpathVarName.Size = new System.Drawing.Size(169, 23);
            this.svXpathVarName.TabIndex = 11;
            this.svXpathVarName.VarName = "";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(257, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 40);
            this.label7.TabIndex = 12;
            this.label7.Text = "可选，当存在多个元素或XPath为相对路径时，可以通过保存XPath得到所有绝对XPath，使用该功能部分情况下可能会比较耗时";
            // 
            // cbReverse
            // 
            this.cbReverse.AutoSize = true;
            this.cbReverse.Location = new System.Drawing.Point(82, 159);
            this.cbReverse.Name = "cbReverse";
            this.cbReverse.Size = new System.Drawing.Size(72, 16);
            this.cbReverse.TabIndex = 13;
            this.cbReverse.Text = "取相反值";
            this.cbReverse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "其它选项";
            this.label6.Visible = false;
            // 
            // FindUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FindUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private litsdk.SelectVarName svXpathVarName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbReverse;
        private System.Windows.Forms.Label label6;
    }
}
