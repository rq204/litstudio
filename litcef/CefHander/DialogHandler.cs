using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcef
{
    /// <summary>
    /// 上传文件的接口
    /// </summary>
    public class DialogHandler : CefSharp.IDialogHandler
    {
        public List<string> UploadFiles = new List<string>();

        public Action<string> WriteLog { get; internal set; }

        public bool Complate = false;

        public bool OnFileDialog(IWebBrowser chromiumWebBrowser, IBrowser browser, CefFileDialogMode mode, CefFileDialogFlags flags, string title, string defaultFilePath, List<string> acceptFilters, int selectedAcceptFilter, IFileDialogCallback callback)
        {
            if (UploadFiles != null && UploadFiles.Count > 0)
            {
                string files = string.Join(",", UploadFiles.ToArray());
                if (WriteLog != null) WriteLog("上传选中文件：" + files);
                callback.Continue(selectedAcceptFilter, UploadFiles.ToArray().ToList());
                this.Complate = true;
                return true;
            }
            else
            {
                this.Complate = true;
                return false;
            }
        }
    }
}
