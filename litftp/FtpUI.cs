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

namespace litftp
{
    internal partial class FtpUI : litsdk.ILitUI
    {
        public FtpUI()
        {
            InitializeComponent();

            this.ivServer.ShowVarName(true, false, true, this.tbServer);
            this.ivUserName.ShowVarName(true, false, true, this.tbUserName);
            this.ivPassword.ShowVarName(true, false, true, this.tbPassword);
            this.ivPort.ShowVarName(true, false, true, this.tbPort);
            this.svFileVarName.ShowVarName(true, true, false);
            this.ivSelectDir.ShowVarName(true, false, true, this.tbSelectDir);

            this.SaveActivity = new Action(() =>
              {
                  if (this.rbUpload.Checked == true) fa.FtpType = FtpType.Upload;
                  else if (this.rbDownload.Checked == true) fa.FtpType = FtpType.Download;
                  else if (this.rbDelete.Checked == true) fa.FtpType = FtpType.Delete;
                  else if (this.rbListDirFile.Checked == true) fa.FtpType = FtpType.ListDirFile;
                  else if (this.rbListDirDir.Checked == true) fa.FtpType = FtpType.ListDirDir;
                  else if (this.rbDownloadDir.Checked == true) fa.FtpType = FtpType.DownloadDir;
                  else if (this.rbUploadDir.Checked == true) fa.FtpType = FtpType.UploadDir;
                  else if (this.rbDeleteDir.Checked == true) fa.FtpType = FtpType.DeleteDir;
 
                  fa.Server = this.tbServer.Text.Trim();
                  int port = 0;
                  if (int.TryParse(this.tbPort.Text, out port)) fa.Port = port;

                  fa.UserName = this.tbUserName.Text.Trim();
                  fa.Password = this.tbPassword.Text.Trim();
                  fa.SelectDir = this.tbSelectDir.Text.Trim();
                  fa.FileVarName = this.svFileVarName.VarName;
                  fa.Passive = this.cbPassive.Checked;
                  fa.ExistIgnore = this.cbExistIgnore.Checked;
                  fa.Sftp = this.cbSftp.Checked;
                  fa.Name = this.tbActivityName.Text.Trim();
              });
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUpload.Checked || this.rbUploadDir.Checked) this.lbDirInfo.Text = "上传目录";
            else if (rbDownload.Checked || this.rbDownloadDir.Checked) this.lbDirInfo.Text = "下载目录";
            else if (rbListDirDir.Checked || rbListDirFile.Checked) this.lbDirInfo.Text = "遍历目录";

            this.cbExistIgnore.Visible = this.rbUpload.Checked || this.rbDownload.Checked || this.rbUploadDir.Checked || this.rbDownloadDir.Checked;
            if (rbListDirDir.Checked || rbListDirFile.Checked)
            {
                this.lbFileInfo.Text = "保存变量";
            }
            else if (this.rbDeleteDir.Checked || this.rbUploadDir.Checked)
            {
                this.lbFileInfo.Text = "目录地址";
            }
            else
            {
                this.lbFileInfo.Text = "文件地址";
            }

            //目录的显示
            this.tbSelectDir.Visible = this.lbDirInfo.Visible = this.ivSelectDir.Visible = !this.rbDelete.Checked && !this.rbDeleteDir.Checked;

            if (this.rbUpload.Checked || this.rbDownload.Checked || this.rbDelete.Checked)
            {
                this.svFileVarName.ShowVarName(true, true, false);
            }
            else if (this.rbUploadDir.Checked || this.rbDeleteDir.Checked)
            {
                this.svFileVarName.ShowVarName(true, false, false);
            }
            else if (this.rbListDirDir.Checked || this.rbListDirFile.Checked)
            {
                this.svFileVarName.ShowVarName(false, true, false);
            }
        }

        public override string ActivityType => "litftp.FtpActivity";
        FtpActivity fa = null;
        public override void SetActivity(Activity activity)
        {
            fa = activity as FtpActivity;

            switch (fa.FtpType)
            {
                case FtpType.Upload:
                    this.rbUpload.Checked = true;
                    break;
                case FtpType.Delete:
                    this.rbDelete.Checked = true;
                    break;
                case FtpType.Download:
                    this.rbDownload.Checked = true;
                    break;
                case FtpType.ListDirFile:
                    this.rbListDirFile.Checked = true;
                    break;
                case FtpType.ListDirDir:
                    this.rbListDirDir.Checked = true;
                    break;
                case FtpType.UploadDir:
                    this.rbUploadDir.Checked = true;
                    break;
                case FtpType.DownloadDir:
                    this.rbDownloadDir.Checked = true;
                    break;
                case FtpType.DeleteDir:
                    this.rbDeleteDir.Checked = true;
                    break;
            }

            this.tbServer.Text = fa.Server;
            this.tbPort.Text = fa.Port.ToString();
            this.tbUserName.Text = fa.UserName;
            this.tbPassword.Text = fa.Password;
            this.tbSelectDir.Text = fa.SelectDir;
            this.svFileVarName.VarName = fa.FileVarName;
            this.cbPassive.Checked = fa.Passive;
            this.cbSftp.Checked = fa.Sftp;
            this.cbExistIgnore.Checked = fa.ExistIgnore;
            this.tbActivityName.Text = fa.Name;
        }
    }
}
