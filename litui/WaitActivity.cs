using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "等待元素", IsFront = true, IsWinForm = false, Index = 45)]
    /// <summary>
    /// 
    /// </summary>
    public class WaitActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "等待元素";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        public UIConfig UIConfig = new UIConfig();

        public WaitType WaitType = WaitType.Apper;

        public string WaitValue = "";

        public int TimeOutMillisecond = 10000;

        public override void Execute(ActivityContext context)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            while (true)
            {
                List<FlaUI.Core.AutomationElements.AutomationElement> automationElements = this.UIConfig.GetElements(context);
                bool ok = false;
                switch (this.WaitType)
                {
                    case WaitType.Apper:
                        if (automationElements.Count > 0)
                        {
                            context.WriteLog("等待元素成功出现"); ok = true;
                        }
                        break;
                    case WaitType.Disapper:
                        if (automationElements.Count == 0)
                        {
                            context.WriteLog("等待元素成功消失"); ok = true;
                        }
                        break;
                    case WaitType.ApperValue:
                        if (automationElements.Count > 0)
                        {
                            string txt = UIConfig.GetText(automationElements[0]);
                            string need = context.ReplaceVar(this.WaitValue);
                            if (txt == need)
                            {
                                context.WriteLog("等待元素成功出现并值为预期值"); ok = true;
                            }
                        }
                        break;
                }
                if (ok) break;
                if (stopwatch.ElapsedMilliseconds > this.TimeOutMillisecond)
                {
                    throw new Exception("元素等待超时跳出");
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
            litsdk.API.ShowConfigForm(this, new WaitUI());
        }

        public override void Validate(ActivityContext context)
        {
            this.UIConfig.Validate(context);
        }
    }
}