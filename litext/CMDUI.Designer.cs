namespace litext
{
    partial class CMDUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMDUI));
            this.label2 = new System.Windows.Forms.Label();
            this.smvVarList = new litsdk.SelectMultVar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.insertVar1 = new litsdk.InsertVar();
            ((System.ComponentModel.ISupportInitialize)(this.scPipeUI)).BeginInit();
            this.scPipeUI.Panel1.SuspendLayout();
            this.scPipeUI.Panel2.SuspendLayout();
            this.scPipeUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // scPipeUI
            // 
            // 
            // scPipeUI.Panel1
            // 
            this.scPipeUI.Panel1.Controls.Add(this.insertVar1);
            this.scPipeUI.Panel1.Controls.Add(this.textBox1);
            this.scPipeUI.Panel1.Controls.Add(this.btnTest);
            this.scPipeUI.Panel1.Controls.Add(this.smvVarList);
            this.scPipeUI.Panel1.Controls.Add(this.label5);
            this.scPipeUI.Panel1.Controls.Add(this.label3);
            this.scPipeUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "要操作的变量";
            // 
            // smvVarList
            // 
            this.smvVarList.Location = new System.Drawing.Point(119, 35);
            this.smvVarList.Name = "smvVarList";
            this.smvVarList.Size = new System.Drawing.Size(307, 23);
            this.smvVarList.TabIndex = 1;
            this.smvVarList.VarNames = ((System.Collections.Generic.List<string>)(resources.GetObject("smvVarList.VarNames")));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "EXE可执行文件";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(531, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "执行EXE文件的原理是将变量转成json字符，通过命令行方式传送给可执行程序，PHP在执行完后再以json格式输出，再反解回变量值。请使用创建PHP文件功能新建脚" +
    "本。";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(121, 121);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "测试执行";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 21);
            this.textBox1.TabIndex = 11;
            // 
            // insertVar1
            // 
            this.insertVar1.Location = new System.Drawing.Point(407, 77);
            this.insertVar1.Name = "insertVar1";
            this.insertVar1.Size = new System.Drawing.Size(20, 23);
            this.insertVar1.TabIndex = 12;
            // 
            // CMDUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CMDUI";
            this.scPipeUI.Panel1.ResumeLayout(false);
            this.scPipeUI.Panel1.PerformLayout();
            this.scPipeUI.Panel2.ResumeLayout(false);
            this.scPipeUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPipeUI)).EndInit();
            this.scPipeUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private litsdk.SelectMultVar smvVarList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTest;
        private litsdk.InsertVar insertVar1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
