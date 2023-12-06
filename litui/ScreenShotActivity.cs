using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "元素截图", RefFile = UIConfig.RefFile, IsFront = true, Index = 55)]
    public class ScreenShotActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "元素截图";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        public UIConfig UIConfig = new UIConfig();

        public string ImgSaveVarName = "";

        public string ImageFormat = "bmp";

        public bool UseTempPath = false;

        public bool SaveToClipboard = false;

        /// <summary>
        /// 全屏
        /// </summary>
        public bool FullScreen = false;

        public override void Execute(ActivityContext context)
        {
            System.Drawing.Bitmap bitmap = null;
            System.Drawing.Imaging.ImageFormat imageFormat = System.Drawing.Imaging.ImageFormat.Bmp;

            litsdk.API.GetMainForm().Invoke((EventHandler)delegate
            {
                if (FullScreen)
                {
                    bitmap = litui.ImgConfig.GetDestopImage(System.Windows.Forms.Screen.PrimaryScreen.Bounds);
                }
                else
                {
                    List<FlaUI.Core.AutomationElements.AutomationElement> automationElements = this.UIConfig.GetElements(context);
                    if (automationElements.Count == 0) throw new Exception("没有找到元素");
                    automationElements[0].SetForeground();

                    bitmap = automationElements[0].Capture();
                }

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
            });

            if (this.SaveToClipboard)
            {
                System.Drawing.Image image = System.Drawing.Image.FromHbitmap(bitmap.GetHbitmap());
                System.Windows.Forms.Clipboard.SetImage(image);
                context.WriteLog($"元素截图成功并保存入剪切板");
            }
            else
            {
                string savepath = "";
                if (this.UseTempPath)
                {
                    savepath = System.IO.Path.GetTempFileName();
                    context.SetVarStr(this.ImgSaveVarName, savepath);
                }
                else savepath = context.GetStr(this.ImgSaveVarName);
                bitmap.Save(savepath, imageFormat);
                bitmap.Dispose();
                context.WriteLog($"元素截图成功并保存{savepath}");
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new ScreenShotUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (!FullScreen)
            {
                this.UIConfig.Validate(context);
            }
            if (!this.SaveToClipboard)
            {
                if (string.IsNullOrEmpty(this.ImgSaveVarName)) throw new Exception("图片保存路径不能为空");
                if (!context.ContainsStr(this.ImgSaveVarName)) throw new Exception($"图片保存路径变量{this.ImgSaveVarName}不存在");
            }
        }
    }
}