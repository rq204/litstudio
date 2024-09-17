using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcef
{
    public class CefLoad
    {

        /// <summary>
        /// 将cef相关文件放在一个目录下的
        /// https://blog.csdn.net/a497785609/article/details/80678787
        /// </summary>
        internal void InitializeCef()
        {
            string lib = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"CefSharp\libcef.dll");
            string browser = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"CefSharp\CefSharp.BrowserSubprocess.exe");
            string locales = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"CefSharp\locales\");
            string res = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"CefSharp\");

            var libraryLoader = new CefLibraryHandle(lib);
            var isValid = !libraryLoader.IsInvalid;
            if (isValid)
            {
                litsdk.API.GetMainForm().Invoke((EventHandler)delegate
        {
            var settings = new CefSettings
            {
                BrowserSubprocessPath = browser,
                LocalesDirPath = locales,
                ResourcesDirPath = res,
            };
            settings.Locale = "zh-Cn";
            settings.LogSeverity = LogSeverity.Disable;

            if (!string.IsNullOrEmpty(litsdk.Setting.CefCacheDir))
            {
                settings.CachePath = litsdk.Setting.CefCacheDir;
                settings.UserDataPath = litsdk.Setting.CefCacheDir;// litsdk.Setting.CefCacheDir.TrimEnd('\\').TrimEnd('/') + "d\\";
            }

            settings.UserAgent = litsdk.Setting.CefUserAgent;
            settings.CefCommandLineArgs.Add("--ignore-urlfetcher-cert-requests", "1");
            settings.CefCommandLineArgs.Add("--ignore-certificate-errors", "1");
            //settings.CefCommandLineArgs.Remove("enable-system-flash");//)) .Add("enable-system-flash", "1"); //启用flash
            //settings.CefCommandLineArgs.Add("enable-system-flash", "1"); //启用flash
            //settings.CefCommandLineArgs.Add("enable-media-stream", "1"); //启用媒体流
            //settings.CefCommandLineArgs.Add("ppapi-flash-version", "99.0.0.999"); //设置flash插件版本                                              
            ////使用指定的flash插件，不使用系统安装的flash版本
            //settings.CefCommandLineArgs.Add("ppapi-flash-path", AppDomain.CurrentDomain.BaseDirectory + "pepflashplayer.dll");
            Cef.Initialize(settings);
        });

            }
            litsdk.API.OnExit += new Action(() =>
            {
                litsdk.API.GetMainForm().Invoke((EventHandler)delegate
                {
                    Cef.Shutdown();
                });
            });
        }

        internal static Lazy<CefLoad> cefLoad = new Lazy<CefLoad>();

        /// <summary>
        /// 选中的浏览器界面
        /// </summary>
        public static CefUI CefUI_Select=null;


        public static void LoadBrowser()
        {
            if (!cefLoad.IsValueCreated) cefLoad.Value.InitializeCef();
            if (CefUI_Select == null)
            {
                litsdk.API.GetMainForm().Invoke((EventHandler)delegate
                {
                    CefUI_Select = CefUI.Instance;
                    litsdk.API.AddTabPage(CefUI.Instance);
                });
            }
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            try
            {
                while (!CefUI_Select.browser.IsBrowserInitialized)
                {
                    System.Threading.Thread.Sleep(100);
                    System.Windows.Forms.Application.DoEvents();
                    if (sw.ElapsedMilliseconds > 30000)
                    {
                        throw new Exception("打开网址但浏览器初始化失败");
                    }
                }
            }
            finally
            {
                sw.Stop();
            }
        }

        /// <summary>
        /// 获取frame
        /// </summary>
        /// <param name="Browser_Select"></param>
        /// <param name="FrameName"></param>
        /// <returns></returns>
        public static IFrame GetIframe(CefSharp.WinForms.ChromiumWebBrowser Browser_Select, string FrameName)
        {
            IFrame frame = null;

            if (!string.IsNullOrEmpty(FrameName))
            {
                //List<string> names = Browser_Select.GetBrowser().GetFrameNames();
                //foreach (string name in names)
                //{
                //    IFrame f = Browser_Select.GetBrowser().GetFrame(name);
                //    if (f.Name == FrameName || f.Url.StartsWith(FrameName))
                //    {
                //        frame = f;
                //        break;
                //    }
                //}
                var identifiers = Browser_Select.GetBrowser().GetFrameIdentifiers();

                foreach (var i in identifiers)
                {
                    frame = Browser_Select.GetBrowser().GetFrame(i);
                    if (frame.Name.Contains(FrameName) || frame.Url.StartsWith(FrameName))
                        return frame;
                }
            }
            else
            {
                frame = Browser_Select.GetBrowser().MainFrame;
            }

            return frame;
        }

        /// <summary>
        /// cef相关的文件,就一个目录
        /// </summary>
        public const string CefFile = "CefSharp";
    }
}