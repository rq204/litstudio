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
    internal partial class ClickUploadUI : litsdk.ILitUI
    {
        public ClickUploadUI()
        {
            InitializeComponent();

            this.ivXPath.ShowVarName(true, false, true, this.tbXPathStr);
            this.svFileVarName.ShowVarName(true, true, false);

            this.SaveActivity = new Action(() =>
              {
                  cd.XPathStr = this.tbXPathStr.Text.Trim();
                  cd.TimeOutSecond = (int)this.nudDownTimeOut.Value;
                  cd.Name = this.tbActivityName.Text.Trim();
                  cd.FrameName = this.tbFrameName.Text.Trim();
                  cd.FileVarName = this.svFileVarName.VarName;
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

        litcore.iecef.ClickUpload cd = null;

        public override void SetActivity(Activity activity)
        {
            cd = activity as litcore.iecef.ClickUpload;
            this.tbXPathStr.Text = cd.XPathStr;
            this.tbFrameName.Text = cd.FrameName;
            this.nudDownTimeOut.Value = cd.TimeOutSecond;
            this.tbActivityName.Text = cd.Name;
            this.svFileVarName.VarName = cd.FileVarName;
        }

    }
}