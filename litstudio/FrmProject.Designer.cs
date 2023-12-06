
namespace litstudio
{
    partial class FrmProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProject));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.svApiVariables = new litsdk.SelectMultVarName();
            this.svApiReturn = new litsdk.SelectMultVarName();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "启动参数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "项目备注";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(80, 95);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(287, 119);
            this.tbNotes.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // svApiVariables
            // 
            this.svApiVariables.Location = new System.Drawing.Point(80, 21);
            this.svApiVariables.Name = "svApiVariables";
            this.svApiVariables.Size = new System.Drawing.Size(287, 23);
            this.svApiVariables.TabIndex = 1;
            this.svApiVariables.VarNames = ((System.Collections.Generic.List<string>)(resources.GetObject("svApiVariables.VarNames")));
            // 
            // svApiReturn
            // 
            this.svApiReturn.Location = new System.Drawing.Point(80, 56);
            this.svApiReturn.Name = "svApiReturn";
            this.svApiReturn.Size = new System.Drawing.Size(287, 23);
            this.svApiReturn.TabIndex = 5;
            this.svApiReturn.VarNames = ((System.Collections.Generic.List<string>)(resources.GetObject("svApiReturn.VarNames")));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "HTTP输出";
            // 
            // FrmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 265);
            this.Controls.Add(this.svApiReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.svApiVariables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "项目属性";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private litsdk.SelectMultVarName svApiVariables;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Button btnSave;
        private litsdk.SelectMultVarName svApiReturn;
        private System.Windows.Forms.Label label3;
    }
}