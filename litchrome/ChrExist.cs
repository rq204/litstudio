using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litchrome
{
    [litsdk.ActivityInfo(Name = "元素存在", IsFront = false, IsWinForm = true, RefFile = ChrLoad.RefFile, Index = 16)]
    public class ChrExist : litcore.iecef.Exist
    {
        public override ActivityGroup Group => ActivityGroup.Chrome;

        public override bool Execute(ActivityContext context)
        {
            ChrLoad.LoadChromeSetting(context);
            try
            {
                string xpahtstr = context.ReplaceVar(this.XPathStr).Trim();
                if (xpahtstr == "")
                {
                    throw new Exception("xpath为空请检查");
                }
                List<string> xpaths = xpahtstr.Replace("\r", "").Split('\n').ToList();

                OpenQA.Selenium.Chrome.ChromeDriver driver = ChrLoad.Driver;
                if (!string.IsNullOrEmpty(this.FrameName))
                {
                    string frameName = context.ReplaceVar(this.FrameName);
                    driver = (OpenQA.Selenium.Chrome.ChromeDriver)ChrLoad.GetFrames(ChrLoad.Driver, frameName);
                    if (driver == null)
                    {
                        context.WriteLog("没有找到框架:" + frameName);
                        return false;
                    }
                }

                List<OpenQA.Selenium.IWebElement> elements = ChrLoad.GetElements(xpaths, driver);

                if (elements.Count > 0)
                {
                    if (!string.IsNullOrEmpty(this.XPosVarName) && !string.IsNullOrEmpty(this.YPosVarName))
                    {
                        string jsstr = litcore.iecef.XPath.CefClickPositionByXPathJs(xpaths);
                        object objclick = ChrLoad.Driver.ExecuteScript(jsstr);
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
                    else
                    {
                        context.WriteLog("成功找到元素");
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
            finally
            {
                ChrLoad.Driver.SwitchTo().DefaultContent();//切换为主窗口
            }
        }
    }
}