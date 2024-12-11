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

namespace litext
{
    internal partial class IniUI : litsdk.ILitUI
    {
        public IniUI()
        {
            InitializeComponent();
            this.svVarName.ShowVarName(true, false, true);
            this.ivIniPath.ShowVarName(true, false, true, this.tbIniFile);
            this.ivSection.ShowVarName(true, false, false, this.tbSetion);
            this.ivKey.ShowVarName(true, false, false, this.tbKey);

            base.SaveActivity = new Action(() =>
            {
                ini.IniFile = this.tbIniFile.Text.Trim();
                ini.Name = this.tbActivityName.Text.Trim();
                ini.ReadIni = this.rbRead.Checked;
                ini.IniConfigs.Clear();
                foreach (ListViewItem lvi in this.lsvIniConfigs.Items)
                {
                    IniConfig c = new IniConfig() { Section = lvi.Text, Key = lvi.SubItems[1].Text, VarName = lvi.SubItems[2].Text };
                    ini.IniConfigs.Add(c);
                }
            });
        }

        IniActivity ini = null;
        public override void SetActivity(Activity activity)
        {
            ini = activity as IniActivity;
            this.tbIniFile.Text = ini.IniFile;
            this.rbRead.Checked = ini.ReadIni;
            this.rbWrite.Checked = !ini.ReadIni;
            foreach (IniConfig config in ini.IniConfigs)
            {
                ListViewItem lvi = new ListViewItem(config.Section);
                lvi.SubItems.Add(config.Key);
                lvi.SubItems.Add(config.VarName);
                this.lsvIniConfigs.Items.Add(lvi);
            }
            this.tbActivityName.Text = ini.Name;
        }

        private void llbCur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbIniFile, this.llbCur.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IniConfig c = new IniConfig() { Section = this.tbSetion.Text.Trim(), Key = this.tbKey.Text.Trim(), VarName = this.svVarName.VarName };
            try
            {
                if (c.Section == "") throw new Exception("节点名不能为空");
                if (c.Key == "") throw new Exception("键名不能为空");
                if (c.VarName == "") throw new Exception("变量名不能为空");
                ListViewItem find = null;
                foreach (ListViewItem lvi in this.lsvIniConfigs.Items)
                {
                    if (lvi.Text == c.Section && lvi.SubItems[1].Text == c.Key)
                    {
                        find = lvi;
                        break;
                    }
                }
                if (find != null)
                {
                    find.SubItems[2].Text = c.VarName;
                }
                else
                {
                    find = new ListViewItem(new string[] { c.Section, c.Key, c.VarName });
                    this.lsvIniConfigs.Items.Add(find);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出错");
            }
        }

        private void lsvIniConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.llbDelete.Enabled = this.llbEdit.Enabled = this.lsvIniConfigs.SelectedItems.Count == 1;
        }

        private void llbAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tbSetion.Clear();
            this.tbKey.Clear();
            this.svVarName.VarName = "";
        }

        private void llbDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.lsvIniConfigs.SelectedItems.Count > 0)
            {
                this.lsvIniConfigs.SelectedItems[0].Remove();
            }
        }

        private void llbEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.lsvIniConfigs.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.lsvIniConfigs.SelectedItems[0];
                this.tbSetion.Text = lvi.Text;
                this.tbKey.Text = lvi.SubItems[1].Text;
                this.svVarName.VarName = lvi.SubItems[2].Text;
            }
        }

        private void lsvIniConfigs_DoubleClick(object sender, EventArgs e)
        {
            llbEdit_LinkClicked(null, null);
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "*.ini|*.ini";
            if (of.ShowDialog() == DialogResult.OK) this.tbIniFile.Text = of.FileName;
        }
    }
}
