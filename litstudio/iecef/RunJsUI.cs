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
    internal partial class RunJsUI : litsdk.ILitUI
    {
        public RunJsUI()
        {
            InitializeComponent();
            this.ivJsCode.ShowVarName(true, false, true, this.tbJsCode);
            this.svSaveVarName.ShowVarName(true, false, false);
            this.lbSave.Visible = this.lbSave2.Visible = this.svSaveVarName.Visible = litcore.iecef.RunJs.SupportSaveJsReturn;
            this.SaveActivity = new Action(() =>
              {
                  rj.JsCode = this.tbJsCode.Text;
                  rj.FrameName = this.tbFrameName.Text.Trim();
                  rj.Name = this.tbActivityName.Text.Trim();
                  rj.SaveVarName = this.svSaveVarName.VarName;
              });
        }

        litcore.iecef.RunJs rj = null;
        public override void SetActivity(Activity activity)
        {
            rj = activity as litcore.iecef.RunJs;
            this.tbJsCode.Text = rj.JsCode;
            this.tbActivityName.Text = rj.Name;
            this.tbFrameName.Text = rj.FrameName;
            this.svSaveVarName.VarName = rj.SaveVarName;
        }
    }
}