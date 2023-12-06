namespace litstudio
{
    partial class CSVUI
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
            this.rbRead = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbWrite = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.svTableVarName = new litsdk.SelectVarName();
            this.label4 = new System.Windows.Forms.Label();
            this.rbOverWritte = new System.Windows.Forms.RadioButton();
            this.rbAppend = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.svFileVarName = new litsdk.SelectVarName();
            this.label6 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.svFileVarName);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.panel1);
            this.scActivityUI.Panel1.Controls.Add(this.svTableVarName);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.rbWrite);
            this.scActivityUI.Panel1.Controls.Add(this.rbRead);
            // 
            // rbRead
            // 
            this.rbRead.AutoSize = true;
            this.rbRead.Location = new System.Drawing.Point(111, 28);
            this.rbRead.Name = "rbRead";
            this.rbRead.Size = new System.Drawing.Size(161, 16);
            this.rbRead.TabIndex = 0;
            this.rbRead.TabStop = true;
            this.rbRead.Text = "将CSV文件读取到表格变量";
            this.rbRead.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "操作类型";
            // 
            // rbWrite
            // 
            this.rbWrite.AutoSize = true;
            this.rbWrite.Location = new System.Drawing.Point(290, 26);
            this.rbWrite.Name = "rbWrite";
            this.rbWrite.Size = new System.Drawing.Size(161, 16);
            this.rbWrite.TabIndex = 0;
            this.rbWrite.TabStop = true;
            this.rbWrite.Text = "将表格变量保存到CSV文件";
            this.rbWrite.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "表格变量";
            // 
            // svTableVarName
            // 
            this.svTableVarName.Location = new System.Drawing.Point(111, 68);
            this.svTableVarName.Name = "svTableVarName";
            this.svTableVarName.Size = new System.Drawing.Size(184, 23);
            this.svTableVarName.TabIndex = 2;
            this.svTableVarName.VarName = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "操作模式";
            // 
            // rbOverWritte
            // 
            this.rbOverWritte.AutoSize = true;
            this.rbOverWritte.Location = new System.Drawing.Point(3, 4);
            this.rbOverWritte.Name = "rbOverWritte";
            this.rbOverWritte.Size = new System.Drawing.Size(47, 16);
            this.rbOverWritte.TabIndex = 3;
            this.rbOverWritte.TabStop = true;
            this.rbOverWritte.Text = "覆盖";
            this.rbOverWritte.UseVisualStyleBackColor = true;
            // 
            // rbAppend
            // 
            this.rbAppend.AutoSize = true;
            this.rbAppend.Location = new System.Drawing.Point(70, 4);
            this.rbAppend.Name = "rbAppend";
            this.rbAppend.Size = new System.Drawing.Size(47, 16);
            this.rbAppend.TabIndex = 4;
            this.rbAppend.TabStop = true;
            this.rbAppend.Text = "追加";
            this.rbAppend.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbAppend);
            this.panel1.Controls.Add(this.rbOverWritte);
            this.panel1.Location = new System.Drawing.Point(110, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 23);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "文件变量";
            // 
            // svFileVarName
            // 
            this.svFileVarName.Location = new System.Drawing.Point(110, 104);
            this.svFileVarName.Name = "svFileVarName";
            this.svFileVarName.Size = new System.Drawing.Size(185, 23);
            this.svFileVarName.TabIndex = 7;
            this.svFileVarName.VarName = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(46, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(473, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "这个组件只处理简单的CSV文件，对于CSV内容中有大段文字换行等内容的，可能无法处理";
            // 
            // CSVUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CSVUI";
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

        private System.Windows.Forms.RadioButton rbRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbWrite;
        private litsdk.SelectVarName svTableVarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbAppend;
        private System.Windows.Forms.RadioButton rbOverWritte;
        private System.Windows.Forms.Label label4;
        private litsdk.SelectVarName svFileVarName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
