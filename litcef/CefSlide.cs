using CefSharp;
using CefSharp.WinForms;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "鼠标拖动", IsFront = true, IsWinForm = true, Index = 46)]
    /// <summary>
    /// 
    /// </summary>
    public sealed class CefSlide : litcore.iecef.Slide
    {
        public override void Execute(ActivityContext context)
        {
            base.LoadOld();
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            string frameName = context.ReplaceVar(this.FrameName);
            CefSharp.IFrame frame = CefLoad.GetIframe(Browser_Select, frameName);
            if (frame == null) throw new Exception("不存在框架:" + frame);

            var host = Browser_Select.GetBrowser().GetHost();

            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;

            if (UseStartXPath)
            {
                string xpathStart = context.ReplaceVar(this.StartXPath);
                if (!getpos(ref x1, ref y1, xpathStart, frame))
                {
                    throw new Exception("没有找到起始元素坐标点");
                }
            }
            else
            {
                string x1s = context.ReplaceVar(this.StartX);
                string y1s = context.ReplaceVar(this.StartY);
                if (!int.TryParse(x1s, out x1) || !int.TryParse(y1s, out y1))
                {
                    throw new Exception($"起始点击坐标错误非数字:X{x1s}Y{y1s}");
                }
            }

            if (UseEndXpath)
            {
                string xpathEnd = context.ReplaceVar(this.EndXPath);
                if (!getpos(ref x2, ref y2, xpathEnd, frame))
                {
                    throw new Exception("没有找到结束元素坐标点");
                }
            }
            else
            {
                string x2s = context.ReplaceVar(this.EndX);
                string y2s = context.ReplaceVar(this.EndY);
                if (!int.TryParse(x2s, out x2) || !int.TryParse(y2s, out y2))
                {
                    throw new Exception($"结束点击坐标错误非数字:X{x2s}Y{y2s}");
                }

                if (Relative)
                {
                    x2 = x1 + x2;
                    y2 = y1 + y2;
                }
            }


            context.WriteLog($"开始从X{x1}Y{y1}拖动鼠标至X{x2}Y{y2}");

            host.SendMouseClickEvent(x1, y1, MouseButtonType.Left, false, 1, CefEventFlags.None);//按下鼠标左键

            System.Threading.Thread.Sleep(3);
            double x = x1;
            double y = y1;
            int xlen = x2 - x1;
            int ylen = y2 - y1;

            double xs = 1;
            double ys = 1;

            int z = (int)Math.Sqrt(xlen * xlen + ylen * ylen);
            xs = (double)xlen / (double)z;
            ys = (double)ylen / (double)z;

            for (int i = 1; i < z; i++)
            {
                x = (x + xs);
                y = (y + ys);
                Thread.Sleep(3);
                host.SendMouseMoveEvent((int)x, (int)y, false, CefEventFlags.LeftMouseButton);//移动鼠标
            }
            Thread.Sleep(3);
            host.SendMouseClickEvent(x2, y2, MouseButtonType.Left, true, 1, CefEventFlags.None);//抬起鼠标左键

            context.WriteLog("鼠标拖动结束");
        }

        private bool getpos(ref int x, ref int y, string xpath, IFrame frame)
        {
            List<string> xpaths = new List<string>() { xpath };
            string jsstr = litcore.iecef.XPath.CefElementExistJs(xpaths);

            object objclick = frame.EvaluateScriptAsync(jsstr).Result.Result;
            if (objclick != null && objclick.ToString() == "exist")
            {

                jsstr = litcore.iecef.XPath.CefClickPositionByXPathJs(xpaths);
                objclick = frame.EvaluateScriptAsync(jsstr).Result.Result;
                if (objclick != null)
                {
                    System.Dynamic.ExpandoObject dynamicObject = objclick as System.Dynamic.ExpandoObject;
                    IDictionary<string, object> dic = dynamicObject;
                    x = Convert.ToInt32(dic["x"]);
                    y = Convert.ToInt32(dic["y"]);
                    return true;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public override ActivityGroup Group => ActivityGroup.CefBroswer;
    }
}