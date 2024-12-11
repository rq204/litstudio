namespace litext
{
    partial class JsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsUI));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.smvVarNames = new litsdk.SelectMultVar();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ivVarNames = new litsdk.InsertVar();
            this.lblitJArray = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.scPipeUI)).BeginInit();
            this.scPipeUI.Panel1.SuspendLayout();
            this.scPipeUI.Panel2.SuspendLayout();
            this.scPipeUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scPipeUI
            // 
            // 
            // scPipeUI.Panel1
            // 
            this.scPipeUI.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnTest);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.smvVarNames);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblitJArray);
            this.splitContainer1.Panel2.Controls.Add(this.ivVarNames);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tbCode);
            this.splitContainer1.Size = new System.Drawing.Size(580, 265);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(492, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择需要处理的变量";
            // 
            // smvVarNames
            // 
            this.smvVarNames.Location = new System.Drawing.Point(126, 4);
            this.smvVarNames.Name = "smvVarNames";
            this.smvVarNames.Size = new System.Drawing.Size(262, 23);
            this.smvVarNames.TabIndex = 0;
            this.smvVarNames.VarNames = ((System.Collections.Generic.List<string>)(resources.GetObject("smvVarNames.VarNames")));
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(0, 0);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCode.Size = new System.Drawing.Size(580, 201);
            this.tbCode.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "使用V8引擎直接对litJArray变量进行操作";
            // 
            // ivVarNames
            // 
            this.ivVarNames.Location = new System.Drawing.Point(535, 203);
            this.ivVarNames.Name = "ivVarNames";
            this.ivVarNames.Size = new System.Drawing.Size(20, 23);
            this.ivVarNames.TabIndex = 2;
            // 
            // lblitJArray
            // 
            this.lblitJArray.AutoSize = true;
            this.lblitJArray.Location = new System.Drawing.Point(463, 208);
            this.lblitJArray.Name = "lblitJArray";
            this.lblitJArray.Size = new System.Drawing.Size(53, 12);
            this.lblitJArray.TabIndex = 3;
            this.lblitJArray.TabStop = true;
            this.lblitJArray.Text = "litJArry";
            this.lblitJArray.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblitJArray_LinkClicked);
            // 
            // JsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "JsUI";
            this.scPipeUI.Panel1.ResumeLayout(false);
            this.scPipeUI.Panel2.ResumeLayout(false);
            this.scPipeUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPipeUI)).EndInit();
            this.scPipeUI.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private litsdk.SelectMultVar smvVarNames;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.LinkLabel lblitJArray;
        private litsdk.InsertVar ivVarNames;
        private System.Windows.Forms.Label label3;
    }
}
