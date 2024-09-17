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

namespace litapps
{
    internal partial class ExplorerOpenUI : litsdk.ILitUI
    {
        public ExplorerOpenUI()
        {
            InitializeComponent();
            this.ivFilePath.ShowVarName(true, false, true, this.tbFilePath);
            this.SaveActivity = new Action(() =>
             {
                 this.eoa.OpenDir = this.cbOpenDir.Checked;
                 this.eoa.OpenFile = this.cbOpenFile.Checked;
                 this.eoa.OpenDirSelectFile = this.cbOpenDirSelectFile.Checked;
                 this.eoa.FilePath = this.tbFilePath.Text.Trim();
                 this.eoa.Name = this.tbActivityName.Text.Trim();
             });
        }
        ExplorerOpenActivity eoa = null;
        public override void SetActivity(Activity activity)
        {
            eoa = activity as ExplorerOpenActivity;
            this.cbOpenDir.Checked = eoa.OpenDir;
            this.cbOpenFile.Checked = eoa.OpenFile;
            this.cbOpenDirSelectFile.Checked = eoa.OpenDirSelectFile;
            this.tbFilePath.Text = eoa.FilePath;
            this.tbActivityName.Text = eoa.Name;
        }
        private void llbdir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbFilePath, this.llbdir.Text);
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) this.tbFilePath.Text = openFileDialog.FileName;
        }
    }
}
