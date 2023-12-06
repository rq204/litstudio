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

namespace litstudio.iecef
{
    internal partial class ClickDownUI : litsdk.ILitUI
    {
        public ClickDownUI()
        {
            InitializeComponent();

            this.ivSavePath.ShowVarName(true, false, true, this.tbSavePath);
            this.ivXPath.ShowVarName(true, false, true, this.tbXPathStr);
            this.svSaveVarName.ShowVarName(true, false, false);

            this.SaveActivity = new Action(() =>
              {
                  cd.XPathStr = this.tbXPathStr.Text.Trim();
                  cd.SavePath = this.tbSavePath.Text;
                  cd.TimeOutSecond = (int)this.nudDownTimeOut.Value;
                  cd.Name = this.tbActivityName.Text.Trim();
                  cd.FrameName = this.tbFrameName.Text.Trim();
                  cd.SaveVarName = this.svSaveVarName.VarName;
              });
            litsdk.API.SetXPath = new Action<string, List<string>>(this.SetXPath);
        }

        private void SetXPath(string frameName,List<string> ls)
        {
            if (this.IsDisposed || this.Disposing) return;
            this.Invoke((EventHandler)delegate
            {
                this.tbXPathStr.Text = string.Join("\r\n", ls.ToArray());
                this.tbFrameName.Text = frameName;
            });
        }

        litcore.iecef.ClickDown cd = null;

        public override void SetActivity(Activity activity)
        {
            cd = activity as litcore.iecef.ClickDown;
            this.tbXPathStr.Text = cd.XPathStr;
            this.tbFrameName.Text = cd.FrameName;

            this.tbSavePath.Text = cd.SavePath;
            this.nudDownTimeOut.Value = cd.TimeOutSecond;
            this.tbActivityName.Text = cd.Name;
            this.svSaveVarName.VarName = cd.SaveVarName;
        }

        private void llbCurDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbSavePath, this.llbCurDir.Text);
        }

        private void llbOriginalName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbSavePath, this.llbOriginalName.Text);
        }

        private void llbExt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbSavePath, this.llbExt.Text);
        }

        private void llbRand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbSavePath, this.llbRand.Text);
        }
    }
}