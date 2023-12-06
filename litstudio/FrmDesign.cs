using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using litcore;
using litsdk;
using Newtonsoft.Json;

namespace litstudio
{
    internal partial class FrmDesign : Form, IMessageFilter
    {
        public FrmDesign()
        {
            InitializeComponent();

            litsdk.API.GetDesignActivityContext = new Func<litsdk.ActivityContext>(this.GetActivityContext);
            litsdk.API.GetDesignActivity = (fullname) =>
            {
                List<Activity> needactivity = new List<Activity>();
                foreach (Node nnn in this.project.Nodes)
                {
                    if (nnn.Activity.GetType().FullName == fullname)
                    {
                        needactivity.Add(nnn.Activity);
                    }
                    else if (nnn.Activity.GetType().FullName == "litcore.activity.SequenceActivity")//序列
                    {
                        litcore.activity.SequenceActivity sa = nnn.Activity as litcore.activity.SequenceActivity;
                        foreach (ProcessActivity pa in sa.Activities)
                        {
                            if (pa.GetType().FullName == fullname)
                            {
                                needactivity.Add(pa);
                            }
                        }
                    }
                }
                return needactivity;
            };

            litsdk.API.ShowConfigForm = new Action<litsdk.Activity, System.Windows.Forms.UserControl>(this.ShowConfigForm);
            litsdk.API.ShowSystemConfigForm = new Action<litsdk.Activity>(this.ShowConfigForm);
            litsdk.API.ShowVariableForm = () => new FrmVarEditor(litsdk.API.GetDesignActivityContext()).ShowDialog();

            litsdk.API.GetMainForm = new Func<Form>(() => this);

            litcore.ActivityLoader.LoadActivities();
            FrmActivity.Create().Parent = this.activityPanel;

            if (!System.IO.Directory.Exists(this.pjdir)) System.IO.Directory.CreateDirectory(this.pjdir);
            this.Icon = this.nfcMain.Icon =Properties.Resources.设计器;
            this.tbLog.BringToFront();

            this.tsmiExport.Visible = litsdk.API.GetRefProject != null;
        }


        private void SetTitle()
        {
            string showstatus = "停止";
            switch (this.botRunner.State)
            {
                case BotState.Running:
                    showstatus = "运行";
                    break;
                case BotState.Paused:
                    showstatus = "暂停";
                    break;
                case BotState.Completed:
                    showstatus = "完成";
                    break;
            }

            string change = "*";
            string projectStr = this.project.ToJson();

            if (this.oldFileContent == projectStr) change = "";
            string title = "流程设计器";
            string txt = string.IsNullOrEmpty(this.fileName) ? title : string.Format("{3}{1} [{2}] - {0}", title, this.fileName, showstatus, change);
            int leng = System.Text.Encoding.Default.GetBytes(txt.ToCharArray()).Length;
            if (leng > 64) txt = string.Format("{3}{1} [{2}] - {0}", title, System.IO.Path.GetFileName(this.fileName), showstatus, change);
            this.Invoke((EventHandler)delegate
            {
                this.Text = txt;
                this.nfcMain.Text = txt;
            });
        }

        public void ShowConfigForm(Activity activity, UserControl userControl)
        {
            ILitUI litUI = userControl as ILitUI;

            if (activity is litcore.activity.SequenceActivity)
            {
                this.pagePanel.Enabled = false;
                this.SequenceFrm = new FrmSequence2(activity as litcore.activity.SequenceActivity);
                this.SequenceFrm.f5action = this.f5action;
                this.scRight.Panel1.Controls.Add(this.SequenceFrm);

                this.SequenceFrm.Location = new Point((int)((this.pagePanel.Width - SequenceFrm.Width) / 2), (int)((this.pagePanel.Height - SequenceFrm.Height) / 2));
                SequenceFrm.BringToFront();
                this.SequenceFrm.Show();
                this.SequenceFrm.Disposed += ((obj, e) =>
                {
                    this.SequenceFrm = null;
                    this.pagePanel.Enabled = true;
                });
            }
            else if (this.SequenceFrm != null)
            {
                this.SequenceFrm.ShowLitUI(activity, litUI);
            }
            else
            {
                this.pagePanel.Enabled = false;
                FrmActivityConfig2 frmVariableConfig = new FrmActivityConfig2(activity, litUI);
                this.scRight.Panel1.Controls.Add(frmVariableConfig);
                frmVariableConfig.Location = new Point((int)((this.pagePanel.Width - frmVariableConfig.Width) / 2), (int)((this.pagePanel.Height - frmVariableConfig.Height) / 2));
                frmVariableConfig.BringToFront();
                frmVariableConfig.Show();
                frmVariableConfig.Disposed += ((obj, e) =>
                 {
                     this.pagePanel.Enabled = true;
                     //如果改的循环，循环结尾也要同名一下
                     if (activity is litcore.activity.LoopStartActivity lpstart)
                     {
                         foreach (litsdk.Node node in this.project.Nodes)
                         {
                             if (node.Activity.Equals(lpstart))
                             {
                                 litcore.LoopStartNode loopStart = node as litcore.LoopStartNode;
                                 litsdk.Node end = this.project.Nodes.Find((f) => f.Id == loopStart.LoopEndNodeId);
                                 end.Activity.Name = lpstart.Name;
                                 break;
                             }
                         }
                     }
                     this.page.Invalidate();
                 });
            }
        }

