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
    internal partial class FindUI : LitUiBase
    {
        public FindUI()
        {
            InitializeComponent();
            this.svXpathVarName.ShowVarName(true, true, false);

            this.SaveActivity = new Action(() =>
              {
                  fa.UIConfig = base.GetUIConfig();
                  fa.Name = this.tbActivityName.Text;
                  fa.XpathVarName = this.svXpathVarName.VarName;
                  fa.Reverse = this.cbReverse.Checked;
              });
        }

        FindActivity fa = null;
        public override void SetActivity(Activity activity)
        {
            fa = activity as FindActivity;
            base.SetUIConfig(fa.UIConfig);
            this.tbActivityName.Text = fa.Name;
            this.svXpathVarName.VarName = fa.XpathVarName;
            this.cbReverse.Checked = fa.Reverse;
        }
    }
}
