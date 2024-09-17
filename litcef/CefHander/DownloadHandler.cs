using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcef
{
    internal class DownloadHandler : CefSharp.IDownloadHandler
    {
        public string TempPath = "";

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            this.DownloadItem = downloadItem;
            if (!callback.IsDisposed && !string.IsNullOrEmpty(this.TempPath))
            {
                using (callback)
                {
                    callback.Continue(TempPath,
                        showDialog: false);
                    if (WriteLog != null) WriteLog($"开始下载文件 {downloadItem.Url}");
                }
            }
        }

        internal IDownloadItemCallback DownloadCallback = null;

        internal Action<string> WriteLog;

        internal DownloadItem DownloadItem = null;


        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            if (this.DownloadCallback == null) this.DownloadCallback = callback;
            DownloadItem = downloadItem;
        }
    }
}
