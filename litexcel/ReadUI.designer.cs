namespace litexcel
{
    partial class ReadUI
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
            this.lbStart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbExcelName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbCell = new System.Windows.Forms.RadioButton();
            this.lbRowStart = new System.Windows.Forms.Label();
            this.rbRegion = new System.Windows.Forms.RadioButton();
            this.rbRow = new System.Windows.Forms.RadioButton();
            this.rbCol = new System.Windows.Forms.RadioButton();
            this.tbRowStart = new System.Windows.Forms.TextBox();
            this.tbColStart = new System.Windows.Forms.TextBox();
            this.lbColStart = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.tbColEnd = new System.Windows.Forms.TextBox();
            this.tbRowEnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ivRowStart = new litsdk.InsertVarName();
            this.ivRowEnd = new litsdk.InsertVarName();
            this.ivColEnd = new litsdk.InsertVarName();
            this.ivColStart = new litsdk.InsertVarName();
            this.label10 = new System.Windows.Forms.Label();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.pEnd = new System.Windows.Forms.Panel();
            this.cbLastCol = new System.Windows.Forms.CheckBox();
            this.cbLastRow = new System.Windows.Forms.CheckBox();
            this.cbSelectFirstIsHeader = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFromHref = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.pEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.cbFromHref);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.cbSelectFirstIsHeader);
            this.scActivityUI.Panel1.Controls.Add(this.pEnd);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.ivColStart);
            this.scActivityUI.Panel1.Controls.Add(this.ivRowStart);
            this.scActivityUI.Panel1.Controls.Add(this.tbColStart);
            this.scActivityUI.Panel1.Controls.Add(this.tbRowStart);
            this.scActivityUI.Panel1.Controls.Add(this.rbCol);
            this.scActivityUI.Panel1.Controls.Add(this.rbRow);
            this.scActivityUI.Panel1.Controls.Add(this.rbRegion);
            this.scActivityUI.Panel1.Controls.Add(this.rbCell);
            this.scActivityUI.Panel1.Controls.Add(this.cbExcelName);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.lbColStart);
            this.scActivityUI.Panel1.Controls.Add(this.lbRowStart);
            this.scActivityUI.Panel1.Controls.Add(this.label10);
            this.scActivityUI.Panel1.Controls.Add(this.lbStart);
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(28, 85);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(65, 12);
            this.lbStart.TabIndex = 0;
            this.lbStart.Text = "单元格位置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "读取方式";
            // 
            // cbExcelName
            // 
            this.cbExcelName.FormattingEnabled = true;
            this.cbExcelName.Location = new System.Drawing.Point(99, 16);
            this.cbExcelName.Name = "cbExcelName";
            this.cbExcelName.Size = new System.Drawing.Size(148, 20);
            this.cbExcelName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Excel对象";
            // 
            // rbCell
            // 
            this.rbCell.AutoSize = true;
            this.rbCell.Location = new System.Drawing.Point(99, 52);
            this.rbCell.Name = "rbCell";
            this.rbCell.Size = new System.Drawing.Size(59, 16);
            this.rbCell.TabIndex = 9;
            this.rbCell.Text = "单元格";
            this.rbCell.UseVisualStyleBackColor = true;
            this.rbCell.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // lbRowStart
            // 
            this.lbRowStart.AutoSize = true;
            this.lbRowStart.Location = new System.Drawing.Point(99, 84);
            this.lbRowStart.Name = "lbRowStart";
            this.lbRowStart.Size = new System.Drawing.Size(29, 12);
            this.lbRowStart.TabIndex = 0;
            this.lbRowStart.Text = "行号";
            // 
            // rbRegion
            // 
            this.rbRegion.AutoSize = true;
            this.rbRegion.Location = new System.Drawing.Point(172, 52);
            this.rbRegion.Name = "rbRegion";
            this.rbRegion.Size = new System.Drawing.Size(71, 16);
            this.rbRegion.TabIndex = 9;
            this.rbRegion.Text = "区域内容";
            this.rbRegion.UseVisualStyleBackColor = true;
            this.rbRegion.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbRow
            // 
            this.rbRow.AutoSize = true;
            this.rbRow.Location = new System.Drawing.Point(259, 52);
            this.rbRow.Name = "rbRow";
            this.rbRow.Size = new System.Drawing.Size(59, 16);
            this.rbRow.TabIndex = 9;
            this.rbRow.Text = "行内容";
            this.rbRow.UseVisualStyleBackColor = true;
            this.rbRow.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbCol
            // 
            this.rbCol.AutoSize = true;
            this.rbCol.Location = new System.Drawing.Point(335, 52);
            this.rbCol.Name = "rbCol";
            this.rbCol.Size = new System.Drawing.Size(59, 16);
            this.rbCol.TabIndex = 9;
            this.rbCol.Text = "列内容";
            this.rbCol.UseVisualStyleBackColor = true;
            this.rbCol.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tbRowStart
            // 
            this.tbRowStart.Location = new System.Drawing.Point(134, 81);
            this.tbRowStart.Name = "tbRowStart";
            this.tbRowStart.Size = new System.Drawing.Size(65, 21);
            this.tbRowStart.TabIndex = 10;
            // 
            // tbColStart
            // 
            this.tbColStart.Location = new System.Drawing.Point(278, 81);
            this.tbColStart.Name = "tbColStart";
            this.tbColStart.Size = new System.Drawing.Size(65, 21);
            this.tbColStart.TabIndex = 10;
            // 
            // lbColStart
            // 
            this.lbColStart.AutoSize = true;
            this.lbColStart.Location = new System.Drawing.Point(243, 85);
            this.lbColStart.Name = "lbColStart";
            this.lbColStart.Size = new System.Drawing.Size(29, 12);
            this.lbColStart.TabIndex = 0;
            this.lbColStart.Text = "列名";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(6, 7);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(65, 12);
            this.lbEnd.TabIndex = 0;
            this.lbEnd.Text = "末尾单元格";
            // 
            // tbColEnd
            // 
            this.tbColEnd.Location = new System.Drawing.Point(256, 5);
            this.tbColEnd.Name = "tbColEnd";
            this.tbColEnd.Size = new System.Drawing.Size(65, 21);
            this.tbColEnd.TabIndex = 13;
            // 
            // tbRowEnd
            // 
            this.tbRowEnd.Location = new System.Drawing.Point(112, 5);
            this.tbRowEnd.Name = "tbRowEnd";
            this.tbRowEnd.Size = new System.Drawing.Size(65, 21);
            this.tbRowEnd.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "列名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "行号";
            // 
            // ivRowStart
            // 
            this.ivRowStart.Location = new System.Drawing.Point(206, 84);
            this.ivRowStart.Name = "ivRowStart";
            this.ivRowStart.Size = new System.Drawing.Size(16, 16);
            this.ivRowStart.TabIndex = 15;
            // 
            // ivRowEnd
            // 
            this.ivRowEnd.Location = new System.Drawing.Point(184, 8);
            this.ivRowEnd.Name = "ivRowEnd";
            this.ivRowEnd.Size = new System.Drawing.Size(16, 16);
            this.ivRowEnd.TabIndex = 16;
            // 
            // ivColEnd
            // 
            this.ivColEnd.Location = new System.Drawing.Point(327, 7);
            this.ivColEnd.Name = "ivColEnd";
            this.ivColEnd.Size = new System.Drawing.Size(16, 16);
            this.ivColEnd.TabIndex = 17;
            // 
            // ivColStart
            // 
            this.ivColStart.Location = new System.Drawing.Point(349, 84);
            this.ivColStart.Name = "ivColStart";
            this.ivColStart.Size = new System.Drawing.Size(16, 16);
            this.ivColStart.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "保存至变量";
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(99, 159);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(157, 23);
            this.svSaveVarName.TabIndex = 19;
            this.svSaveVarName.VarName = "";
            // 
            // pEnd
            // 
            this.pEnd.Controls.Add(this.cbLastCol);
            this.pEnd.Controls.Add(this.cbLastRow);
            this.pEnd.Controls.Add(this.lbEnd);
            this.pEnd.Controls.Add(this.label9);
            this.pEnd.Controls.Add(this.label8);
            this.pEnd.Controls.Add(this.ivColEnd);
            this.pEnd.Controls.Add(this.tbRowEnd);
            this.pEnd.Controls.Add(this.ivRowEnd);
            this.pEnd.Controls.Add(this.tbColEnd);
            this.pEnd.Location = new System.Drawing.Point(22, 113);
            this.pEnd.Name = "pEnd";
            this.pEnd.Size = new System.Drawing.Size(527, 30);
            this.pEnd.TabIndex = 20;
            // 
            // cbLastCol
            // 
            this.cbLastCol.AutoSize = true;
            this.cbLastCol.Location = new System.Drawing.Point(443, 7);
            this.cbLastCol.Name = "cbLastCol";
            this.cbLastCol.Size = new System.Drawing.Size(72, 16);
            this.cbLastCol.TabIndex = 18;
            this.cbLastCol.Text = "最后一列";
            this.cbLastCol.UseVisualStyleBackColor = true;
            // 
            // cbLastRow
            // 
            this.cbLastRow.AutoSize = true;
            this.cbLastRow.Location = new System.Drawing.Point(362, 7);
            this.cbLastRow.Name = "cbLastRow";
            this.cbLastRow.Size = new System.Drawing.Size(72, 16);
            this.cbLastRow.TabIndex = 18;
            this.cbLastRow.Text = "最后一行";
            this.cbLastRow.UseVisualStyleBackColor = true;
            // 
            // cbSelectFirstIsHeader
            // 
            this.cbSelectFirstIsHeader.AutoSize = true;
            this.cbSelectFirstIsHeader.Location = new System.Drawing.Point(384, 85);
            this.cbSelectFirstIsHeader.Name = "cbSelectFirstIsHeader";
            this.cbSelectFirstIsHeader.Size = new System.Drawing.Size(168, 16);
            this.cbSelectFirstIsHeader.TabIndex = 21;
            this.cbSelectFirstIsHeader.Text = "区域或列第一行为表格表头";
            this.cbSelectFirstIsHeader.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(36, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(503, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "列名默认的是ABCD这个Excel列，如果选中区域或列第一行为表格表头，也可以使用该表头的值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(257, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "Excel对象为空时，请先新建打开Excel流程";
            // 
            // cbFromHref
            // 
            this.cbFromHref.AutoSize = true;
            this.cbFromHref.Location = new System.Drawing.Point(278, 162);
            this.cbFromHref.Name = "cbFromHref";
            this.cbFromHref.Size = new System.Drawing.Size(108, 16);
            this.cbFromHref.TabIndex = 41;
            this.cbFromHref.Text = "取单元格超链接";
            this.cbFromHref.UseVisualStyleBackColor = true;
            // 
            // ReadUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ReadUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.pEnd.ResumeLayout(false);
            this.pEnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCell;
        private System.Windows.Forms.ComboBox cbExcelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbCol;
        private System.Windows.Forms.RadioButton rbRow;
        private System.Windows.Forms.RadioButton rbRegion;
        private System.Windows.Forms.Label lbRowStart;
        private System.Windows.Forms.TextBox tbColEnd;
        private System.Windows.Forms.TextBox tbRowEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbColStart;
        private System.Windows.Forms.TextBox tbRowStart;
        private System.Windows.Forms.Label lbColStart;
        private System.Windows.Forms.Label lbEnd;
        private litsdk.SelectVarName svSaveVarName;
        private litsdk.InsertVarName ivColStart;
        private litsdk.InsertVarName ivColEnd;
        private litsdk.InsertVarName ivRowEnd;
        private litsdk.InsertVarName ivRowStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pEnd;
        private System.Windows.Forms.CheckBox cbLastCol;
        private System.Windows.Forms.CheckBox cbLastRow;
        private System.Windows.Forms.CheckBox cbSelectFirstIsHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbFromHref;
    }
}
