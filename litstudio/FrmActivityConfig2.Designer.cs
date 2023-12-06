namespace litstudio
{
    partial class FrmActivityConfig2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pCaption = new System.Windows.Forms.Panel();
            this.lbHelp = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pCaption.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCaption
            // 
            this.pCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCaption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pCaption.Controls.Add(this.lbHelp);
            this.pCaption.Controls.Add(this.lbClose);
            this.pCaption.Controls.Add(this.lbTitle);
            this.pCaption.Location = new System.Drawing.Point(0, -1);
            this.pCaption.Name = "pCaption";
            this.pCaption.Size = new System.Drawing.Size(594, 33);
            this.pCaption.TabIndex = 0;
            this.pCaption.Paint += new System.Windows.Forms.PaintEventHandler(this.pCaption_Paint);
            this.pCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pCaption_MouseDown);
            this.pCaption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCaption_MouseMove);
            // 
            // lbHelp
            // 
            this.lbHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbHelp.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHelp.ForeColor = System.Drawing.SystemColors.Window;
            this.lbHelp.Location = new System.Drawing.Point(543, 0);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(24, 33);
            this.lbHelp.TabIndex = 2;
            this.lbHelp.Text = "?";
            this.lbHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHelp.Click += new System.EventHandler(this.lbHelp_Click);
            this.lbHelp.MouseEnter += new System.EventHandler(this.lbHelp_MouseEnter);
            this.lbHelp.MouseLeave += new System.EventHandler(this.lbHelp_MouseLeave);
            // 
            // lbClose
            // 
            this.lbClose.BackColor = System.Drawing.Color.Transparent;
            this.lbClose.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbClose.ForeColor = System.Drawing.SystemColors.Window;
            this.lbClose.Location = new System.Drawing.Point(567, 0);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(24, 33);
            this.lbClose.TabIndex = 1;
            this.lbClose.Text = "X";
            this.lbClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            this.lbClose.MouseEnter += new System.EventHandler(this.lbClose_MouseEnter);
            this.lbClose.MouseLeave += new System.EventHandler(this.lbClose_MouseLeave);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTitle.Location = new System.Drawing.Point(4, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(56, 16);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "label1";
            // 
            // FrmActivityConfig2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pCaption);
            this.Name = "FrmActivityConfig2";
            this.Size = new System.Drawing.Size(594, 324);
            this.pCaption.ResumeLayout(false);
            this.pCaption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCaption;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbHelp;
    }
}