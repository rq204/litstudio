using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using litsdk;

namespace litapps
{
    internal partial class AppStartUI : litsdk.ILitUI
    {
        public AppStartUI()
        {
            InitializeComponent();
            this.ivAppPath.ShowVarName(true, false, true, this.tbAppPath);
            this.ivArguments.ShowVarName(true, false, true, this.tbArguments);
            this.ivWorkingDirectory.ShowVarName(true, false, true, this.tbWorkingDirectory);
            this.svSaveVarName.ShowVarName(true, false, false);

            this.SaveActivity = new Action(() =>
              {
                  sa.AppPath = this.tbAppPath.Text.Trim();
                  sa.Arguments = this.tbArguments.Text.Trim();
                  sa.SaveVarName = this.svSaveVarName.VarName;
                  sa.WorkingDirectory = this.tbWorkingDirectory.Text.Trim();
                  sa.WaitProcess = this.cbWaitProcess.Checked;
                  sa.Name = this.tbActivityName.Text.Trim();
                  sa.DefaultApp = this.cbDefaultApp.Checked;
                  sa.Hide = this.cbHide.Checked;
                  sa.TimeOutSeconds = (int)this.nudTimeOutSeconds.Value;
                  sa.OutputEncoding = this.cbOutputEncoding.Text;
              });
        }

        AppStartActivity sa = null;
        public override void SetActivity(Activity activity)
        {
            sa = activity as AppStartActivity;
            this.tbAppPath.Text = sa.AppPath;
            this.tbArguments.Text = sa.Arguments;
            this.tbWorkingDirectory.Text = sa.WorkingDirectory;
            this.svSaveVarName.VarName = sa.SaveVarName;
            this.cbWaitProcess.Checked = sa.WaitProcess;
            this.tbActivityName.Text = sa.Name;
            this.cbDefaultApp.Checked = sa.DefaultApp;
            this.cbHide.Checked = sa.Hide;
            this.cbOutputEncoding.Text = sa.OutputEncoding;
        }

        private void cbWaitProcess_CheckedChanged(object sender, EventArgs e)
        {
            this.lbTimeOut.Visible = this.llbOutResult.Visible = this.svSaveVarName.Visible = this.nudTimeOutSeconds.Visible = this.lbOutEncoding.Visible = this.cbOutputEncoding.Visible = this.cbWaitProcess.Checked;
        }

        private void cbDefaultApp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbDefaultApp.Checked) this.cbWaitProcess.Checked = false;
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "可执行文件|*.exe;*.vbs;*.bat;*.com;*.sys";
            if (of.ShowDialog() == DialogResult.OK)
            {
                this.tbAppPath.Text = of.FileName;
            }
        }

        private void llbCurrentDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbAppPath, this.llbCurrentDir.Text);
        }
    }
}
