using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litmail
{
    internal partial class FrmMailConfig : Form
    {
        public FrmMailConfig()
        {
            InitializeComponent();

            this.ivusername.ShowVarName(true, false, false, this.tbUserName);
            this.ivpassword.ShowVarName(true, false, false, this.tbPassword);
            this.ivPOP3IMAPHost.ShowVarName(true, false, false, this.tbPop3IMAPHost);
            this.ivSMTPHost.ShowVarName(true, false, false, this.tbSMTPHost);

            this.cbEmailType.Items.Remove("Exchange");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MailConfig sdb = GetUIMailConfig();
                litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
                if (string.IsNullOrEmpty(sdb.Name)) throw new Exception("配置名不能为空");
                if (string.IsNullOrEmpty(sdb.UserName)) throw new Exception("用户名不能为空");
                if (string.IsNullOrEmpty(sdb.Password)) throw new Exception("密码不能为空");
                if (string.IsNullOrEmpty(sdb.SMTPHost)) throw new Exception("SMTP服务器配置不能为空");
                if (string.IsNullOrEmpty(sdb.SMTPPort)) throw new Exception("SMTP端口配置不能为空");
                if (string.IsNullOrEmpty(sdb.Pop3IMAPEXHost)) throw new Exception("POP或IMAP主机配置不能为空");
                if (string.IsNullOrEmpty(sdb.Pop3IMAPPort)) throw new Exception("POP或IMAP端口配置不能为空");
                MailConfig.SetMailConfig(context, sdb);
                this.reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "发生错误");
            }
        }

        private MailConfig GetUIMailConfig()
        {
            MailConfig dBConfig = new MailConfig() { Name = this.tbName.Text.Trim(), Pop3IMAPEXHost = this.tbPop3IMAPHost.Text, SMTPHost = this.tbSMTPHost.Text.Trim(), Password = this.tbPassword.Text.Trim(), Pop3IMAPPort = this.tbPop3IMAPPort.Text, UserName = this.tbUserName.Text.Trim(), Pop3IMAPSSL = this.cbPop3IMAPSSL.Checked, SMTPPort = this.tbSMTPPort.Text, SMTPSSL = this.cbSMTPSSL.Checked, STARTTLS = this.cbSTARTTLS.Checked};
            dBConfig.MailType = (MailType)Enum.Parse(typeof(MailType), typeof(MailType).GetEnumName(this.cbEmailType.SelectedIndex)); ;
            return dBConfig;
        }

        private void reload()
        {
            this.lbEmailConfigs.Items.Clear();
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            List<MailConfig> sdbs = MailConfig.GetMailConfigs(context);
            foreach (MailConfig dBConfig in sdbs)
            {
                this.lbEmailConfigs.Items.Add(dBConfig.Name);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MailConfig sdb = GetUIMailConfig();
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();

            this.btnTest.Enabled = false;
            new System.Threading.Thread(() =>
            {
                try
                {
                    sdb.TestConnect();
                    MessageBox.Show("测试链接成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace, "发生错误");
                }
                finally
                {
                    try
                    {
                        this.Invoke((EventHandler)delegate { this.btnTest.Enabled = true; });
                    }
                    catch { }
                }
            }).Start();
        }

        private void lbDBConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.lbEmailConfigs.Text))
            {
                litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
                    MailConfig mail = MailConfig.GetSqlDBConfig(context,this.lbEmailConfigs.Text);
                if (mail != null)
                {
                    this.setMailConfig(mail);
                }
            }
        }

        private void llbEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbDBConfigs_SelectedIndexChanged(null, null);
        }

        private void llbNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setMailConfig(new MailConfig());
        }

        private void setMailConfig(MailConfig mail)
        {
            this.tbName.Text = mail.Name;
            if (mail.MailType == MailType.POP3) this.cbEmailType.SelectedIndex = 0;
            else if (mail.MailType == MailType.IMAP) this.cbEmailType.SelectedIndex = 1;
            else if (mail.MailType == MailType.Exchange) this.cbEmailType.SelectedIndex = 2;

            this.tbUserName.Text = mail.UserName;
            this.tbPassword.Text = mail.Password;

            this.tbPop3IMAPHost.Text = mail.Pop3IMAPEXHost;
            this.cbPop3IMAPSSL.Checked = mail.Pop3IMAPSSL;
            this.tbPop3IMAPPort.Text = mail.Pop3IMAPPort;

            this.tbSMTPHost.Text = mail.SMTPHost;
            this.cbSMTPSSL.Checked = mail.SMTPSSL;
            this.tbSMTPPort.Text = mail.SMTPPort;

            this.cbSTARTTLS.Checked = mail.STARTTLS;
        }

        private void llbDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.lbEmailConfigs.Text))
            {
                litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
                List<MailConfig> sdbs = MailConfig.GetMailConfigs(context);
                int index = sdbs.FindIndex((m) => m.Name == this.lbEmailConfigs.Text);
                if (index > -1) sdbs.RemoveAt(index);

                this.reload();
            }
        }

        private void cbDatabaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cbEmailType.Text)
            {
                case "POP3":
                    this.lbHost.Text = "POP服务器";
                    break;
                case "IMAP":
                    this.lbHost.Text = "IMAP服务器";
                    break;
            }
        }

        private void FrmMailConfig_Load(object sender, EventArgs e)
        {
            this.reload();
        }
    }
}
