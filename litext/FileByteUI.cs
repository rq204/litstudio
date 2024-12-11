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
    public partial class FileByteUI : litsdk.ILitUI
    {
        public FileByteUI()
        {
            InitializeComponent();
            this.svOptVarName.ShowVarName(true, false, false);
            this.ivFilePath.ShowVarName(true, false, true, this.tbOptFilePath);

            //foreach (Control c in this.scActivityUI.Panel1.Controls)
            //{
            //    if (c is RadioButton rb) rb.CheckedChanged += Rb_CheckedChanged;
            //}

            this.SaveActivity = () =>
            {
                if (this.rbFileDateToBase64.Checked)
                {
                    fa.FileByteType = FileByteType.FileDataToBase64;
                }
                else if (this.rbBase64Str2File.Checked)
                {
                    fa.FileByteType= FileByteType.Base64Str2File;
                }
                fa.Name = this.tbActivityName.Text;
                fa.OptVarName = this.svOptVarName.VarName;
                fa.FilePath = this.tbOptFilePath.Text;
            };
        }

        //private void Rb_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        private FileByteActivity fa = null;

        public override void SetActivity(Activity activity)
        {
            fa = activity as FileByteActivity;

            switch (fa.FileByteType)
            {
                case FileByteType.FileDataToBase64:
                    this.rbFileDateToBase64.Checked = true;
                    break;
                case FileByteType.Base64Str2File:
                    this.rbBase64Str2File.Checked = true;
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
