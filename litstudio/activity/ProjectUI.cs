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
    internal partial class ProjectUI : litsdk.ILitUI
    {
        public ProjectUI()
        {
            InitializeComponent();

            this.llbDir.Visible = this.llbOpen.Visible = true;

            this.SaveActivity = new Action(() =>
              {
                  pa.FilePath = this.tbFilePath.Text.Trim();
                  pa.Name = this.tbActivityName.Text;
                  pa.Bak = this.tbBak.Text;
                  pa.UseAsyn = this.cbUseAsyn.Checked;
                  pa.ThreadNum = (int)this.nudNumofAsyn.Value;
                  pa.OnlyUserLog = this.cbOnlyUserLog.Checked;
              });
        }

        litcore.activity.ProjectActivity pa = null;
        public override void SetActivity(Activity activity)
        {
            pa = activity as litcore.activity.ProjectActivity;
            this.tbFilePath.Text = pa.FilePath;
            this.tbActivityName.Text = pa.Name;
            this.tbBak.Text = pa.Bak;
            this.cbUseAsyn.Checked = pa.UseAsyn;
            try
            {
                this.nudNumofAsyn.Value = pa.ThreadNum;
            }
            catch
            {
                this.nudNumofAsyn.Value = 10;
            }
            this.cbOnlyUserLog.Checked = pa.OnlyUserLog;
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Project\\";
            if(openFileDialog.ShowDialog()== DialogResult.OK)
            {
                this.tbFilePath.Text = openFileDialog.FileName;
            }
        }

        private void llbDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbFilePath, this.llbDir.Text);
        }

        //private void cbEmbedFile_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (this.cbEmbedFile.Checked)
        //    {
        //        string filepath = litsdk.API.GetDesignActivityContext().ReplaceVar(this.tbFilePath.Text);
        //        if (this.tbFilePath.Text.Contains("{--var."))
        //        {
        //            MessageBox.Show("嵌入文件时，必须指定")
        //        }
        //        if (System.IO.File.Exists(filepath))
        //        {
        //            this.projectstr = System.IO.File.ReadAllText(filepath, System.Text.Encoding.UTF8);
        //            this.lbProjectSize.Text = $"当前流程文件大小为{this.projectstr.Length}";
        //        }
        //        else
        //        {
                   
        //        }
        //    }
        //}
    }
}
