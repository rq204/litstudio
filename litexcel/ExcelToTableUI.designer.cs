namespace litexcel
{
    partial class ExcelToTableUI
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
            this.rbExcelDataToTable = new System.Windows.Forms.RadioButton();
            this.rbTableDataToExcel = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbExcelFilePath = new System.Windows.Forms.TextBox();
            this.tbSheetName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.svTableVarName = new litsdk.SelectVarName();
            this.llbCurrentDir = new System.Windows.Forms.LinkLabel();
            this.ivExcelFilePath = new litsdk.InsertVarName();
            this.ivSheetName = new litsdk.InsertVarName();
            this.cbOverWrite = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
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
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.cbOverWrite);
            this.scActivityUI.Panel1.Controls.Add(this.llbCurrentDir);
            this.scActivityUI.Panel1.Controls.Add(this.ivSheetName);
            this.scActivityUI.Panel1.Controls.Add(this.ivExcelFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.svTableVarName);
            this.scActivityUI.Panel1.Controls.Add(this.tbSheetName);
            this.scActivityUI.Panel1.Controls.Add(this.tbExcelFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.rbTableDataToExcel);
            this.scActivityUI.Panel1.Controls.Add(this.rbExcelDataToTable);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "操作类型";
            // 
            // rbExcelDataToTable
            // 
            this.rbExcelDataToTable.AutoSize = true;
            this.rbExcelDataToTable.Location = new System.Drawing.Point(90, 21);
            this.rbExcelDataToTable.Name = "rbExcelDataToTable";
            this.rbExcelDataToTable.Size = new System.Drawing.Size(149, 16);
            this.rbExcelDataToTable.TabIndex = 1;
            this.rbExcelDataToTable.TabStop = true;
            this.rbExcelDataToTable.Text = "Excel数据写入表格变量";
            this.rbExcelDataToTable.UseVisualStyleBackColor = true;
            // 
            // rbTableDataToExcel
            // 
            this.rbTableDataToExcel.AutoSize = true;
            this.rbTableDataToExcel.Location = new System.Drawing.Point(262, 21);
            this.rbTableDataToExcel.Name = "rbTableDataToExcel";
            this.rbTableDataToExcel.Size = new System.Drawing.Size(149, 16);
            this.rbTableDataToExcel.TabIndex = 1;
            this.rbTableDataToExcel.TabStop = true;
            this.rbTableDataToExcel.Text = "表格变量写入Excel文档";
            this.rbTableDataToExcel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Excel文档";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sheet名称";
            // 
            // tbExcelFilePath
            // 
            this.tbExcelFilePath.Location = new System.Drawing.Point(90, 53);
            this.tbExcelFilePath.Name = "tbExcelFilePath";
            this.tbExcelFilePath.Size = new System.Drawing.Size(321, 21);
            this.tbExcelFilePath.TabIndex = 2;
            // 
            // tbSheetName
            // 
            this.tbSheetName.Location = new System.Drawing.Point(90, 92);
            this.tbSheetName.Name = "tbSheetName";
            this.tbSheetName.Size = new System.Drawing.Size(134, 21);
            this.tbSheetName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "表格变量";
            // 
            // svTableVarName
            // 
            this.svTableVarName.Location = new System.Drawing.Point(90, 132);
            this.svTableVarName.Name = "svTableVarName";
            this.svTableVarName.Size = new System.Drawing.Size(161, 23);
            this.svTableVarName.TabIndex = 3;
            this.svTableVarName.VarName = "";
            // 
            // llbCurrentDir
            // 
            this.llbCurrentDir.AutoSize = true;
            this.llbCurrentDir.Location = new System.Drawing.Point(443, 58);
            this.llbCurrentDir.Name = "llbCurrentDir";
            this.llbCurrentDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurrentDir.TabIndex = 6;
            this.llbCurrentDir.TabStop = true;
            this.llbCurrentDir.Text = "[当前目录]";
            this.llbCurrentDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurrentDir_LinkClicked);
            // 
            // ivExcelFilePath
            // 
            this.ivExcelFilePath.Location = new System.Drawing.Point(417, 55);
            this.ivExcelFilePath.Name = "ivExcelFilePath";
            this.ivExcelFilePath.Size = new System.Drawing.Size(20, 23);
            this.ivExcelFilePath.TabIndex = 5;
            // 
            // ivSheetName
            // 
            this.ivSheetName.Location = new System.Drawing.Point(231, 92);
            this.ivSheetName.Name = "ivSheetName";
            this.ivSheetName.Size = new System.Drawing.Size(20, 23);
            this.ivSheetName.TabIndex = 5;
            // 
            // cbOverWrite
            // 
            this.cbOverWrite.AutoSize = true;
            this.cbOverWrite.Location = new System.Drawing.Point(445, 23);
            this.cbOverWrite.Name = "cbOverWrite";
            this.cbOverWrite.Size = new System.Drawing.Size(96, 16);
            this.cbOverWrite.TabIndex = 7;
            this.cbOverWrite.Text = "覆盖原来数据";
            this.cbOverWrite.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(88, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "该组件直接操作Excel和表格，并在操作完成后直接关闭Excel文件";
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(514, 58);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 9;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // ExcelToTableUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ExcelToTableUI";
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
        private System.Windows.Forms.RadioButton rbTableDataToExcel;
        private System.Windows.Forms.RadioButton rbExcelDataToTable;
        private System.Windows.Forms.TextBox tbSheetName;
        private System.Windows.Forms.TextBox tbExcelFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private litsdk.SelectVarName svTableVarName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel llbCurrentDir;
        private litsdk.InsertVarName ivSheetName;
        private litsdk.InsertVarName ivExcelFilePath;
        private System.Windows.Forms.CheckBox cbOverWrite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llbOpen;
    }
}
