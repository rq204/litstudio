using FluentFTP;
using litsdk;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litftp
{
    [litsdk.ActivityInfo(Name = "Ftp上传下载", RefFile = "FluentFTP.dll,Renci.SshNet.dll", IsLinux = true, IsWinForm = false, IsFront = false)]
    public class FtpActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "Ftp上传下载";

        public override ActivityGroup Group => ActivityGroup.NetWork;

        /// <summary>
        /// 操作类型
        /// </summary>
        public FtpType FtpType = FtpType.Upload;

        public string Server = "";

        public int Port = 21;

        public string UserName = "";

        public string Password = "";

        public string SelectDir = "";

        public string FileVarName = "";

        public bool ExistIgnore = true;

        public bool Sftp = false;

        /// <summary>
        ///  被动模式
        /// </summary>
        public bool Passive = false;

        /// <summary>
        /// 常用操作 
        /// https://blog.csdn.net/yangwohenmai1/article/details/88571375
        /// https://github.com/robinrodricks/FluentFTP
        /// </summary>
        /// <param name="context"></param>
        public override void Execute(ActivityContext context)
        {
            string server = context.ReplaceVar(this.Server);
            string username = context.ReplaceVar(this.UserName);
            string password = context.ReplaceVar(this.Password);
            string selectdir = context.ReplaceVar(this.SelectDir);

            List<string> files = new List<string>();
            if (this.FtpType != FtpType.ListDirDir && this.FtpType != FtpType.ListDirFile)
            {
                if (context.ContainsStr(this.FileVarName))
                {
                    files.Add(context.GetStr(this.FileVarName));
                }
                else
                {
                    files.AddRange(context.GetList(this.FileVarName));
                }
            }

            if (!this.Sftp)
            {
                FtpRemoteExists remoteExists = this.ExistIgnore ? FtpRemoteExists.Skip : FtpRemoteExists.Overwrite;
                FtpLocalExists ftpLocalExists = this.ExistIgnore ? FtpLocalExists.Skip : FtpLocalExists.Overwrite;
                
                FtpConfig ftpConfig = new FtpConfig();
                if (this.Passive) ftpConfig.DataConnectionType = FtpDataConnectionType.PASV;
                ftpConfig.RetryAttempts = 5;

                FtpClient client = new FtpClient(server, username, password, this.Port,ftpConfig);
             
                client.Connect();

                try
                {
                    switch (this.FtpType)
                    {
                        case FtpType.Upload:
                            client.UploadFiles(files, selectdir, remoteExists);
                            context.WriteLog($"成功上传{files.Count}个文件到远程目录{selectdir}");
                            break;
                        case FtpType.Download:
                            foreach (string sf in files)
                            {
                                client.DownloadFile(System.IO.Path.Combine(selectdir, System.IO.Path.GetFileName(sf)), sf, ftpLocalExists);
                            }
                            context.WriteLog($"成功下载{files.Count}个文件到本地目录{selectdir}");
                            break;
                        case FtpType.Delete:
                            foreach (string f in files) client.DeleteFile(f);
                            context.WriteLog($"成功删除{files.Count}个远程文件");
                            break;
                        case FtpType.ListDirFile:
                        case FtpType.ListDirDir:
                            client.SetWorkingDirectory(selectdir);
                            List<string> fs = new List<string>();
                            List<string> ds = new List<string>();
                            foreach (var v in client.GetListing())
                            {
                                if (v.Type == FtpObjectType.File) fs.Add(v.FullName);
                                if (v.Type == FtpObjectType.Directory) ds.Add(v.FullName);
                            }
                            if (this.FtpType == FtpType.ListDirDir)
                            {
                                context.SetVarList(this.FileVarName, ds);
                                context.WriteLog($"成功列出{ds.Count}个远程目录");
                            }
                            else if (this.FtpType == FtpType.ListDirFile)
                            {
                                context.SetVarList(this.FileVarName, fs);
                                context.WriteLog($"成功列出{fs.Count}个远程文件");
                            }
                            break;
                        case FtpType.DeleteDir:
                            client.DeleteDirectory(files[0]);
                            context.WriteLog($"成功删除远程目录{files[0]}");
                            break;
                        case FtpType.DownloadDir:
                            context.WriteLog($"开始下载远程目录{files[0]}");
                            client.DownloadDirectory(files[0], selectdir, FtpFolderSyncMode.Update, ftpLocalExists);
                            context.WriteLog($"成功下载远程目录{files[0]}");
                            break;
                        case FtpType.UploadDir:
                            context.WriteLog($"开始上传文件夹至远程目录{files[0]}");
                            client.UploadDirectory(files[0], selectdir, FtpFolderSyncMode.Update, remoteExists);
                            context.WriteLog($"成功上传文件夹至远程目录{files[0]}");
                            break;
                    }
                }
                finally
                {
                    client.Disconnect();
                }
            }
            else
            {
                if (this.FtpType == FtpType.ListDirDir || this.FtpType == FtpType.ListDirFile || this.FtpType == FtpType.Delete)
                {
                    using (SshClient sshClient = new SshClient(server, this.Port, username, password))
                    {
                        //连接
                        sshClient.Connect();
                        if (this.FtpType == FtpType.Delete)
                        {
                            foreach (string s in files)
                            {
                                var dcmd = sshClient.RunCommand("rm -f '" + s + "'");
                                //ExitStatus == 0 执行成功
                                //
                                if (dcmd.ExitStatus == 0)
                                {
                                    context.WriteLog($"成功删除远程文件 {s}");
                                }
                                else
                                {
                                    throw new Exception(dcmd.Error);//错误信息
                                }
                                context.WriteLog($"成功删除{files.Count}个远程文件");
                            }
                        }
                        else
                        {
                            //执行命令
                            var cmd = sshClient.RunCommand("ls -lF " + selectdir);

                            //ExitStatus == 0 执行成功
                            //
                            if (cmd.ExitStatus == 0)
                            {
                                List<string> lines = cmd.Result.Trim().Split('\n').ToList();
                                List<string> datas = new List<string>();

                                if (this.FtpType == FtpType.ListDirDir)
                                {
                                    for (int i = 0; i < lines.Count; i++)
                                    {
                                        if (lines[i].StartsWith("d"))
                                        {
                                            string txt = getName(lines[i]);
                                            datas.Add(selectdir.TrimEnd('/') + "/" + txt);
                                        }
                                    }
                                    context.SetVarList(this.FileVarName, datas);
                                    context.WriteLog($"成功列出{datas.Count}个远程目录");
                                }
                                else if (this.FtpType == FtpType.ListDirFile)
                                {
                                    for (int i = 0; i < lines.Count; i++)
                                    {
                                        if (lines[i].StartsWith("-"))
                                        {
                                            string txt = getName(lines[i]);
                                            datas.Add(selectdir.TrimEnd('/') + "/" + txt);
                                        }
                                    }
                                    context.SetVarList(this.FileVarName, datas);
                                    context.WriteLog($"成功列出{datas.Count}个远程文件");
                                }
                            }
                            else
                            {
                                throw new Exception(cmd.Error);//错误信息
                            }
                        }

                        //断开连接
                        sshClient.Disconnect();
                    }
                }
                else
                {
                    using (var sftpClient = new SftpClient(server, this.Port, username, password))
                    {
                        sftpClient.Connect();
                        if (this.FtpType == FtpType.Upload)
                        {
                            foreach (string fi in files)
                            {
                                context.WriteLog($"开始上传 {fi} 到远程目录{selectdir}");
                                System.IO.FileStream stream = System.IO.File.Open(fi, FileMode.Open);
                                string tofile = selectdir + "/" + System.IO.Path.GetFileName(fi);
                                sftpClient.UploadFile(stream, tofile, !this.ExistIgnore);
                            }
                            context.WriteLog($"成功上传{files.Count}个文件到远程目录{selectdir}");
                        }
                        else if (this.FtpType == FtpType.Download)
                        {
                            foreach (string fi in files)
                            {
                                string save = System.IO.Path.Combine(selectdir, System.IO.Path.GetFileName(fi));
                                if (System.IO.File.Exists(save) && this.ExistIgnore) continue;
                                using (var stream = File.Open(save, FileMode.OpenOrCreate))
                                {
                                    context.WriteLog($"开始下载 {fi} 到本地目录{save}");
                                    sftpClient.DownloadFile(fi, stream);
                                }
                            }
                            context.WriteLog($"成功下载{files.Count}个文件到本地目录{selectdir}");
                        }
                    }
                }
            }
        }

        private string getName(string text)
        {
            System.Text.RegularExpressions.Match m = System.Text.RegularExpressions.Regex.Match(text, "\\d\\d:?\\d\\d (.*?)$");
            if (m.Success)
            {
                string find = m.Groups[1].Value;
                return getName(find);
            }
            else
            {
                return text;
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.Server)) throw new Exception("主机地址不能为空");
            if (this.Port == 0) throw new Exception("端口不能为空");
            if (string.IsNullOrEmpty(this.UserName)) throw new Exception("用户名不能为空");
            if (string.IsNullOrEmpty(this.Password)) throw new Exception("密码不能为空");

            switch (this.FtpType)
            {
                case FtpType.ListDirDir:
                case FtpType.ListDirFile:
                    if (this.SelectDir == "") throw new Exception("目录不能为空");
                    if (string.IsNullOrEmpty(this.FileVarName)) throw new Exception("保存变量不能为空");
                    if (!context.ContainsList(this.FileVarName)) throw new Exception("保存变量必须为列表变量");
                    break;
                case FtpType.Delete:
                    if (string.IsNullOrEmpty(this.FileVarName)) throw new Exception("删除变量不能为空");
                    if (!context.ContainsList(this.FileVarName) && !context.ContainsStr(this.FileVarName)) throw new Exception("删除变量必须为字符或列表变量");
                    break;
                case FtpType.Upload:
                case FtpType.Download:
                    if (this.SelectDir == "") throw new Exception("目录不能为空");
                    if (string.IsNullOrEmpty(this.FileVarName)) throw new Exception("上传或下载变量不能为空");
                    if (!context.ContainsList(this.FileVarName) && !context.ContainsStr(this.FileVarName)) throw new Exception("上传或下载变量必须为字符或列表变量");
                    break;
                case FtpType.UploadDir:
                case FtpType.DownloadDir:
                    if (this.SelectDir == "") throw new Exception("目录不能为空");
                    if (string.IsNullOrEmpty(this.FileVarName)) throw new Exception("上传或下载变量不能为空");
                    if (!context.ContainsStr(this.FileVarName)) throw new Exception("上传或下载变量必须为字符变量");
                    break;
            }
        }
    }
}
