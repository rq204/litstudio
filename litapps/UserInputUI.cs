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

namespace litapps
{
    internal partial class UserInputUI : litsdk.ILitUI
    {
        public UserInputUI()
        {
            InitializeComponent();
            this.cbType.SelectedIndex = 0;
            this.ivFormTitle.ShowVarName(true, false, true, this.tbFormTitle);
            this.SaveActivity = () =>
            {
                user.FormTitle = this.tbFormTitle.Text.Trim();
                user.TimeOutClose = this.cbTimeOutClose.Checked;
                user.TimeOutSenconds = (int)this.nudTimeOutSenconds.Value;
                user.Configs = new List<UserInputConfig>();
                foreach(ListViewItem lvi in this.lsvConfigs.Items)
                {
                    user.Configs.Add(lvi.Tag as UserInputConfig);
                }
                user.Name = this.tbActivityName.Text;
                user.CanCloseForm = this.cbCanCloseForm.Checked;
            };
        }

        UserInputActivity user = null;
        public override void SetActivity(Activity activity)
        {
            user = activity as UserInputActivity;
            this.tbFormTitle.Text = user.FormTitle;
            this.cbTimeOutClose.Checked = user.TimeOutClose;
            this.nudTimeOutSenconds.Value = user.TimeOutSenconds;
            foreach (UserInputConfig cc in user.Configs)
            {
                ListViewItem lvi = GetItem(cc);
                this.lsvConfigs.Items.Add(lvi);
            }
            this.tbActivityName.Text = user.Name;
            this.cbCanCloseForm.Checked = user.CanCloseForm;
        }

        private void lsvConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.llbEdit.Enabled = this.llbDelete.Enabled = this.lsvConfigs.SelectedItems.Count == 1;
            this.llbUp.Enabled = this.lsvConfigs.Items.Count > 1 && this.lsvConfigs.SelectedItems.Count == 1 && this.lsvConfigs.SelectedItems[0] != this.lsvConfigs.Items[0];
            this.llbDown.Enabled = this.lsvConfigs.Items.Count > 1 && this.lsvConfigs.SelectedItems.Count == 1 && this.lsvConfigs.SelectedItems[0] != this.lsvConfigs.Items[this.lsvConfigs.Items.Count - 1];
        }

        private void llbUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.lsvConfigs.SelectedItems.Count == 0) return;
            ListViewItem lvi = this.lsvConfigs.SelectedItems[0];
            int pos = this.lsvConfigs.Items.IndexOf(lvi);
            lvi.Remove();
            lsvConfigs.Items.Insert(pos - 1, lvi);
        }

        private void llbDown_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.lsvConfigs.SelectedItems.Count == 0) return;
            ListViewItem lvi = this.lsvConfigs.SelectedItems[0];
            int pos = this.lsvConfigs.Items.IndexOf(lvi);
            lvi.Remove();
            lsvConfigs.Items.Insert(pos + 1, lvi);
        }

        private void llbEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.lsvConfigs.SelectedItems.Count == 0) return;
            UserInputConfig uc = this.lsvConfigs.SelectedItems[0].Tag as UserInputConfig;
            this.tbTitle.Text = uc.Title;
            this.svDefaultVarName.VarName = uc.DefaultVarName;
            this.svSaveVarName.VarName = uc.ValueVarName;
            this.cbCanEmpty.Checked = uc.CanEmpty;
            this.cbType.SelectedIndex = (int)uc.Type;
        }

        private void llbDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.lsvConfigs.SelectedItems.Count == 0) return;
            this.lsvConfigs.SelectedItems[0].Remove();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbDefault.Text = "默认值";
            switch (cbType.SelectedIndex)
            {
                case (int)UserInputType.TextBox:
                case (int)UserInputType.MulTextBox:
                    this.svDefaultVarName.ShowVarName(true, false, false, false);
                    this.svSaveVarName.ShowVarName(true, false, false, false);
                    break;
                case (int)UserInputType.ComboBox:
                case (int)UserInputType.RadioButton:
                    this.lbDefault.Text = "选项值";
                    this.svDefaultVarName.ShowVarName(false, true, false, false);
                    this.svSaveVarName.ShowVarName(true, false, false);
                    break;
                case (int)UserInputType.CheckBox:
                    this.lbDefault.Text = "选项值";
                    this.svDefaultVarName.ShowVarName(true, true, false, false);
                    this.svSaveVarName.ShowVarName(true, true, false);
                    break;
                case (int)UserInputType.NumericUpDwon:
                    this.svDefaultVarName.ShowVarName(false, false, true, false);
                    this.svSaveVarName.ShowVarName(false, false, true);
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserInputConfig uc = new UserInputConfig() { CanEmpty = this.cbCanEmpty.Checked, Title = this.tbTitle.Text.Trim(), DefaultVarName = this.svDefaultVarName.VarName, ValueVarName = this.svSaveVarName.VarName };
            uc.Type = (UserInputType)Enum.ToObject(typeof(UserInputType), this.cbType.SelectedIndex);

            try
            {
                if (string.IsNullOrEmpty(uc.Title)) throw new Exception("标签名称不能为空");
                if (uc.Type == UserInputType.ComboBox || uc.Type == UserInputType.RadioButton)
                {
                    if (string.IsNullOrEmpty(uc.DefaultVarName)) throw new Exception("选项值不能为空");
                }
                if (string.IsNullOrEmpty(uc.ValueVarName)) throw new Exception("保存变量不能为空");
                ListViewItem find = null;
                foreach (ListViewItem lvi in this.lsvConfigs.Items)
                {
                    if (lvi.Text == uc.Title) { find = lvi; break; }
                }
                if (find != null)
                {
                    find.SubItems[1].Text = this.cbType.Text;
                    find.SubItems[2].Text = uc.DefaultVarName;
                    find.SubItems[3].Text = uc.ValueVarName;
                    find.SubItems[4].Text = uc.CanEmpty ? "是" : "否";
                    find.Tag = uc;
                }
                else
                {
                    find = GetItem(uc);// new ListViewItem(uc.Title);
                    this.lsvConfigs.Items.Add(find);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出错");
            }
        }

        private ListViewItem GetItem(UserInputConfig uc)
        {
            ListViewItem find = new ListViewItem(uc.Title);
            find.SubItems.Add(this.cbType.Text);
            find.SubItems.Add(uc.DefaultVarName);
            find.SubItems.Add(uc.ValueVarName);
            find.SubItems.Add(uc.CanEmpty ? "是" : "否");
            find.Tag = uc;
            return find;
        }

        private void lsvConfigs_DoubleClick(object sender, EventArgs e)
        {
            llbEdit_LinkClicked(null, null);
        }

        private void cbCanCloseForm_CheckedChanged(object sender, EventArgs e)
        {
            this.cbTimeOutClose.Enabled = cbCanCloseForm.Checked;
        }

        private void cbTimeOutClose_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbTimeOutClose.Checked && !this.cbCanCloseForm.Checked) this.cbCanCloseForm.Checked = true;
        }
    }
}
