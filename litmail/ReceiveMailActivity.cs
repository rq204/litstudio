using litsdk;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litmail
{
    /// <summary>
    /// http://www.mimekit.net/docs/html/T_MailKit_Net_Pop3_Pop3Client.htm
    /// http://www.mimekit.net/docs/html/T_MailKit_Net_Imap_ImapClient.htm
    /// </summary>
    [litsdk.ActivityInfo(Name = "收取邮件", RefFile = "MailKit.dll,MimeKit.dll,BouncyCastle.Crypto.dll", IsLinux = true)]
    public class ReceiveMailActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "收取邮件";

        public string ConfigName = "";

        /// <summary>
        /// 邮件标题包含
        /// </summary>
        public string SubjectContains = "";

        /// <summary>
        /// 发件人包含
        /// </summary>
        public string SenderContains = "";

        /// <summary>
        /// 收件内容包含
        /// </summary>
        public string BodyContains = "";

        /// <summary>
        /// 收件时间大于
        /// </summary>
        public string LaterThan = "";

        /// <summary>
        /// 邮件标题存入
        /// </summary>
        public string VarSubject = "";

        /// <summary>
        /// 收件人存入
        /// </summary>
        public string VarSender = "";

        /// <summary>
        /// 邮件正文存入
        /// </summary>
        public string VarBody = "";

        /// <summary>
        /// 邮件附件存入
        /// </summary>
        public string VarAttachments = "";

        /// <summary>
        /// 所有邮件存入表格
        /// </summary>
        public string VarAllMail = "";

        /// <summary>
        /// 将所有符合条件邮件存入表格变量
        /// </summary>
        public bool SaveAllMail = false;

        public bool DeleteAfterGet = false;


        public override ActivityGroup Group => ActivityGroup.NetWork;

        public override void Execute(ActivityContext context)
        {
            MailConfig config = MailConfig.GetSqlDBConfig(context, this.ConfigName);

            string username = context.ReplaceVar(config.UserName);
            string password = context.ReplaceVar(config.Password);

            string pie_host = context.ReplaceVar(config.Pop3IMAPEXHost);
            string pie_ports = context.ReplaceVar(config.Pop3IMAPPort);
            int pie_port = 0;
            if (!int.TryParse(pie_ports, out pie_port)) throw new Exception("收件端口错误：" + pie_ports);

            List<MimeKit.MimeMessage> msgs = new List<MimeKit.MimeMessage>();

            Pop3Client clientPop3 = null;
            ImapClient clientImap = null;

            if (config.MailType == MailType.POP3)
            {
                clientPop3 = new Pop3Client();

                // For demo-purposes, accept all SSL certificates
                clientPop3.ServerCertificateValidationCallback = (s, c, h, e) => true;
                clientPop3.Connect(pie_host, pie_port, config.Pop3IMAPSSL);
                clientPop3.Authenticate(username, password);

                for (int i = 0; i < clientPop3.Count; i++)
                {
                    var message = clientPop3.GetMessage(i);
                    msgs.Add(message);
                    if (msgs.Count == 5) break;
                }

                //clientPop3.Disconnect(true);
            }
            else if (config.MailType == MailType.IMAP)
            {
                clientImap = new ImapClient();

                // For demo-purposes, accept all SSL certificates
                clientImap.ServerCertificateValidationCallback = (s, c, h, e) => true;
                clientImap.Connect(pie_host, pie_port, config.Pop3IMAPSSL);

                var clientImplementation = new ImapImplementation
                {
                    Name = "MailKit4LitRPA",
                    Version = "1.0.0"
                };
                var serverImplementation = clientImap.Identify(clientImplementation);

                clientImap.Authenticate(username, password);

                var inbox = clientImap.Inbox;
                inbox.Open(MailKit.FolderAccess.ReadWrite);
                
                //Console.WriteLine("Total messages: {0}", inbox.Count);
                //Console.WriteLine("Recent messages: {0}", inbox.Recent);

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    msgs.Add(message);
                    if (msgs.Count == 5) break;
                }

                //clientImap.Disconnect(true);
            }

            ///现在对结果邮件进行筛选
            List<MimeMessage> finds = new List<MimeMessage>();
            string subjectcontains = context.ReplaceVar(this.SubjectContains);
            string bodycontains = context.ReplaceVar(this.BodyContains);
            string sendercontains = context.ReplaceVar(this.SenderContains);
            string laterthan = context.ReplaceVar(this.LaterThan);

            foreach (MimeKit.MimeMessage mime in msgs)
            {
                if (!string.IsNullOrEmpty(subjectcontains))
                {
                    if (!mime.Subject.Contains(subjectcontains)) continue;
                }
                if (!string.IsNullOrEmpty(sendercontains))
                {
                    if (!mime.Subject.Contains(sendercontains)) continue;
                }
                if (!string.IsNullOrEmpty(laterthan))
                {
                    DateTime later = DateTime.Now;
                    if (!DateTime.TryParse(laterthan, out later))
                    {
                        throw new Exception("时间过滤设置错误");
                    }
                    if (mime.Date.DateTime < DateTime.Parse(laterthan)) continue;
                }
                finds.Add(mime);
            }

            string result = "";
            if (this.SaveAllMail)
            {
                System.Data.DataTable table = new System.Data.DataTable();
                foreach (string t in new string[] { "Subject","Sender","Body" }) table.Columns.Add(t);
                foreach (MimeMessage mm in finds)
                {
                    System.Data.DataRow dr = table.NewRow();
                    dr["Subject"] = mm.Subject;
                    dr["Sender"] = mm.Sender.Address;
                    dr["Body"] = mm.TextBody;
                    //dr["Attachments"] = "";
                    table.Rows.Add(dr);
                    if (DeleteAfterGet)
                    {
                        //clientImap.Inbox.Append
                        //UniqueId emailUniqueId = new UniqueId(mm..MessageId);
                        //clientImap.Inbox.RemoveFlags(mm. mm.MessageId, MailKit.MessageFlags.Deleted, false);
                    }
                }
                context.Variables.Find((ff) => ff.Name == this.VarAllMail).TableValue = table;
                result = $"总计获取到{finds.Count}条数据并保存至表格变量{this.VarAllMail}";
            }
            else
            {
                string varSubject = "", varBody = "", varSender = "";
                List<string> varAttachments = new List<string>();

                if (finds.Count > 0)
                {
                    varSubject = finds[0].Subject;
                    varBody = finds[0].TextBody;
                    varSender = finds[0].Sender.Address;

                    result = $"找到符合条件数据{finds.Count}条并取第一条";
                }
                else
                {
                    result = "没有找到符合条件的邮件，所有变量设置为空";
                }
                if (!string.IsNullOrEmpty(this.VarSubject)) context.SetVarStr(this.VarSubject, varSubject);
                if (!string.IsNullOrEmpty(this.VarSender)) context.SetVarStr(this.VarSender, varSender);
                if (!string.IsNullOrEmpty(this.VarBody)) context.SetVarStr(this.VarBody, varBody);
            }
            context.WriteLog(result);
            if (clientPop3 != null) clientPop3.Disconnect(true);
            if (clientImap != null) clientImap.Disconnect(true);

        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.ConfigName)) throw new Exception("邮件配置不能为空");
            if (this.SaveAllMail)
            {
                if (string.IsNullOrEmpty(this.VarAllMail)) throw new Exception("所有邮件存入变量不能为空");
                if (!context.ContainsTable(this.VarAllMail)) throw new Exception($"不存在表格变量 {this.VarAllMail}");
            }
            else
            {
                if (string.IsNullOrEmpty(this.VarSubject) && string.IsNullOrEmpty(this.VarSender) && string.IsNullOrEmpty(this.VarBody)) throw new Exception("获取的数据必须选择至少一个保存变量");

                if (!string.IsNullOrEmpty(this.VarSubject) && !context.ContainsStr(this.VarSubject)) throw new Exception($"不存标题存入字符变量 {this.VarSubject}");

                if (!string.IsNullOrEmpty(this.VarSender) && !context.ContainsStr(this.VarSender)) throw new Exception($"不存标题存入字符变量 {this.VarSender}");

                if (!string.IsNullOrEmpty(this.VarBody) && !context.ContainsStr(this.VarBody)) throw new Exception($"不存标题存入字符变量 {this.VarBody}");
            }
        }
    }
}