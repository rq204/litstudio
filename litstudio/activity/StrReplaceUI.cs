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
    internal partial class StrReplaceUI : litsdk.ILitUI
    {
        public StrReplaceUI()
        {
            InitializeComponent();

            this.svStrSaveVarName.ShowVarName(true, true, false);
            this.svStrVarName.ShowVarName(true, true, false);
            this.ivOldStr.ShowVarName(true, false, true, this.tbOldStr);
            this.ivNewStr.ShowVarName(true, false, true, this.tbNewStr);

            base.SaveActivity = new Action(() =>
            {
                sr.NewStr = this.tbNewStr.Text;
                sr.OldStr = this.tbOldStr.Text;
                sr.IsRegex = this.cbIsRegex.Checked;
                sr.StrVarName = this.svStrVarName.VarName;
                sr.StrSaveVarName = this.svStrSaveVarName.VarName;
                sr.Name = this.tbActivityName.Text;
            });
        }

        litcore.activity.StrReplaceActivity sr = null;
        public override void SetActivity(Activity activity)
        {
            sr = activity as litcore.activity.StrReplaceActivity;
            this.tbNewStr.Text = sr.NewStr;
            this.tbOldStr.Text = sr.OldStr;
            this.cbIsRegex.Checked = sr.IsRegex;
            this.svStrVarName.VarName = sr.StrVarName;
            this.svStrSaveVarName.VarName = sr.StrSaveVarName;
            this.tbActivityName.Text = sr.Name;
        }

        private void cbIsRegex_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void lbReplaceEmo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.cbIsRegex.Checked = true;
            this.tbOldStr.Text = @"\p{Cs}";//https://docs.microsoft.com/zh-cn/previous-versions/dotnet/netframework-4.0/20bw873z(v=vs.100)?redirectedfrom=MSDN
        }

        private void llbTrimInvalName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.cbIsRegex.Checked = true;
            this.tbOldStr.Text = "[\\\\/:\\?\"<>\\|\\*]";
        }
    }
}
