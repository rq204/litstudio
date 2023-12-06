namespace litui
{
    partial class MouseMoveUI
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
            this.rbFullScreen = new System.Windows.Forms.RadioButton();
            this.rbActivityForm = new System.Windows.Forms.RadioButton();
            this.rbCurLocation = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbXLocation = new System.Windows.Forms.TextBox();
            this.tbYLocation = new System.Windows.Forms.TextBox();
            this.ivXLocation = new litsdk.InsertVarName();
            this.ivYLocation = new litsdk.InsertVarName();
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
            this.scActivityUI.Panel1.Controls.Add(this.ivYLocation);
            this.scActivityUI.Panel1.Controls.Add(this.ivXLocation);
            this.scActivityUI.Panel1.Controls.Add(this.tbYLocation);
            this.scActivityUI.Panel1.Controls.Add(this.tbXLocation);
            this.scActivityUI.Panel1.Controls.Add(this.rbCurLocation);
            this.scActivityUI.Panel1.Controls.Add(this.rbActivityForm);
            this.scActivityUI.Panel1.Controls.Add(this.rbFullScreen);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "参照位置";
            // 
            // rbFullScreen
            // 
            this.rbFullScreen.AutoSize = true;
            this.rbFullScreen.Location = new System.Drawing.Point(93, 26);
            this.rbFullScreen.Name = "rbFullScreen";
            this.rbFullScreen.Size = new System.Drawing.Size(83, 16);
            this.rbFullScreen.TabIndex = 1;
            this.rbFullScreen.TabStop = true;
            this.rbFullScreen.Text = "屏幕左上角";
            this.rbFullScreen.UseVisualStyleBackColor = true;
            // 
            // rbActivityForm
            // 
            this.rbActivityForm.AutoSize = true;
            this.rbActivityForm.Location = new System.Drawing.Point(197, 26);
            this.rbActivityForm.Name = "rbActivityForm";
            this.rbActivityForm.Size = new System.Drawing.Size(131, 16);
            this.rbActivityForm.TabIndex = 1;
            this.rbActivityForm.TabStop = true;
            this.rbActivityForm.Text = "当前激活窗口左上角";
            this.rbActivityForm.UseVisualStyleBackColor = true;
            // 
            // rbCurLocation
            // 
            this.rbCurLocation.AutoSize = true;
            this.rbCurLocation.Location = new System.Drawing.Point(335, 26);
            this.rbCurLocation.Name = "rbCurLocation";
            this.rbCurLocation.Size = new System.Drawing.Size(95, 16);
            this.rbCurLocation.TabIndex = 1;
            this.rbCurLocation.TabStop = true;
            this.rbCurLocation.Text = "当前鼠标位置";
            this.rbCurLocation.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "水平移动";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "垂直移动";
            // 
            // tbXLocation
            // 
            this.tbXLocation.Location = new System.Drawing.Point(93, 67);
            this.tbXLocation.Name = "tbXLocation";
            this.tbXLocation.Size = new System.Drawing.Size(100, 21);
            this.tbXLocation.TabIndex = 2;
            // 
            // tbYLocation
            // 
            this.tbYLocation.Location = new System.Drawing.Point(93, 109);
            this.tbYLocation.Name = "tbYLocation";
            this.tbYLocation.Size = new System.Drawing.Size(100, 21);
            this.tbYLocation.TabIndex = 2;
            // 
            // ivXLocation
            // 
            this.ivXLocation.Location = new System.Drawing.Point(203, 70);
            this.ivXLocation.Name = "ivXLocation";
            this.ivXLocation.Size = new System.Drawing.Size(16, 16);
            this.ivXLocation.TabIndex = 3;
            // 
            // ivYLocation
            // 
            this.ivYLocation.Location = new System.Drawing.Point(202, 111);
            this.ivYLocation.Name = "ivYLocation";
            this.ivYLocation.Size = new System.Drawing.Size(16, 16);
            this.ivYLocation.TabIndex = 3;
            // 
            // MouseMoveUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MouseMoveUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private litsdk.InsertVarName ivYLocation;
        private litsdk.InsertVarName ivXLocation;
        private System.Windows.Forms.TextBox tbYLocation;
        private System.Windows.Forms.TextBox tbXLocation;
        private System.Windows.Forms.RadioButton rbCurLocation;
        private System.Windows.Forms.RadioButton rbActivityForm;
        private System.Windows.Forms.RadioButton rbFullScreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
