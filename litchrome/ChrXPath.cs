using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litchrome
{
    [litsdk.ActivityInfo(Name = "取值点击", IsFront = false, IsWinForm = true, RefFile = ChrLoad.RefFile, Index = 8)]
    public class ChrXPath : litcore.iecef.XPath
    {
        public override ActivityGroup Group => litsdk.ActivityGroup.Chrome;

        public override void Execute(ActivityContext context)
        {
            ChrLoad.LoadChromeSetting(context);

            string xpahtstr = context.ReplaceVar(this.XPathStr).Trim();
            if (xpahtstr == "")
            {
                throw new Exception("xpath为空请检查");
            }
            List<string> xpaths = xpahtstr.Replace("\r", "").Split('\n').ToList();

            OpenQA.Selenium.Chrome.ChromeDriver driver = ChrLoad.Driver;

            try
            {
                if (!string.IsNullOrEmpty(this.FrameName))
                {
                    string frameName = context.ReplaceVar(this.FrameName);
                    driver = (OpenQA.Selenium.Chrome.ChromeDriver)ChrLoad.GetFrames(driver, frameName);
                    if (driver == null)
                    {
                        throw new Exception("没有找到框架:" + frameName);
                    }
                }

                List<OpenQA.Selenium.IWebElement> elements = ChrLoad.GetElements(xpaths, driver);

                if (elements.Count > 0)
                {
                    switch (this.XPathType)
                    {
                        case litcore.ictype.XPathType.Click:
                            elements[0].Click();
                            context.WriteLog("点击操作完成");
                            break;
                        case litcore.ictype.XPathType.Get:

                            List<string> lst = new List<string>();
                            foreach (OpenQA.Selenium.IWebElement ele in elements)
                            {
                                lst.Add(ele.GetAttribute(this.Attribute));
                            }
                            string rdata = lst.Count == 0 ? "" : lst[0];
                            if (rdata == null) rdata = "";
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
                            break;

                        case litcore.ictype.XPathType.Set:
                            string value = context.GetStr(this.RWVarName);
                            if (this.Attribute == "value"&&elements[0].TagName=="input")
                            {
                                elements[0].Clear();
                                elements[0].SendKeys(value);
                                context.WriteLog("input操作成功完成");
                            }
                            else
                            {
                                string jsset = litcore.iecef.XPath.CefSetAttByXPathJs(xpaths, this.Attribute, value, true);
                                object obj2 = driver.ExecuteScript(jsset);
                                if (obj2 != null && obj2.ToString() == "ok")
                                {
                                    context.WriteLog("写值操作成功完成");
                                }
                                else
                                {
                                    throw new Exception("写值操作失败");
                                }
                            }
                            break;
                    }
                    System.Threading.Thread.Sleep(10);
                }
                else
                {
                    throw new Exception("没找到元素");
                }

                if (this.Sleep > 0)
                {
                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Start();

                    while (sw.ElapsedMilliseconds < this.Sleep)
                    {
                        System.Threading.Thread.Sleep(100);
#if NET461
                        System.Windows.Forms.Application.DoEvents();
#endif
                        context.ThrowIfCancellationRequested();
                    }
                    sw.Stop();
                }
            }
            finally
            {
                driver.SwitchTo().DefaultContent();
            }
        }

        public override void ShowConfig()
        {
#if NET461
            litsdk.API.ShowSystemConfigForm(this);
#endif
        }
    }
}