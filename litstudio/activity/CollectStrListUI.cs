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
    internal partial class CollectStrListUI : litsdk.ILitUI
    {
        public CollectStrListUI()
        {
            InitializeComponent();
            this.svStrVarName.ShowVarName(true, false, false);
            this.svSaveVarName.ShowVarName(true, true, true, true);
            this.SaveActivity = new Action(() =>
            {
                cs.StrVarName = this.svStrVarName.VarName;
                cs.SaveVarName = this.svSaveVarName.VarName;

                cs.RegexString = this.tbRegexString.Text;
                cs.CollectList = this.cbCollectList.Checked;
                cs.Name = this.tbActivityName.Text;

                cs.TrimHtml = this.cbTrimHtml.Checked;
                cs.TrimBlank = this.cbTrimBlank.Checked;
                cs.Trim = this.cbTrim.Checked;
            });
        }

        litcore.activity.RegexActivity cs = null;

        public override void SetActivity(Activity activity)
        {
            cs = activity as litcore.activity.RegexActivity;
            this.svStrVarName.VarName = cs.StrVarName;
            this.svSaveVarName.VarName = cs.SaveVarName;

            this.tbRegexString.Text = cs.RegexString;
            this.cbCollectList.Checked = cs.CollectList;
            this.tbActivityName.Text = cs.Name;

            this.cbTrimHtml.Checked = cs.TrimHtml;
            this.cbTrimBlank.Checked = cs.TrimBlank;
            this.cbTrim.Checked = cs.Trim;
        }

        private void llbRegex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(tbRegexString, this.llbRegex.Text);
        }
    }
}