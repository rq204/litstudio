using litsdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litext
{
    internal partial class FileAttriUI : litsdk.ILitUI
    {
        public FileAttriUI()
        {
            InitializeComponent();
            this.svOptVarName.ShowVarName(true, false, false);
            this.ivFilePath.ShowVarName(true, false, true, this.tbOptFilePath);

            foreach (Control c in this.scActivityUI.Panel1.Controls)
            {
                if (c is RadioButton rb) rb.CheckedChanged += Rb_CheckedChanged;
            }

            this.SaveActivity = () =>
            {
                if (this.rbGetCreationTime.Checked)
                {
                    fa.FileAttriType = FileAttriType.GetCreationTime;
                }
                else if (this.rbGetLastAccessTime.Checked)
                {
                    fa.FileAttriType = FileAttriType.GetLastAccessTime;

                }
                else if (this.rbGetLastWriteTime.Checked)
                {
                    fa.FileAttriType = FileAttriType.GetLastWriteTime;
                }
                else if (this.rbSetCreationTime.Checked)
                {
                    fa.FileAttriType = FileAttriType.SetCreationTime;
                }
                else if (this.rbSetLastAccessTime.Checked)
                {
                    fa.FileAttriType = FileAttriType.SetLastAccessTime;
                }
                else if (this.rbSetLastWriteTime.Checked)
                {
                    fa.FileAttriType = FileAttriType.SetLastWriteTime;
                }
                fa.Name = this.tbActivityName.Text;
                fa.OptVarName = this.svOptVarName.VarName;
                fa.FilePath = this.tbOptFilePath.Text;
            };
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private FileAttriActivity fa = null;
        public override void SetActivity(Activity activity)
        {
            fa = activity as FileAttriActivity;

            switch (fa.FileAttriType)
            {
                case FileAttriType.GetCreationTime:
                    this.rbGetCreationTime.Checked = true;
                    break;
                case FileAttriType.GetLastAccessTime:
                    this.rbGetLastAccessTime.Checked = true;
                    break;
                case FileAttriType.GetLastWriteTime:
                    this.rbGetLastWriteTime.Checked = true;
                    break;
                case FileAttriType.SetCreationTime:
                    this.rbSetCreationTime.Checked = true;
                    break;
                case FileAttriType.SetLastAccessTime:
                    this.rbSetLastAccessTime.Checked = true;
                    break;
                case FileAttriType.SetLastWriteTime:
                    this.rbSetLastWriteTime.Checked = true;
                    break;
            }

            this.svOptVarName.VarName = fa.OptVarName;
            this.tbActivityName.Text = fa.Name;
            this.tbOptFilePath.Text = fa.FilePath;
        }

        private void llbCur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbOptFilePath, this.llbCur.Text);
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK) this.tbOptFilePath.Text = of.FileName;
        }
    }
}
