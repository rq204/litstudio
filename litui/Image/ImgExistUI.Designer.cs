namespace litui
{
    partial class ImgExistUI
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
            this.svSaveX = new litsdk.SelectVarName();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.svSaveY = new litsdk.SelectVarName();
            this.label10 = new System.Windows.Forms.Label();
            this.cbReverse = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.label11);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveY);
            this.scActivityUI.Panel1.Controls.Add(this.label10);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveX);
            this.scActivityUI.Panel1.Controls.Add(this.label9);
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(251, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "可选，保存符合条件的图像坐标至指定变量";
            // 
            // svSaveX
            // 
            this.svSaveX.Location = new System.Drawing.Point(70, 150);
            this.svSaveX.Name = "svSaveX";
            this.svSaveX.Size = new System.Drawing.Size(75, 23);
            this.svSaveX.TabIndex = 19;
            this.svSaveX.VarName = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "保存图片中心点位置至数字变量";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "X";
            // 
            // svSaveY
            // 
            this.svSaveY.Location = new System.Drawing.Point(170, 150);
            this.svSaveY.Name = "svSaveY";
            this.svSaveY.Size = new System.Drawing.Size(75, 23);
            this.svSaveY.TabIndex = 22;
            this.svSaveY.VarName = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "Y";
            // 
            // cbReverse
            // 
            this.cbReverse.AutoSize = true;
            this.cbReverse.Location = new System.Drawing.Point(34, 194);
            this.cbReverse.Name = "cbReverse";
            this.cbReverse.Size = new System.Drawing.Size(72, 16);
            this.cbReverse.TabIndex = 24;
            this.cbReverse.Text = "取相反值";
            this.cbReverse.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(99, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "（即选中后图片存在返回False）";
            // 
            // ImgExistUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ImgExistUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private litsdk.SelectVarName svSaveY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private litsdk.SelectVarName svSaveX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbReverse;
        private System.Windows.Forms.Label label11;
    }
}
