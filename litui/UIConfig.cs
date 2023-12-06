using FlaUI.Core.AutomationElements;
using litsdk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace litui
{
    public class UIConfig
    {
        /// <summary>
        /// 引擎
        /// </summary>
        public string Engine = "FlaUI3";//FlaUI2 FlaUI3 Java

        /// <summary>
        /// 进程名
        /// </summary>
        public string ProcessName = "";

        /// <summary>
        /// 元素的XPath
        /// </summary>
        public string XPath = "";

        /// <summary>
        /// 
        /// </summary>
        public string ImgBase64 = "";

        internal void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.ProcessName)) throw new Exception("进程名不能为空");
            if (string.IsNullOrEmpty(this.Engine)) throw new Exception("UI识别引擎不能为空");
            if (string.IsNullOrEmpty(this.XPath)) throw new Exception("XPath不能为空");
        }

        internal FlaUI.Core.AutomationBase Automation = null;
        private static string self_name = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
        internal FlaUI.Core.Application GetApplication(ActivityContext context)
        {
            string processname = context.ReplaceVar(this.ProcessName);
            if (processname == "[self]") processname = self_name;
            Automation = new FlaUI.UIA3.UIA3Automation();
            //else if (this.Engine == "Java")
            //{
            //    automation = null;
            //}
            System.Diagnostics.Process[] apps = System.Diagnostics.Process.GetProcessesByName(processname);
            if (apps.Length == 0) throw new Exception("找不到进程：" + processname);
            System.Diagnostics.Process process = null;
            foreach(System.Diagnostics.Process p in apps)
            {
                if (p.MainWindowHandle != IntPtr.Zero)
                {
                    process = p;
                    break;
                }
            }
            if (process == null) throw new Exception("当前进程没有窗口");
            FlaUI.Core.Application application = FlaUI.Core.Application.Attach(process);
            return application;
        }

        internal List<FlaUI.Core.AutomationElements.AutomationElement> GetElements(ActivityContext context)
        {
            string xpath = context.ReplaceVar(this.XPath);
            FlaUI.Core.Application application = GetApplication(context);
           // FlaUI.Core.AutomationElements.Window window = null;

            List<Window> windows = application.GetAllTopLevelWindows(Automation).ToList();
            if (windows.Count == 0)
            {
                windows.Add(application.GetMainWindow(Automation));
            }
            //if (this.ProcessName == "[self]")
            //{
            //    if (tabFormText == null)
            //    {
            //        litwsdk.API.GetMainForm().Invoke((EventHandler)delegate
            //        {
            //            List<System.Windows.Forms.UserControl> lcs = litwsdk.API.GetTabPages();
            //            tabFormText = lcs[0].FindForm().Text;
            //        });
            //    }

            //    window = windows.Find((w) => w.Name == tabFormText);
            //    if (window == null) window = application.GetMainWindow(Automation);
            //}
            //else
            //{
            //    window = application.GetMainWindow(Automation);
            //}
            List<string> xArr = xpath.Split('/').ToList();
            if (xArr[1].StartsWith("Window"))
            {
                xArr.RemoveAt(1);
                xpath = string.Join("/", xArr.ToArray());
            }

            foreach (Window w in windows)
            {
                List<FlaUI.Core.AutomationElements.AutomationElement> finds = w.FindAllByXPath(xpath).ToList();
                if (application.Name == "explorer" && finds.Count == 0) finds = w.Parent.FindAllByXPath(xpath).ToList();
                if (finds.Count > 0) return finds;
            }

            return new List<AutomationElement>();
        }


        internal System.Drawing.Point GetClickablePoint(FlaUI.Core.AutomationElements.AutomationElement element)
        {
            System.Drawing.Point point = new System.Drawing.Point();
            if (!element.TryGetClickablePoint(out point))
            {
                point = new Point(element.BoundingRectangle.Left + element.BoundingRectangle.Width / 2,
                                    element.BoundingRectangle.Top + element.BoundingRectangle.Height / 2);
            }
            return point;
        }

       public const  string RefFile = "FlaUI.Core.dll,FlaUI.UIA2.dll,FlaUI.UIA3.dll,Gma.UserActivityMonitor.dll,Interop.UIAutomationClient.dll";

        internal static string GetText(FlaUI.Core.AutomationElements.AutomationElement element)
        {
            string data = "";
            
            switch (element.ControlType)
            {
                case FlaUI.Core.Definitions.ControlType.CheckBox:
                    FlaUI.Core.AutomationElements.CheckBox checkBox = element as
                   FlaUI.Core.AutomationElements.CheckBox;
                    data = checkBox.ToggleState.ToString();
                    break;
                case FlaUI.Core.Definitions.ControlType.RadioButton:
                    FlaUI.Core.AutomationElements.RadioButton radioButton = element as FlaUI.Core.AutomationElements.RadioButton;
                    data = radioButton.IsChecked.ToString();
                    break;
                case FlaUI.Core.Definitions.ControlType.Text:
                    data = element.Name;
                    break;
                case FlaUI.Core.Definitions.ControlType.TitleBar:
                case FlaUI.Core.Definitions.ControlType.Document:
                    if (element.Patterns.Value.IsSupported)
                    {
                        data = element.Patterns.Value.Pattern.Value;
                    }
                    break;
                case FlaUI.Core.Definitions.ControlType.ComboBox:
                    data = element.AsComboBox().SelectedItem.Text;
                    break;
                case FlaUI.Core.Definitions.ControlType.Edit:
                    if (element.Patterns.Value.IsSupported)
                    {
                        data = element.Patterns.Value.Pattern.Value;
                    }
                    break;
                default:
                    data = element.Name;
                    break;
            }
            return data;
        }
    }
}
