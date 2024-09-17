using CefSharp;
using CefSharp.WinForms;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "元素等待", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 12)]
    public class CefWait : litcore.iecef.Wait
    {
        public override ActivityGroup Group => ActivityGroup.CefBroswer;

        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;
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
                    CefSharp.IFrame frame = CefLoad.GetIframe(Browser_Select, frameName);

                    if (frame == null)
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
                        string jsstr = litcore.iecef.XPath.CefElementExistJs(xpaths);

                        object objclick = frame.EvaluateScriptAsync(jsstr).Result.Result;
                        if (objclick != null && objclick.ToString() == "exist")
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
                        System.Threading.Thread.Sleep(100);
                        System.Windows.Forms.Application.DoEvents();
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