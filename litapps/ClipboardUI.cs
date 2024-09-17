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
    internal partial class ClipboardUI : litsdk.ILitUI
    {
        public ClipboardUI()
        {
            InitializeComponent();
            this.svStrVarName.ShowVarName(true, false, false);
            this.SaveActivity = new Action(() =>
              {
                  ca.StrVarName = this.svStrVarName.VarName;
                  if (this.rbSetStrToClipboard.Checked) ca.ClipboardType = ClipboardType.SetStrToClipboard;
                  else if (this.rbSetImageToClipboard.Checked) ca.ClipboardType = ClipboardType.SetImageToClipboard;
                  else if (this.rbSetFileToClipboard.Checked) ca.ClipboardType = ClipboardType.SetFileToClipboard;
                  else if (this.rbGetStrFromClipboard.Checked) ca.ClipboardType = ClipboardType.GetStrFromClipboard;
                  else if (this.rbSaveImageFromClipboard.Checked) ca.ClipboardType = ClipboardType.SaveImageFromClipboard;
                  ca.Name = this.tbActivityName.Text;
              });
        }

        ClipboardActivity ca = null;
        public override void SetActivity(Activity activity)
        {
            ca = activity as ClipboardActivity;
            switch (ca.ClipboardType)
            {
                case ClipboardType.GetStrFromClipboard:
                    this.rbGetStrFromClipboard.Checked = true;
                    break;
                case ClipboardType.SaveImageFromClipboard:
                    this.rbSaveImageFromClipboard.Checked = true;
                    break;
                case ClipboardType.SetFileToClipboard:
                    this.rbSetFileToClipboard.Checked = true;
                    break;
                case ClipboardType.SetImageToClipboard:
                    this.rbSetImageToClipboard.Checked = true;
                    break;
                case ClipboardType.SetStrToClipboard:
                    this.rbSetStrToClipboard.Checked = true;
                    break;
            }
            this.svStrVarName.VarName = ca.StrVarName;
            this.tbActivityName.Text = ca.Name;
        }

        private void rbSet_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked) this.lbSetGet.Text = "使用变量值";
        }

        private void rbGet_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked) this.lbSetGet.Text = "保存至变量";
        }
    }
}