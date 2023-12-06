namespace litui
{
    partial class ImgClickUI
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
            this.pPos = new System.Windows.Forms.Panel();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbMiddle = new System.Windows.Forms.RadioButton();
            this.lbPos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbClick = new System.Windows.Forms.RadioButton();
            this.rbDoubleClick = new System.Windows.Forms.RadioButton();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.rbHover = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.pPos.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.rbHover);
            this.scActivityUI.Panel1.Controls.Add(this.rbUp);
            this.scActivityUI.Panel1.Controls.Add(this.rbDown);
            this.scActivityUI.Panel1.Controls.Add(this.rbDoubleClick);
            this.scActivityUI.Panel1.Controls.Add(this.rbClick);
            this.scActivityUI.Panel1.Controls.Add(this.pPos);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.lbPos);
            // 
            // pPos
            // 
            this.pPos.Controls.Add(this.rbLeft);
            this.pPos.Controls.Add(this.rbRight);
            this.pPos.Controls.Add(this.rbMiddle);
            this.pPos.Location = new System.Drawing.Point(90, 139);
            this.pPos.Name = "pPos";
            this.pPos.Size = new System.Drawing.Size(167, 26);
            this.pPos.TabIndex = 18;
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Location = new System.Drawing.Point(3, 5);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(47, 16);
            this.rbLeft.TabIndex = 8;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "左键";
            this.rbLeft.UseVisualStyleBackColor = true;
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(56, 5);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(47, 16);
            this.rbRight.TabIndex = 8;
            this.rbRight.TabStop = true;
            this.rbRight.Text = "右键";
            this.rbRight.UseVisualStyleBackColor = true;
            // 
            // rbMiddle
            // 
            this.rbMiddle.AutoSize = true;
            this.rbMiddle.Location = new System.Drawing.Point(110, 5);
            this.rbMiddle.Name = "rbMiddle";
            this.rbMiddle.Size = new System.Drawing.Size(47, 16);
            this.rbMiddle.TabIndex = 8;
            this.rbMiddle.TabStop = true;
            this.rbMiddle.Text = "中键";
            this.rbMiddle.UseVisualStyleBackColor = true;
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Location = new System.Drawing.Point(32, 146);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(53, 12);
            this.lbPos.TabIndex = 17;
            this.lbPos.Text = "鼠标键位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "点击类型";
            // 
            // rbClick
            // 
            this.rbClick.AutoSize = true;
            this.rbClick.Location = new System.Drawing.Point(90, 108);
            this.rbClick.Name = "rbClick";
            this.rbClick.Size = new System.Drawing.Size(47, 16);
            this.rbClick.TabIndex = 19;
            this.rbClick.TabStop = true;
            this.rbClick.Text = "单击";
            this.rbClick.UseVisualStyleBackColor = true;
            // 
            // rbDoubleClick
            // 
            this.rbDoubleClick.AutoSize = true;
            this.rbDoubleClick.Location = new System.Drawing.Point(143, 108);
            this.rbDoubleClick.Name = "rbDoubleClick";
            this.rbDoubleClick.Size = new System.Drawing.Size(47, 16);
            this.rbDoubleClick.TabIndex = 20;
            this.rbDoubleClick.TabStop = true;
            this.rbDoubleClick.Text = "双击";
            this.rbDoubleClick.UseVisualStyleBackColor = true;
            // 
            // rbDown
            // 
            this.rbDown.AutoSize = true;
            this.rbDown.Location = new System.Drawing.Point(200, 108);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(47, 16);
            this.rbDown.TabIndex = 21;
            this.rbDown.TabStop = true;
            this.rbDown.Text = "按下";
            this.rbDown.UseVisualStyleBackColor = true;
            // 
            // rbUp
            // 
            this.rbUp.AutoSize = true;
            this.rbUp.Location = new System.Drawing.Point(253, 108);
            this.rbUp.Name = "rbUp";
            this.rbUp.Size = new System.Drawing.Size(47, 16);
            this.rbUp.TabIndex = 22;
            this.rbUp.TabStop = true;
            this.rbUp.Text = "弹起";
            this.rbUp.UseVisualStyleBackColor = true;
            // 
            // rbHover
            // 
            this.rbHover.AutoSize = true;
            this.rbHover.Location = new System.Drawing.Point(314, 108);
            this.rbHover.Name = "rbHover";
            this.rbHover.Size = new System.Drawing.Size(47, 16);
            this.rbHover.TabIndex = 23;
            this.rbHover.TabStop = true;
            this.rbHover.Text = "悬浮";
            this.rbHover.UseVisualStyleBackColor = true;
            // 
            // ClickUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ClickUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.pPos.ResumeLayout(false);
            this.pPos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPos;
        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.RadioButton rbMiddle;
        private System.Windows.Forms.Label lbPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbClick;
        private System.Windows.Forms.RadioButton rbDoubleClick;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.RadioButton rbUp;
        private System.Windows.Forms.RadioButton rbHover;
    }
}
