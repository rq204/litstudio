using CefSharp.WinForms;
using CefSharp;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "网页截图", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 20)]
    /// <summary>
    /// 截图
    /// </summary>
    public class CefScreenShot : litcore.iecef.ScreenShot
    {

        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            System.Drawing.Imaging.ImageFormat imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            switch (this.ImageFormat)
            {
                case "jpg":
                    imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    break;
                case "bmp":
                    imageFormat = System.Drawing.Imaging.ImageFormat.Bmp;
                    break;
                case "png":
                    imageFormat = System.Drawing.Imaging.ImageFormat.Png;
                    break;
            }

            if (this.ScreenShotType == litcore.ictype.ScreenShotType.XPath)
            {
                string xpathstr = context.ReplaceVar(this.XPathStr);
                if (xpathstr == "") throw new Exception("XPath不能为空");

                IFrame frame = CefLoad.GetIframe(Browser_Select, this.FrameName);

                if (frame == null) throw new Exception("不存在框架:" + this.FrameName);

                List<string> xps = xpathstr.Replace("\r", "").Split('\n').ToList();
                string js = litcore.iecef.XPath.CefImageByXPathJs(xps);
                object objclick = frame.EvaluateScriptAsync(js).Result.Result;
                if (objclick != null)
                {
                    string base64str = objclick.ToString();
                    byte[] vs = Convert.FromBase64String(base64str);
                    string path = context.GetStr(this.SaveFilePathVarName);
                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(new System.IO.MemoryStream(vs));

                    if (SaveToClipboard)
                    {
                        System.Drawing.Image image = System.Drawing.Image.FromHbitmap(bitmap.GetHbitmap());
                        System.Windows.Forms.Clipboard.SetImage(image);
                        context.WriteLog($"XPath截图成功并保存入剪切板");
                    }
                    else
                    {
                        string savepath = "";
                        if (this.UseTempPath)
                        {
                            savepath = System.IO.Path.GetTempFileName();
                            context.SetVarStr(this.SaveFilePathVarName, savepath);
                        }
                        else savepath = context.GetStr(this.SaveFilePathVarName);
                        bitmap.Save(savepath, imageFormat);
                        bitmap.Dispose();
                        context.WriteLog("成功生成元素截图:" + savepath);
                    }
                }
                else
                {
                    throw new Exception("获取图片失败");
                }
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
            litcore.iecef.ScreenShot.FullSupport = false;
            base.ShowConfig();
        }

        public override ActivityGroup Group => ActivityGroup.CefBroswer;
    }
}