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
    [litsdk.ActivityInfo(Name = "元素存在", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 16)]
    public class CefExist : litcore.iecef.Exist
    {
        public override ActivityGroup Group => ActivityGroup.CefBroswer;

        public override bool Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            try
            {
                string xpahtstr = context.ReplaceVar(this.XPathStr).Trim();
                if (xpahtstr == "")
                {
                    throw new Exception("xpath为空请检查");
                }
                List<string> xpaths = xpahtstr.Replace("\r", "").Split('\n').ToList();

                string frameName = context.ReplaceVar(this.FrameName);
                CefSharp.IFrame frame = CefLoad.GetIframe(Browser_Select, frameName);
                if (frame == null) throw new Exception("不存在框架:" + frame);

                string jsstr = litcore.iecef.XPath.CefElementExistJs(xpaths);

                object objclick = frame.EvaluateScriptAsync(jsstr).Result.Result;
                if (objclick != null && objclick.ToString() == "exist")
                {
                    context.WriteLog("找到元素");

                    if (!string.IsNullOrEmpty(this.XPosVarName) && !string.IsNullOrEmpty(this.YPosVarName))
                    {
                        jsstr = litcore.iecef.XPath.CefClickPositionByXPathJs(xpaths);
                        objclick = frame.EvaluateScriptAsync(jsstr).Result.Result;
                        if (objclick != null)
                        {
                            System.Dynamic.ExpandoObject dynamicObject = objclick as System.Dynamic.ExpandoObject;
                            IDictionary<string, object> dic = dynamicObject;
                            int x = Convert.ToInt32(dic["x"]);
                            int y = Convert.ToInt32(dic["y"]);
                            context.SetVarInt(this.XPosVarName, x);
                            context.SetVarInt(this.YPosVarName, y);
                            context.WriteLog($"获取到首元素位置X{x}Y{y}");
                            return true;
                        }
                    }
                    return true;
                }
                else
                {
                    context.WriteLog("没有找到元素");
                    return false;
                }
            }
            catch (Exception ex)
            {
                context.WriteLog("没有找到元素:" + ex.Message);
                return false;
            }
        }
    }
}