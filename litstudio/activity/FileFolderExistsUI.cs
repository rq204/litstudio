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
    internal partial class FileFolderExistsUI : litsdk.ILitUI
    {
        public FileFolderExistsUI()
        {
            InitializeComponent();
            this.ivPath.ShowVarName(true, false, true, this.tbFileDirPath);
            this.SaveActivity = new Action(() =>
            {
                ffea.FileDirPath = this.tbFileDirPath.Text.Trim();
                ffea.IsDir = this.rbDir.Checked;
                ffea.Name = this.tbActivityName.Text.Trim();
            });
        }

        litcore.activity.IOResExistsActivity ffea = null;
        public override void SetActivity(Activity activity)
        {
            ffea = activity as litcore.activity.IOResExistsActivity;
            this.tbFileDirPath.Text = ffea.FileDirPath;
            this.rbFile.Checked = !ffea.IsDir;
            this.rbDir.Checked = ffea.IsDir;
            this.tbActivityName.Text = ffea.Name;
        }

        private void llbCurrentDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbFileDirPath, llbCurrentDir.Text);
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.rbFile.Checked)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.tbFileDirPath.Text = openFileDialog.FileName;
                }
            }
            else
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                if (f.ShowDialog() == DialogResult.OK) this.tbFileDirPath.Text = f.SelectedPath;
            }
        }
    }
}