using System;
using System.Collections.Generic;

namespace litstudio.iecef
{
    partial class MouseUI
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
            this.rbPosClick = new System.Windows.Forms.RadioButton();
            this.rbHotKey = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPosX = new System.Windows.Forms.TextBox();
            this.tbPoxY = new System.Windows.Forms.TextBox();
            this.ivPosY = new litsdk.InsertVarName();
            this.ivPosX = new litsdk.InsertVarName();
            this.cbHotKey = new System.Windows.Forms.ComboBox();
            this.rbTextInPut = new System.Windows.Forms.RadioButton();
            this.tbTextInPut = new System.Windows.Forms.TextBox();
            this.ivTextInPut = new litsdk.InsertVarName();
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
            this.scActivityUI.Panel1.Controls.Add(this.ivTextInPut);
            this.scActivityUI.Panel1.Controls.Add(this.tbTextInPut);
            this.scActivityUI.Panel1.Controls.Add(this.cbHotKey);
            this.scActivityUI.Panel1.Controls.Add(this.ivPosX);
            this.scActivityUI.Panel1.Controls.Add(this.ivPosY);
            this.scActivityUI.Panel1.Controls.Add(this.tbPoxY);
            this.scActivityUI.Panel1.Controls.Add(this.tbPosX);
            this.scActivityUI.Panel1.Controls.Add(this.rbTextInPut);
            this.scActivityUI.Panel1.Controls.Add(this.rbHotKey);
            this.scActivityUI.Panel1.Controls.Add(this.rbPosClick);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // rbPosClick
            // 
            this.rbPosClick.AutoSize = true;
            this.rbPosClick.Location = new System.Drawing.Point(23, 22);
            this.rbPosClick.Name = "rbPosClick";
            this.rbPosClick.Size = new System.Drawing.Size(71, 16);
            this.rbPosClick.TabIndex = 20;
            this.rbPosClick.TabStop = true;
            this.rbPosClick.Text = "坐标点击";
            this.rbPosClick.UseVisualStyleBackColor = true;
            // 
            // rbHotKey
            // 
            this.rbHotKey.AutoSize = true;
            this.rbHotKey.Location = new System.Drawing.Point(23, 65);
            this.rbHotKey.Name = "rbHotKey";
            this.rbHotKey.Size = new System.Drawing.Size(83, 16);
            this.rbHotKey.TabIndex = 20;
            this.rbHotKey.TabStop = true;
            this.rbHotKey.Text = "功能键输入";
            this.rbHotKey.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "坐标X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "坐标Y";
            // 
            // tbPosX
            // 
            this.tbPosX.Location = new System.Drawing.Point(158, 22);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(100, 21);
            this.tbPosX.TabIndex = 24;
            // 
            // tbPoxY
            // 
            this.tbPoxY.Location = new System.Drawing.Point(352, 23);
            this.tbPoxY.Name = "tbPoxY";
            this.tbPoxY.Size = new System.Drawing.Size(100, 21);
            this.tbPoxY.TabIndex = 25;
            // 
            // ivPosY
            // 
            this.ivPosY.Location = new System.Drawing.Point(459, 25);
            this.ivPosY.Name = "ivPosY";
            this.ivPosY.Size = new System.Drawing.Size(16, 16);
            this.ivPosY.TabIndex = 26;
            // 
            // ivPosX
            // 
            this.ivPosX.Location = new System.Drawing.Point(264, 23);
            this.ivPosX.Name = "ivPosX";
            this.ivPosX.Size = new System.Drawing.Size(16, 16);
            this.ivPosX.TabIndex = 26;
            // 
            // cbHotKey
            // 
            this.cbHotKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHotKey.FormattingEnabled = true;
            this.cbHotKey.Items.AddRange(new object[] {
            "ENTER",
            "TAB",
            "NEXT",
            "LEFT",
            "UP",
            "RIGHT",
            "DOWN",
            "BACK",
            "PAUSE",
            "ALT",
            "SHIFT",
            "END",
            "HOME",
            "INSERT",
            "DELETE",
            "PRIOR",
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
            this.cbHotKey.Location = new System.Drawing.Point(119, 65);
            this.cbHotKey.Name = "cbHotKey";
            this.cbHotKey.Size = new System.Drawing.Size(121, 20);
            this.cbHotKey.TabIndex = 27;
            // 
            // rbTextInPut
            // 
            this.rbTextInPut.AutoSize = true;
            this.rbTextInPut.Location = new System.Drawing.Point(23, 112);
            this.rbTextInPut.Name = "rbTextInPut";
            this.rbTextInPut.Size = new System.Drawing.Size(71, 16);
            this.rbTextInPut.TabIndex = 20;
            this.rbTextInPut.TabStop = true;
            this.rbTextInPut.Text = "文本输入";
            this.rbTextInPut.UseVisualStyleBackColor = true;
            // 
            // tbTextInPut
            // 
            this.tbTextInPut.Location = new System.Drawing.Point(119, 111);
            this.tbTextInPut.Multiline = true;
            this.tbTextInPut.Name = "tbTextInPut";
            this.tbTextInPut.Size = new System.Drawing.Size(384, 70);
            this.tbTextInPut.TabIndex = 28;
            // 
            // ivTextInPut
            // 
            this.ivTextInPut.Location = new System.Drawing.Point(516, 113);
            this.ivTextInPut.Name = "ivTextInPut";
            this.ivTextInPut.Size = new System.Drawing.Size(16, 16);
            this.ivTextInPut.TabIndex = 29;
            // 
            // MouseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MouseUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbPosClick;
        private System.Windows.Forms.TextBox tbTextInPut;
        private System.Windows.Forms.ComboBox cbHotKey;
        private litsdk.InsertVarName ivPosX;
        private litsdk.InsertVarName ivPosY;
        private System.Windows.Forms.TextBox tbPoxY;
        private System.Windows.Forms.TextBox tbPosX;
        private System.Windows.Forms.RadioButton rbTextInPut;
        private System.Windows.Forms.RadioButton rbHotKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private litsdk.InsertVarName ivTextInPut;
    }
}
