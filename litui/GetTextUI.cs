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
    internal partial class GetTextUI : LitUiBase
    {
        public GetTextUI()
        {
            InitializeComponent();
            this.svSaveVarName.ShowVarName(true, true, true, true);

            this.SaveActivity = new Action(() =>
              {
                  ga.SaveVarName = this.svSaveVarName.VarName;
                  //ga.AttName = this.tbAttName.Text;
                  ga.UIConfig = base.GetUIConfig();
                  ga.Name = this.tbActivityName.Text;
                  ga.NoFindEmpty = this.cbNoFindEmpty.Checked;
              });
        }

        GetTextActivity ga = null;
        public override void SetActivity(Activity activity)
        {
            ga = activity as GetTextActivity;
            this.svSaveVarName.VarName = ga.SaveVarName;
            //this.tbAttName.Text = ga.AttName;
            base.SetUIConfig(ga.UIConfig);
            this.tbActivityName.Text = ga.Name;
            this.cbNoFindEmpty.Checked = ga.NoFindEmpty;
        }
    }
}
