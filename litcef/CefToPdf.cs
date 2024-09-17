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
    [litsdk.ActivityInfo(Name = "生成PDF", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 44)]
    public class CefToPdf : litcore.iecef.ToPdf
    {
        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            string savepath = context.ReplaceVar(this.PdfPath);

            PdfPrintSettings settings = new PdfPrintSettings();
            settings.ScaleFactor = this.ScaleFactor;

            Browser_Select.GetMainFrame().Browser.PrintToPdfAsync(savepath, settings);


            context.WriteLog("成功生成pdf文件:" + savepath);
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