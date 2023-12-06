using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsdk
{
    /// <summary>
    /// 机器人运行控制
    /// </summary>
    public class Boter
    {
        /// <summary>
        /// 任务ID
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        /// 机器人Id
        /// </summary>
        public string BotId { get; set; }

        /// <summary>
        /// 流程数据
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// BotStart
        /// </summary>
        public BotStart BotStart { get; set; } 

        /// <summary>
        /// 返回的参数变量
        /// </summary>
        public List<litsdk.Variable> Variables = new List<litsdk.Variable>();

        /// <summary>
        /// 机器人地址
        /// </summary>
        public static string BotFile = AppDomain.CurrentDomain.BaseDirectory + "litrobot.exe";

        public static bool BotFileExist
        {
            get
            {
                return System.IO.File.Exists(BotFile);
            }
        }

        private System.Diagnostics.Process process = null;

        /// <summary>
        /// 只启动一次的
        /// </summary>
        public void Start()
        {
            if (this.process != null) return;//只启动一次
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
            processStartInfo.FileName = BotFile;
            processStartInfo.UseShellExecute = false;
            processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            processStartInfo.Arguments = litsdk.API.BotStartEncode(this.BotStart);
            this.process = System.Diagnostics.Process.Start(processStartInfo);
            this.process.EnableRaisingEvents = true;
            this.process.Exited += P_Exited;
        }

        /// <summary>
        /// 任务是否结束
        /// </summary>
        public bool End = false;

        /// <summary>
        /// 结束事件
        /// </summary>
        public Action<Boter> BotEnd = null;

        private void P_Exited(object sender, EventArgs e)
        {
            this.End = true;
            if (BotEnd != null) BotEnd(this);
        }

        /// <summary>
        /// 关闭进程
        /// </summary>
        public void Close()
        {
            if (this.process.HasExited) return;
            this.process.Exited -= P_Exited;
            try
            {
                if (!this.process.HasExited) this.process.Kill();
            }
            catch
            {
                System.Threading.Thread.Sleep(100);
                try
                {
                    if (!this.process.HasExited) this.process.Kill();
                }
                catch { }
            }
        }

        /// <summary>
        /// 注销资源
        /// </summary>
        public void Dispose()
        {
            this.BotStart = null;
            this.process = null;
            this.Project = null;
        }
    }
}