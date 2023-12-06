using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litstudio.iecef
{
    public partial class FrmChrSetting : Form
    {
        private litsdk.ActivityContext context = null;
        public FrmChrSetting()
        {
            InitializeComponent();
            this.context = litsdk.API.GetDesignActivityContext();
            this.ivPath.ShowVarName(true, false, true, tbChromePath);
            this.ivUserData.ShowVarName(true, false, true, this.tbUserData);
            this.ivArge.ShowVarName(true, false, true, this.tbArguments);
            this.ivDriverPath.ShowVarName(true, false, true, this.tbDriverPath);
            this.svCrxVarName.ShowVarName(true, true, false);
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "谷歌浏览器|chrome.exe";
            openFile.Title = "请选择chrome.exe文件路径";
            if (openFile.ShowDialog() == DialogResult.OK) this.tbChromePath.Text = openFile.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            litcore.iecef.ChrSetting setting = new litcore.iecef.ChrSetting()
            {
                ChromePath = this.tbChromePath.Text,
                Arguments = this.tbArguments.Text,
                UserData = this.tbUserData.Text,
                UseDefaultUserData = this.cbUserDefaultUserData.Checked,
                RemoteDebugging = this.cbRemoteDebugging.Checked,
                DriverPath = this.tbDriverPath.Text,
                CrxVarName = this.svCrxVarName.VarName,
                Mobile = this.cbMobile.Checked
            };
            context.SetUserConfig("ChrSetting", setting);
            this.DialogResult = DialogResult.OK;
        }

        private void FrmChrSetting_Load(object sender, EventArgs e)
        {
            object obj = context.GetUserConfig("ChrSetting");
            if (obj != null)
            {
                litcore.iecef.ChrSetting setting = obj as litcore.iecef.ChrSetting;
                this.tbChromePath.Text = setting.ChromePath;
                this.tbArguments.Text = setting.Arguments;
                this.tbUserData.Text = setting.UserData;
                this.cbUserDefaultUserData.Checked = setting.UseDefaultUserData;
                this.cbRemoteDebugging.Checked = setting.RemoteDebugging;
                this.tbDriverPath.Text = setting.DriverPath;
                this.svCrxVarName.VarName = setting.CrxVarName;
                this.cbMobile.Checked = setting.Mobile;
            }
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK) this.tbUserData.Text = folder.SelectedPath;
        }

        private void cbRemoteDebugging_CheckedChanged(object sender, EventArgs e)
        {
            this.lbPath.Text = cbRemoteDebugging.Checked ? "调试地址" : "谷歌路径";
        }

        private void btnDirverPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "谷歌驱动|chromedriver.exe";
            openFile.Title = "请选择chromedriver.exe文件路径,空为使用当前目录下chromedriver.exe";
            if (openFile.ShowDialog() == DialogResult.OK) this.tbDriverPath.Text = openFile.FileName;
        }
    }
}
