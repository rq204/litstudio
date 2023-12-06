using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litcore.activity
{
    [litsdk.ActivityInfo(Name ="序列", IsLinux = true)]
    public class SequenceActivity : litsdk.ProcessActivity
    {
        private string name = "序列";
        public override string Name { get => name; set => name=value; }

        public override ActivityGroup Group => ActivityGroup.General;

        /// <summary>
        /// 序列列表
        /// </summary>
        public List<litsdk.ProcessActivity> Activities = new List<ProcessActivity>();

        /// <summary>
        /// 是否启用多线程
        /// </summary>
        public bool MultThread = false;

        /// <summary>
        /// 运行线程数
        /// </summary>
        public int ThreadNum = 1;

       /// <summary>
       /// 同线程间两次执行时间间隔
       /// </summary>
        public int IntervalMillisecond = 100;

        /// <summary>
        /// 指定传入参数
        /// </summary>
        public List<string> RefVariable = new List<string>();

        /// <summary>
        /// 等候队列数达指定值时暂停
        /// </summary>
        public bool WaitQueuePause = false;

        /// <summary>
        /// 等候队列数目
        /// </summary>
        public int WaitQueueNum = 5;

        /// <summary>
        /// 运行的线程池
        /// </summary>
        private List<System.Threading.Thread> Threads = new List<System.Threading.Thread>();

        /// <summary>
        /// 等候队列
        /// </summary>
        private List<litsdk.ActivityContext> Contexts = new List<ActivityContext>();


        private object lkQueue = new object();

        public override void Execute(ActivityContext context)
        {
            if (!this.MultThread)
            {
                context.WriteLog($"序列 {this.Name} 共有 {this.Activities.Count} 个组件开始运行");

                foreach (litsdk.ProcessActivity activity in this.Activities)
                {
                    if (activity.Group == ActivityGroup.CefBroswer)
                    {
#if NET461
                        litsdk.API.GetMainForm().Invoke((EventHandler)delegate
                        {
                            activity.Execute(context);
                        });
#endif
                    }     
                    else
                    {
                        activity.Execute(context);
                    }
                }
                context.WriteLog($"序列 {this.Name} 共有 {this.Activities.Count} 个组件运行结束");
                return;
            }
            lock (lkQueue)
            {
                if (Threads.Count == 0)
                {
                    for (int i = 0; i < this.ThreadNum; i++)
                    {
                        System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(work));
                        Threads.Add(thread);
                        allthreads.Add(thread);
                        thread.Start();
                    }
                }
            }
        }

        private static List<System.Threading.Thread> allthreads = new List<System.Threading.Thread>();
        public static void StopAllThread()
        {
            foreach (System.Threading.Thread t in allthreads.ToArray())
            {
                try
                {
                    t.Abort();
                }
                catch { }
            }
        }

        private void work()
        {
            try
            {

            }
            catch (System.Threading.ThreadAbortException)
            {

            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            foreach (litsdk.ProcessActivity activity in this.Activities) activity.Validate(context);
        }
    }
}