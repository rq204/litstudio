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

namespace litstudio
{
    internal partial class LogUI : litsdk.ILitUI
    {
        public LogUI()
        {
            InitializeComponent();

            this.ivLog.ShowVarName(true, false, true, this.tbLogFormat);

            this.SaveActivity = new Action(() =>
              {
                  la.LogFormat = this.tbLogFormat.Text.Trim();
                  la.Name = this.tbActivityName.Text.Trim();
              });
        }

        private litcore.activity.LogActivity la = null;
        public override void SetActivity(Activity activity)
        {
            la = activity as litcore.activity.LogActivity;
            this.tbLogFormat.Text = la.LogFormat;
            this.tbActivityName.Text = la.Name;
        }
    }
}
