using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace litcore
{
    /// <summary>
    /// 异步操作类
    /// </summary>
    internal class AsynRunner
    {
        public AsynRunner(string subName, litsdk.ActivityContext context, litcore.activity.ProjectActivity projectActivity)
        {
            this.cstSop = context.GetCancellationTokenSource();
            this.projectActivity = projectActivity;
            this.SubName = subName;
           
            context.OnEnd += EndThread;//添加异步的事件

            loopThread = new System.Threading.Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        runLoopThread();
                    }
                    catch (System.OperationCanceledException)
                    {
                        break;
                    }
                    catch
                    {

                    }
                    System.Threading.Thread.Sleep(50);
                }
            });
            loopThread.Start();
        }

        private litcore.activity.ProjectActivity projectActivity = null; 

        ///// <summary>
        ///// 子流程名
        ///// </summary>
        internal string SubName = "";

        /// <summary>
        /// 停止
        /// </summary>
        internal CancellationTokenSource cstSop;

        private List<BotRunner> runList = new List<BotRunner>();

        public void runLoopThread()
        {
            cstSop.Token.ThrowIfCancellationRequested();

            if (runList.Count == 0 && projectActivity.RefProjects.Count == 0) return;

            List<BotRunner> endList = runList.FindAll((t) => t.State != BotState.Running);

            if (endList.Count > 0)
            {
                foreach (BotRunner br in endList) runList.Remove(br);
            }

            if (projectActivity.RefProjects.Count > 0)
            {
                //有要添加的，以及运行中小于设定值
                while (projectActivity.RefProjects.Count > 0 && runList.Count < projectActivity.ThreadNum)
                {
                    cstSop.Token.ThrowIfCancellationRequested();

                    Project project1 = projectActivity.RefProjects[0];
                    lock (projectActivity.lkRef)
                    {
                        projectActivity.RefProjects.RemoveAt(0);
                    }

                    projectActivity.RefWriteLog($"开始执行异步流程：{this.SubName}");

                    litcore.BotRunner botRunner = new litcore.BotRunner(project1);
                    BotRunLog brl = new BotRunLog(botRunner);
                    brl.NodeAction = new Action<litsdk.Node, string>(this.WriteLog);
                    botRunner.SetRefTrue();
                    botRunner.ActivityContext.WriteLog = brl.WriteLog;
                    botRunner.InitAction();
                    botRunner.Run(cstSop);
                    runList.Add(botRunner);
                }
            }
        }


        private void WriteLog(Node node, string txt)
        {
            if (this.projectActivity.OnlyUserLog)
            {
                if (node.Activity.GetType() == typeof(litcore.activity.LogActivity))
                {
                    this.projectActivity.RefWriteLog(txt);
                }
            }
            else
            {
                this.projectActivity.RefWriteLog(txt);
            }
        }

        /// <summary>
        /// 运行的线程
        /// </summary>
        private System.Threading.Thread loopThread = null;

        /// <summary>
        /// 最终退出前运行的
        /// </summary>
        internal void EndThread()
        {
            try
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                string last = "";
                while (this.projectActivity.RefProjects.Count > 0)
                {
                    string temp = $"异步引用流程还剩下 {this.projectActivity.RefProjects.Count} 个，运行中{runList.Count} 个";
                    if (temp != last)
                    {
                        last = temp;
                        this.projectActivity.RefWriteLog(last);
                    }
                    else if (sw.ElapsedMilliseconds > 5000)
                    {
                        sw.Restart();
                        this.projectActivity.RefWriteLog(last);
                    }

                    System.Threading.Thread.Sleep(50);
                    cstSop.Token.ThrowIfCancellationRequested();
                }

                sw.Stop();
                if (loopThread != null)
                {
                    try
                    {
                        loopThread.Abort();
                    }
                    catch { }
                }

                while (runList.Count > 0)
                {
                    List<BotRunner> endList = runList.FindAll((t) => t.State != BotState.Running);

                    if (endList.Count > 0)
                    {
                        foreach (BotRunner br in endList) runList.Remove(br);
                        this.projectActivity.RefWriteLog($"异步引用流程剩余运行中{runList.Count}");
                    }
                }

                this.projectActivity.RefWriteLog($"异步引用流程全部完成");
            }
            catch (OperationCanceledException) { }
        }
    }
}