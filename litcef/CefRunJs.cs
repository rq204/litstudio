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
    [litsdk.ActivityInfo(Name = "执行Js", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 24)]
    public class CefRunJs : litcore.iecef.RunJs
    {
        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            string code = context.ReplaceVar(this.JsCode);

            string frameName = context.ReplaceVar(this.FrameName);
            CefSharp.IFrame frame = CefLoad.GetIframe(Browser_Select, frameName);
            if (frame == null) throw new Exception("不存在框架:" + frame);

            string data = "";
            try
            {
                var result = frame.EvaluateScriptAsync(code, Browser_Select.Address, 1, TimeSpan.FromSeconds(20)).Result.Result;
                if (result != null) data = result.ToString();
            }
            catch
            {
                context.WriteLog("执行JS代码5秒超时");
            }

            if (string.IsNullOrEmpty(this.SaveVarName))
            {
                context.WriteLog("成功执行JS代码");
            }
            else
            {
                context.SetVarStr(this.SaveVarName, data);
                context.WriteLog($"成功执行JS代码并保存结果至变量{this.SaveVarName}，返回结果长度{data.Length}");
            }
            System.Threading.Thread.Sleep(200);
        }

        public override void ShowConfig()
        {
            if (!CefLoad.cefLoad.IsValueCreated) CefLoad.cefLoad.Value.InitializeCef();
            litcore.iecef.RunJs.SupportSaveJsReturn = true;
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