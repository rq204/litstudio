using litcore.iecef;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litchrome
{
    public class ChrLoad
    {
        /// <summary>
        /// 浏览器配置
        /// </summary>
        internal static litcore.iecef.ChrSetting Setting = null;

        /// <summary>
        /// 使用的对象
        /// </summary>
        private static ChromeDriver driver = null;

        /// <summary>
        /// 进程id
        /// </summary>
        public static int ProcessId = 0;

        /// <summary>
        /// 浏览器对象，只有一个的
        /// </summary>
        public static ChromeDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    if (Setting == null) Setting = new ChrSetting() { };

                    try
                    {
                        driver = CreateDriver();
                    }
                    catch (Exception ex)
                    {
                        string err = ParserError(ex);
                        if (err != null) throw new Exception(err);
                        throw;
                    }
                    ChrSwitchTab.InitTab(driver.CurrentWindowHandle);
                }
                return driver;
            }
        }


        private static string ParserError(Exception ex)
        {
            if (ex.Message.Contains("Current browser version is"))
            {
                System.Text.RegularExpressions.Match m = System.Text.RegularExpressions.Regex.Match(ex.Message, " (?<dver>\\S+)\\nCurrent browser version is\\s(?<cver>\\S+)\\s");
                if (m.Success)
                {
                    string cver = m.Groups["cver"].Value.Split('.')[0];
                    string dver = m.Groups["dver"].Value;
                    //https://registry.npmmirror.com/-/binary/chromedriver/LATEST_RELEASE_100
                    return $"当前驱动版本{dver}，浏览器版本{cver}，请下载和浏览器版本一致的驱动程序并替换当前程序目录下 chromedriver.exe ，下载地址：https://registry.npmmirror.com/binary.html?path=chromedriver/";
                }
            }
            return null;
        }

        private static litsdk.ActivityContext activityContext = null;
        public static void LoadChromeSetting(litsdk.ActivityContext context)
        {
            object obj = context.GetUserConfig("ChrSetting");
            if (obj != null)
            {
                Setting = obj as litcore.iecef.ChrSetting;
            }
            activityContext = context;
        }

        /// <summary>
        /// 获取元素
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="xpaths"></param>
        /// <returns></returns>
        public static List<OpenQA.Selenium.IWebElement> GetElements(List<string> xpaths, IWebDriver wdriver)
        {
            foreach (string xp in xpaths)
            {
                List<OpenQA.Selenium.IWebElement> eles = wdriver.FindElements(OpenQA.Selenium.By.XPath(xp)).ToList();
                if (eles.Count > 0) return eles;
            }
            return new List<OpenQA.Selenium.IWebElement>();
        }

        /// <summary>
        /// 多层
        /// </summary>
        /// <param name="xpaths"></param>
        /// <returns></returns>
        public static IWebDriver GetFrames(IWebDriver parent, string frameName, int deep = 1)
        {
            var iframes = parent.FindElements(By.TagName("iframe"));
            //先第一层
            foreach (OpenQA.Selenium.IWebElement element in iframes)
            {
                string fname = element.GetAttribute("name");
                string fid = element.GetAttribute("id");
                string fsrc = element.GetAttribute("src");
                if (fid == null) fid = "";
                if (fsrc == null) fsrc = "";

                if (fname.Contains(frameName) || fid.Contains(frameName) || fsrc.Contains(frameName))
                {
                    IWebDriver now = parent.SwitchTo().Frame(element);
                    return now;
                }
            }

            var frames = parent.FindElements(By.TagName("frame"));
            foreach (OpenQA.Selenium.IWebElement element in frames)
            {
                string fname = element.GetAttribute("name");
                string fid = element.GetAttribute("id");
                string fsrc = element.GetAttribute("src");
                if (fid == null) fid = "";
                if (fsrc == null) fsrc = "";

                if (fname.Contains(frameName) || fid.Contains(frameName) || fsrc.Contains(frameName))
                {
                    IWebDriver now = parent.SwitchTo().Frame(element);
                    return now;
                }
            }


            //最多处理4层嵌套
            if (deep == 4) return null;

            int deep2 = deep + 1;
            //子层级
            foreach (OpenQA.Selenium.IWebElement element in iframes)
            {
                IWebDriver now = parent.SwitchTo().Frame(element);
                IWebDriver child = GetFrames(now, frameName, deep2);
                if (child != null) return child;

                Driver.SwitchTo().ParentFrame();
            }

            foreach (OpenQA.Selenium.IWebElement element in frames)
            {
                IWebDriver now = parent.SwitchTo().Frame(element);
                IWebDriver child = GetFrames(now, frameName, deep2);
                if (child != null) return child;

                Driver.SwitchTo().ParentFrame();
            }
            return null;
        }

        public const string RefFile = "WebDriver.dll,WebDriver.Support.dll,chromedriver.exe";

        private static ChromeDriver CreateDriver()
        {
            string exePath = AppDomain.CurrentDomain.BaseDirectory + "chromedriver.exe";

            if (!string.IsNullOrEmpty(Setting.DriverPath))
            {
                exePath = activityContext.ReplaceVar(Setting.DriverPath);
            }

            if (!System.IO.File.Exists(exePath)) throw new Exception("驱动程序不存在:" + exePath);

            ChromeDriverService service = ChromeDriverService.CreateDefaultService(AppDomain.CurrentDomain.BaseDirectory, exePath);
            service.HideCommandPromptWindow = true;
            ChromeOptions option = new ChromeOptions();

            string chromePath = activityContext.ReplaceVar(Setting.ChromePath);

            if (Setting.RemoteDebugging)
            {
                option.DebuggerAddress = chromePath;
            }
            else
            {
                // 不显示浏览器
                //options.AddArgument("--headless");
                // GPU加速可能会导致Chrome出现黑屏及CPU占用率过高,所以禁用
                option.AddArgument("--disable-gpu");
                option.AddArgument("lang=zh_CN.UTF-8");
                option.AddArgument("ignore-certificate-errors");
                option.AddExcludedArgument("enable-automation");//去掉显示 Chrome 正受自动测试软件控制 字样
                //option.AddArgument("start-fullscreen");全屏

                ///https://www.cnblogs.com/wangchuang/p/11120497.html
                //// 伪装user-agent
                //option.AddArgument("user-agent=Mozilla/5.0 (iPhone; CPU iPhone OS 10_3 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) CriOS/56.0.2924.75 Mobile/14E5239e Safari/602.1");
                //// 设置chrome启动时size大小
                //option.AddArgument("--window-size=414,736");
                //// 禁用图片
                //option.AddUserProfilePreference("profile.default_content_setting_values.images", 2);

                //option.AddExcludedArgument("enable-automation");

                option.AddArgument("--start-maximized");

                option.AddAdditionalOption("useAutomationExtension", false);
                //option.AddExcludedArgument("excludeSwitches=enable-automation");
                option.AddAdditionalOption("--disable-blink-features","AutomationControlled");
                option.AddLocalStatePreference("exit_type", (object)"Normal");
                option.AddUserProfilePreference("exit_type", (object)"Normal");

                if (string.IsNullOrEmpty(chromePath))
                {
                    //获取系统path
                    chromePath = GetChromePath();
                }

                option.BinaryLocation = chromePath;// activityContext.ReplaceVar(chromePath);

                if (string.IsNullOrEmpty(option.BinaryLocation) || !System.IO.File.Exists(option.BinaryLocation))
                {
                    string log = "没有找到浏览器，请检查，路径为空";
                    if (!string.IsNullOrEmpty(option.BinaryLocation))
                    {
                        log = "没有找到浏览器，请检查:" + option.BinaryLocation;
                    }

                    throw new Exception(log);
                }

                if (Setting.UseDefaultUserData)
                {
                    string userdata = GetDefaultUserData();
                    if (!string.IsNullOrEmpty(userdata))
                    {
                        option.AddArguments(new string[1]
                           {
                                        "--user-data-dir=" + userdata
                           });
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(Setting.UserData))
                    {
                        //string userData 
                        string userdata = activityContext.ReplaceVar(Setting.UserData);
                        if (System.IO.Directory.Exists(userdata))
                        {
                            option.AddArguments(new string[1]
                                {
                                        "--user-data-dir=" + userdata
                                });
                        }
                    }
                }
            }

            if (Setting.Mobile)
            {
                //option.EnableMobileEmulation("Galaxy S21+");
                ChromiumMobileEmulationDeviceSettings mset = new ChromiumMobileEmulationDeviceSettings()
                {
                    EnableTouchEvents = true,
                    UserAgent = "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Mobile Safari/537.36",
                    Height = 800,
                    Width = 360,
                    PixelRatio = 3.0
                };
                option.EnableMobileEmulation(mset);
            }

            if (!string.IsNullOrEmpty(Setting.Arguments))
            {
                string arguments = activityContext.ReplaceVar(Setting.Arguments);
                int pos = arguments.IndexOf("--");
                while (pos > -1)
                {
                    int hou = arguments.IndexOf("--", pos + 2);
                    if (hou > 0)
                    {
                        string arg = arguments.Substring(pos, hou - pos);
                        option.AddArgument(arg.Trim());
                        pos = hou;
                    }
                    else
                    {
                        string arg = arguments.Substring(pos, arguments.Length - pos);
                        option.AddArgument(arg.Trim());
                        break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(Setting.CrxVarName))
            {
                List<string> crxPaths = new List<string>();
                if (activityContext.ContainsStr(Setting.CrxVarName))
                {
                    crxPaths.Add(activityContext.GetStr(Setting.CrxVarName));
                }
                else if (activityContext.ContainsList(Setting.CrxVarName))
                {
                    crxPaths.AddRange(activityContext.GetList(Setting.CrxVarName));
                }
                foreach(string crxPath in crxPaths)
                {
                    if(System.IO.File.Exists(crxPath)) option.AddExtension(crxPath);
                }
            }

            ChromeDriver driver = new ChromeDriver(service, option);

            ProcessId = service.ProcessId;

            //远程的先等待3秒
            if (Setting.RemoteDebugging)
            {
                activityContext.WriteLog("启动外部浏览器中");
                System.Threading.Thread.Sleep(3000);
            }

            //https://cloud.tencent.com/developer/article/1598082?from=article.detail.1397806
            //Dictionary<string, object> dic = new Dictionary<string, object>();
            // dic.Add("source", "Object.defineProperties(navigator, {webdriver:{get:()=>undefined}});");
            //dic.Add("source", Resource.stealth);
            //driver.ExecuteCdpCommand("Page.addScriptToEvaluateOnNewDocument", dic);
            //https://www.cnblogs.com/lyl6796910/p/14275770.html 去掉window.navigator.webdriver
            //https://cloud.tencent.com/developer/article/1397806
            //https://www.cxyzjd.com/article/qq_38154948/116003618
            //https://github.com/kingname/stealth.min.js
            //检查 https://bot.sannysoft.com
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("Object.defineProperties(navigator, {webdriver:{get:()=>undefined}});");

            litsdk.API.OnExit += new Action(() => driver.Quit());

            return driver;
        }

        public static void Quit()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }
        /// <summary>
        /// https://blog.csdn.net/qq_29542611/article/details/105321490
        /// </summary>
        /// <returns></returns>
        public static string GetChromePath()
        {
            List<string> maybe = new List<string>();

#if NET461
            try
            {
                //Microsoft.Win32.RegistryKey userk = Microsoft.Win32.Registry.CurrentUser;
                //Microsoft.Win32.RegistryKey gookey = userk.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall\Google Chrome");
                //if (gookey != null)
                //{
                //    gookey.GetValue("");
                //}
                //if (!string.IsNullOrEmpty(key)) maybe.Add(key);

                var exe = System.Text.RegularExpressions.Regex.Match((string)Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(@"ChromeHTML\shell\open\command").GetValue(null),
          @"""(.*?)""",
          System.Text.RegularExpressions.RegexOptions.None)
      .Groups[1].Value;
                if (!string.IsNullOrEmpty(exe)) maybe.Add(exe);
            }
            catch { }
            string program = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"Google\Chrome\Application\chrome.exe").Replace(" (x86)", "");
               string program2 = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"Google\Chrome\Application\chrome.exe");
            string program86 = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), @"Google\Chrome\Application\chrome.exe");
            maybe.Add(program);
            maybe.Add(program2);
            maybe.Add(program86);
#endif
            return maybe.Distinct().ToList().Find(f => System.IO.File.Exists(f));
        }

        /// <summary>
        /// 获取默认配置
        /// https://chromium.googlesource.com/chromium/src/+/HEAD/docs/user_data_dir.md
        /// </summary>
        /// <returns></returns>
        private static string GetDefaultUserData()
        {
            string Chromed = @"\Google\Chrome\User Data";
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Chromed;
            if (System.IO.Directory.Exists(dir)) return dir;
            return null;
            //string chromeBeta = @"%\Google\Chrome Beta\User Data";
            //string 
            ////[Chrome] %LOCALAPPDATA%\Google\Chrome\User Data
            //[Chrome Beta] % LOCALAPPDATA 
            //  [Chrome Canary] % LOCALAPPDATA %\Google\Chrome SxS\User Data
            //    [Chromium] % LOCALAPPDATA %\Chromium\User Data
        }
    }
}
