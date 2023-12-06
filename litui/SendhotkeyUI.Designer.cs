namespace litui
{
    partial class SendHotkeyUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWin = new System.Windows.Forms.CheckBox();
            this.cbShift = new System.Windows.Forms.CheckBox();
            this.cbCtrl = new System.Windows.Forms.CheckBox();
            this.cbAlt = new System.Windows.Forms.CheckBox();
            this.cbKey = new System.Windows.Forms.ComboBox();
            this.cbCurLocation = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.cbCurLocation);
            this.scActivityUI.Panel1.Controls.Add(this.cbKey);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.cbWin);
            this.scActivityUI.Panel1.Controls.Add(this.cbShift);
            this.scActivityUI.Panel1.Controls.Add(this.cbCtrl);
            this.scActivityUI.Panel1.Controls.Add(this.cbAlt);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "其它按键";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "控制按键";
            // 
            // cbWin
            // 
            this.cbWin.AutoSize = true;
            this.cbWin.Location = new System.Drawing.Point(256, 153);
            this.cbWin.Name = "cbWin";
            this.cbWin.Size = new System.Drawing.Size(42, 16);
            this.cbWin.TabIndex = 7;
            this.cbWin.Text = "Win";
            this.cbWin.UseVisualStyleBackColor = true;
            // 
            // cbShift
            // 
            this.cbShift.AutoSize = true;
            this.cbShift.Location = new System.Drawing.Point(187, 154);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(54, 16);
            this.cbShift.TabIndex = 8;
            this.cbShift.Text = "Shift";
            this.cbShift.UseVisualStyleBackColor = true;
            // 
            // cbCtrl
            // 
            this.cbCtrl.AutoSize = true;
            this.cbCtrl.Location = new System.Drawing.Point(133, 154);
            this.cbCtrl.Name = "cbCtrl";
            this.cbCtrl.Size = new System.Drawing.Size(48, 16);
            this.cbCtrl.TabIndex = 9;
            this.cbCtrl.Text = "Ctrl";
            this.cbCtrl.UseVisualStyleBackColor = true;
            // 
            // cbAlt
            // 
            this.cbAlt.AutoSize = true;
            this.cbAlt.Location = new System.Drawing.Point(76, 154);
            this.cbAlt.Name = "cbAlt";
            this.cbAlt.Size = new System.Drawing.Size(42, 16);
            this.cbAlt.TabIndex = 10;
            this.cbAlt.Text = "Alt";
            this.cbAlt.UseVisualStyleBackColor = true;
            // 
            // cbKey
            // 
            this.cbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKey.FormattingEnabled = true;
            this.cbKey.Items.AddRange(new object[] {
            "",
            "ENTER",
            "KEY_A",
            "KEY_B",
            "KEY_C",
            "KEY_D",
            "KEY_E",
            "KEY_F",
            "KEY_G",
            "KEY_H",
            "KEY_I",
            "KEY_J",
            "KEY_K",
            "KEY_L",
            "KEY_M",
            "KEY_N",
            "KEY_O",
            "KEY_P",
            "KEY_Q",
            "KEY_R",
            "KEY_S",
            "KEY_T",
            "KEY_U",
            "KEY_V",
            "KEY_W",
            "KEY_X",
            "KEY_Y",
            "KEY_Z",
            "KEY_0",
            "KEY_1",
            "KEY_2",
            "KEY_3",
            "KEY_4",
            "KEY_5",
            "KEY_6",
            "KEY_7",
            "KEY_8",
            "KEY_9",
            "PRIOR",
            "NEXT",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "BACK",
            "ESC",
            "TAB",
            "PAUSE",
            "END",
            "HOME",
            "INSERT",
            "DELETE",
            "LWIN",
            "RWIN",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.cbKey.Location = new System.Drawing.Point(371, 151);
            this.cbKey.Name = "cbKey";
            this.cbKey.Size = new System.Drawing.Size(95, 20);
            this.cbKey.TabIndex = 13;
            // 
            // cbCurLocation
            // 
            this.cbCurLocation.AutoSize = true;
            this.cbCurLocation.Location = new System.Drawing.Point(76, 119);
            this.cbCurLocation.Name = "cbCurLocation";
            this.cbCurLocation.Size = new System.Drawing.Size(216, 16);
            this.cbCurLocation.TabIndex = 14;
            this.cbCurLocation.Text = "使用当前光标位置（不用选择元素）";
            this.cbCurLocation.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "按键选项";
            // 
            // SendHotkeyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SendHotkeyUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbWin;
        private System.Windows.Forms.CheckBox cbShift;
        private System.Windows.Forms.CheckBox cbCtrl;
        private System.Windows.Forms.CheckBox cbAlt;
        private System.Windows.Forms.ComboBox cbKey;
        private System.Windows.Forms.CheckBox cbCurLocation;
        private System.Windows.Forms.Label label5;
    }
}
