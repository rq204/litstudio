using litsdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litstudio
{
    internal partial class MultDecisionUI : litsdk.ILitUI
    {
        public MultDecisionUI()
        {
            InitializeComponent();
            this.svVarNames.ShowVarName(true, true, true, true);

            this.SaveActivity = () =>
             {
                 this.mult.VarNames = this.svVarNames.VarNames;
                 if (this.rbAllIsEmpty.Checked)
                 {
                     this.mult.MultDecideType = litcore.type.MultDecideType.AllIsEmpty;
                 }
                 else if (this.rbAllIsNotEmpty.Checked)
                 {
                     this.mult.MultDecideType = litcore.type.MultDecideType.AllIsNotEmpty;
                 }
                 else if (this.rbOneMoreEmpty.Checked)
                 {
                     this.mult.MultDecideType = litcore.type.MultDecideType.OneMoreIsEmpty;
                 }
                 mult.Name = this.tbActivityName.Text;
             };
        }

        private litcore.activity.MultDecideActivity mult = null;
        public override void SetActivity(Activity activity)
        {
            mult = activity as litcore.activity.MultDecideActivity;
            this.svVarNames.VarNames = mult.VarNames.ToArray().ToList();
            switch (mult.MultDecideType)
            {
                case litcore.type.MultDecideType.AllIsEmpty:
                    this.rbAllIsEmpty.Checked = true;
                    break;
                case litcore.type.MultDecideType.AllIsNotEmpty:
                    this.rbAllIsNotEmpty.Checked = true;
                    break;
                case litcore.type.MultDecideType.OneMoreIsEmpty:
                    this.rbOneMoreEmpty.Checked = true;
                    break;
            }
            this.tbActivityName.Text = mult.Name;
        }
    }
}
