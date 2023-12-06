namespace CSharpWin_JD.CaptureImage
{
    partial class DrawToolsControl
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAccept = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();

            this.toolStripButtonText = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRectangular = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRectangular,
            this.toolStripButtonEllipse,
            this.toolStripButtonText,
            this.toolStripButtonLine,
            this.toolStripSeparator1,
            this.toolStripButtonRedo,
            this.toolStripButtonSave,
            this.toolStripSeparator2,
            this.toolStripButtonExit,
            this.toolStripButtonAccept});
            this.toolStrip.Location = new System.Drawing.Point(2, 2);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(220, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::litui.Properties.Resource.Exit;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExit.Text = "退出截图";
            // 
            // toolStripButtonAccept
            // 
            this.toolStripButtonAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAccept.Image = global::litui.Properties.Resource.Accept;
            this.toolStripButtonAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAccept.Name = "toolStripButtonAccept";
            this.toolStripButtonAccept.Size = new System.Drawing.Size(23, 20);
            this.toolStripButtonAccept.Text = "完成截图";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::litui.Properties.Resource.Save;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "保存";
            this.toolStripButtonSave.Visible = false;
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Image = global::litui.Properties.Resource.Redo;
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRedo.Text = "撤销";
            this.toolStripButtonRedo.Visible = false;
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLine.Image = global::litui.Properties.Resource.Line;
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLine.Text = "画笔";
            this.toolStripButtonLine.Visible = false;

            // 
            // toolStripButtonText
            // 
            this.toolStripButtonText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonText.Image = global::litui.Properties.Resource.Text;
            this.toolStripButtonText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonText.Name = "toolStripButtonText";
            this.toolStripButtonText.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonText.Text = "添加文字";
            this.toolStripButtonText.Visible = false;
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEllipse.Image = global::litui.Properties.Resource.Ellipse;
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEllipse.Text = "添加椭圆";
            this.toolStripButtonEllipse.Visible = false;
            // 
            // toolStripButtonRectangular
            // 
            this.toolStripButtonRectangular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRectangular.Image = global::litui.Properties.Resource.Rectangular;
            this.toolStripButtonRectangular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRectangular.Name = "toolStripButtonRectangular";
            this.toolStripButtonRectangular.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRectangular.Text = "添加矩形";
            this.toolStripButtonRectangular.Visible = false;
            // 
            // DrawToolsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip);
            this.Name = "DrawToolsControl";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(224, 29);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripButton toolStripButtonAccept;
        private System.Windows.Forms.ToolStripButton toolStripButtonRectangular;
        private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
        private System.Windows.Forms.ToolStripButton toolStripButtonText;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
    }
}
