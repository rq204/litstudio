using litsdk;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litmail
{
    [litsdk.ActivityInfo(Name = "发送邮件", RefFile = "MailKit.dll,MimeKit.dll,BouncyCastle.Crypto.dll", IsLinux = true)]
    public class SendMailActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "发送邮件";

        public override ActivityGroup Group => ActivityGroup.NetWork;

        /// <summary>
        /// 配置名称
        /// </summary>
        public string ConfigName = "";

        /// <summary>
        /// 收件人邮箱
        /// </summary>
        public string MailTo = "";

        /// <summary>
        /// 发送者昵称
        /// </summary>
        public string SenderNick = "";

        /// <summary>
        /// 收件人昵称
        /// </summary>
        public string ReceiverNick = "";

        /// <summary>
        /// 邮件标题
        /// </summary>
        public string Subject = "";

        /// <summary>
        /// 附件变量，可字符列表
        /// </summary>
        public string AttachmentsVarName = "";

        /// <summary>
        /// 邮件内容
        /// </summary>
        public string Body = "";


        public override void Execute(ActivityContext context)
        {
            MailConfig config = MailConfig.GetSqlDBConfig(context, this.ConfigName);

            string subject = context.ReplaceVar(this.Subject);
            string senderNidck = context.ReplaceVar(this.SenderNick);
            string body = context.ReplaceVar(this.Body);
            MimeEntity mbody = new TextPart(TextFormat.Plain) { Text = body };

            var msgSend = new MimeMessage
            {
                Subject = subject,
            };

            string username = context.ReplaceVar(config.UserName);
            string password = context.ReplaceVar(config.Password);

            msgSend.From.Add(new MailboxAddress(senderNidck, username));

            if (!string.IsNullOrEmpty(this.AttachmentsVarName))
            {
                List<string> attachs = new List<string>();
                var multipart = new Multipart("mixed");

                if (context.ContainsStr(this.AttachmentsVarName))
                {
                    attachs.Add(context.GetStr(this.AttachmentsVarName));
                }
                else
                {
                    attachs = context.GetList(this.AttachmentsVarName);
                }

                if (attachs.Count == 0) throw new Exception("附件数不能为空");

                List<string> images = new List<string>() { "gif", "png", "jpg", "bmp" };
                foreach (string f in attachs)
                {
                    string fname = Path.GetFileName(f);
                    // create an image attachment for the file located at path
                    var attachment = new MimePart();
                    string ext = images.Find(x => fname.EndsWith("." + x));
                    if (!string.IsNullOrEmpty(ext))
                    {
                        attachment = new MimePart("image", ext);
                    }
                    attachment.Content = new MimeContent(File.OpenRead(f), ContentEncoding.Default);
                    attachment.ContentDisposition = new ContentDisposition(ContentDisposition.Attachment);
                    attachment.ContentTransferEncoding = ContentEncoding.Base64;
                    attachment.FileName = fname;

                    multipart.Add(attachment);
                }

                // now create the multipart/mixed container to hold the message text and the
                // image attachment
                multipart.Add(mbody);
                msgSend.Body = multipart;
            }
            else
            {
                msgSend.Body = mbody;
            }

            string receiverNick = context.ReplaceVar(this.ReceiverNick);
            string receiverMail = context.ReplaceVar(this.MailTo);
            msgSend.To.Add(new MailboxAddress(receiverNick, receiverMail));

            string host = context.ReplaceVar(config.SMTPHost);
            string ports = context.ReplaceVar(config.SMTPPort);
            int port = 0;
            if (!int.TryParse(ports, out port))
            {
                throw new Exception("STMP端口号错误：" + ports);
            }


            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
                if (config.STARTTLS)
                {
                    smtp.Connect(host, port, SecureSocketOptions.StartTls);
                }
                else
                {
                    if (config.SMTPSSL)
                    {
                        smtp.Connect(host, port, SecureSocketOptions.SslOnConnect);
                    }
                    else
                    {
                        smtp.Connect(host, port, SecureSocketOptions.Auto);
                    }
                }

                smtp.Authenticate(username, password);
                smtp.Send(msgSend);
                smtp.Disconnect(true);
                context.WriteLog("成功发送邮件");
            };
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.ConfigName)) throw new Exception("邮件配置不能为空");
            if (string.IsNullOrEmpty(this.ReceiverNick)) throw new Exception("收件人昵称不能为空");
            if (string.IsNullOrEmpty(this.SenderNick)) throw new Exception("发件人昵称不能为空");
            if (string.IsNullOrEmpty(this.MailTo)) throw new Exception("收件人邮箱不能为空");
            if (string.IsNullOrEmpty(this.Subject)) throw new Exception("邮件标题不能为空");
            if (string.IsNullOrEmpty(this.Body)) throw new Exception("邮件内容不能为空");
            if (!string.IsNullOrEmpty(this.AttachmentsVarName))
            {
                if (!context.ContainsStr(this.AttachmentsVarName) && !context.ContainsList(this.AttachmentsVarName)) throw new Exception("不存在字符或列表变量：" + this.AttachmentsVarName);
            }
        }
    }
}
