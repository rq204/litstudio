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

namespace litapps
{
    public partial class MessageBoxUI : litsdk.ILitUI
    {
        public MessageBoxUI()
        {
            InitializeComponent();
            this.ivCaption.ShowVarName(true, false, true, this.tbCaption);
            this.ivText.ShowVarName(true, false, true, this.tbText);
            this.SaveActivity = () =>
            {
                mb.Caption = this.tbCaption.Text;
                mb.Text = this.tbText.Text;
                if (this.rbInformation.Checked) mb.MessageBoxType = MessageBoxType.Information;
                else if (this.rbWarning.Checked) mb.MessageBoxType = MessageBoxType.Warning;
                else if (this.rbError.Checked) mb.MessageBoxType = MessageBoxType.Error;

                mb.TimeOutSenconds = (int)this.nudTimeOutSeconds.Value;
                mb.Name = this.tbActivityName.Text;
            };
        }

        MessageBoxActivity mb = null;
        public override void SetActivity(Activity activity)
        {
            mb = activity as MessageBoxActivity;
            this.tbCaption.Text = mb.Caption;
            this.tbText.Text = mb.Text;
            switch (mb.MessageBoxType)
            {
                case MessageBoxType.Information:
                    this.rbInformation.Checked = true;
                    break;
                case MessageBoxType.Warning:
                    this.rbWarning.Checked = true;
                    break;
                case MessageBoxType.Error:
                    this.rbError.Checked = true;
                    break;
            }
            this.nudTimeOutSeconds.Value = mb.TimeOutSenconds;
            this.tbActivityName.Text = mb.Name;
        }

    }
}
