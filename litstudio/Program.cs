using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litstudio
{
    [Serializable]
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);//设置非窗体异常是否捕获或抛出模式
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "litwsdk.dll")) System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory + "litwsdk.dll");

            Assembly asm = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(asm.Location);
            if (!fvi.InternalName.Equals("litstudio.exe", StringComparison.OrdinalIgnoreCase)) return;

            //https://www.cnblogs.com/ahdung/p/5499570.html

            bool restart = args.Length == 1 && args[0] == "restart";
            if (restart) System.Threading.Thread.Sleep(2000);

            string sourcedir = AppDomain.CurrentDomain.BaseDirectory + "Temp~\\";
            if (!System.IO.Directory.Exists(sourcedir)) System.IO.Directory.CreateDirectory(sourcedir);

            Process instance = RunningInstance();
            if (instance != null)
            {
                if (!PostThreadMessage(instance.Threads[0].Id, 0x80F0, IntPtr.Zero, IntPtr.Zero))
                {
                    if (restart)
                    {
                        instance.Kill();
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("程序已经运行！", "提示",
    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                litsdk.Setting.CefCacheDir = AppDomain.CurrentDomain.BaseDirectory + "Temp~\\cef\\";
                litstudio.FrmDesign design = new FrmDesign();
                Application.Run(design);
            }
        }


        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool PostThreadMessage(int threadId, uint msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 获取正在运行的实例，没有运行的实例返回null;
        /// </summary>
        public static Process RunningInstance()
        {
            System.Diagnostics.Process curProcess = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process[] allProcess = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process process in allProcess)
            {
                try
                {
                    if (process.Id != curProcess.Id)
                    {
                        if (process.ProcessName == curProcess.ProcessName || process.MainModule.FileVersionInfo.InternalName == curProcess.MainModule.FileVersionInfo.InternalName || (!string.IsNullOrEmpty(curProcess.MainModule.FileVersionInfo.ProductName) && process.MainModule.FileVersionInfo.ProductName == curProcess.MainModule.FileVersionInfo.ProductName))
                        {
                            return process;
                        }
                    }
                }
                catch { }
            }
            return null;
        }


        //关于异常处理：http://hi.baidu.com/zionking/blog/item/d6e28fdf5a5438b3cc11662d.html
        /// <summary>
        /// 非UI线程异常，UnhandledException提供的机制并不能阻止应用程序终止，记录到异常后，应用程序就会被终止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = e.ExceptionObject as Exception;
            if (exception == null)
            {
                return;
            }
            MessageBox.Show(exception.Message + "\r\n" + exception.StackTrace, "UnhandledException", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// UI线程异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message + "\r\n" + e.Exception.StackTrace, "ThreadException", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}