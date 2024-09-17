using CefSharp.WinForms;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "点击下载", Index = 50)]
    public class CefClickDown : litcore.iecef.ClickDown
    {
        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            string xpahtstr = context.ReplaceVar(this.XPathStr).Trim();
            if (xpahtstr == "")
            {
                throw new Exception("xpath为空请检查");
            }
            List<string> xpaths = xpahtstr.Replace("\r", "").Split('\n').ToList();

            string frameName = context.ReplaceVar(this.FrameName);
            CefSharp.IFrame frame = CefLoad.GetIframe(Browser_Select, frameName);
            if (frame == null) throw new Exception("不存在框架:" + frame);

            DownloadHandler downloader = CefLoad.CefUI_Select.downloader;
            downloader.WriteLog = context.WriteLog;

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            try
            {
                string jsstr = litcore.iecef.XPath.CefClickByXPathJs(xpaths, "click");

                string savepath = context.ReplaceVar(this.SavePath);
                string tempPath = System.IO.Path.GetTempFileName();
                downloader.TempPath = tempPath;

                object objclick = frame.EvaluateScriptAsync(jsstr).Result.Result;
                if (objclick != null && objclick.ToString() == "ok")
                {
                    context.WriteLog("成功点击操作完成，等待下载中");
                }
                else
                {
                    context.WriteLog("点击失败，停止下载");
                }

                sw.Start();
                while (downloader.DownloadItem == null)
                {
                    if (sw.ElapsedMilliseconds > 10000)
                    {
                        context.WriteLog("没有开始下载，请确认是否点击下载成功");
                        return;
                    }
                    System.Threading.Thread.Sleep(10);
                    System.Windows.Forms.Application.DoEvents();
                }

                sw.Restart();

                int timeout = this.TimeOutSecond * 1000;

                while (downloader.DownloadItem.IsInProgress)
                {
                    if (sw.ElapsedMilliseconds > timeout)
                    {
                        context.WriteLog("文件下载超时失败");
                        downloader.DownloadCallback.Cancel();
                        return;
                    }
                    System.Threading.Thread.Sleep(10);
                    System.Windows.Forms.Application.DoEvents();
                    try
                    {
                        context.ThrowIfCancellationRequested();
                    }
                    catch
                    {
                        downloader.DownloadCallback.Cancel();
                        throw;
                    }
                    if (downloader.DownloadItem.IsComplete || downloader.DownloadItem.IsCancelled)
                        break;
                }

                if (System.IO.File.Exists(tempPath))
                {
                    if (savepath.Contains("["))
                    {
                        string filename = "";
                        //attachment; filename*=UTF-8''QQwry%E7%BA%AF%E7%9C%9FIP%E6%95%B0%E6%8D%AE%E5%BA%93.rar
                        if (!string.IsNullOrEmpty(downloader.DownloadItem.ContentDisposition) && downloader.DownloadItem.ContentDisposition.Contains("="))
                        {
                            string attdata = downloader.DownloadItem.ContentDisposition.Split('=')[1];
                            if (attdata.StartsWith("UTF-8''", StringComparison.OrdinalIgnoreCase))
                            {
                                attdata = attdata.Substring(7, attdata.Length - 7);
                                attdata = attdata.Trim('\'');
                                filename = System.Web.HttpUtility.UrlDecode(attdata);
                            }
                        }

                        if (string.IsNullOrEmpty(filename) && !string.IsNullOrEmpty(downloader.DownloadItem.SuggestedFileName))
                        {
                            filename = downloader.DownloadItem.SuggestedFileName;
                        }

                        if (string.IsNullOrEmpty(filename))
                        {
                            try
                            {
                                filename = System.IO.Path.GetFileName(downloader.DownloadItem.Url);
                                if (filename.Contains("?")) filename = filename.Split('?')[0];
                            }
                            catch { }
                        }

                        if (savepath.Contains("[原文件全名]")) savepath = savepath.Replace("[原文件全名]", filename);
                        if (savepath.Contains("[随机文件名]"))
                        {
                            string rnd = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
                            savepath = savepath.Replace("[随机文件名]", rnd);
                        }
                        string ext = System.IO.Path.GetExtension(filename);
                        if (savepath.Contains("[原扩展名]")) savepath = savepath.Replace("[原扩展名]", ext);
                    }
                    savepath = litcore.activity.HttpRequestActivity.TrimInvalidPath(savepath);

                    if (!string.IsNullOrEmpty(this.SaveVarName)) context.SetVarStr(this.SaveVarName, savepath);

                    System.IO.File.Copy(tempPath, savepath, true);
                    System.IO.File.Delete(tempPath);
                    context.WriteLog("文件下载成功至 " + savepath);
                }
                else
                {
                    context.WriteLog("文件下载失败");
                }
            }
            finally
            {
                CefLoad.CefUI_Select.downloader.TempPath = null;
                CefLoad.CefUI_Select.downloader.WriteLog = null;
                sw.Stop();
            }
        }

        public override void Validate(ActivityContext context)
        {
            if (!CefLoad.cefLoad.IsValueCreated && litsdk.API.GetMainForm != null) CefLoad.cefLoad.Value.InitializeCef();
            base.Validate(context);
        }

        public override void ShowConfig()
        {
            if (!CefLoad.cefLoad.IsValueCreated) CefLoad.cefLoad.Value.InitializeCef();
            base.ShowConfig();
        }

        public override ActivityGroup Group => ActivityGroup.CefBroswer;
    }
}
