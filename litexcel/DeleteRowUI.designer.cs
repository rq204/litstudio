namespace litexcel
{
    partial class DeleteRowUI
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
            this.cbExcelName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRowStart = new System.Windows.Forms.TextBox();
            this.tbRowEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbFirst = new System.Windows.Forms.RadioButton();
            this.rbLast = new System.Windows.Forms.RadioButton();
            this.rbDeleteAll = new System.Windows.Forms.RadioButton();
            this.rbDeleteRange = new System.Windows.Forms.RadioButton();
            this.ivRowStart = new litsdk.InsertVarName();
            this.ivRowEnd = new litsdk.InsertVarName();
            this.cbLastRow = new System.Windows.Forms.CheckBox();
            this.pRowNum = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.pRowNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.pRowNum);
            this.scActivityUI.Panel1.Controls.Add(this.rbDeleteRange);
            this.scActivityUI.Panel1.Controls.Add(this.rbDeleteAll);
            this.scActivityUI.Panel1.Controls.Add(this.rbLast);
            this.scActivityUI.Panel1.Controls.Add(this.rbFirst);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.cbExcelName);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Excel对象";
            // 
            // cbExcelName
            // 
            this.cbExcelName.FormattingEnabled = true;
            this.cbExcelName.Location = new System.Drawing.Point(87, 21);
            this.cbExcelName.Name = "cbExcelName";
            this.cbExcelName.Size = new System.Drawing.Size(177, 20);
            this.cbExcelName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "行号开始";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "行号结束";
            // 
            // tbRowStart
            // 
            this.tbRowStart.Location = new System.Drawing.Point(62, 8);
            this.tbRowStart.Name = "tbRowStart";
            this.tbRowStart.Size = new System.Drawing.Size(100, 21);
            this.tbRowStart.TabIndex = 2;
            // 
            // tbRowEnd
            // 
            this.tbRowEnd.Location = new System.Drawing.Point(62, 43);
            this.tbRowEnd.Name = "tbRowEnd";
            this.tbRowEnd.Size = new System.Drawing.Size(100, 21);
            this.tbRowEnd.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "删除方式";
            // 
            // rbFirst
            // 
            this.rbFirst.AutoSize = true;
            this.rbFirst.Location = new System.Drawing.Point(88, 61);
            this.rbFirst.Name = "rbFirst";
            this.rbFirst.Size = new System.Drawing.Size(83, 16);
            this.rbFirst.TabIndex = 5;
            this.rbFirst.TabStop = true;
            this.rbFirst.Text = "删除第一行";
            this.rbFirst.UseVisualStyleBackColor = true;
            this.rbFirst.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbLast
            // 
            this.rbLast.AutoSize = true;
            this.rbLast.Location = new System.Drawing.Point(177, 61);
            this.rbLast.Name = "rbLast";
            this.rbLast.Size = new System.Drawing.Size(95, 16);
            this.rbLast.TabIndex = 5;
            this.rbLast.TabStop = true;
            this.rbLast.Text = "删除最后一行";
            this.rbLast.UseVisualStyleBackColor = true;
            this.rbLast.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbDeleteAll
            // 
            this.rbDeleteAll.AutoSize = true;
            this.rbDeleteAll.Location = new System.Drawing.Point(278, 61);
            this.rbDeleteAll.Name = "rbDeleteAll";
            this.rbDeleteAll.Size = new System.Drawing.Size(83, 16);
            this.rbDeleteAll.TabIndex = 5;
            this.rbDeleteAll.TabStop = true;
            this.rbDeleteAll.Text = "删除所有行";
            this.rbDeleteAll.UseVisualStyleBackColor = true;
            this.rbDeleteAll.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbDeleteRange
            // 
            this.rbDeleteRange.AutoSize = true;
            this.rbDeleteRange.Location = new System.Drawing.Point(367, 61);
            this.rbDeleteRange.Name = "rbDeleteRange";
            this.rbDeleteRange.Size = new System.Drawing.Size(83, 16);
            this.rbDeleteRange.TabIndex = 5;
            this.rbDeleteRange.TabStop = true;
            this.rbDeleteRange.Text = "删除指定行";
            this.rbDeleteRange.UseVisualStyleBackColor = true;
            this.rbDeleteRange.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // ivRowStart
            // 
            this.ivRowStart.Location = new System.Drawing.Point(171, 10);
            this.ivRowStart.Name = "ivRowStart";
            this.ivRowStart.Size = new System.Drawing.Size(16, 16);
            this.ivRowStart.TabIndex = 6;
            // 
            // ivRowEnd
            // 
            this.ivRowEnd.Location = new System.Drawing.Point(171, 46);
            this.ivRowEnd.Name = "ivRowEnd";
            this.ivRowEnd.Size = new System.Drawing.Size(16, 16);
            this.ivRowEnd.TabIndex = 7;
            // 
            // cbLastRow
            // 
            this.cbLastRow.AutoSize = true;
            this.cbLastRow.Location = new System.Drawing.Point(205, 46);
            this.cbLastRow.Name = "cbLastRow";
            this.cbLastRow.Size = new System.Drawing.Size(72, 16);
            this.cbLastRow.TabIndex = 8;
            this.cbLastRow.Text = "最后一行";
            this.cbLastRow.UseVisualStyleBackColor = true;
            // 
            // pRowNum
            // 
            this.pRowNum.Controls.Add(this.label3);
            this.pRowNum.Controls.Add(this.label4);
            this.pRowNum.Controls.Add(this.tbRowStart);
            this.pRowNum.Controls.Add(this.tbRowEnd);
            this.pRowNum.Controls.Add(this.cbLastRow);
            this.pRowNum.Controls.Add(this.ivRowStart);
            this.pRowNum.Controls.Add(this.ivRowEnd);
            this.pRowNum.Location = new System.Drawing.Point(24, 92);
            this.pRowNum.Name = "pRowNum";
            this.pRowNum.Size = new System.Drawing.Size(301, 71);
            this.pRowNum.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(288, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 12);
            this.label7.TabIndex = 39;
            this.label7.Text = "Excel对象为空时，请先新建打开Excel流程";
            // 
            // DeleteRowUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DeleteRowUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.pRowNum.ResumeLayout(false);
            this.pRowNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbExcelName;
        private System.Windows.Forms.TextBox tbRowEnd;
        private System.Windows.Forms.TextBox tbRowStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbDeleteRange;
        private System.Windows.Forms.RadioButton rbDeleteAll;
        private System.Windows.Forms.RadioButton rbLast;
        private System.Windows.Forms.RadioButton rbFirst;
        private System.Windows.Forms.Label label5;
        private litsdk.InsertVarName ivRowEnd;
        private litsdk.InsertVarName ivRowStart;
        private System.Windows.Forms.CheckBox cbLastRow;
        private System.Windows.Forms.Panel pRowNum;
        private System.Windows.Forms.Label label7;
    }
}
