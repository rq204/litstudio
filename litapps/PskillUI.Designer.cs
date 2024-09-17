namespace litapps
{
    partial class PskillUI
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
            this.rbLatest = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPskillValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbFilePath = new System.Windows.Forms.RadioButton();
            this.rbProcessName = new System.Windows.Forms.RadioButton();
            this.rbProcessId = new System.Windows.Forms.RadioButton();
            this.ivPskillvalue = new litsdk.InsertVarName();
            this.rbEarliest = new System.Windows.Forms.RadioButton();
            this.llbCurrentDir = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.panel1);
            this.scActivityUI.Panel1.Controls.Add(this.llbCurrentDir);
            this.scActivityUI.Panel1.Controls.Add(this.ivPskillvalue);
            this.scActivityUI.Panel1.Controls.Add(this.rbProcessId);
            this.scActivityUI.Panel1.Controls.Add(this.rbProcessName);
            this.scActivityUI.Panel1.Controls.Add(this.rbFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.tbPskillValue);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            // 
            // rbLatest
            // 
            this.rbLatest.AutoSize = true;
            this.rbLatest.Location = new System.Drawing.Point(2, 5);
            this.rbLatest.Name = "rbLatest";
            this.rbLatest.Size = new System.Drawing.Size(107, 16);
            this.rbLatest.TabIndex = 0;
            this.rbLatest.TabStop = true;
            this.rbLatest.Text = "关闭最近打开的";
            this.rbLatest.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(229, 5);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(83, 16);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "关闭所有的";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "参数值";
            // 
            // tbPskillValue
            // 
            this.tbPskillValue.Location = new System.Drawing.Point(101, 56);
            this.tbPskillValue.Name = "tbPskillValue";
            this.tbPskillValue.Size = new System.Drawing.Size(240, 21);
            this.tbPskillValue.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "多个进程时";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "关闭方式";
            // 
            // rbFilePath
            // 
            this.rbFilePath.AutoSize = true;
            this.rbFilePath.Location = new System.Drawing.Point(264, 19);
            this.rbFilePath.Name = "rbFilePath";
            this.rbFilePath.Size = new System.Drawing.Size(59, 16);
            this.rbFilePath.TabIndex = 4;
            this.rbFilePath.TabStop = true;
            this.rbFilePath.Text = "按路径";
            this.rbFilePath.UseVisualStyleBackColor = true;
            this.rbFilePath.Visible = false;
            // 
            // rbProcessName
            // 
            this.rbProcessName.AutoSize = true;
            this.rbProcessName.Location = new System.Drawing.Point(101, 20);
            this.rbProcessName.Name = "rbProcessName";
            this.rbProcessName.Size = new System.Drawing.Size(71, 16);
            this.rbProcessName.TabIndex = 4;
            this.rbProcessName.TabStop = true;
            this.rbProcessName.Text = "按进程名";
            this.rbProcessName.UseVisualStyleBackColor = true;
            // 
            // rbProcessId
            // 
            this.rbProcessId.AutoSize = true;
            this.rbProcessId.Location = new System.Drawing.Point(178, 20);
            this.rbProcessId.Name = "rbProcessId";
            this.rbProcessId.Size = new System.Drawing.Size(71, 16);
            this.rbProcessId.TabIndex = 4;
            this.rbProcessId.TabStop = true;
            this.rbProcessId.Text = "按进程Id";
            this.rbProcessId.UseVisualStyleBackColor = true;
            // 
            // ivPskillvalue
            // 
            this.ivPskillvalue.Location = new System.Drawing.Point(352, 57);
            this.ivPskillvalue.Name = "ivPskillvalue";
            this.ivPskillvalue.Size = new System.Drawing.Size(16, 16);
            this.ivPskillvalue.TabIndex = 5;
            // 
            // rbEarliest
            // 
            this.rbEarliest.AutoSize = true;
            this.rbEarliest.Location = new System.Drawing.Point(116, 5);
            this.rbEarliest.Name = "rbEarliest";
            this.rbEarliest.Size = new System.Drawing.Size(107, 16);
            this.rbEarliest.TabIndex = 0;
            this.rbEarliest.TabStop = true;
            this.rbEarliest.Text = "关闭最早打开的";
            this.rbEarliest.UseVisualStyleBackColor = true;
            // 
            // llbCurrentDir
            // 
            this.llbCurrentDir.AutoSize = true;
            this.llbCurrentDir.Location = new System.Drawing.Point(378, 60);
            this.llbCurrentDir.Name = "llbCurrentDir";
            this.llbCurrentDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurrentDir.TabIndex = 7;
            this.llbCurrentDir.TabStop = true;
            this.llbCurrentDir.Text = "[当前目录]";
            this.llbCurrentDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurrentDir_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbLatest);
            this.panel1.Controls.Add(this.rbAll);
            this.panel1.Controls.Add(this.rbEarliest);
            this.panel1.Location = new System.Drawing.Point(101, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 25);
            this.panel1.TabIndex = 8;
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(449, 60);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 14;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // PskillUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PskillUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbLatest;
        private System.Windows.Forms.TextBox tbPskillValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbAll;
        private litsdk.InsertVarName ivPskillvalue;
        private System.Windows.Forms.RadioButton rbProcessId;
        private System.Windows.Forms.RadioButton rbProcessName;
        private System.Windows.Forms.RadioButton rbFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbEarliest;
        private System.Windows.Forms.LinkLabel llbCurrentDir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llbOpen;
    }
}
