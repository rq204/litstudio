namespace CSharpWin_JD.CaptureImage
{
    partial class CaptureImageTool
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReselect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAccept = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolsControl = new CSharpWin_JD.CaptureImage.DrawToolsControl();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "bmp";
            this.saveFileDialog.Filter = "BMP 文件(*.bmp)|*.bmp|JPEG 文件(*.jpg,*.jpeg)|*.jpg,*.jpeg|PNG 文件(*.png)|*.png|GIF 文件" +
    "(*.gif)|*.gif";
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox.Location = new System.Drawing.Point(2, 233);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 21);
            this.textBox.TabIndex = 4;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRedo,
            this.menuItemReselect,
            this.toolStripSeparator1,
            this.menuItemAccept,
            this.menuItemSave,
            this.toolStripSeparator2,
            this.menuItemExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(173, 126);
            // 
            // menuItemRedo
            // 
            this.menuItemRedo.Image = global::litui.Properties.Resource.Redo;
            this.menuItemRedo.Name = "menuItemRedo";
            this.menuItemRedo.Size = new System.Drawing.Size(172, 22);
            this.menuItemRedo.Text = "撤销编辑";
            // 
            // menuItemReselect
            // 
            this.menuItemReselect.Name = "menuItemReselect";
            this.menuItemReselect.Size = new System.Drawing.Size(172, 22);
            this.menuItemReselect.Text = "重新选择截图区域";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // menuItemAccept
            // 
            this.menuItemAccept.Image = global::litui.Properties.Resource.Accept;
            this.menuItemAccept.Name = "menuItemAccept";
            this.menuItemAccept.Size = new System.Drawing.Size(172, 22);
            this.menuItemAccept.Text = "复制并退出截图";
            // 
            // menuItemSave
            // 
            this.menuItemSave.Image = global::litui.Properties.Resource.Save;
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(172, 22);
            this.menuItemSave.Text = "另存为...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Image = global::litui.Properties.Resource.Exit;
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(172, 22);
            this.menuItemExit.Text = "退出截图";
            // 
            // drawToolsControl
            // 
            this.drawToolsControl.Location = new System.Drawing.Point(2, 154);
            this.drawToolsControl.Name = "drawToolsControl";
            this.drawToolsControl.Padding = new System.Windows.Forms.Padding(2);
            this.drawToolsControl.Size = new System.Drawing.Size(51, 29);
            this.drawToolsControl.TabIndex = 0;
            // 
            // CaptureImageTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(319, 266);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.drawToolsControl);
            this.KeyPreview = true;
            this.Name = "CaptureImageTool";
            this.Text = "CaptureImageTool";
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureImageTool_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CaptureImageTool_KeyUp);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private DrawToolsControl drawToolsControl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        //private ColorSelector colorSelector;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemRedo;
        private System.Windows.Forms.ToolStripMenuItem menuItemReselect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemAccept;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
    }
}