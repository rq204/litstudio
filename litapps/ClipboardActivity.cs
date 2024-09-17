using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using litsdk;

namespace litapps
{
    [Serializable]
    [ActivityInfo(Name = "剪贴板操作", IsWinForm = true)]
    public class ClipboardActivity : litsdk.ProcessActivity
    {
        private string name = "剪贴板操作";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.App;

        /// <summary>
        /// 设置剪贴板
        /// </summary>
        public ClipboardType ClipboardType = ClipboardType.SetStrToClipboard;

        /// <summary>
        /// 设置或获取的变量名
        /// </summary>
        public string StrVarName = "";

        public override void Execute(ActivityContext context)
        {
            string debug = "";
            litsdk.API.GetMainForm().Invoke((EventHandler)delegate
            {
                switch (this.ClipboardType)
                {
                    case ClipboardType.SetStrToClipboard:
                        string txt = context.GetStr(this.StrVarName);
                        Clipboard.SetText(txt);
                        debug = $"设置剪切板成功，字符长度为{txt.Length}";
                        break;
                    case ClipboardType.SetFileToClipboard:
                        string filepath = context.GetStr(this.StrVarName);
                        StringCollection paths = new StringCollection();
                        paths.Add(filepath);
                        Clipboard.SetFileDropList(paths);
                        debug = "";
                        break;
                    case ClipboardType.SetImageToClipboard:
                        string imgpath = context.GetStr(this.StrVarName);
                        System.Drawing.Image img = System.Drawing.Image.FromFile(imgpath);
                        Clipboard.SetImage(img);
                        break;
                    case ClipboardType.GetStrFromClipboard:
                        string txt2 = Clipboard.GetText();
                        context.SetVarStr(this.StrVarName, txt2);
                        debug = $"获取剪切板内容成功，字符长度为{txt2.Length}";
                        break;
                    case ClipboardType.SaveImageFromClipboard:
                        string saveimgpath = context.GetStr(this.StrVarName);
                        System.Drawing.Image image = Clipboard.GetImage();
                        image.Save(saveimgpath, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
            });
            context.WriteLog(debug);
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new ClipboardUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (!context.ContainsStr(this.StrVarName))
            {
                throw new Exception("原变量名不存在:" + this.StrVarName);
            }
        }
    }
}
