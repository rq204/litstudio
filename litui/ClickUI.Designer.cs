namespace litui
{
    partial class ClickUI
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
            this.rbDoubleClick = new System.Windows.Forms.RadioButton();
            this.rbClick = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.lbPos = new System.Windows.Forms.Label();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbMiddle = new System.Windows.Forms.RadioButton();
            this.pPos = new System.Windows.Forms.Panel();
            this.rbHover = new System.Windows.Forms.RadioButton();
            this.cbCurLocation = new System.Windows.Forms.CheckBox();
            this.cbInterFaceClick = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.cbInterFaceClick);
            this.scActivityUI.Panel1.Controls.Add(this.cbCurLocation);
            this.scActivityUI.Panel1.Controls.Add(this.pPos);
            this.scActivityUI.Panel1.Controls.Add(this.rbHover);
            this.scActivityUI.Panel1.Controls.Add(this.rbUp);
            this.scActivityUI.Panel1.Controls.Add(this.rbDown);
            this.scActivityUI.Panel1.Controls.Add(this.rbDoubleClick);
            this.scActivityUI.Panel1.Controls.Add(this.rbClick);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.lbPos);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // rbDoubleClick
            // 
            this.rbDoubleClick.AutoSize = true;
            this.rbDoubleClick.Location = new System.Drawing.Point(126, 122);
            this.rbDoubleClick.Name = "rbDoubleClick";
            this.rbDoubleClick.Size = new System.Drawing.Size(47, 16);
            this.rbDoubleClick.TabIndex = 9;
            this.rbDoubleClick.TabStop = true;
            this.rbDoubleClick.Text = "双击";
            this.rbDoubleClick.UseVisualStyleBackColor = true;
            this.rbDoubleClick.CheckedChanged += new System.EventHandler(this.rbDoubleClick_CheckedChanged);
            // 
            // rbClick
            // 
            this.rbClick.AutoSize = true;
            this.rbClick.Location = new System.Drawing.Point(73, 122);
            this.rbClick.Name = "rbClick";
            this.rbClick.Size = new System.Drawing.Size(47, 16);
            this.rbClick.TabIndex = 8;
            this.rbClick.TabStop = true;
            this.rbClick.Text = "单击";
            this.rbClick.UseVisualStyleBackColor = true;
            this.rbClick.CheckedChanged += new System.EventHandler(this.rbClick_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "点击类型";
            // 
            // rbDown
            // 
            this.rbDown.AutoSize = true;
            this.rbDown.Location = new System.Drawing.Point(179, 124);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(47, 16);
            this.rbDown.TabIndex = 9;
            this.rbDown.TabStop = true;
            this.rbDown.Text = "按下";
            this.rbDown.UseVisualStyleBackColor = true;
            this.rbDown.CheckedChanged += new System.EventHandler(this.rbDown_CheckedChanged);
            // 
            // rbUp
            // 
            this.rbUp.AutoSize = true;
            this.rbUp.Location = new System.Drawing.Point(233, 124);
            this.rbUp.Name = "rbUp";
            this.rbUp.Size = new System.Drawing.Size(47, 16);
            this.rbUp.TabIndex = 9;
            this.rbUp.TabStop = true;
            this.rbUp.Text = "弹起";
            this.rbUp.UseVisualStyleBackColor = true;
            this.rbUp.CheckedChanged += new System.EventHandler(this.rbUp_CheckedChanged);
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Location = new System.Drawing.Point(11, 157);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(53, 12);
            this.lbPos.TabIndex = 7;
            this.lbPos.Text = "鼠标键位";
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
            this.rbRight.Location = new System.Drawing.Point(57, 5);
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
            this.rbMiddle.CheckedChanged += new System.EventHandler(this.rbMiddle_CheckedChanged);
            // 
            // pPos
            // 
            this.pPos.Controls.Add(this.rbLeft);
            this.pPos.Controls.Add(this.rbRight);
            this.pPos.Controls.Add(this.rbMiddle);
            this.pPos.Location = new System.Drawing.Point(69, 150);
            this.pPos.Name = "pPos";
            this.pPos.Size = new System.Drawing.Size(167, 26);
            this.pPos.TabIndex = 10;
            // 
            // rbHover
            // 
            this.rbHover.AutoSize = true;
            this.rbHover.Location = new System.Drawing.Point(286, 125);
            this.rbHover.Name = "rbHover";
            this.rbHover.Size = new System.Drawing.Size(47, 16);
            this.rbHover.TabIndex = 9;
            this.rbHover.TabStop = true;
            this.rbHover.Text = "悬浮";
            this.rbHover.UseVisualStyleBackColor = true;
            this.rbHover.CheckedChanged += new System.EventHandler(this.rbHover_CheckedChanged);
            // 
            // cbCurLocation
            // 
            this.cbCurLocation.AutoSize = true;
            this.cbCurLocation.Location = new System.Drawing.Point(72, 194);
            this.cbCurLocation.Name = "cbCurLocation";
            this.cbCurLocation.Size = new System.Drawing.Size(216, 16);
            this.cbCurLocation.TabIndex = 11;
            this.cbCurLocation.Text = "使用当前光标位置（不用选择元素）";
            this.cbCurLocation.UseVisualStyleBackColor = true;
            this.cbCurLocation.CheckedChanged += new System.EventHandler(this.cbCurLocation_CheckedChanged);
            // 
            // cbInterFaceClick
            // 
            this.cbInterFaceClick.AutoSize = true;
            this.cbInterFaceClick.Location = new System.Drawing.Point(370, 126);
            this.cbInterFaceClick.Name = "cbInterFaceClick";
            this.cbInterFaceClick.Size = new System.Drawing.Size(132, 16);
            this.cbInterFaceClick.TabIndex = 12;
            this.cbInterFaceClick.Text = "使用自动化接口点击";
            this.cbInterFaceClick.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "其它选项";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(290, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 42);
            this.label6.TabIndex = 13;
            this.label6.Text = "如果软件支持自动化接口点击，选中它点击时将不用移动鼠标。但是部分情况下会失点击失败，失败后会尝试坐标点击。";
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

        private System.Windows.Forms.RadioButton rbDoubleClick;
        private System.Windows.Forms.RadioButton rbClick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pPos;
        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.RadioButton rbMiddle;
        private System.Windows.Forms.RadioButton rbUp;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.Label lbPos;
        private System.Windows.Forms.RadioButton rbHover;
        private System.Windows.Forms.CheckBox cbCurLocation;
        private System.Windows.Forms.CheckBox cbInterFaceClick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
