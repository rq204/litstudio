using CefSharp.WinForms;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "打开网页", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 4)]
    public class CefNavigate : litcore.iecef.Navigate
    {
        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            string url = context.ReplaceVar(this.Url);
            string referer = context.ReplaceVar(this.Referer);
            Browser_Select.Tag = this.NewWindow;

            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                string username = context.ReplaceVar(this.UserName);
                string password = context.ReplaceVar(this.Password);
                CefLoad.CefUI_Select.requester.UserName = username;
                CefLoad.CefUI_Select.requester.Password = password;
            }

            if (!string.IsNullOrEmpty(this.AcceptLanguage)) CefLoad.CefUI_Select.requester.AcceptLanguage = AcceptLanguage;

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            Browser_Select.Load(url);
            try
            {
                IsLoading = true;
                Browser_Select.LoadingStateChanged += Browser_Select_LoadingStateChanged;
                sw.Start();
                System.Threading.Thread.Sleep(1000);

                while (IsLoading)
                {
                    context.ThrowIfCancellationRequested();
                    System.Threading.Thread.Sleep(300);
                    System.Windows.Forms.Application.DoEvents();
                    if (sw.ElapsedMilliseconds > this.TimeOutSenconds * 1000)
                    {
                        sw.Stop();
                        context.WriteLog("打开网页超时");
                        break;
                    }
                }
                sw.Stop();
                context.WriteLog("打开网页完成");
            }
            finally
            {
                IsLoading = false;
                Browser_Select.LoadingStateChanged -= Browser_Select_LoadingStateChanged;
            }
        }

        private static bool IsLoading = false;
        private static void Browser_Select_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {
            IsLoading = e.IsLoading;
        }

        public override void ShowConfig()
        {
            if (!CefLoad.cefLoad.IsValueCreated) CefLoad.cefLoad.Value.InitializeCef();
            litcore.iecef.Navigate.SupportReferer = false;
            litcore.iecef.Navigate.SupportAuthCredentials = true;

            base.ShowConfig();
        }

        public override void Validate(ActivityContext context)
        {
            if (!CefLoad.cefLoad.IsValueCreated && litsdk.API.GetMainForm != null) CefLoad.cefLoad.Value.InitializeCef();
            base.Validate(context);
        }

        public override ActivityGroup Group => ActivityGroup.CefBroswer;
    }
}