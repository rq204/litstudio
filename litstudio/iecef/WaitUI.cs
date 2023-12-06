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
    internal partial class WaitUI : litsdk.ILitUI
    {
        public WaitUI()
        {
            InitializeComponent();
            this.ivXPath.ShowVarName(true, false, true, this.tbXPathStr);

            this.SaveActivity = new Action(() =>
              {
                  wt.XPathStr = this.tbXPathStr.Text.Trim();
                  wt.Name = this.tbActivityName.Text;
                  wt.FrameName = this.tbFrameName.Text.Trim();

                  wt.WaitIframe = this.cbWaitIFrame.Checked;
                  wt.WaitAppear = this.rbWaitAppear.Checked;
                  wt.TimeOutMillisecond = (int)this.nudTimeOut.Value;
              });
            litsdk.API.SetXPath = new Action<string,List<string>>(this.SetXPath);
        }

        private void SetXPath(string frameName, List<string> ls)
        {
            if (this.IsDisposed || this.Disposing) return;
            this.Invoke((EventHandler)delegate
            {
                this.tbXPathStr.Text = string.Join("\r\n", ls.ToArray());
                this.tbFrameName.Text = frameName;
            });
        }

        litcore.iecef.Wait wt = null;


        public override void SetActivity(Activity activity)
        {
            wt = activity as litcore.iecef.Wait;
            this.tbXPathStr.Text = wt.XPathStr;
            this.tbActivityName.Text = wt.Name;
            this.tbFrameName.Text = wt.FrameName;

            this.cbWaitIFrame.Checked = wt.WaitIframe;
            this.rbWaitAppear.Checked = wt.WaitAppear;
            this.rbWaitDisAppear.Checked = !wt.WaitAppear;
            this.nudTimeOut.Value = wt.TimeOutMillisecond;
        }
    }
}
