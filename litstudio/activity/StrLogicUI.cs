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
    internal partial class StrLogicUI : litsdk.ILitUI
    {
        public StrLogicUI()
        {
            InitializeComponent();
            this.svVarName.ShowVarName(true, false, false);
            this.SaveActivity = new Action(() =>
              {
                  if (this.rbNumber.Checked) sla.StrType = litcore.type.StrType.Number;
                  else if (this.rbPhone.Checked) sla.StrType = litcore.type.StrType.Phone;
                  else if (this.rbEmail.Checked) sla.StrType = litcore.type.StrType.Email;
                  else if (this.rbDateTime.Checked) sla.StrType = litcore.type.StrType.DateTime;
                  else if (this.rbLetter.Checked) sla.StrType = litcore.type.StrType.Letter;
                  else if (this.rbChinese.Checked) sla.StrType = litcore.type.StrType.Chinese;
                  else if (this.rbUrl.Checked) sla.StrType = litcore.type.StrType.Url;
                  else if (this.rbIP.Checked) sla.StrType = litcore.type.StrType.Regex;
                  else if (this.rbRegex.Checked) sla.StrType = litcore.type.StrType.Regex;

                  sla.RegexPattern = this.tbRegexPattern.Text;
                  sla.VarName = this.svVarName.VarName;
                  sla.Name = this.tbActivityName.Text;
              });
        }

        litcore.activity.StrLogicActivity sla = null;
        public override void SetActivity(Activity activity)
        {
            sla = activity as litcore.activity.StrLogicActivity;
            switch (sla.StrType)
            {
                case litcore.type.StrType.Number:
                    this.rbNumber.Checked = true;
                    break;
                case litcore.type.StrType.Phone:
                    this.rbPhone.Checked = true;
                    break;
                case litcore.type.StrType.Email:
                    this.rbEmail.Checked = true;
                    break;
                case litcore.type.StrType.DateTime:
                    this.rbDateTime.Checked = true;
                    break;
                case litcore.type.StrType.Letter:
                    this.rbLetter.Checked = true;
                    break;
                case litcore.type.StrType.Chinese:
                    this.rbChinese.Checked = true;
                    break;
                case litcore.type.StrType.Url:
                    this.rbUrl.Checked = true;
                    break;
                case litcore.type.StrType.IP:
                    this.rbIP.Checked = true;
                    break;
                case litcore.type.StrType.Regex:
                    this.rbRegex.Checked = true;
                    break;
            }
            this.tbRegexPattern.Text = sla.RegexPattern;
            this.tbActivityName.Text = sla.Name;
            this.svVarName.VarName = sla.VarName;
        }

        private void rbRegex_CheckedChanged(object sender, EventArgs e)
        {
            this.tbRegexPattern.Visible = this.rbRegex.Checked;
        }
    }
}
