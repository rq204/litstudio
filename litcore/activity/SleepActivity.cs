using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using litsdk;

namespace litcore.activity
{
    [ActivityInfo(Name = "暂停等待", IsLinux = true)]
    /// <summary>
    /// 暂停等待的秒数，不超过300秒
    /// </summary>
    public class SleepActivity : litsdk.ProcessActivity
    {
        private string name = "暂停等待";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.General;

        /// <summary>
        /// 捆住等待的毫秒数
        /// </summary>
        public int MilliSeconds = 3000;

        /// <summary>
        /// 随机数结束
        /// </summary>
        public int MilliSecondsEnd = 5000;

        /// <summary>
        /// 使用随机数
        /// </summary>
        public bool UseRandNum = false;

        /// <summary>
        /// 使用变量
        /// </summary>
        public bool UseVariable = false;

        /// <summary>
        /// 
        /// </summary>
        public string IntVarName = "";


        public override void Execute(ActivityContext context)
        {
            int mseconds = MilliSeconds;
            if (UseVariable)
            {
                mseconds = context.GetInt(this.IntVarName);
            }
            else
            {
                if (UseRandNum)
                {
                    mseconds = new Random(System.Guid.NewGuid().GetHashCode()).Next(this.MilliSeconds - 1, this.MilliSecondsEnd);
                }
            }

            context.WriteLog($"开始暂停等待{mseconds}毫秒");
            if (mseconds < 3000)
            {
                System.Threading.Thread.Sleep(mseconds);
            }
            else
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();

                while (sw.ElapsedMilliseconds < mseconds)
                {
                    System.Threading.Thread.Sleep(500);
                    context.ThrowIfCancellationRequested();
                }
                sw.Stop();
            }
        }

        public override void Validate(ActivityContext context)
        {
            if (UseVariable)
            {
                if (!context.ContainsInt(this.IntVarName)) throw new Exception("不存在数字变量:" + this.IntVarName);
            }
            else if (UseRandNum)
            {
                if (this.MilliSecondsEnd < this.MilliSeconds) throw new Exception("结束毫秒不能小于开始毫秒");
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }
    }
}