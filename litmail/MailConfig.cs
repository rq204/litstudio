using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litmail
{
    [Serializable]
    /// <summary>
    /// 邮箱配置
    /// </summary>
    public class MailConfig
    {
        /// <summary>
        /// 配置名称
        /// </summary>
        public string Name = "";

        /// <summary>
        /// 收件类型
        /// </summary>
        public MailType MailType = MailType.POP3;

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName = "";

        /// <summary>
        /// 密码
        /// </summary>
        public string Password = "";

        /// <summary>
        /// POP3或IMAP服务器地地址
        /// </summary>
        public string Pop3IMAPEXHost = "";

        /// <summary>
        /// 是否SSL
        /// </summary>
        public bool Pop3IMAPSSL = false;

        /// <summary>
        /// POP3或IMAP端口
        /// </summary>
        public string Pop3IMAPPort = "";

        /// <summary>
        /// smt服务器地址
        /// </summary>
        public string SMTPHost = "";

        /// <summary>
        /// SMTP是否SSL
        /// </summary>
        public bool SMTPSSL = false;

        /// <summary>
        /// SMTP端口
        /// </summary>
        public string SMTPPort = "";

        /// <summary>
        /// 如果服务器支持，用STARTTLS加密传输
        /// </summary>
        public bool STARTTLS = false;


        internal ImapClient GetImapClient()
        {
            return null;
        }

        internal MailKit.Net.Pop3.Pop3Client GetPop3Client()
        {
            return null;
        }

        public void TestConnect()
        {
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            string smtp_host = context.ReplaceVar(this.SMTPHost);
            string smtp_ports = context.ReplaceVar(this.SMTPPort);
            int smtp_port = 0;
            if (!int.TryParse(smtp_ports, out smtp_port))
            {
                throw new Exception("STMP端口号错误：" + smtp_ports);
            }
            string username = context.ReplaceVar(this.UserName);
            string password = context.ReplaceVar(this.Password);

            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
                if (this.STARTTLS)
                {
                    smtp.Connect(smtp_host, smtp_port, SecureSocketOptions.StartTls);
                }
                else
                {
                    if (this.SMTPSSL)
                    {
                        smtp.Connect(smtp_host, smtp_port, SecureSocketOptions.SslOnConnect);
                    }
                    else
                    {
                        smtp.Connect(smtp_host, smtp_port, SecureSocketOptions.Auto);
                    }
                }

                smtp.Authenticate(username, password);
                smtp.Disconnect(true);
            };

            string pie_host = context.ReplaceVar(this.Pop3IMAPEXHost);
            string pie_ports = context.ReplaceVar(this.Pop3IMAPPort);
            int pie_port = 0;
            if (!int.TryParse(pie_ports, out pie_port)) throw new Exception("收件端口错误：" + pie_ports);

            if (this.MailType == MailType.POP3)
            {
                using (var client = new Pop3Client())
                {
                    // For demo-purposes, accept all SSL certificates
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect(pie_host, pie_port, this.Pop3IMAPSSL);
                    client.Authenticate(username, password);
                    client.Disconnect(true);
                }
            }
            else if (this.MailType == MailType.IMAP)
            {
                using (var client = new ImapClient())
                {
                    // For demo-purposes, accept all SSL certificates
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect(pie_host, pie_port, this.Pop3IMAPSSL);
                    client.Authenticate(username, password);
                    client.Disconnect(true);
                }
            }
        }
        
        public static MailConfig GetSqlDBConfig(litsdk.ActivityContext context, string dbconfigName)
        {
            return GetMailConfigs(context).Find((F) => F.Name == dbconfigName);
        }

        public static List<MailConfig> GetMailConfigs(litsdk.ActivityContext context)
        {
            object obj = context.GetUserConfig("MailConfig");
            if (obj == null) return new List<MailConfig>();
            List<MailConfig> emConfigs = obj as List<MailConfig>;
            return emConfigs;
        }

        public static void SetMailConfig(litsdk.ActivityContext context, MailConfig emDBConfig)
        {
            List<MailConfig> dbs = GetMailConfigs(context);
            int index = dbs.FindIndex((f) => f.Name == emDBConfig.Name);

            if (index == -1) dbs.Add(emDBConfig);
            else
            {
                dbs[index] = emDBConfig;
            }
            context.SetUserConfig("MailConfig", dbs);
        }

    }
}