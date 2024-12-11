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
using System.IO;

namespace litext
{
    internal partial class PHPUI : litsdk.ILitUI
    {
        public PHPUI()
        {
            InitializeComponent();
            this.smvVarList.ShowVarName(true, true, true);
            this.SaveActivity = new Action(() =>
              {
                  ToActivity(pa);
              });
            if (string.IsNullOrEmpty(PHPActivity.PHPExePath)) PHPActivity.LoadPHPPath();
            this.llbSetEnvPath.Visible = string.IsNullOrEmpty(PHPActivity.PHPExePath);
            this.mainLoadFiles();
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            this.threadLoadFiles();
            watcher.EnableRaisingEvents = true;
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            this.threadLoadFiles();
            watcher.EnableRaisingEvents = true;
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            this.threadLoadFiles();
            watcher.EnableRaisingEvents = true;
        }

        private void ToActivity(PHPActivity haa)
        {
            haa.Name = this.tbActivityName.Text;
            haa.PhpFile = this.cbPyFile.Text;
            haa.VarList = this.smvVarList.VarNames;
            haa.Name = this.tbActivityName.Text;
        }

        private System.IO.FileSystemWatcher watcher = null;
        PHPActivity pa = null;
        public override void SetActivity(Activity activity)
        {
            pa = activity as PHPActivity;
            this.smvVarList.VarNames = pa.VarList;
            this.cbPyFile.Text = pa.PhpFile;
            this.tbActivityName.Text = pa.Name;
            if (!string.IsNullOrEmpty(PHPActivity.PHPExePath)) this.llbCheck.Text = PHPActivity.PHPExePath;
        }

        private void llbSetEnvPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://jingyan.baidu.com/article/a17d5285c9b0c48099c8f26a.html");
        }

        private void llbCreatePython_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = PHPActivity.PHPDir;
            sfd.Filter = "*.php|*.php";
            sfd.DefaultExt = ".php";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, Properties.Resource.php, System.Text.Encoding.UTF8);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            PHPActivity pythonActivity = new PHPActivity();
            ToActivity(pythonActivity);
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            try
            {
                pythonActivity.Validate(context);
                pythonActivity.TestExecute(context);
                MessageBox.Show("测试完成，请查看相关变量值以确认代码是否有效","成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "发生错误");
            }
        }

        private object lk = new object();
        private void mainLoadFiles()
        {
            lock (lk)
            {
                string txt = this.cbPyFile.Text;
                this.cbPyFile.Items.Clear();
                foreach (string s in System.IO.Directory.GetFiles(PHPActivity.PHPDir, "*.php"))
                {
                    this.cbPyFile.Items.Add(System.IO.Path.GetFileName(s));
                }
                this.cbPyFile.Text = txt;
                if (string.IsNullOrEmpty(this.cbPyFile.Text) && this.cbPyFile.Items.Count > 0)
                {
                    this.cbPyFile.SelectedIndex = 0;
                }

            }
        }

        private void threadLoadFiles()
        {
            if (this.IsDisposed || this.Disposing) return;

            this.Invoke((EventHandler)delegate
            {
                mainLoadFiles();
            });
        }

        private void llbOpenDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(PHPActivity.PHPDir);
        }

        private void llbEditPython_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string f = PHPActivity.PHPDir + this.cbPyFile.Text;
            if (System.IO.File.Exists(f))
            {
                System.Diagnostics.Process.Start(f);
            }
        }

        private void PHPUI_Load(object sender, EventArgs e)
        {
            watcher = new System.IO.FileSystemWatcher(PHPActivity.PHPDir, "*.php");
            watcher.NotifyFilter = NotifyFilters.FileName;
            watcher.Created += Watcher_Created;
            watcher.Deleted += Watcher_Deleted;
            watcher.Renamed += Watcher_Renamed;
            watcher.EnableRaisingEvents = true;
        }
    }
}
