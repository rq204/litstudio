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
    internal partial class NavigateUI : litsdk.ILitUI
    {
        public NavigateUI()
        {
            InitializeComponent();
            this.ivUrl.ShowVarName(true, false, true, this.tbUrl);
            this.ivReferer.ShowVarName(true, false, false, this.tbReferer);
            this.tbReferer.Enabled = this.ivReferer.Enabled = litcore.iecef.Navigate.SupportReferer;
            this.gbAuthCredentials.Enabled = litcore.iecef.Navigate.SupportAuthCredentials;

            this.ivUserName.ShowVarName(true, false, false, this.tbUserName);
            this.ivPassword.ShowVarName(true, false, false, this.tbPassword);

            this.lbChrSetting.Visible = litcore.iecef.ChrSetting.IsChrome;

            this.SaveActivity = new Action(() =>
              {
                  ng.Url = this.tbUrl.Text.Trim();
                  ng.Referer = this.tbReferer.Text.Trim();
                  ng.Name = this.tbActivityName.Text.Trim();
                  ng.NewWindow = this.rbPopUpOn.Checked;
                  ng.TimeOutSenconds = (int)this.nudTimeOutSenconds.Value;
                  ng.UserName = this.tbUserName.Text;
                  ng.Password = this.tbPassword.Text;
                  ng.AcceptLanguage = this.tbAcceptLanguage.Text;
              });
        }

        litcore.iecef.Navigate ng = null;
        public override void SetActivity(Activity activity)
        {
            ng = activity as litcore.iecef.Navigate;
            this.tbUrl.Text = ng.Url;
            this.tbReferer.Text = ng.Referer;
            this.tbActivityName.Text = ng.Name;
            this.rbPopUpOn.Checked = ng.NewWindow;
            this.rbPopUpOff.Checked = !ng.NewWindow;
            this.nudTimeOutSenconds.Value = ng.TimeOutSenconds;
            this.tbUserName.Text = ng.UserName;
            this.tbPassword.Text = ng.Password;
            this.tbAcceptLanguage.Text = ng.AcceptLanguage;
        }

        private void lbChrSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmChrSetting fc = new FrmChrSetting();
            fc.ShowDialog();
        }
    }
}
