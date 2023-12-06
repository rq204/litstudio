using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litchrome
{
    [litsdk.ActivityInfo(Name = "元素等待", IsFront = false, IsWinForm = true, RefFile = ChrLoad.RefFile, Index = 12)]
    public class ChrWait : litcore.iecef.Wait
    {
        public override ActivityGroup Group => ActivityGroup.Chrome;

        public override void Execute(ActivityContext context)
        {
            ChrLoad.LoadChromeSetting(context);

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            this.lastLogTime = DateTime.Now;

            try
            {
                string xpahtstr = context.ReplaceVar(this.XPathStr).Trim();
                if (xpahtstr == "")
                {
                    throw new Exception("xpath为空请检查");
                }
                List<string> xpaths = xpahtstr.Replace("\r", "").Split('\n').ToList();

                while (true)
                {
                    bool ok = false;

                    string frameName = context.ReplaceVar(this.FrameName);
                    OpenQA.Selenium.IWebDriver driver = ChrLoad.Driver;
                    if (!string.IsNullOrEmpty(frameName)) driver = ChrLoad.GetFrames(ChrLoad.Driver, frameName);

                    if (driver == null)
                    {
                        if (!this.WaitIframe)
                        {
                            throw new Exception("不存在框架:" + this.FrameName);
                        }
                        else
                        {
                            if (showLog()) context.WriteLog($"没找到框架：{ this.FrameName}，等待中");
                        }
                    }
                    else
                    {
                        List<OpenQA.Selenium.IWebElement> elements = ChrLoad.GetElements(xpaths, driver);
                        bool exist = elements.Count > 0;
                      
                        if (exist)
                        {
                            if (WaitAppear)
                            {
                                context.WriteLog("成功找到元素，跳出等待");
                                ok = true;
                            }
                            else
                            {
                                if (showLog()) context.WriteLog("元素没有消失，继续等待");
                            }
                        }
                        else
                        {
                            if (WaitAppear)
                            {
                                if (showLog()) context.WriteLog("没有找到元素，继续等待");
                            }
                            else
                            {
                                context.WriteLog("元素已经消失，跳出等待");
                                ok = true;
                            }
                        }
                    }

                    if (ok) break;
                    if (stopwatch.ElapsedMilliseconds > this.TimeOutMillisecond)
                    {
                        throw new Exception("元素等待超时跳出");
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(500);
#if NET461
                        System.Windows.Forms.Application.DoEvents();
#endif
                        context.ThrowIfCancellationRequested();
                    }
                }
            }
            catch (Exception ex)
            {
                context.WriteLog("发生错误:" + ex.Message);
                throw ex;
            }
            finally
            {
                stopwatch.Stop();
                ChrLoad.Driver.SwitchTo().DefaultContent();//切换为主窗口
            }
        }

        private bool showLog()
        {
            if (lastLogTime.AddSeconds(3) < DateTime.Now)
            {
                return false;
            }
            else
            {
                this.lastLogTime = DateTime.Now;
                return true;
            }
        }
    }
}