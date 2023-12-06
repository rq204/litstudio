namespace litexcel
{
    partial class ExcelInfoUI
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
            this.cbExcelName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.svSheetNames = new litsdk.SelectVarName();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.svSheetRowCount = new litsdk.SelectVarName();
            this.label3 = new System.Windows.Forms.Label();
            this.svSheetHeaders = new litsdk.SelectVarName();
            this.label7 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.svSheetHeaders);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.svSheetRowCount);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.svSheetNames);
            this.scActivityUI.Panel1.Controls.Add(this.cbExcelName);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            // 
            // cbExcelName
            // 
            this.cbExcelName.FormattingEnabled = true;
            this.cbExcelName.Location = new System.Drawing.Point(206, 22);
            this.cbExcelName.Name = "cbExcelName";
            this.cbExcelName.Size = new System.Drawing.Size(124, 20);
            this.cbExcelName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Excel对象";
            // 
            // svSheetNames
            // 
            this.svSheetNames.Location = new System.Drawing.Point(206, 59);
            this.svSheetNames.Name = "svSheetNames";
            this.svSheetNames.Size = new System.Drawing.Size(149, 23);
            this.svSheetNames.TabIndex = 9;
            this.svSheetNames.VarName = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "所有工作表名称至列表变量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "获取当前工作表总行数至数字变量";
            // 
            // svSheetRowCount
            // 
            this.svSheetRowCount.Location = new System.Drawing.Point(206, 95);
            this.svSheetRowCount.Name = "svSheetRowCount";
            this.svSheetRowCount.Size = new System.Drawing.Size(149, 23);
            this.svSheetRowCount.TabIndex = 12;
            this.svSheetRowCount.VarName = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "当前工作表表头至列表变量";
            // 
            // svSheetHeaders
            // 
            this.svSheetHeaders.Location = new System.Drawing.Point(206, 132);
            this.svSheetHeaders.Name = "svSheetHeaders";
            this.svSheetHeaders.Size = new System.Drawing.Size(149, 23);
            this.svSheetHeaders.TabIndex = 14;
            this.svSheetHeaders.VarName = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(336, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "Excel对象为空时，请先新建打开Excel流程";
            // 
            // ExcelInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ExcelInfoUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbExcelName;
        private System.Windows.Forms.Label label4;
        private litsdk.SelectVarName svSheetNames;
        private litsdk.SelectVarName svSheetHeaders;
        private System.Windows.Forms.Label label3;
        private litsdk.SelectVarName svSheetRowCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}
