using litcore.ictype;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    public class XPath : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "取值点击";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        /// <summary>
        ///xpath
        /// </summary>
        public string XPathStr = "";

        /// <summary>
        /// 操作类型
        /// </summary>
        public XPathType XPathType = XPathType.Get;

        /// <summary>
        /// 写或取变量名
        /// </summary>
        public string RWVarName = "";

        /// <summary>
        /// 属性或是点击对像
        /// </summary>
        public string Attribute = "";

        /// <summary>
        /// 暂停等待毫秒
        /// </summary>
        public int Sleep = 0;

        /// <summary>
        /// 框架名称
        /// </summary>
        public string FrameName = "";

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (XPathType != XPathType.Click)
            {
                if (string.IsNullOrEmpty(this.Attribute)) throw new Exception("属性不能为空");
                if (string.IsNullOrEmpty(this.RWVarName)) throw new Exception("变量名不能为空");
            }
            else
            {
                if (string.IsNullOrEmpty(this.Attribute)) throw new Exception("点击事件不能为空");
            }
        }

        /// <summary>
        /// 获取值的js代码
        /// </summary>
        /// <param name="xpaths"></param>
        /// <param name="att"></param>
        /// <returns></returns>
        public static string CefGetAttByXPathJs(List<string> xpaths, string att, bool mb = false)
        {
            string rnd = null;
            string js = getxnodesJs(xpaths, ref rnd);
            string add = $"xnodes{rnd}[t].getAttribute('{att}')";
            if (atts.Contains(att))
            {
                add = $"xnodes{rnd}[t].{att}";
            }
            string addre = mb ? "return" : "";
            js += string.Format(@"
var litdatas{1}=[];
for(var t=0;t<xnodes{1}.length;t++){{
var xtext{1}={0};
if(xtext{1}==null) xtext{1}='';
litdatas{1}.push(xtext{1});
}}
{2} JSON.stringify(litdatas{1});
", add, rnd, addre);
            return js;
        }

        /// <summary>
        /// 按xpath取得元素并设置值
        /// </summary>
        /// <param name="xpaths"></param>
        /// <param name="att"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string CefSetAttByXPathJs(List<string> xpaths, string att, string value, bool mb = false)
        {
            string rnd = null;
            if (!string.IsNullOrEmpty(value)) value = value.Replace("'", "\\'");
            string js = getxnodesJs(xpaths, ref rnd);
            //input为应对vue，增加了input事件
            string add = $"xnodes{rnd}[t].setAttribute('{att}','{value}')";
            if (atts.Contains(att))
            {
                add = $"xnodes{rnd}[t].{att}='{value}'";
            }
            add += $";var event{rnd}=document.createEvent('Event');event{rnd}.initEvent('input', true, true);xnodes{rnd}[t].dispatchEvent(event{rnd})";
            string addre = mb ? "return " : "";
            js += string.Format(@"
for(var t=0;t<xnodes{1}.length;t++){{
{0};
}}
{2} 'ok';
", add, rnd, addre);
            return js;
        }

        /// <summary>
        /// 获取元素点击位置的js，如果要点击的界面不显示或是滚动条，点不准
        /// </summary>
        /// <param name="xpaths"></param>
        /// <returns></returns>
        public static string CefClickPositionByXPathJs(List<string> xpaths, bool mb = false)
        {
            string rnd = null;
            string js = getxnodesJs(xpaths, ref rnd);
            string addre = mb ? "return" : "";
            string add = string.Format(@"function currentFrameAbsolutePosition{0}(){let currentWindow=window;let currentParentWindow;let positions=[];let rect;while(currentWindow!==window.top){currentParentWindow=currentWindow.parent;for(let idx=0;idx<currentParentWindow.frames.length;idx++)if(currentParentWindow.frames[idx]===currentWindow){for(let frameElement of currentParentWindow.document.getElementsByTagName('iframe')){if(frameElement.contentWindow===currentWindow){rect=frameElement.getBoundingClientRect();positions.push({x:rect.x,y:rect.y})}}currentWindow=currentParentWindow;break}}return positions.reduce((accumulator,currentValue)=>{return{x:accumulator.x+currentValue.x,y:accumulator.y+currentValue.y}},{x:0,y:0})};var xposition{0};if (xnodes{0}.length>0){{ xposition{0}=xnodes{0}[0].getBoundingClientRect(); var top{0} = getCurrentFrameAbsolutePosition{0}();xposition{0}={{x:xposition{0}.left+xposition{0}.width/2+top{0}.x,y:xposition{0}.top+xposition{0}.height/2+top{0}.y}};{1} xposition{0};}}", rnd, addre);
            return js + "\r\n" + add; ;
        }

        /// <summary>
        /// 判断元素是否存在的js
        /// </summary>
        /// <param name="xpaths"></param>
        /// <returns></returns>
        public static string CefElementExistJs(List<string> xpaths, bool mb = false)
        {
            string rnd = null;
            string js = getxnodesJs(xpaths, ref rnd);
            string addre = mb ? "return" : "";
            string add = string.Format(@"var xexist{0}='notexist';if (xnodes{0}.length>0) xexist{0}='exist';{1} xexist{0}", rnd, addre);
            return js + "\r\n" + add; ;
        }

        /// <summary>
        /// js代码进行点击的操作
        /// </summary>
        /// <param name="xpaths"></param>
        /// <param name="clickstr"></param>
        /// <returns></returns>
        public static string CefClickByXPathJs(List<string> xpaths, string clickstr, bool mb = false)
        {
            string rnd = null;
            string js = getxnodesJs(xpaths, ref rnd);
            string addre = mb ? "return" : "";
            string add = string.Format(@"if (xnodes{0}.length>0) xnodes{0}[0].{1}();{2} 'ok';", rnd, clickstr, addre);
            return js + "\r\n" + add; ;
        }

        /// <summary>
        /// js代码进行点击的操作
        /// </summary>
        /// <param name="xpaths"></param>
        /// <param name="clickstr"></param>
        /// <returns></returns>
        public static string CefScrollIntoViewByXPathJs(List<string> xpaths, bool mb = false)
        {
            string rnd = null;
            string js = getxnodesJs(xpaths, ref rnd);
            string addre = mb ? "return" : "";
            string add = string.Format(@"if (xnodes{0}.length>0) xnodes{0}[0].scrollIntoView();{1} 'ok';", rnd, addre);
            return js + "\r\n" + add; ;
        }

        public static string GetAfterLoadJs()
        {
            return litcore.Resource.hight + "\r\n" + litcore.Resource.readxpath;
        }


        private static List<string> atts = new List<string> { "innerHTML", "innerText", "textContent", "outerText", "outerHTML","value" ,"text"};
        private static string getxnodesJs(List<string> xpaths, ref string rnd)
        {
            rnd = GetRnd();
            string js = string.Format(@"var xresult{1} = document.evaluate('{0}', document, null, XPathResult.ANY_TYPE, null);
var xnodes{1} = [];
var xres{1};
while (xres{1} = xresult{1}.iterateNext()) {{
   xnodes{1}.push(xres{1});
}}", xpaths[0].Replace("'","\\'"), rnd);
            for (int i = 1; i < xpaths.Count; i++)
            {
                js += string.Format(@"
if (xnodes{1}.length==0){{
xresult{1} = document.evaluate('{0}', document, null, XPathResult.ANY_TYPE, null);
while (xres{1} = xresult{1}.iterateNext()) {{
   xnodes{1}.push(xres{1});
}}
}}", xpaths[i].Replace("'", "\\'"), rnd);
            }
            return js;
        }


        public static string GetRnd()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }

        /// <summary>
        /// https://cloud.tencent.com/developer/ask/52433
        /// https://www.cnblogs.com/inet/archive/2013/11/13/3422018.html
        /// https://stackoverflow.com/questions/934012/get-image-data-url-in-javascript/934925#934925
        /// </summary>
        /// <returns></returns>
        public static string CefImageByXPathJs(List<string> xpaths, bool mb = false)
        {
            string rnd = null;
            string js = getxnodesJs(xpaths, ref rnd);
            string addre = mb ? "return" : "";
            string imgjs = string.Format(@"
if (xnodes{0}.length>0&&xnodes{0}[0].nodeName=='IMG'){{
                var canvas{0} = document.createElement('canvas');
                canvas{0}.width = xnodes{0}[0].naturalWidth;
                canvas{0}.height = xnodes{0}[0].naturalHeight;

                var ctx{0} = canvas{0}.getContext('2d');
                ctx{0}.drawImage(xnodes{0}[0], 0, 0);

                var dataURL{0} = canvas{0}.toDataURL('image/png');

                var imgData{0}= dataURL{0}.replace(/^data:image\/(png|jpg);base64,/,'');
               {1} imgData{0};
}}
            ", rnd, addre);
            return js + imgjs;
        }

        public override void Execute(ActivityContext context)
        {
           
        }
    }
}