        /// <summary>
        /// 自匹配配置界面
        /// </summary>
        /// <param name="activity"></param>
        public void ShowConfigForm(Activity activity)
        {
            litsdk.ILitUI litUI = GetLitUI(activity);
            if (litUI == null) litUI = litcore.IlitUILoader.GetInstance(activity.GetType().FullName);
            if (litUI == null && !(activity is litcore.activity.SequenceActivity)) throw new Exception("not find ilitui " + activity.GetType().FullName);

            if (activity is litcore.activity.SequenceActivity)
            {
                this.pagePanel.Enabled = false;
                this.SequenceFrm = new FrmSequence2(activity as litcore.activity.SequenceActivity);
                this.SequenceFrm.f5action = this.f5action;
                this.scRight.Panel1.Controls.Add(this.SequenceFrm);
                this.SequenceFrm.Location = new Point((int)((this.pagePanel.Width - SequenceFrm.Width) / 2), (int)((this.pagePanel.Height - SequenceFrm.Height) / 2));
                SequenceFrm.BringToFront();
                this.SequenceFrm.Show();
                this.SequenceFrm.Disposed += ((obj, e) =>
                {
                    this.SequenceFrm = null;
                    this.pagePanel.Enabled = true;
                });

            }
            else if (this.SequenceFrm != null)
            {
                this.SequenceFrm.ShowLitUI(activity, litUI);
            }
            else
            {
                this.pagePanel.Enabled = false;
                FrmActivityConfig2 frmVariableConfig = new FrmActivityConfig2(activity, litUI);
                this.scRight.Panel1.Controls.Add(frmVariableConfig);
                frmVariableConfig.Location = new Point((int)((this.pagePanel.Width - frmVariableConfig.Width) / 2), (int)((this.pagePanel.Height - frmVariableConfig.Height) / 2));
                frmVariableConfig.BringToFront();
                frmVariableConfig.Show();
                frmVariableConfig.Disposed += ((obj, e) =>
                {
                    this.pagePanel.Enabled = true;
                    //如果改的循环，循环结尾也要同名一下
                    if (activity is litcore.activity.LoopStartActivity lpstart)
                    {
                        foreach (litsdk.Node node in this.project.Nodes)
                        {
                            if (node.Activity.Equals(lpstart))
                            {
                                litcore.LoopStartNode loopStart = node as litcore.LoopStartNode;
                                litsdk.Node end = this.project.Nodes.Find((f) => f.Id == loopStart.LoopEndNodeId);
                                end.Activity.Name = lpstart.Name;
                                break;
                            }
                        }
                    }
                    this.page.Invalidate();
                });
            }
        }

        private void FrmDesign_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private litsdk.Project project = new litsdk.Project();

        /// <summary>
        /// 设计图
        /// </summary>
        private Page page;

        /// <summary>
        /// 当前编辑的文件名
        /// </summary>
        private string fileName = string.Empty;
        /// <summary>
        /// 旧文件的内容
        /// </summary>
        private string oldFileContent = string.Empty;

        private void FrmDesign_Load(object sender, EventArgs e)
        {
            this.createNewProject();
            this.WindowState = FormWindowState.Maximized;

            Application.AddMessageFilter(this);

            litcore.Hotkey.RegisterHotKey(this.Handle, 100, Hotkey.KeyModifiers.Alt, Keys.F11);
            litcore.Hotkey.RegisterHotKey(this.Handle, 101, Hotkey.KeyModifiers.Shift, Keys.F11);


            //加载界面
            new System.Threading.Thread(() => { litcore.IlitUILoader.LoadIlitUIs(); }).Start();

            Option.Read();
        }

        private System.Threading.Thread f5thread = null;

