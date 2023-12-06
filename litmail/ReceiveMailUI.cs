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
    internal partial class ReceiveMailUI : litsdk.ILitUI
    {
        public ReceiveMailUI()
        {
            InitializeComponent();

            this.ivSubjectContains.ShowVarName(true, false, false, this.tbSubjectContains);
            this.ivSenderContains.ShowVarName(true, false, false, this.tbSenderContains);
            this.ivBodyContains.ShowVarName(true, false, false, this.tbBodyContains);
            this.ivLaterThan.ShowVarName(true, false, false, this.tbLaterThan);

            this.svVarSubject.ShowVarName(true, false, false);
            this.svVarSender.ShowVarName(true, false, false);
            this.svVarBody.ShowVarName(true, false, false);
            this.svVarAttachments.ShowVarName(true, true, false);
            this.svVarAllMail.ShowVarName(false, false, false, true);

            this.SaveActivity = () =>
            {
                rm.ConfigName = this.cbConfigName.Text;
                rm.SubjectContains = this.tbSubjectContains.Text;
                rm.SenderContains = this.tbSenderContains.Text;
                rm.BodyContains = this.tbBodyContains.Text;
                rm.LaterThan = this.tbLaterThan.Text;

                rm.VarSubject = this.svVarSubject.VarName;
                rm.VarSender = this.svVarSender.VarName;
                rm.VarBody = this.svVarBody.VarName;
                rm.VarAttachments = this.svVarAttachments.VarName;
                rm.VarAllMail = this.svVarAllMail.VarName;

                rm.SaveAllMail = this.cbSaveAllEmail.Checked;
                rm.Name = this.tbActivityName.Text;
            };

            this.lbAllEmail.Location = this.lbSubject.Location;
            this.svVarAllMail.Location = this.svVarSubject.Location;
            this.reloadlist();
        }

        private litmail.ReceiveMailActivity rm = null;

        public override void SetActivity(Activity activity)
        {
            rm = activity as litmail.ReceiveMailActivity;
            this.cbConfigName.Text = rm.ConfigName;
            this.tbSubjectContains.Text = rm.SubjectContains;
            this.tbSenderContains.Text = rm.SenderContains;
            this.tbBodyContains.Text = rm.BodyContains;
            this.tbLaterThan.Text = rm.LaterThan;

            this.svVarSubject.VarName = rm.VarSubject;
            this.svVarSender.VarName = rm.VarSender;
            this.svVarBody.VarName = rm.VarBody;
            this.svVarAttachments.VarName = rm.VarAttachments;
            this.svVarAllMail.VarName = rm.VarAllMail;

            this.tbActivityName.Text = rm.Name;
            this.cbSaveAllEmail.Checked = rm.SaveAllMail;
        }


        public override string ActivityType => "litmail.ReceiveMailActivity";

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


        private void reloadlist()
        {
            this.cbConfigName.Items.Clear();
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            foreach (MailConfig config in MailConfig.GetMailConfigs(context))
            {
                this.cbConfigName.Items.Add(config.Name);
            }
        }

        private void cbSaveAllEmail_CheckedChanged(object sender, EventArgs e)
        {
            this.svVarSubject.Visible = this.svVarSender.Visible = this.svVarBody.Visible = !this.cbSaveAllEmail.Checked;

            this.lbSubject.Visible = this.lbSender.Visible = this.lbBody.Visible = !this.cbSaveAllEmail.Checked;

            this.svVarAllMail.Visible = this.lbAllEmail.Visible = this.cbSaveAllEmail.Checked;
        }
    }
}
