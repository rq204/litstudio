using litsdk;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litchrome
{
    [litsdk.ActivityInfo(Name = "网页截图", IsFront = false, IsWinForm = true, RefFile = ChrLoad.RefFile, Index = 20)]
    /// <summary>
    /// 截图
    /// https://www.cjavapy.com/article/612/
    /// 
    /// </summary>
    public class ChrScreenShot : litcore.iecef.ScreenShot
    {
        public override ActivityGroup Group => litsdk.ActivityGroup.Chrome;

        public override void Execute(ActivityContext context)
        {
            ChrLoad.LoadChromeSetting(context);

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

                //IFrame frame = CefLoad.GetIframe(Browser_Select, this.FrameName);
                //if (frame == null) throw new Exception("不存在框架:" + this.FrameName);

                List<string> xps = xpathstr.Replace("\r", "").Split('\n').ToList();
                string js = litcore.iecef.XPath.CefImageByXPathJs(xps, true);
                object objclick = ChrLoad.Driver.ExecuteScript(js);
                if (objclick != null)
                {
                    string base64str = objclick.ToString();
                    byte[] vs = Convert.FromBase64String(base64str);

                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(new System.IO.MemoryStream(vs));

                    if (SaveToClipboard)
                    {
#if NET461
                        System.Drawing.Image image = System.Drawing.Image.FromHbitmap(bitmap.GetHbitmap());
                        System.Windows.Forms.Clipboard.SetImage(image);
                        context.WriteLog($"XPath截图成功并保存入剪切板");
#endif
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
            else
            {
                //string width = ChrLoad.Driver.ExecuteScript("return document.body.scrollWidth").ToString();
                //string height = ChrLoad.Driver.ExecuteScript("return document.body.scrollHeight").ToString();

                //int old_height = ChrLoad.Driver.Manage().Window.Size.Height;
                //int old_width = ChrLoad.Driver.Manage().Window.Size.Width;

                //ChrLoad.Driver.Manage().Window.Size = new System.Drawing.Size(int.Parse(width), int.Parse(height));
                //System.Threading.Thread.Sleep(3000);

                //var screenshot = (ChrLoad.Driver as ITakesScreenshot).GetScreenshot();
           
                //System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(new System.IO.MemoryStream(screenshot.AsByteArray));
                System.Drawing.Bitmap bitmap = GetEntereScreenshot(ChrLoad.Driver);

                if (SaveToClipboard)
                {
                    System.Drawing.Image image = System.Drawing.Image.FromHbitmap(bitmap.GetHbitmap());
#if NET461
                    System.Windows.Forms.Clipboard.SetImage(image);
                    context.WriteLog($"XPath截图成功并保存入剪切板");
#endif
                }
                else
                {
                    string savepath = "";
                    if (this.UseTempPath)
                    {
                        savepath = System.IO.Path.GetTempFileName();
                        context.SetVarStr(this.SaveFilePathVarName, savepath);
                    }
                    else
                    {
                        savepath = context.GetStr(this.SaveFilePathVarName);
                        string dir = System.IO.Path.GetDirectoryName(savepath);
                        if (!System.IO.Directory.Exists(dir)) System.IO.Directory.CreateDirectory(dir);
                    }

                    try
                    {
                        bitmap.Save(savepath, imageFormat);
                    }
                    catch (Exception ex)
                    {
                        //int lid = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
                        //throw new Exception(ex.Message + "\r\n" + ex.StackTrace + " \r\nwin32code:" + lid.ToString());
                    }
                    finally
                    {
                        bitmap.Dispose();
                    }
                    context.WriteLog("成功生成元素截图:" + savepath);
                }

                //ChrLoad.Driver.Manage().Window.Maximize();//.Size = new System.Drawing.Size(old_width, old_height);
            }
        }

        public override void ShowConfig()
        {
            litcore.iecef.ScreenShot.FullSupport = true;
            litsdk.API.ShowSystemConfigForm(this);
        }

        public Bitmap GetEntereScreenshot(ChromeDriver _driver)
        {
            Bitmap stitchedImage = null;
            try
            {
                long totalwidth1 = (long)((IJavaScriptExecutor)_driver).ExecuteScript("return document.body.offsetWidth");//documentElement.scrollWidth");

                long totalHeight1 = (long)((IJavaScriptExecutor)_driver).ExecuteScript("return  document.body.parentNode.scrollHeight");

                int totalWidth = (int)totalwidth1;
                int totalHeight = (int)totalHeight1;

                // Get the Size of the Viewport
                long viewportWidth1 = (long)((IJavaScriptExecutor)_driver).ExecuteScript("return document.body.clientWidth");//documentElement.scrollWidth");
                long viewportHeight1 = (long)((IJavaScriptExecutor)_driver).ExecuteScript("return window.innerHeight");//documentElement.scrollWidth");

                int viewportWidth = (int)viewportWidth1;
                int viewportHeight = (int)viewportHeight1;


                // Split the Screen in multiple Rectangles
                List<Rectangle> rectangles = new List<Rectangle>();
                // Loop until the Total Height is reached
                for (int i = 0; i < totalHeight; i += viewportHeight)
                {
                    int newHeight = viewportHeight;
                    // Fix if the Height of the Element is too big
                    if (i + viewportHeight > totalHeight)
                    {
                        newHeight = totalHeight - i;
                    }
                    // Loop until the Total Width is reached
                    for (int ii = 0; ii < totalWidth; ii += viewportWidth)
                    {
                        int newWidth = viewportWidth;
                        // Fix if the Width of the Element is too big
                        if (ii + viewportWidth > totalWidth)
                        {
                            newWidth = totalWidth - ii;
                        }

                        // Create and add the Rectangle
                        Rectangle currRect = new Rectangle(ii, i, newWidth, newHeight);
                        rectangles.Add(currRect);
                    }
                }

                // Build the Image
                stitchedImage = new Bitmap(totalWidth, totalHeight);
                // Get all Screenshots and stitch them together
                Rectangle previous = Rectangle.Empty;
                foreach (var rectangle in rectangles)
                {
                    // Calculate the Scrolling (if needed)
                    if (previous != Rectangle.Empty)
                    {
                        int xDiff = rectangle.Right - previous.Right;
                        int yDiff = rectangle.Bottom - previous.Bottom;
                        // Scroll
                        //selenium.RunScript(String.Format("window.scrollBy({0}, {1})", xDiff, yDiff));
                        ((IJavaScriptExecutor)_driver).ExecuteScript(String.Format("window.scrollBy({0}, {1})", xDiff, yDiff));
                        System.Threading.Thread.Sleep(200);
                    }

                    // Take Screenshot
                    var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();

                    // Build an Image out of the Screenshot
                    Image screenshotImage;
                    using (MemoryStream memStream = new MemoryStream(screenshot.AsByteArray))
                    {
                        screenshotImage = Image.FromStream(memStream);
                    }

                    // Calculate the Source Rectangle
                    Rectangle sourceRectangle = new Rectangle(viewportWidth - rectangle.Width, viewportHeight - rectangle.Height, rectangle.Width, rectangle.Height);

                    // Copy the Image
                    using (Graphics g = Graphics.FromImage(stitchedImage))
                    {
                        g.DrawImage(screenshotImage, rectangle, sourceRectangle, GraphicsUnit.Pixel);
                    }

                    screenshotImage.Dispose();

                    // Set the Previous Rectangle
                    previous = rectangle;
                }
            }
            catch (Exception ex)
            {
                // handle
            }
            return stitchedImage;
        }
    }
}