        private void f5action(litsdk.Node node)
        {
            if ((botRunner.State == BotState.Completed || botRunner.State == BotState.Stopped) && (f5thread == null || f5thread.ThreadState != System.Threading.ThreadState.Running) && node.Activity is litsdk.ProcessActivity pac)
            {
                if (this.scRight.Panel2.Height <= 10) this.scRight.SplitterDistance = this.scRight.Height - 66;

                bool isfront = false, iswinform = false, isbrowser = false;
                litcore.Utility.CheckActivity(node.Activity, ref isfront, ref iswinform, ref isbrowser);

                WriteLog("开始执行单步测试，按F6停止");

                this.tsbRun.Enabled = false;

                if (isfront)
                {
                    DsDebug.Location = this.Location;
                    DsDebug.Size = this.Size;
                    this.WindowState = FormWindowState.Minimized;
                    System.Threading.Thread.Sleep(300);
                }

                botRunner.CurrentNode = node;

                if (pac is litcore.activity.ProjectActivity pactivity) pactivity.ClearArunner();

                this.f5thread = new System.Threading.Thread(() =>
                  {
                      try
                      {
                          litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
                          context.WriteLog = this.WriteLog;
                          pac.Validate(context);
                          botRunner.ctsStop = new CancellationTokenSource();

                          if (node.Activity.Group == ActivityGroup.CefBroswer)
                          {
                              litsdk.API.GetMainForm().Invoke((EventHandler)delegate
                              {
                                  pac.Execute(context);
                              });
                          }
                          else
                          {
                              pac.Execute(context);
                          }
                      }
                      catch (Exception ex)
                      {
                          if (this.botRunner.ctsStop == null || !botRunner.ctsStop.IsCancellationRequested)
                          {
                              WriteLog("单步测试出错:" + ex.Message);
                          }
                      }
                      finally
                      {
                          if (f5thread != null)
                          {
                              this.f5thread = null;
                              botRunner.CurrentNode = null;
                              botRunner.ctsStop = null;

                              if (!this.IsDisposed && !this.Disposing)
                              {
                                  this.Invoke((EventHandler)delegate
                                  {
                                      this.tsbRun.Enabled = true;
                                      if (isfront)
                                      {
                                          this.WindowState = FormWindowState.Normal;
                                          this.Location = DsDebug.Location;
                                          this.Size = DsDebug.Size;
                                      }
                                      if (isbrowser) this.Activate();
                                  });
                              }

                              this.WriteLog("当前单步测试完成");
                          }
                      }
                  });
                this.f5thread.Start();
            }
        }

        private void f6action()
        {
            if (this.f5thread != null)
            {
                if (this.f5thread.ThreadState == System.Threading.ThreadState.Running)
                {
                    try
                    {
                        this.f5thread.Abort();
                    }
                    catch { }
                }
                this.f5thread = null;
                botRunner.CurrentNode = null;
                botRunner.ctsStop.Cancel();

                this.Invoke((EventHandler)delegate
                {
                    if (this.tsbRun.Enabled == false) this.tsbRun.Enabled = true;
                });

                WriteLog("当前单步测试被用户停止");
            }
        }

        private void createNewProject()
        {
            if (litsdk.API.OnChangeProject != null) litsdk.API.OnChangeProject();

            this.fileName = string.Empty;
            this.page = Page.Create();
            this.page.OnPaint = new Action(this.SetTitle);
            this.page.F5Action = new Action<Node>(this.f5action);
            this.page.F6Action = new Action(this.f6action);
            this.project = new Project();
            this.project.Nodes = this.page.Nodes;
            this.botRunner = new litcore.BotRunner(this.project);
            this.botRunner.InitAction();
            this.botRunner.ActivityContext.WriteLog = this.WriteLog;

            this.botRunner.OnStateChanged += BotRunner_OnStateChanged;
            this.botRunner.OnNodeChanged += page.Page_OnNodeChanged;
            this.page.Show(this.pagePanel);
            this.oldFileContent = this.project.ToJson();
            this.tsbRun.Enabled = true;
            this.tsbPause.Enabled = this.tsbStop.Enabled = false;
            this.scRight.SplitterDistance = this.scRight.Height;
            this.SetTitle();
            if (this.SequenceFrm != null)
            {
                this.SequenceFrm.Dispose();
                this.SequenceFrm = null;
            }
            foreach (Control c in this.scRight.Panel1.Controls)
            {
                if (c.GetType() == typeof(FrmActivityConfig2))
                {
                    ((FrmActivityConfig2)c).Dispose();
                }
            }
        }

