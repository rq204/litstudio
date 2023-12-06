using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "窗口控制", RefFile = UIConfig.RefFile, IsFront = true, Index = 65)]
    public class WindowActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "窗口控制";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        public UIConfig UIConfig = new UIConfig();

        public WindowType WindowType = WindowType.Close;

        public override void Execute(ActivityContext context)
        {
            FlaUI.Core.Application application = this.UIConfig.GetApplication(context);
            string xpath = context.ReplaceVar(this.UIConfig.XPath);
            FlaUI.Core.AutomationElements.Window[] windows = application.GetAllTopLevelWindows(this.UIConfig.Automation);

            if (windows.Length == 0) throw new Exception($"没有发现可操作的窗口，进程{this.UIConfig.ProcessName}窗口数为0");

            string data = System.Text.RegularExpressions.Regex.Replace(xpath, "/Window\\[\\d+?\\]", "");

            string name = "";
            string classname = "";
            if (data != "")
            {
                System.Text.RegularExpressions.Match m = System.Text.RegularExpressions.Regex.Match(data, "\\[Name='(\\S*?)'\\]");
                if (m.Success) name = m.Groups[1].Value;
                m = System.Text.RegularExpressions.Regex.Match(data, "\\[ClassName='(\\S*?)'\\]");
                if (m.Success) classname = m.Groups[1].Value;
            }

            FlaUI.Core.AutomationElements.Window w = null;
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(classname))
            {
                w = windows[0];
            }
            else
            {
                foreach (FlaUI.Core.AutomationElements.Window window in windows)
                {
                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(name))
                    {
                        if (window.Name == name && window.ClassName == classname)
                        {
                            w = window;
                            break;
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(name))
                        {
                            if (window.Name == name)
                            {
                                w = window;
                                break;
                            }
                        }
                        else
                        {
                            if (window.ClassName == classname)
                            {
                                w = window;
                                break;
                            }
                        }
                    }
                }
            }

            if (w == null) throw new Exception("没有找到符合条件的窗口");

            IntPtr windowHandle = IntPtr.Zero;

            try
            {
                if (w.Properties.NativeWindowHandle.IsSupported)
                {
                    windowHandle = w.Properties.NativeWindowHandle.ValueOrDefault;
                }
            }
            catch (Exception)
            {
                context.WriteLog("找到的窗口没有句柄");
            }

            if (windowHandle != IntPtr.Zero)
            {
                switch (this.WindowType)
                {
                    case WindowType.Close:
                        SendMessage(windowHandle, 0x10, IntPtr.Zero, IntPtr.Zero);
                        context.WriteLog("成功发送窗口关闭消息");
                        break;
                    case WindowType.Min:
                        SendMessage(windowHandle, 0x0112, (IntPtr)0xF020, IntPtr.Zero);
                        context.WriteLog("成功发送窗口最小化消息");
                        break;
                    case WindowType.Max:
                        SendMessage(windowHandle, 0x0112, (IntPtr)0xF030, IntPtr.Zero);
                        context.WriteLog("成功发送窗口最大化消息");
                        break;
                    case WindowType.Hide:
                        ShowWindow((int)windowHandle, 0);
                        context.WriteLog("成功发送窗口隐藏消息");
                        break;
                    case WindowType.Show:
                        ShowWindow((int)windowHandle, 1);
                        context.WriteLog("成功发送窗口显示消息");
                        break;
                    case WindowType.Foreground:
                        w.SetForeground();
                        context.WriteLog("成功设置窗口前置");
                        break;
                }
            }
        }

        [DllImport("User32.dll", EntryPoint = "PostMessage", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);


        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        public static extern IntPtr ShowWindow(int hWnd, int _value);


        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new WindowUI());
        }

        public override void Validate(ActivityContext context)
        {
            UIConfig.Validate(context);
        }
    }
}