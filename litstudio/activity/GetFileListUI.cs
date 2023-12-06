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
    internal partial class GetFileListUI : litsdk.ILitUI
    {
        public GetFileListUI()
        {
            InitializeComponent();
            this.ivPath.ShowVarName(true, false, false, this.tbDirPath);
            this.SaveActivity = new Action(() =>
            {
                gfl.DirPath = this.tbDirPath.Text.Trim();
                gfl.Filter = this.tbFilter.Text.Trim();
                gfl.ListVarName = this.svListVarName.VarName;
                gfl.OnlyFileName = this.cbOnlyFileName.Checked;
                gfl.OnlyFileNameWithoutExt = this.cbOnlyFileNameWithoutExt.Checked;
                gfl.Name = this.tbActivityName.Text;
                gfl.DirList = this.cbDirList.Checked;
            });
            this.svListVarName.ShowVarName(false, true, false);
        }

        private void llbDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbDirPath, llbDir.Text);
        }

        litcore.activity.GetFileListActivity gfl = null;
        public override void SetActivity(Activity activity)
        {
            gfl = activity as litcore.activity.GetFileListActivity;
            this.tbDirPath.Text = gfl.DirPath;
            this.tbFilter.Text = gfl.Filter;
            this.svListVarName.VarName = gfl.ListVarName;
            this.tbActivityName.Text = gfl.Name;
            this.cbOnlyFileName.Checked = gfl.OnlyFileName;
            this.cbOnlyFileNameWithoutExt.Checked = gfl.OnlyFileNameWithoutExt;
            this.cbDirList.Checked = gfl.DirList;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbFilter, this.linkLabel1.Text);
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbDirPath.Text = openFileDialog.SelectedPath;
            }
        }
    }
}
