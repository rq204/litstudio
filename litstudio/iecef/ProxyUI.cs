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
    internal partial class ProxyUI : litsdk.ILitUI
    {
        public ProxyUI()
        {
            InitializeComponent();
            this.ivProxySetting.ShowVarName(true, false, true, this.tbProxySetting);
            this.SaveActivity = new Action(() =>
              {
                  py.ProxySetting = this.tbProxySetting.Text.Trim();
                  py.Name = this.tbActivityName.Text;
              });
        }

        litcore.iecef.Proxy py = null;
        public override void SetActivity(Activity activity)
        {
            py = activity as litcore.iecef.Proxy;
            this.tbProxySetting.Text = py.ProxySetting;
            this.tbActivityName.Text = py.Name;
        }
    }
}
