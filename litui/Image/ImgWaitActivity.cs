using litsdk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "等待图像", IsFront = true, IsWinForm = false, Index = 105)]
    public class ImgWaitActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "等待图像";

        public WaitType WaitType = WaitType.Apper;

        public ImgConfig ImgConfig = new ImgConfig();

        public int TimeOutMillisecond = 10000;

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        public override void Execute(ActivityContext context)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            while (true)
            {
                Point point = new Point();
                string result = this.ImgConfig.GetClickablePoint(ref point);

                bool ok = false;
                switch (this.WaitType)
                {
                    case WaitType.Apper:
                        if (result == null)
                        {
                            context.WriteLog("等待图片成功出现"); ok = true;
                        }
                        break;
                    case WaitType.Disapper:
                        if (result != null)
                        {
                            context.WriteLog("等待图片成功消失"); ok = true;
                        }
                        break;
                }
                if (ok) break;
                if (stopwatch.ElapsedMilliseconds > this.TimeOutMillisecond)
                {
                    throw new Exception("图片等待超时跳出");
                }
                else
                {
                    System.Threading.Thread.Sleep(100);
                    System.Windows.Forms.Application.DoEvents();
                    context.ThrowIfCancellationRequested();
                }
            }
            stopwatch.Stop();
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new ImgWaitUI());
        }

        public override void Validate(ActivityContext context)
        {
            this.ImgConfig.Validate(context);
        }
    }
}