        private void BotRunner_OnStateChanged(litcore.BotRunner botRunner)
        {
            if (this.Disposing || this.IsDisposed) return;
            this.Invoke((EventHandler)delegate
            {
                switch (botRunner.State)
                {
                    case litsdk.BotState.Completed:
                    case litsdk.BotState.Stopped:
                        this.tsbRun.Enabled = true;
                        this.tsbPause.Enabled = this.tsbStop.Enabled = false;
                        try
                        {
                            if (this.IsDisposed || this.Disposing) return;
                            this.Invoke((EventHandler)delegate
                            {
                                if (this.WindowState == FormWindowState.Minimized || DsDebug.IsFront)
                                {
                                    this.WindowState = FormWindowState.Normal;
                                    this.Location = DsDebug.Location;
                                    this.Size = DsDebug.Size;
                                }
                            });
                        }
                        catch { }
                        break;
                    case litsdk.BotState.Paused:
                        this.tsbPause.Enabled = false;
                        this.tsbRun.Enabled = this.tsbStop.Enabled = true;
                        break;
                    case litsdk.BotState.Running:
                        this.tsbRun.Enabled = false;
                        this.tsbPause.Enabled = this.tsbStop.Enabled = true;
                        break;
                }
            });
            this.SetTitle();
        }

        private litcore.BotRunner botRunner = null;

        public litsdk.ActivityContext GetActivityContext()
        {
            return this.botRunner.ActivityContext;
        }

        public void WriteLog(string txt)
        {
            if (this.IsDisposed || this.Disposing) return;
            string log = $"【{DateTime.Now.ToString("MM-dd HH:mm:ss")}】{txt}";
            if (botRunner.CurrentNode != null) log = $"【{DateTime.Now.ToString("MM-dd HH:mm:ss")}】【{botRunner.CurrentNode.Activity.Name}】{txt}";
            this.Invoke((EventHandler)delegate
            {
                if (this.tbLog.Lines.Length > 5000) this.tbLog.Clear();
                this.tbLog.AppendText($"{log}\r\n");
            });
        }

        private void TsbNew_Click(object sender, EventArgs e)
        {
            if (this.project.ToJson() != this.oldFileContent)
            {
                if (MessageBox.Show("确认不保存当前流程设计内容？", "新建确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;
            }
            this.createNewProject();
        }

        private string pjdir = AppDomain.CurrentDomain.BaseDirectory + "Project";
        private void TsbOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = pjdir;
            openFileDialog.Filter = "*.json|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.openProject(openFileDialog.FileName);
            }
        }

        private void openProject(string filename)
        {
            string json = "";
            json = System.IO.File.ReadAllText(filename, System.Text.Encoding.UTF8);

            Project temp = Project.GetProject(json);
            this.openProject(temp, filename, json);
        }

        private void openProject(litsdk.Project temp, string filename, string json)
        {
            if (temp == null)
            {
                List<string> ls = litcore.Utility.GetUnavailableActivity(json);
                ///以后版本要发现并能下载
                if (ls.Count > 0)
                {
                    MessageBox.Show(string.Join("\r\n", ls.ToArray()), "项目文件无法解析");
                }
                else
                {
                    if (Project.PaserError == null)
                    {
                        MessageBox.Show("没有找到不能解析的组件，但是整个项目不能解析，可能是组件命名空间升级错误，请检查或联系服务提供商", "项目文件无法解析");
                    }
                    else
                    {
                        MessageBox.Show(Project.PaserError.ErrorContext.Error.Message, "解析流程文件失败");
                    }
                }
            }
            else
            {
                this.project = temp;

                this.fileName = filename;
                this.page = Page.Create();
                this.page.OnPaint = new Action(this.SetTitle);
                this.page.F5Action = new Action<Node>(this.f5action);
                this.page.F6Action = new Action(this.f6action);
                this.page.Nodes = this.project.Nodes;
                this.page.Show(this.pagePanel);

                this.botRunner = new litcore.BotRunner(this.project);
                this.botRunner.ActivityContext.WriteLog = this.WriteLog;
                this.botRunner.InitAction();
                this.botRunner.OnStateChanged += BotRunner_OnStateChanged;
                this.botRunner.OnNodeChanged += page.Page_OnNodeChanged;

                this.oldFileContent = this.project.ToJson();

                this.tsbPause.Enabled = this.tsbStop.Enabled = false;
                this.SetTitle();
                Option.SetOpenList(filename);

                if (litsdk.API.OnChangeProject != null) litsdk.API.OnChangeProject();
            }
            if (this.SequenceFrm != null)
            {
                this.SequenceFrm.Dispose();
                this.SequenceFrm = null;
            }
            foreach (Control c in this.scRight.Panel1.Controls)
            {
                if (c.GetType() == typeof(FrmActivityConfig2))
                {
                    ((FrmActivityConfig2)c).Dispose();
                }
            }
        }

