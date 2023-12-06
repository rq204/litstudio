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

namespace litui
{
    internal partial class WaitUI : LitUiBase
    {
        public WaitUI()
        {
            InitializeComponent();
            this.ivWaitValue.ShowVarName(true, false, true, this.tbWaitValue);
            this.SaveActivity = new Action(() =>
              {
                  wa.UIConfig = base.GetUIConfig();
                  wa.Name = this.tbActivityName.Text;
                  wa.WaitValue = this.tbWaitValue.Text;
                  if (this.rbAppear.Checked)
                  {
                      wa.WaitType = WaitType.Apper;
                  }
                  else if (this.rbDisAppear.Checked)
                  {
                      wa.WaitType = WaitType.Disapper;
                  }
                  else if (this.rbWaitValue.Checked)
                  {
                      wa.WaitType = WaitType.ApperValue;
                  }
                  wa.TimeOutMillisecond = (int)this.nudTimeOut.Value;
              });
        }

        WaitActivity wa = null;
        public override void SetActivity(Activity activity)
        {
            wa = activity as WaitActivity;
            base.SetUIConfig(wa.UIConfig);
            this.tbActivityName.Text = wa.Name;
            this.tbWaitValue.Text = wa.WaitValue;
            switch (wa.WaitType)
            {
                case WaitType.Apper:
                    this.rbAppear.Checked = true;
                    break;
                case WaitType.Disapper:
                    this.rbDisAppear.Checked = true;
                    break;
                case WaitType.ApperValue:
                    this.rbWaitValue.Checked = true;
                    break;
            }
            this.nudTimeOut.Value = wa.TimeOutMillisecond;
        }
    }
}
