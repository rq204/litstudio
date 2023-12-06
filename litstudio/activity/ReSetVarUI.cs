using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using litsdk;
using litstudio;

namespace litstudio
{
    internal class ReSetVarUI : ILitUI
    {
        public ReSetVarUI()
        {
            this.InitializeComponent();
            this.svSaveVarName.ShowVarName(true, true, true);
            this.ivContent.ShowVarName(true, false, true, this.tbSetVarValue);
            this.smvEmptyVarNames.ShowVarName(true, true, true, true);
            base.SaveActivity = new Action(() =>
            {
                ea.SaveVarName = this.svSaveVarName.VarName;
                ea.SetVarValue = this.tbSetVarValue.Text;
                ea.Name = this.tbActivityName.Text.Trim();
                ActivityContext context = litsdk.API.GetDesignActivityContext();
                if (context.ContainsStr(ea.SaveVarName)) ea.VariableType = VariableType.String;
                else if (context.ContainsList(ea.SaveVarName)) ea.VariableType = VariableType.List;
                else if (context.ContainsInt(ea.SaveVarName)) ea.VariableType = VariableType.Int;
                ea.EmptyVarNames = this.smvEmptyVarNames.VarNames;
            });
        }
        private Label label2;
        private SelectVarName svSaveVarName;
        private Label label3;
        private InsertVarName ivContent;
        private Label label4;
        private LinkLabel llbValueDir;
        private LinkLabel llbTempFileName;
        private SelectMultVarName smvEmptyVarNames;
        private Label label5;
        private Label label6;
        private TextBox tbSetVarValue;

        public override void SetActivity(Activity activity)
        {
            this.ea = activity as litcore.activity.ReSetVarActivity;
            this.tbSetVarValue.Text = ea.SetVarValue;
            this.svSaveVarName.VarName = ea.SaveVarName;
            this.tbActivityName.Text = ea.Name;
            this.smvEmptyVarNames.VarNames = ea.EmptyVarNames;
        }

        litcore.activity.ReSetVarActivity ea = null;


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReSetVarUI));
            this.label2 = new System.Windows.Forms.Label();
            this.tbSetVarValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.ivContent = new litsdk.InsertVarName();
            this.label4 = new System.Windows.Forms.Label();
            this.llbValueDir = new System.Windows.Forms.LinkLabel();
            this.llbTempFileName = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.smvEmptyVarNames = new litsdk.SelectMultVarName();
            this.label6 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.smvEmptyVarNames);
            this.scActivityUI.Panel1.Controls.Add(this.llbTempFileName);
            this.scActivityUI.Panel1.Controls.Add(this.llbValueDir);
            this.scActivityUI.Panel1.Controls.Add(this.ivContent);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.tbSetVarValue);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "重置变量名称";
            // 
            // tbSetVarValue
            // 
            this.tbSetVarValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSetVarValue.Location = new System.Drawing.Point(92, 50);
            this.tbSetVarValue.MaxLength = 302767;
            this.tbSetVarValue.Multiline = true;
            this.tbSetVarValue.Name = "tbSetVarValue";
            this.tbSetVarValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSetVarValue.Size = new System.Drawing.Size(401, 107);
            this.tbSetVarValue.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "重置变量内容";
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(92, 14);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(189, 23);
            this.svSaveVarName.TabIndex = 3;
            this.svSaveVarName.VarName = "";
            // 
            // ivContent
            // 
            this.ivContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivContent.Location = new System.Drawing.Point(503, 53);
            this.ivContent.Name = "ivContent";
            this.ivContent.Size = new System.Drawing.Size(20, 23);
            this.ivContent.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(287, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "列表变量为一行一条记录，其它变量直接转换";
            // 
            // llbValueDir
            // 
            this.llbValueDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llbValueDir.AutoSize = true;
            this.llbValueDir.Location = new System.Drawing.Point(501, 119);
            this.llbValueDir.Name = "llbValueDir";
            this.llbValueDir.Size = new System.Drawing.Size(65, 12);
            this.llbValueDir.TabIndex = 9;
            this.llbValueDir.TabStop = true;
            this.llbValueDir.Text = "[当前目录]";
            this.llbValueDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbValueDir_LinkClicked);
            // 
            // llbTempFileName
            // 
            this.llbTempFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llbTempFileName.AutoSize = true;
            this.llbTempFileName.Location = new System.Drawing.Point(499, 145);
            this.llbTempFileName.Name = "llbTempFileName";
            this.llbTempFileName.Size = new System.Drawing.Size(65, 12);
            this.llbTempFileName.TabIndex = 10;
            this.llbTempFileName.TabStop = true;
            this.llbTempFileName.Text = "[临时文件]";
            this.llbTempFileName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTempFileName_LinkClicked);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "清空选定变量";
            // 
            // smvEmptyVarNames
            // 
            this.smvEmptyVarNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smvEmptyVarNames.Location = new System.Drawing.Point(92, 176);
            this.smvEmptyVarNames.Name = "smvEmptyVarNames";
            this.smvEmptyVarNames.Size = new System.Drawing.Size(474, 23);
            this.smvEmptyVarNames.TabIndex = 11;
            this.smvEmptyVarNames.VarNames = ((System.Collections.Generic.List<string>)(resources.GetObject("smvEmptyVarNames.VarNames")));
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(90, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "变量重置和清空变量可以二项配置一项，也可以同时配置两项";
            // 
            // ReSetVarUI
            // 
            this.Name = "ReSetVarUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void llbValueDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbSetVarValue, this.llbValueDir.Text);
        }

        private void llbTempFileName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbSetVarValue, this.llbTempFileName.Text);
        }
    }
}