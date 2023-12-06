namespace litstudio
{
    partial class FormUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.svSourceVarName = new litsdk.SelectVarName();
            this.svTableVarName = new litsdk.SelectVarName();
            this.tbFormName = new System.Windows.Forms.TextBox();
            this.ivFormName = new litsdk.InsertVarName();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbInput = new System.Windows.Forms.RadioButton();
            this.rbFirstTable = new System.Windows.Forms.RadioButton();
            this.rbLastTable = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbOnlyNameValue = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbClearTable = new System.Windows.Forms.CheckBox();
            this.cbRemoveAspNetInput = new System.Windows.Forms.CheckBox();
            this.cbRemoveSubmit = new System.Windows.Forms.CheckBox();
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
            this.scActivityUI.Panel1.Controls.Add(this.cbRemoveSubmit);
            this.scActivityUI.Panel1.Controls.Add(this.cbClearTable);
            this.scActivityUI.Panel1.Controls.Add(this.cbRemoveAspNetInput);
            this.scActivityUI.Panel1.Controls.Add(this.cbOnlyNameValue);
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.rbLastTable);
            this.scActivityUI.Panel1.Controls.Add(this.rbFirstTable);
            this.scActivityUI.Panel1.Controls.Add(this.rbInput);
            this.scActivityUI.Panel1.Controls.Add(this.rbAll);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.ivFormName);
            this.scActivityUI.Panel1.Controls.Add(this.tbFormName);
            this.scActivityUI.Panel1.Controls.Add(this.svTableVarName);
            this.scActivityUI.Panel1.Controls.Add(this.svSourceVarName);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label9);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "源字符串";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "表单名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "保存变量";
            // 
            // svSourceVarName
            // 
            this.svSourceVarName.Location = new System.Drawing.Point(82, 52);
            this.svSourceVarName.Name = "svSourceVarName";
            this.svSourceVarName.Size = new System.Drawing.Size(165, 23);
            this.svSourceVarName.TabIndex = 1;
            this.svSourceVarName.VarName = "";
            // 
            // svTableVarName
            // 
            this.svTableVarName.Location = new System.Drawing.Point(82, 125);
            this.svTableVarName.Name = "svTableVarName";
            this.svTableVarName.Size = new System.Drawing.Size(159, 23);
            this.svTableVarName.TabIndex = 1;
            this.svTableVarName.VarName = "";
            // 
            // tbFormName
            // 
            this.tbFormName.Location = new System.Drawing.Point(82, 88);
            this.tbFormName.Name = "tbFormName";
            this.tbFormName.Size = new System.Drawing.Size(137, 21);
            this.tbFormName.TabIndex = 2;
            // 
            // ivFormName
            // 
            this.ivFormName.Location = new System.Drawing.Point(225, 90);
            this.ivFormName.Name = "ivFormName";
            this.ivFormName.Size = new System.Drawing.Size(16, 16);
            this.ivFormName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(262, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "提取结果保存至表格变量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "提取方式";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(82, 19);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(95, 16);
            this.rbAll.TabIndex = 5;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "所有表单元素";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbInput
            // 
            this.rbInput.AutoSize = true;
            this.rbInput.Location = new System.Drawing.Point(183, 19);
            this.rbInput.Name = "rbInput";
            this.rbInput.Size = new System.Drawing.Size(89, 16);
            this.rbInput.TabIndex = 5;
            this.rbInput.TabStop = true;
            this.rbInput.Text = "仅Input元素";
            this.rbInput.UseVisualStyleBackColor = true;
            // 
            // rbFirstTable
            // 
            this.rbFirstTable.AutoSize = true;
            this.rbFirstTable.Location = new System.Drawing.Point(278, 19);
            this.rbFirstTable.Name = "rbFirstTable";
            this.rbFirstTable.Size = new System.Drawing.Size(83, 16);
            this.rbFirstTable.TabIndex = 5;
            this.rbFirstTable.TabStop = true;
            this.rbFirstTable.Text = "第一个表格";
            this.rbFirstTable.UseVisualStyleBackColor = true;
            this.rbFirstTable.Visible = false;
            // 
            // rbLastTable
            // 
            this.rbLastTable.AutoSize = true;
            this.rbLastTable.Location = new System.Drawing.Point(369, 19);
            this.rbLastTable.Name = "rbLastTable";
            this.rbLastTable.Size = new System.Drawing.Size(95, 16);
            this.rbLastTable.TabIndex = 5;
            this.rbLastTable.TabStop = true;
            this.rbLastTable.Text = "最后一个表格";
            this.rbLastTable.UseVisualStyleBackColor = true;
            this.rbLastTable.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(262, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "表单名称为空则从整个字符中提取";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(262, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "源字符串需要包含闭合完整的html代码";
            // 
            // cbOnlyNameValue
            // 
            this.cbOnlyNameValue.AutoSize = true;
            this.cbOnlyNameValue.Location = new System.Drawing.Point(235, 165);
            this.cbOnlyNameValue.Name = "cbOnlyNameValue";
            this.cbOnlyNameValue.Size = new System.Drawing.Size(162, 16);
            this.cbOnlyNameValue.TabIndex = 7;
            this.cbOnlyNameValue.Text = "表单仅保存name和value值";
            this.cbOnlyNameValue.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "保存选项";
            // 
            // cbClearTable
            // 
            this.cbClearTable.AutoSize = true;
            this.cbClearTable.Location = new System.Drawing.Point(80, 165);
            this.cbClearTable.Name = "cbClearTable";
            this.cbClearTable.Size = new System.Drawing.Size(144, 16);
            this.cbClearTable.TabIndex = 7;
            this.cbClearTable.Text = "保存前清空原表格数据";
            this.cbClearTable.UseVisualStyleBackColor = true;
            // 
            // cbRemoveAspNetInput
            // 
            this.cbRemoveAspNetInput.AutoSize = true;
            this.cbRemoveAspNetInput.Location = new System.Drawing.Point(79, 193);
            this.cbRemoveAspNetInput.Name = "cbRemoveAspNetInput";
            this.cbRemoveAspNetInput.Size = new System.Drawing.Size(126, 16);
            this.cbRemoveAspNetInput.TabIndex = 7;
            this.cbRemoveAspNetInput.Text = "去ASP.NET窗体参数";
            this.cbRemoveAspNetInput.UseVisualStyleBackColor = true;
            // 
            // cbRemoveSubmit
            // 
            this.cbRemoveSubmit.AutoSize = true;
            this.cbRemoveSubmit.Location = new System.Drawing.Point(235, 194);
            this.cbRemoveSubmit.Name = "cbRemoveSubmit";
            this.cbRemoveSubmit.Size = new System.Drawing.Size(138, 16);
            this.cbRemoveSubmit.TabIndex = 8;
            this.cbRemoveSubmit.Text = "去掉Submit类型Input";
            this.cbRemoveSubmit.UseVisualStyleBackColor = true;
            // 
            // FormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FormUI";
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
        private litsdk.SelectVarName svSourceVarName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private litsdk.SelectVarName svTableVarName;
        private litsdk.InsertVarName ivFormName;
        private System.Windows.Forms.TextBox tbFormName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbLastTable;
        private System.Windows.Forms.RadioButton rbFirstTable;
        private System.Windows.Forms.RadioButton rbInput;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbOnlyNameValue;
        private System.Windows.Forms.CheckBox cbClearTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbRemoveAspNetInput;
        private System.Windows.Forms.CheckBox cbRemoveSubmit;
    }
}
