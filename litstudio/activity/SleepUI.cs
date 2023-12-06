using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using litsdk;

namespace litstudio
{
    internal class SleepUI : ILitUI
    {
        public SleepUI()
        {
            this.InitializeComponent();
            this.svIntVarName.ShowVarName(false, false, true, false);
            base.SaveActivity = new Action(() =>
            {
                sa.MilliSeconds = (int)this.nudSleepSeconds.Value;

                sa.MilliSecondsEnd = (int)this.nudSleepSecondsEnd.Value;
                sa.UseRandNum = this.cbUseRand.Checked;
                sa.UseVariable = this.cbUseVar.Checked;
                sa.IntVarName = this.svIntVarName.VarName;

                sa.Name = this.tbActivityName.Text.Trim();
            });
        }

        private Label label1;
        private NumericUpDown nudSleepSeconds;
        private SelectVarName svIntVarName;
        private Label lbVar;
        private NumericUpDown nudSleepSecondsEnd;
        private Label lbZhi;
        private CheckBox cbUseRand;
        private CheckBox cbUseVar;
        litcore.activity.SleepActivity sa = null;
        public override void SetActivity(Activity activity)
        {
            sa = activity as litcore.activity.SleepActivity;
            this.nudSleepSeconds.Value = sa.MilliSeconds;
            this.nudSleepSecondsEnd.Value = sa.MilliSecondsEnd;
            this.cbUseRand.Checked = sa.UseRandNum;
            this.cbUseVar.Checked = sa.UseVariable;
            this.svIntVarName.VarName = sa.IntVarName;
            this.tbActivityName.Text = sa.Name;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nudSleepSeconds = new System.Windows.Forms.NumericUpDown();
            this.svIntVarName = new litsdk.SelectVarName();
            this.lbVar = new System.Windows.Forms.Label();
            this.cbUseRand = new System.Windows.Forms.CheckBox();
            this.lbZhi = new System.Windows.Forms.Label();
            this.nudSleepSecondsEnd = new System.Windows.Forms.NumericUpDown();
            this.cbUseVar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepSecondsEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.cbUseVar);
            this.scActivityUI.Panel1.Controls.Add(this.nudSleepSecondsEnd);
            this.scActivityUI.Panel1.Controls.Add(this.lbZhi);
            this.scActivityUI.Panel1.Controls.Add(this.cbUseRand);
            this.scActivityUI.Panel1.Controls.Add(this.svIntVarName);
            this.scActivityUI.Panel1.Controls.Add(this.lbVar);
            this.scActivityUI.Panel1.Controls.Add(this.nudSleepSeconds);
            this.scActivityUI.Panel1.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "暂停毫秒";
            // 
            // nudSleepSeconds
            // 
            this.nudSleepSeconds.Location = new System.Drawing.Point(104, 37);
            this.nudSleepSeconds.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.nudSleepSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSleepSeconds.Name = "nudSleepSeconds";
            this.nudSleepSeconds.Size = new System.Drawing.Size(86, 21);
            this.nudSleepSeconds.TabIndex = 1;
            this.nudSleepSeconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // svIntVarName
            // 
            this.svIntVarName.Location = new System.Drawing.Point(104, 80);
            this.svIntVarName.Name = "svIntVarName";
            this.svIntVarName.Size = new System.Drawing.Size(131, 23);
            this.svIntVarName.TabIndex = 8;
            this.svIntVarName.VarName = "";
            this.svIntVarName.Visible = false;
            // 
            // lbVar
            // 
            this.lbVar.AutoSize = true;
            this.lbVar.Location = new System.Drawing.Point(38, 84);
            this.lbVar.Name = "lbVar";
            this.lbVar.Size = new System.Drawing.Size(53, 12);
            this.lbVar.TabIndex = 7;
            this.lbVar.Text = "使用变量";
            this.lbVar.Visible = false;
            // 
            // cbUseRand
            // 
            this.cbUseRand.AutoSize = true;
            this.cbUseRand.Location = new System.Drawing.Point(341, 40);
            this.cbUseRand.Name = "cbUseRand";
            this.cbUseRand.Size = new System.Drawing.Size(84, 16);
            this.cbUseRand.TabIndex = 9;
            this.cbUseRand.Text = "使用随机数";
            this.cbUseRand.UseVisualStyleBackColor = true;
            this.cbUseRand.CheckedChanged += new System.EventHandler(this.cbUseRand_CheckedChanged);
            // 
            // lbZhi
            // 
            this.lbZhi.AutoSize = true;
            this.lbZhi.Location = new System.Drawing.Point(202, 41);
            this.lbZhi.Name = "lbZhi";
            this.lbZhi.Size = new System.Drawing.Size(17, 12);
            this.lbZhi.TabIndex = 10;
            this.lbZhi.Text = "至";
            this.lbZhi.Visible = false;
            // 
            // nudSleepSecondsEnd
            // 
            this.nudSleepSecondsEnd.Location = new System.Drawing.Point(232, 37);
            this.nudSleepSecondsEnd.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.nudSleepSecondsEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSleepSecondsEnd.Name = "nudSleepSecondsEnd";
            this.nudSleepSecondsEnd.Size = new System.Drawing.Size(86, 21);
            this.nudSleepSecondsEnd.TabIndex = 11;
            this.nudSleepSecondsEnd.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSleepSecondsEnd.Visible = false;
            // 
            // cbUseVar
            // 
            this.cbUseVar.AutoSize = true;
            this.cbUseVar.Location = new System.Drawing.Point(431, 40);
            this.cbUseVar.Name = "cbUseVar";
            this.cbUseVar.Size = new System.Drawing.Size(72, 16);
            this.cbUseVar.TabIndex = 12;
            this.cbUseVar.Text = "使用变量";
            this.cbUseVar.UseVisualStyleBackColor = true;
            this.cbUseVar.CheckedChanged += new System.EventHandler(this.cbUseVar_CheckedChanged);
            // 
            // SleepUI
            // 
            this.Name = "SleepUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepSecondsEnd)).EndInit();
            this.ResumeLayout(false);

        }

        private void cbUseRand_CheckedChanged(object sender, EventArgs e)
        {
            this.lbZhi.Visible = this.nudSleepSecondsEnd.Visible = this.cbUseRand.Checked;
            if (this.cbUseRand.Checked) this.cbUseVar.Checked = false;
        }

        private void cbUseVar_CheckedChanged(object sender, EventArgs e)
        {
            this.lbVar.Visible = this.svIntVarName.Visible = this.cbUseVar.Checked;
            if (this.cbUseVar.Checked) this.cbUseRand.Checked = false;
        }
    }
}
