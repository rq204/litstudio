using CefSharp;
using CefSharp.WinForms;
using litsdk;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "取值点击", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile,Index =8)]
    public class CefXPath : litcore.iecef.XPath
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

            switch (this.XPathType)
            {
                case litcore.ictype.XPathType.Click:
                    string jsstr = litcore.iecef.XPath.CefClickByXPathJs(xpaths, this.Attribute);

                    object objclick = frame.EvaluateScriptAsync(jsstr).Result.Result;
                    if (objclick != null && objclick.ToString() == "ok")
                    {
                        context.WriteLog("点击操作完成");
                    }
                    else
                    {
                        context.WriteLog("点击失败");
                    }
                    //int x=0, y=0;
                    //string jsclick = litcore.iecef.this.CefClickPositionByXPathJs(xpaths);
                    //object objclick = Browser_Select.GetBrowser().MainFrame.EvaluateScriptAsync(jsclick).Result.Result;
                    //if (objclick != null)
                    //{
                    //    var dic=(IDictionary<string, object>)objclick; 
                    //    x = Convert.ToInt32(dic["x"]);
                    //    y = Convert.ToInt32(dic["y"]);
                    //    string add = $",元素位置x:{x},y:{y}";
                    //    IBrowserHost host = Browser_Select.GetBrowser().GetHost();
                    //    if (this.Attribute.Equals("click", StringComparison.OrdinalIgnoreCase))
                    //    {
                    //        host.SendMouseClickEvent(x, y, MouseButtonType.Left, false, 1, CefEventFlags.None);
                    //        System.Threading.Thread.Sleep(15);
                    //        host.SendMouseClickEvent(x, y, MouseButtonType.Left, true, 1, CefEventFlags.None);
                    //        context.WriteLog("点击操作完成" + add);
                    //    }
                    //    else
                    //    {
                    //        throw new Exception("不支持的点击操作类型");
                    //    }
                    //}
                    //else
                    //{
                    //    throw new Exception("没有找到元素");
                    //}

                    break;
                case litcore.ictype.XPathType.Get:
                    string jsget = litcore.iecef.XPath.CefGetAttByXPathJs(xpaths, this.Attribute);
                    object obj = frame.EvaluateScriptAsync(jsget).Result.Result;
                    if (obj != null)
                    {
                        List<string> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(obj.ToString());
                        string rdata = lst.Count == 0 ? "" : lst[0];
                        if (context.ContainsStr(this.RWVarName))
                        {
                            context.SetVarStr(this.RWVarName, rdata);
                            context.WriteLog($"取值字符操作成功字符长度{rdata.Length}");
                        }
                        else if (context.ContainsInt(this.RWVarName))
                        {
                            int ri = 0;
                            if (int.TryParse(rdata, out ri))
                            {
                                context.WriteLog($"取值数字操作成功结果为{rdata}");
                            }
                            else
                            {
                                context.WriteLog($"取值数字操作失败，取的值为{rdata}");
                            }
                            context.SetVarInt(this.RWVarName, ri);
                        }
                        else if (context.ContainsList(this.RWVarName))
                        {
                            context.AddVarListList(this.RWVarName, lst);
                            context.WriteLog("取值操作成功完成");
                        }
                    }
                    else
                    {
                        throw new Exception("没有找到元素");
                    }
                    break;
                case litcore.ictype.XPathType.Set:
                    string value = context.GetStr(this.RWVarName);
                    string jsset = litcore.iecef.XPath.CefSetAttByXPathJs(xpaths, this.Attribute, value);
                    object obj2 = frame.EvaluateScriptAsync(jsset).Result.Result;
                    if (obj2 != null && obj2.ToString() == "ok")
                    {
                        context.WriteLog("写值操作成功完成");
                    }
                    else
                    {
                        throw new Exception("写值操作失败");
                    }
                    break;
            }

            if (this.Sleep > 0)
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();

                while (sw.ElapsedMilliseconds < this.Sleep)
                {
                    System.Threading.Thread.Sleep(100);
                    System.Windows.Forms.Application.DoEvents();
                    context.ThrowIfCancellationRequested();
                }
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

        //        var result = document.evaluate("//a[@href]", document, null, XPathResult.ANY_TYPE, null);
        //        var nodes = result.iterateNext(); //枚举第一个元素
        //while (nodes){
        //    // 对 nodes 执行操作;
        //    nodes=result.iterateNext(); //枚举下一个元素
        //}

        //    // 如果只查找单个元素，可以简写成这样
        //    nodes=document.evaluate("//div[@id='xxx']", document).iterateNext();
    }
}