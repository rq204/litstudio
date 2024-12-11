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
    internal partial class CSharpUI : litsdk.ILitUI
    {
        public CSharpUI()
        {
            InitializeComponent();
            this.ivCode.ShowVarName(true, false, true, this.tbCode);
            this.SaveActivity = new Action(() =>
              {
                  ca.Code = this.tbCode.Text;
                  ca.Name = this.tbActivityName.Text;
              });
        }

        CSharpActivity ca = null;
        public override void SetActivity(Activity activity)
        {
            ca = activity as CSharpActivity;
            this.tbCode.Text = ca.Code;
            this.tbActivityName.Text = ca.Name;
        }

        private void lbget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbCode, this.lbget.Text);
        }

        private void lbSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbCode, this.lbSet.Text);
        }
    }
}
