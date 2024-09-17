using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litapps
{
    [litsdk.ActivityInfo(Name = "打开程序")]
    public class AppStartActivity : litsdk.ProcessActivity
    {
        /// <summary>
        /// 操作类型 等待程序执行完成 （等待程序执行完成并保存输出到变量） 仅打开程序（保存pid到变量） 设置打超时
        /// </summary>
        private string name = "打开程序";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.App;

        /// <summary>
        /// 路径
        /// </summary>
        public string AppPath = "";

        /// <summary>
        /// 参数
        /// </summary>
        public string Arguments = "";

        /// <summary>
        /// 工作目录
        /// </summary>
        public string WorkingDirectory = "";

        //操作类型 打开

        /// <summary>
        /// 是否等待进行执行完毕
        /// </summary>
        public bool WaitProcess = false;

        /// <summary>
        /// 等待的话显示哪些返回信息
        /// </summary>
        public string SaveVarName = "";

        /// <summary>
        /// 输出编码
        /// </summary>
        public string OutputEncoding = "GB2312";

        /// <summary>
        /// 超时秒数
        /// </summary>
        public int TimeOutSeconds = 100;

        /// <summary>
        /// 默认app
        /// </summary>
        public bool DefaultApp = false;

        /// <summary>
        /// 隐藏启动
        /// </summary>
        public bool Hide = false;

        private bool exit = false;

        static bool InConsole = false;

        static AppStartActivity()
        {
            try
            {
                Console.WriteLine(Console.Title);
                InConsole = true;
            }
            catch { }
        }

        public override void Execute(ActivityContext context)
        {
            System.Diagnostics.Process p = null;
            if (this.DefaultApp)
            {
                string args = context.ReplaceVar(this.Arguments);
                p = System.Diagnostics.Process.Start(args);
                context.WriteLog($"使用默认文件执行打开{args}");
            }
            else
            {
                string exefile = context.ReplaceVar(this.AppPath);
                if (!System.IO.File.Exists(exefile)) throw new Exception("找不到可执行文件：" + exefile);
                System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
                processStartInfo.FileName = exefile;
                processStartInfo.Arguments = context.ReplaceVar(this.Arguments);

                if (!string.IsNullOrEmpty(this.WorkingDirectory))
                {
                    processStartInfo.WorkingDirectory = context.ReplaceVar(this.WorkingDirectory);
                }

                processStartInfo.UseShellExecute = false;
                if (Hide) processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

                if (!string.IsNullOrEmpty(this.SaveVarName))//不为空时要是控制台
                {
                    processStartInfo.RedirectStandardInput = true;
                    processStartInfo.RedirectStandardOutput = true;
                    processStartInfo.StandardOutputEncoding = System.Text.Encoding.Default;
                }

                p = System.Diagnostics.Process.Start(processStartInfo);
            }

            if (this.WaitProcess)
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                this.exit = false;
                p.EnableRaisingEvents = true;
                p.Exited += (a, b) => this.exit = true;

                string log = "";
                string outstr = "";
                if (!string.IsNullOrEmpty(this.SaveVarName))
                {
                    outstr = p.StandardOutput.ReadToEnd();

                    if (string.IsNullOrEmpty(outstr))
                    {
                        StreamReader myStreamReader = p.StandardError;// 读取错误流
                        outstr = myStreamReader.ReadToEnd();
                        log = "命令行执行读取到错误流";
                    }
                    else
                    {
                        log = "命令行执行完成";
                    }
                }
                else
                {
                    log = "打开程序并等待";
                }


                while (!exit)
                {
                    if (sw.ElapsedMilliseconds > this.TimeOutSeconds * 1000)
                    {
                        log = "运行超时结束任务";
                        try
                        {
                            p.Kill();
                        }
                        catch { }
                        break;
                    }
                    if (!InConsole)
                    {
                        System.Windows.Forms.Application.DoEvents();
                    }
                }
                sw.Stop();

                if (!string.IsNullOrEmpty(this.SaveVarName))
                {
                    context.SetVarStr(this.SaveVarName, outstr);
                    log += $",获取数据长库 {outstr.Length}";
                }
                context.WriteLog(log + ",总用时 " + ((int)(sw.ElapsedMilliseconds / 1000)).ToString() + "秒");
            }
            else
            {
                context.WriteLog("无需等待，命令行执行完成");
            }
        }

        private void P_Exited(object sender, EventArgs e)
        {
            exit = true;
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new AppStartUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.AppPath) && !this.DefaultApp) throw new Exception("应用程序不能为空");
            if (this.WaitProcess && !string.IsNullOrEmpty(this.SaveVarName) && !context.ContainsStr(this.SaveVarName)) throw new Exception("保存变量不存在");
        }


        /// <summary>
        /// https://www.xin3721.com/ArticlePrograme/C_biancheng/15552.html
        /// </summary>
        /// <param name="pFilePath"></param>
        /// <returns></returns>
        public static bool IsGuiApp(string pFilePath)

        {
            UInt16 subSystem;
            ushort architecture = 0;

            subSystem = 0;

            try

            {

                using (System.IO.FileStream fStream = new System.IO.FileStream(pFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))

                {

                    using (System.IO.BinaryReader bReader = new System.IO.BinaryReader(fStream))

                    {

                        if (bReader.ReadUInt16() == 23117) //check the MZ signature

                        {

                            fStream.Seek(0x3A, System.IO.SeekOrigin.Current); //seek to e_lfanew.

                            fStream.Seek(bReader.ReadUInt32(), System.IO.SeekOrigin.Begin); //seek to the start of the NT header.

                            if (bReader.ReadUInt32() == 17744) //check the PE\0\0 signature.

                            {

                                fStream.Seek(20, System.IO.SeekOrigin.Current); //seek past the file header,

                                architecture = bReader.ReadUInt16(); //read the magic number of the optional header.

                                fStream.Seek(0x42, System.IO.SeekOrigin.Current); //0x44h

                                subSystem = bReader.ReadUInt16();

                            }

                        }

                    }

                }

            }

            catch (Exception) { /* TODO: Any exception handling you want to do, personally I just take 0 as a sign of failure */}

            //if architecture returns 0, there has been an error.
            //SubSystem = subSystem == 2 ? "GUI" : (subSystem == 3 ? "CUI" : ""),

            return subSystem == 2;

            //return architecture;
        }
    }
}
