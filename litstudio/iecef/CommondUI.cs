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
    internal partial class CommondUI : litsdk.ILitUI
    {
        public CommondUI()
        {
            InitializeComponent();
            this.SaveActivity = new Action(() =>
              {
                  if (this.rbGo.Checked)
                  {
                      cd.CmdType = litcore.ictype.CommondType.GoForward;
                  }
                  else if (this.rbBack.Checked)
                  {
                      cd.CmdType = litcore.ictype.CommondType.GoBack;
                  }
                  else if (this.rbStop.Checked)
                  {
                      cd.CmdType = litcore.ictype.CommondType.Stop;
                  }
                  else if (this.rbRefresh.Checked)
                  {
                      cd.CmdType = litcore.ictype.CommondType.Reload;
                  }
                  cd.Name = this.tbActivityName.Text.Trim();
              });
        }

        litcore.iecef.Commond cd =null;
        public override void SetActivity(Activity activity)
        {
             cd = activity as litcore.iecef.Commond;
            switch (cd.CmdType)
            {
                case litcore.ictype.CommondType.GoForward:
                    this.rbGo.Checked = true;
                    break;
                case litcore.ictype.CommondType.GoBack:
                    this.rbBack.Checked = true;
                    break;
                case litcore.ictype.CommondType.Stop:
                    this.rbStop.Checked = true;
                    break;
                case litcore.ictype.CommondType.Reload:
                    this.rbRefresh.Checked = true;
                    break;
            }
            this.tbActivityName.Text = cd.Name;
        }
    }
}
