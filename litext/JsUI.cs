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

namespace litext
{
    internal partial class JsUI : litsdk.ILitUI
    {
        public JsUI()
        {
            InitializeComponent();
            base.SaveActivity = new Action(() =>
            {
                this.js.Code = this.tbCode.Text.Trim();
                this.js.VarNames = this.smvVarNames.VarNames;
                this.js.Name = this.tbStepName.Text.Trim();
            });
            this.ivVarNames.ShowVar(true, true, true, this.tbCode);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        litext.JsActivity js = null;
        public override void SetActivity(Activity activity)
        {
            this.js = activity as JsActivity;
            this.tbStepName.Text = js.Name;
            this.tbCode.Text = js.Code;
            this.smvVarNames.VarNames = js.VarNames;
        }

        private void lblitJArray_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVar.InsertSelected(this.tbCode, this.lblitJArray.Text);
        }
    }
}
