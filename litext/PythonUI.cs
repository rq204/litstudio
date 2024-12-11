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
    internal partial class PythonUI : litsdk.ILitUI
    {
        public PythonUI()
        {
            InitializeComponent();
            this.smvVarList.ShowVarName(true, true, true);
            this.SaveActivity = new Action(() =>
              {
                  ToActivity(pa);
              });
            if (string.IsNullOrEmpty(PythonActivity.PythonExePath)) PythonActivity.LoadPythonPath();
            this.llbSetEnvPath.Visible = string.IsNullOrEmpty(PythonActivity.PythonExePath);
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

        private void ToActivity(PythonActivity haa)
        {
            haa.Name = this.tbActivityName.Text;
            haa.PyFile = this.cbPyFile.Text;
            haa.VarList = this.smvVarList.VarNames;
            haa.Name = this.tbActivityName.Text;
        }

        private System.IO.FileSystemWatcher watcher = null;
        PythonActivity pa = null;
        public override void SetActivity(Activity activity)
        {
            pa = activity as PythonActivity;
            this.smvVarList.VarNames = pa.VarList;
            this.cbPyFile.Text = pa.PyFile;
            this.tbActivityName.Text = pa.Name;
            if (!string.IsNullOrEmpty(PythonActivity.PythonExePath)) this.llbCheck.Text = PythonActivity.PythonExePath;
        }

        private void llbSetEnvPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://jingyan.baidu.com/article/a17d5285c9b0c48099c8f26a.html");
        }

        private void llbCreatePython_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = PythonActivity.PythonDir;
            sfd.Filter = "*.py|*.py";
            sfd.DefaultExt = ".py";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, Properties.Resource.python, System.Text.Encoding.UTF8);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            PythonActivity pythonActivity = new PythonActivity();
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
                foreach (string s in System.IO.Directory.GetFiles(PythonActivity.PythonDir, "*.py"))
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
            System.Diagnostics.Process.Start(PythonActivity.PythonDir);
        }

        private void llbEditPython_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string f = PythonActivity.PythonDir + this.cbPyFile.Text;
            if (System.IO.File.Exists(f))
            {
                System.Diagnostics.Process.Start(f);
            }
        }

        private void PythonUI_Load(object sender, EventArgs e)
        {
            watcher = new System.IO.FileSystemWatcher(PythonActivity.PythonDir, "*.py");
            watcher.NotifyFilter = NotifyFilters.FileName;
            watcher.Created += Watcher_Created;
            watcher.Deleted += Watcher_Deleted;
            watcher.Renamed += Watcher_Renamed;
            watcher.EnableRaisingEvents = true;
        }
    }
}
