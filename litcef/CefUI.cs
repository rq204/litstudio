using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;

namespace litcef
{
    public partial class CefUI : UserControl
    {
        private static CefUI instance = null;

        public static CefUI Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    litsdk.API.GetMainForm().Invoke((EventHandler)delegate
                    {
                        instance = new CefUI() { AccessibleName = litcore.iecef.SwitchTab.DefaultTabName };
                    });
                }
                return instance;
            }
        }

        public ChromiumWebBrowser browser;
        internal DownloadHandler downloader = new DownloadHandler();
        internal RequestHandler requester = new RequestHandler();
        internal DialogHandler dialoger = new DialogHandler();


        public CefUI()
        {
            InitializeComponent();
            browser = new ChromiumWebBrowser("about:blank");// "https://s2.xanwi.com/index.html");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            browser.MenuHandler = new MenuHandler();
            browser.LifeSpanHandler = new LifeSpanHandler();
            browser.JsDialogHandler = new JsDialogHandler();
            browser.DownloadHandler = this.downloader;
            browser.RequestHandler = this.requester;
            browser.DialogHandler = this.dialoger;

            if (litsdk.API.GetDesignActivityContext != null)
            {
                browser.FrameLoadEnd += Browser_FrameLoadEnd;
                browser.FrameLoadStart += Browser_FrameLoadStart;
                tmXPath.Enabled = true;
            }

            this.Tag = "google";
        }

        private void Form_Deactivate(object sender, EventArgs e)
        {
            this.tmXPath.Enabled = false;
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            this.tmXPath.Enabled = true;
        }

        internal static bool StopXPath = false;

        private bool jsload = false;
        private void Browser_FrameLoadStart(object sender, FrameLoadStartEventArgs e)
        {
            if (litsdk.API.GetDesignActivityContext() != null)
            {
                if (e.Frame.IsMain)
                {
                    this.jsload = false;
                }
            }
        }

        private void Browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (litsdk.API.GetDesignActivityContext() != null)
            {
                if (e.Frame != null && e.Frame.IsMain && e.Url != "about:blank")
                {
                    string js = litcore.iecef.XPath.GetAfterLoadJs();
                    e.Frame.ExecuteJavaScriptAsync(js);
                    this.jsload = true;
                }
            }
        }

        private void tmXPath_Tick(object sender, EventArgs e)
        {
            if (!this.jsload || this.IsDisposed || !this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)) || StopXPath || litsdk.API.SetXPath == null || tabControl == null || tabPage == null || tabControl.SelectedTab != tabPage)
            {
                return;
            }

            //browser.GetBrowser().MainFrame.
            //https://blog.csdn.net/sdta25196/article/details/79226308 当前鼠标在哪个元素上
            //https://www.cnblogs.com/frogblog/p/8881365.html 判断变量是不是存在
            string rnd = litcore.iecef.XPath.GetRnd();
            string jsall = $"var xpath{rnd}= readXPath(litmouse); xpath{rnd};";
            this.browser.GetMainFrame().EvaluateScriptAsync(jsall).ContinueWith((x) =>
            {
                var objre = x.Result.Result;
                if (objre != null)
                {
                    List<string> ls = new List<string>() { objre.ToString() };
                    if (litsdk.API.SetXPath != null) litsdk.API.SetXPath("", ls);
                }
            });
        }

        private TabControl tabControl = null;
        private TabPage tabPage = null;
        private void CefUI_Load(object sender, EventArgs e)
        {
            Form form = this.FindForm();
            form.Activated += Form_Activated;
            form.Deactivate += Form_Deactivate;
            if (this.Parent is TabPage tp)
            {
                this.tabPage = tp;
                this.tabControl = tp.Parent as TabControl;
            }
        }

        //private 
    }

    /// <summary>
    /// https://blog.csdn.net/lanwilliam/article/details/79640954
    /// https://www.jianshu.com/p/d1e96fe1b2b9
    /// </summary>
    internal class LifeSpanHandler : ILifeSpanHandler
    {
        public bool DoClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            return true;
        }

        public void OnAfterCreated(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {

        }

        public void OnBeforeClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {

        }

        private ChromiumWebBrowser parent = null;
        private bool newWindow = false;
        public bool OnBeforePopup(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            newBrowser = null;
            parent = chromiumWebBrowser as ChromiumWebBrowser;
            newWindow = Convert.ToBoolean(parent.Tag);

            //不新开线程打不开页面
            new System.Threading.Thread(() =>
            {
                System.Threading.Thread.Sleep(300);
                if (newWindow)
                {
                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Start();

                    try
                    {
                        litsdk.API.GetMainForm().Invoke((EventHandler)delegate
                        {
                            CefUI cefUI = new CefUI() { AccessibleName = targetUrl };
                            cefUI.browser.Tag = newWindow;
                            litsdk.API.AddTabPage(cefUI);

                            while (!cefUI.browser.IsBrowserInitialized)
                            {
                                System.Threading.Thread.Sleep(100);
                                Application.DoEvents();
                                if (sw.ElapsedMilliseconds > 30000)
                                {
                                    throw new Exception("打开新窗口初始化失败");
                                }
                            }
                            cefUI.browser.Load(targetUrl);
                        });
                    }
                    finally
                    {
                        sw.Stop();
                    }

                    //if (cefUI.Parent != null && cefUI.Parent.GetType() == typeof(TabPage))
                    //{
                    //    cefUI.Parent.Text = cefUI.AccessibleName = targetUrl; ;
                    //}
                    //windowInfo.SetAsChild(cefUI.Handle, 0, 0, (int)cefUI.Width, (int)cefUI.Height);
                }
                else
                {
                    parent.Load(targetUrl);
                }
            }).Start();
            return true;
        }
    }

    internal class MenuHandler : IContextMenuHandler
    {

        public void OnBeforeContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            //System.Windows.Forms.MessageBox.Show("xxx");
        }

        public bool OnContextMenuCommand(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            return true;
        }

        public void OnContextMenuDismissed(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame)
        {

        }

        public bool RunContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            model.Clear();
            CefUI.StopXPath = !CefUI.StopXPath;
            return false;//true是取消右键，false删除菜单也可以不显示菜单
        }
    }

    /// <summary>
    /// https://www.cnblogs.com/wolf-sun/p/7405761.html
    /// </summary>
    internal class JsDialogHandler : CefSharp.IJsDialogHandler
    {
        public bool OnBeforeUnloadDialog(IWebBrowser chromiumWebBrowser, IBrowser browser, string messageText, bool isReload, IJsDialogCallback callback)
        {
            return true;
        }

        public void OnDialogClosed(CefSharp.IWebBrowser browserControl, CefSharp.IBrowser browser)
        {

        }

        public bool OnJSDialog(CefSharp.IWebBrowser browserControl, CefSharp.IBrowser browser,
string originUrl, CefSharp.CefJsDialogType dialogType, string messageText, string defaultPromptText,
 CefSharp.IJsDialogCallback callback, ref bool suppressMessage)
        {
            switch (dialogType)
            {
                case CefSharp.CefJsDialogType.Alert:
                    // MessageBox.Show(messageText, "提示");
                    suppressMessage = false;
                    callback.Continue(true);
                    return true;
                case CefSharp.CefJsDialogType.Confirm:
                    suppressMessage = false;
                    callback.Continue(true, string.Empty);
                    return true;
                //var dr = MessageBox.Show(messageText, "提示", MessageBoxButtons.YesNo);
                //if (dr == DialogResult.Yes)
                //{
                //    callback.Continue(true, string.Empty);
                //    suppressMessage = false;
                //    return true;
                //}
                //else
                //{
                //    callback.Continue(false, string.Empty);
                //    suppressMessage = false;
                //    return true;
                //}
                case CefSharp.CefJsDialogType.Prompt:
                    //MessageBox.Show("系统不支持prompt形式的提示框", "提示");
                    suppressMessage = false;
                    callback.Continue(true);
                    return true;
                default:
                    break;
            }
            return false;
        }

        public void OnResetDialogState(CefSharp.IWebBrowser browserControl, CefSharp.IBrowser browser)
        {

        }
    }



}
