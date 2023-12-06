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

namespace litmail
{
    internal partial class SendMailUI : litsdk.ILitUI
    {
        public SendMailUI()
        {
            InitializeComponent();

            this.ivMailTo.ShowVarName(true, false, true, this.tbMailTo);
            this.ivSenderNick.ShowVarName(true, false, false, this.tbSenderNick);
            this.ivReceiverNick.ShowVarName(true, false, false, this.tbReceiverNick);
            this.ivSubject.ShowVarName(true, false, true, this.tbSubject);
            this.ivBody.ShowVarName(true, false, true, this.tbBody);

            this.svAttachments.ShowVarName(true, true, false);

            this.SaveActivity = new Action(() =>
              {
                  sendMail.ConfigName = this.cbConfigName.Text;
                  sendMail.MailTo = this.tbMailTo.Text.Trim();
                  sendMail.SenderNick = this.tbSenderNick.Text.Trim();
                  sendMail.ReceiverNick = this.tbReceiverNick.Text.Trim();
                  sendMail.Subject = this.tbSubject.Text.Trim();
                  sendMail.Body = this.tbBody.Text.Trim();
                  sendMail.AttachmentsVarName = this.svAttachments.VarName;
                  sendMail.Name = this.tbActivityName.Text.Trim();
              });

            this.reloadlist();
        }

        private void reloadlist()
        {
            this.cbConfigName.Items.Clear();
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            foreach (MailConfig config in MailConfig.GetMailConfigs(context))
            {
                this.cbConfigName.Items.Add(config.Name);
            }
        }

        public override string ActivityType => "litmail.SendMailActivity";
        private SendMailActivity sendMail = null;
        public override void SetActivity(Activity activity)
        {
            sendMail = activity as SendMailActivity;

            this.cbConfigName.Text = sendMail.ConfigName;
            this.tbMailTo.Text = sendMail.MailTo;
            this.tbSenderNick.Text = sendMail.SenderNick;
            this.tbReceiverNick.Text = sendMail.ReceiverNick;
            
            this.tbSubject.Text = sendMail.Subject;
            this.tbBody.Text = sendMail.Body;
            this.svAttachments.VarName = sendMail.AttachmentsVarName;
            this.tbActivityName.Text = sendMail.Name;
        }

        private void llbShowDatabase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            string old = Newtonsoft.Json.JsonConvert.SerializeObject(MailConfig.GetMailConfigs(context));
            new FrmMailConfig().ShowDialog();
            string now = Newtonsoft.Json.JsonConvert.SerializeObject(MailConfig.GetMailConfigs(context));
            if (old != now)
            {
                this.reloadlist();
            }
        }
    }
}