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

namespace litstudio
{
    internal partial class FileUI : litsdk.ILitUI
    {
        public FileUI()
        {
            InitializeComponent();
            this.ivSource.ShowVarName(true, false, true, this.tbSourcePath);
            this.ivDestPath.ShowVarName(true, false, true, this.tbDestPath);

            this.SaveActivity = new Action(() =>
              {
                  this.fa.SourcePath = this.tbSourcePath.Text.Trim();
                  this.fa.DestPath = this.tbDestPath.Text.Trim();
                  this.fa.Name = this.tbActivityName.Text;
                  if (this.rbCopyFile.Checked) fa.FileType = litcore.type.FileType.CopyFile;
                  else if (this.rbCreateDir.Checked) fa.FileType = litcore.type.FileType.CreateDir;
                  else if (this.rbDeleteFile.Checked) fa.FileType = litcore.type.FileType.DeleteFile;
                  else if (this.rbMoveFile.Checked) fa.FileType = litcore.type.FileType.MoveFile;
                  else if (this.rbDeleteDir.Checked) fa.FileType = litcore.type.FileType.DeleteDir;
              });
        }

        litcore.activity.FileActivity fa = null;
        public override void SetActivity(Activity activity)
        {
            fa = activity as litcore.activity.FileActivity;
            this.tbSourcePath.Text = fa.SourcePath;
            this.tbDestPath.Text = fa.DestPath;
            this.tbActivityName.Text = fa.Name;
            switch (fa.FileType)
            {
                case litcore.type.FileType.CopyFile:
                    this.rbCopyFile.Checked = true;
                    break;
                case litcore.type.FileType.CreateDir:
                    this.rbCreateDir.Checked = true;
                    break;
                case litcore.type.FileType.DeleteFile:
                    this.rbDeleteFile.Checked = true;
                    break;
                case litcore.type.FileType.MoveFile:
                    this.rbMoveFile.Checked = true;
                    break;
                case litcore.type.FileType.DeleteDir:
                    this.rbDeleteDir.Checked = true;
                    break;
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            this.lbDest.Visible = this.tbDestPath.Visible = this.ivDestPath.Visible = this.llbDestDir.Visible = !this.rbDeleteFile.Checked && !this.rbCreateDir.Checked && !this.rbDeleteDir.Checked;
        }

        private void llbCurrentDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbSourcePath, this.llbCurrentDir.Text);
        }

        private void llbDestDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbDestPath, this.llbDestDir.Text);
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "所有文件|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbSourcePath.Text = openFileDialog.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbDestPath.Text = openFileDialog.FileName;
            }
        }
    }
}