        private void TsbSave_Click(object sender, EventArgs e)
        {
            string projectJson = this.project.ToJson();

            if (!string.IsNullOrEmpty(this.fileName))
            {
                if (projectJson != this.oldFileContent)
                {
                    string bakpath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bak", DateTime.Now.ToString("yyyy-MM-dd"), System.IO.Path.GetFileNameWithoutExtension(this.fileName) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".json");
                    string bakdir = System.IO.Path.GetDirectoryName(bakpath);
                    if (!System.IO.Directory.Exists(bakdir)) System.IO.Directory.CreateDirectory(bakdir);
                    System.IO.File.WriteAllText(bakpath, this.oldFileContent, System.Text.Encoding.UTF8);
                }
                else
                {
                    return;
                }
            }

            this.oldFileContent = projectJson;

            if (string.IsNullOrEmpty(this.fileName))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "*.json|*.json";
                saveFileDialog.InitialDirectory = pjdir;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.fileName = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(this.fileName, this.oldFileContent, System.Text.Encoding.UTF8);
                }
                else return;
            }
            else
            {
                System.IO.File.WriteAllText(this.fileName, this.oldFileContent, System.Text.Encoding.UTF8);
            }

            this.SetTitle();
            Option.SetOpenList(this.fileName);
        }


        private void TsbRun_Click(object sender, EventArgs e)
        {
            Node node = null;
            try
            {
                this.botRunner.Validate(ref node);
            }
            catch (Exception ex)
            {
                string err = node.Activity.Name + "\r\n" + ex.Message;
                err += "\r\n" + ex.StackTrace;
                MessageBox.Show(err, "配置有误");
                return;
            }
            this.ShowLog();
            bool isfront = false, iswinform = false, isbrowser = false;
            this.project.CheckCreateApp(ref isfront, ref iswinform, ref isbrowser);
            if (isfront)
            {
                DsDebug.Location = this.Location;
                DsDebug.Size = this.Size;
                this.WindowState = FormWindowState.Minimized;
                System.Threading.Thread.Sleep(300);
            }

            DsDebug.IsFront = isfront;
            DsDebug.IsWinform = iswinform;
            DsDebug.IsBrowser = isbrowser;
            this.tbLog.Clear();
            this.botRunner.ctsStop = new CancellationTokenSource();

            foreach (Node n in this.project.Nodes)
            {
                if (n.Activity is litcore.activity.ProjectActivity pa)
                {
                    pa.ClearArunner();
                }
            }

            this.botRunner.Run();
        }

        internal void ShowLog()
        {
            if (this.scRight.Panel2.Height <= 10) this.scRight.SplitterDistance = this.scRight.Height - 66;
        }

        private void TsbPause_Click(object sender, EventArgs e)
        {
            this.botRunner.Pause();
        }

        private void TsbStop_Click(object sender, EventArgs e)
        {
            this.botRunner.Stop();
        }

        private void TsbVariable_Click(object sender, EventArgs e)
        {
            FrmVarEditor frmVarEditor = new FrmVarEditor(litsdk.API.GetDesignActivityContext());
            frmVarEditor.ShowDialog();
            this.SetTitle();
        }

        private FrmSequence2 SequenceFrm = null;

        public static litsdk.ILitUI GetLitUI(litsdk.Activity activity)
        {
            litsdk.ILitUI litUI = null;
            if (activity is litcore.activity.ConvertActivity)
            {
                litUI = new litstudio.ConvertUI();
            }
            else if (activity is litcore.activity.HttpRequestActivity)
            {
                litUI = new litstudio.HttpRequestUI();
            }
            else if (activity is litcore.activity.IntActivity)
            {
                litUI = new litstudio.IntUI();
            }
            else if (activity is litcore.activity.SleepActivity)
            {
                litUI = new litstudio.SleepUI();
            }
            else if (activity is litcore.activity.TrimListActivity)
            {
                litUI = new litstudio.TrimListUI();
            }
            else if (activity is litcore.activity.ReSetVarActivity)
            {
                litUI = new litstudio.ReSetVarUI();
            }
            else if (activity is litcore.activity.LogicDecideActivity)
            {
                litUI = new litstudio.LogicUI();
            }
            else if (activity is litcore.activity.RWTextActivity)
            {
                litUI = new litstudio.ReadWriteTextUI();
            }
            else if (activity is litcore.activity.LoopStartActivity)
            {
                litUI = new litstudio.LoopUI();
            }
            else if (activity is litcore.activity.GetResourceActivity)
            {
                litUI = new litstudio.GetUrlUI();
            }
            else if (activity is litcore.activity.TextEncodeActivity)
            {
                litUI = new litstudio.TextEncodeUI();
            }
            else if (activity is litcore.activity.RegexActivity)
            {
                litUI = new litstudio.CollectStrListUI();
            }
            else if (activity is litcore.activity.StrReplaceActivity)
            {
                litUI = new litstudio.StrReplaceUI();
            }
            else if (activity is litcore.activity.StrLogicActivity)
            {
                litUI = new litstudio.StrLogicUI();
            }
            else if (activity is litcore.activity.IOResExistsActivity)
            {
                litUI = new litstudio.FileFolderExistsUI();
            }
            else if (activity is litcore.activity.GetFileListActivity)
            {
                litUI = new litstudio.GetFileListUI();
            }
            else if (activity is litcore.activity.CSVActivity)
            {
                litUI = new litstudio.CSVUI();
            }
            else if (activity is litcore.activity.JsonActivity)
            {
                litUI = new litstudio.JsonUI();
            }
            else if (activity is litcore.activity.RandomActivity)
            {
                litUI = new litstudio.RandomUI();
            }
            else if (activity is litcore.activity.TimeActivity)
            {
                litUI = new litstudio.TimeUI();
            }
            else if (activity is litcore.activity.LogActivity)
            {
                litUI = new litstudio.LogUI();
            }
            //浏览器
            else if (activity is litcore.iecef.Commond)
            {
                litUI = new litstudio.iecef.CommondUI();
            }
            else if (activity is litcore.iecef.Cookies)
            {
                litUI = new litstudio.iecef.CookiesUI();
            }
            else if (activity is litcore.iecef.Navigate)
            {
                litUI = new litstudio.iecef.NavigateUI();
            }
            else if (activity is litcore.iecef.RunJs)
            {
                litUI = new litstudio.iecef.RunJsUI();
            }
            else if (activity is litcore.iecef.ScreenShot)
            {
                litUI = new litstudio.iecef.ScreenShotUI();
            }
            else if (activity is litcore.iecef.SwitchTab)
            {
                litUI = new litstudio.iecef.SwitchTabUI();
            }
            else if (activity is litcore.iecef.PageInfo)
            {
                litUI = new litstudio.iecef.PageInfoUI();
            }
            else if (activity is litcore.iecef.Scroll)
            {
                litUI = new litstudio.iecef.ScrollUI();
            }
            else if (activity is litcore.iecef.XPath)
            {
                litUI = new litstudio.iecef.XPathUI();
            }
            else if (activity is litcore.iecef.Proxy)
            {
                litUI = new litstudio.iecef.ProxyUI();
            }
            else if (activity is litcore.iecef.ToPdf)
            {
                litUI = new litstudio.iecef.ToPdfUI();
            }
            else if (activity is litcore.iecef.Exist)
            {
                litUI = new litstudio.iecef.ExistUI();
            }
            else if (activity is litcore.iecef.ClickDown)
            {
                litUI = new litstudio.iecef.ClickDownUI();
            }
            else if (activity is litcore.iecef.ClickUpload)
            {
                litUI = new litstudio.iecef.ClickUploadUI();
            }
            else if (activity is litcore.activity.ProjectActivity)
            {
                litUI = new litstudio.ProjectUI();
            }
            else if (activity is litcore.activity.TableActivity)
            {
                litUI = new litstudio.TableUI();
            }
            else if (activity is litcore.activity.FileActivity)
            {
                litUI = new litstudio.FileUI();
            }
            else if (activity is litcore.activity.FormActivity)
            {
                litUI = new litstudio.FormUI();
            }
            else if (activity is litcore.iecef.Wait)
            {
                litUI = new litstudio.iecef.WaitUI();
            }
            else if (activity is litcore.iecef.FormState)
            {
                litUI = new litstudio.iecef.FormStateUI();
            }
            else if (activity is litcore.iecef.Slide)
            {
                litUI = new litstudio.iecef.SlideUI();
            }
            else if (activity is litcore.iecef.Mouse)
            {
                litUI = new litstudio.iecef.MouseUI();
            }
            else if (activity is litcore.iecef.Sniffer)
            {
                litUI = new litstudio.iecef.SnifferUI();
            }
            else if (activity is litcore.activity.MultDecideActivity)
            {
                litUI = new litstudio.MultDecisionUI();
            }
            return litUI;
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            if (this.project.ToJson() != this.oldFileContent)
            {
                if (MessageBox.Show("确认不保存当前流程设计内容？", "退出确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;
            }
            litcore.Hotkey.UnregisterHotKey(this.Handle, 100);
            litcore.Hotkey.UnregisterHotKey(this.Handle, 101);

            if (this.botRunner.State == BotState.Running) this.botRunner.Stop();
            if (litsdk.API.OnExit != null) litsdk.API.OnExit();
            Application.RemoveMessageFilter(this);
            Environment.Exit(100);
        }

        private void tsmiShowMain_Click(object sender, EventArgs e)
        {
            if (!this.Visible) this.Show();
            else this.Hide();
        }

        private void nfcMain_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Visible) this.Show();
            else this.Hide();
        }

        private void tsmiCaptureImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "*.jpg|*.jpg";
            saveFileDialog.DefaultExt = ".jpg";
            saveFileDialog.FileName = this.fileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.page.CreateBitmap().Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }

        private void FrmDesign_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                this.tsbSave.PerformClick();
            }
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "*.json|*.json";
            saveFileDialog.InitialDirectory = pjdir;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.fileName = saveFileDialog.FileName;
            }
            else return;
            this.oldFileContent = this.project.ToJson();
            System.IO.File.WriteAllText(this.fileName, this.oldFileContent, System.Text.Encoding.UTF8);

            this.SetTitle();
            Option.option.OpenList.Remove(this.fileName);
            Option.option.OpenList.Insert(0, this.fileName);
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x80F0)
            {
                if (!this.Visible) this.Show();
                else HandleRunningInstance(System.Diagnostics.Process.GetCurrentProcess());
                return true;
            }
            else if (m.Msg == 0x312)
            {
                switch (m.WParam.ToInt32())
                {
                    case 100:  //按下的是Alt+F11,开始、停止
                        if (this.botRunner.State == BotState.Running)
                        {
                            this.botRunner.Stop();
                        }
                        else
                        {
                            TsbRun_Click(null, null);
                        }
                        break;
                    case 101:  //按下的是Shift+F11，暂停
                        if (this.botRunner.State == BotState.Running)
                        {
                            this.botRunner.Pause();
                        }
                        break;
                }

            }
            return false;
        }

        /// <summary>
        /// 显示已运行的程序。
        /// </summary>
        public static void HandleRunningInstance(Process instance)
        {
            ShowWindowAsync(instance.MainWindowHandle, WS_SHOWNORMAL); //显示，可以注释掉
            SetForegroundWindow(instance.MainWindowHandle);            //放到前端
        }
        /// <summary>
        /// 该函数设置由不同线程产生的窗口的显示状态。
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="cmdShow">指定窗口如何显示。查看允许值列表，请查阅ShowWlndow函数的说明部分。</param>
        /// <returns>如果函数原来可见，返回值为非零；如果函数原来被隐藏，返回值为零。</returns>
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        /// <summary>
        /// 该函数将创建指定窗口的线程设置到前台，并且激活该窗口。键盘输入转向该窗口，并为用户改各种可视的记号。系统给创建前台窗口的线程分配的权限稍高于其他线程。
        /// </summary>
        /// <param name="hWnd">将被激活并被调入前台的窗口句柄。</param>
        /// <returns>如果窗口设入了前台，返回值为非零；如果窗口未被设入前台，返回值为零。</returns>
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private const int WS_SHOWNORMAL = 1;

        private void tsbSelecter_Click(object sender, EventArgs e)
        {
            string exe = AppDomain.CurrentDomain.BaseDirectory + "FlaUInspect.exe";
            if (System.IO.File.Exists(exe))
            {
                System.Diagnostics.Process.Start(exe);
            }
            else
            {
                MessageBox.Show("找不到文件:" + exe, "找不到文件");
            }
        }

        private void tsmiWebSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.litrpa.com/");
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            this.page.CtrlC();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            this.page.CtrlV();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            this.page.DeleteNode();
        }

        private void tsmiRunSelect_Click(object sender, EventArgs e)
        {
            this.page.F5Run();
        }

        private void tsmiOption_Click(object sender, EventArgs e)
        {
            new FrmOption().ShowDialog();
        }


        private void tsmiRebot_Click(object sender, EventArgs e)
        {
            if (this.project.ToJson() != this.oldFileContent)
            {
                if (MessageBox.Show("确认不保存当前流程设计内容？", "重启确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;
            }
            litcore.Hotkey.UnregisterHotKey(this.Handle, 100);
            litcore.Hotkey.UnregisterHotKey(this.Handle, 101);

            if (this.botRunner.State == BotState.Running) this.botRunner.Stop();

            if (litsdk.API.OnExit != null) litsdk.API.OnExit();
            System.Diagnostics.Process.Start(Application.ExecutablePath, "restart");
            Application.RemoveMessageFilter(this);
            Environment.Exit(100);
        }

        private void tsmiOpenDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void tmAutoSave_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.fileName) && Option.option.AutoSave)
            {
                this.tsmiSave.PerformClick();
            }
        }

        private void tsmiShowAllActivity_Click(object sender, EventArgs e)
        {
            FrmActivity.Instance.ReloadTree();
            this.tsmiShowAllActivity.Checked = true;
            this.tsmiShowNoFrontActivity.Checked = false;
            this.tsmiShowCrossActivity.Checked = false;
        }

        private void tsmiShowNoFrontActivity_Click(object sender, EventArgs e)
        {
            FrmActivity.Instance.ReloadTreeSelect(true, false, true);
            this.tsmiShowAllActivity.Checked = false;
            this.tsmiShowNoFrontActivity.Checked = true;
            this.tsmiShowCrossActivity.Checked = false;
        }

        private void tsmiShowCrossActivity_Click(object sender, EventArgs e)
        {
            FrmActivity.Instance.ReloadTreeSelect(false, false, true);
            this.tsmiShowAllActivity.Checked = false;
            this.tsmiShowNoFrontActivity.Checked = false;
            this.tsmiShowCrossActivity.Checked = true;
        }

        private void tsmiProject_Click(object sender, EventArgs e)
        {
            FrmProject fp = new FrmProject(this.project);
            fp.ShowDialog();
        }

        private void tsmiTestSpeed0s_Click(object sender, EventArgs e)
        {
            Option.option.DebugSleep = 0;
            Option.Save();
        }

        private void tsmiTestSpeed05s_Click(object sender, EventArgs e)
        {
            Option.option.DebugSleep = 300;
            Option.Save();
        }

        private void tsmiTestSpeed1s_Click(object sender, EventArgs e)
        {
            Option.option.DebugSleep = 500;
            Option.Save();
        }

        private void tsmiTestSpeed_DropDownOpening(object sender, EventArgs e)
        {
            this.tsmiTestSpeed0s.Checked = this.tsmiTestSpeed05s.Checked = this.tsmiTestSpeed1s.Checked = false;
            switch (Option.option.DebugSleep)
            {
                case 0:
                    this.tsmiTestSpeed0s.Checked = true;
                    break;
                case 300:
                    this.tsmiTestSpeed05s.Checked = true;
                    break;
                case 500:
                    this.tsmiTestSpeed1s.Checked = true;
                    break;
            }
        }

        private void tsmiFile_DropDownOpening(object sender, EventArgs e)
        {
            this.tsmiOpenLastProject.DropDownItems.Clear();
            foreach (string s in Option.option.OpenList)
            {
                ToolStripMenuItem toolStrip = new ToolStripMenuItem(System.IO.Path.GetFileName(s));
                toolStrip.Tag = s;
                toolStrip.Click += new EventHandler((s1, e1) =>
                {
                    this.openProject(((ToolStripMenuItem)s1).Tag.ToString());
                });
                toolStrip.AutoToolTip = true;
                toolStrip.ToolTipText = s;
                this.tsmiOpenLastProject.DropDownItems.Add(toolStrip);
            }
            this.tsmiSaveAs.Visible = !string.IsNullOrEmpty(this.fileName);
        }

        private void tsmiImportLocal_Click(object sender, EventArgs e)
        {
            if (this.project.ToJson() != this.oldFileContent)
            {
                if (MessageBox.Show("确认不保存当前流程设计内容？", "新建确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;
            }
            if (litsdk.API.GetRefProject != null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "*.json|*.json";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                string json = System.IO.File.ReadAllText(ofd.FileName, System.Text.Encoding.UTF8);
                litsdk.Project pj = litsdk.Project.GetProject(json);
                this.fileName = string.Empty;
                this.openProject(pj, this.fileName, json);
            }
        }

        private void tsmiExport_Click(object sender, EventArgs e)
        {
            string projectJson = this.project.ToJson();
            string saveName = !string.IsNullOrEmpty(this.fileName) ? this.fileName : "未命名";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "*.json|*.json";
            saveFileDialog.InitialDirectory = pjdir;
            saveFileDialog.FileName = saveName + ".json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, projectJson, System.Text.Encoding.UTF8);
            }
        }


        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiUndo_Click(object sender, EventArgs e)
        {
            this.page.Undo();
        }

        /// <summary>
        /// 恢复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRecover_Click(object sender, EventArgs e)
        {
            this.page.Redo();
        }

        private void tsmiMerge_Click(object sender, EventArgs e)
        {
            this.page.CtrlM();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }
    }
}