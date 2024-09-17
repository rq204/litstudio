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
    internal partial class PskillUI : litsdk.ILitUI
    {
        public PskillUI()
        {
            InitializeComponent();
            this.ivPskillvalue.ShowVarName(true, false, true, this.tbPskillValue);
            this.SaveActivity = new Action(() =>
            {
                ps.PskillValue = this.tbPskillValue.Text.Trim();
                ps.Name = this.tbActivityName.Text;
                if (this.rbFilePath.Checked) ps.PskillFindType = PskillFindType.FilePath;
                else if (this.rbProcessName.Checked) ps.PskillFindType = PskillFindType.ProcessName;
                else if (this.rbProcessId.Checked) ps.PskillFindType = PskillFindType.ProcessId;

                if (this.rbLatest.Checked) ps.PskillCloseType = PskillCloseType.Latest;
                else if (this.rbEarliest.Checked) ps.PskillCloseType = PskillCloseType.Earliest;
                else if (this.rbAll.Checked) ps.PskillCloseType = PskillCloseType.All;
            });
        }

        PskillActivity ps = null;
        public override void SetActivity(Activity activity)
        {
             ps = activity as PskillActivity;
            switch (ps.PskillFindType)
            {
                case PskillFindType.FilePath:
                    this.rbFilePath.Checked = true;
                    break;
                case PskillFindType.ProcessName:
                    this.rbProcessName.Checked = true;
                    break;
                case PskillFindType.ProcessId:
                    this.rbProcessId.Checked = true;
                    break;
            }
            this.tbPskillValue.Text = ps.PskillValue;
            this.tbActivityName.Text = ps.Name;
            switch (ps.PskillCloseType)
            {
                case PskillCloseType.Earliest:
                    this.rbEarliest.Checked = true;
                    break;
                case PskillCloseType.Latest:
                    this.rbLatest.Checked = true;
                    break;
                case PskillCloseType.All:
                    this.rbAll.Checked = true;
                    break;
                   
            }
        }

        private void llbCurrentDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbPskillValue, this.llbCurrentDir.Text);
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) this.tbPskillValue.Text = openFileDialog.FileName;
        }
    }
}
