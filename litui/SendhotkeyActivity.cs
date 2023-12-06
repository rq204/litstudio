using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "发送热键", RefFile = UIConfig.RefFile, IsFront = true, Index = 25)]
    public class SendHotkeyActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "发送热键";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        public UIConfig UIConfig = new UIConfig();

        public bool Alt = false;

        public bool Ctrl = false;

        public bool Shift = false;

        public bool Win = false;

        public string Key = "KEY_A";

        public bool CurMousePosition = false;

        public override void Execute(ActivityContext context)
        {
            if (!this.CurMousePosition)
            {
                ///先给控件来个焦点
                List<FlaUI.Core.AutomationElements.AutomationElement> automationElements = this.UIConfig.GetElements(context);
                if (automationElements.Count == 0) throw new Exception("没有找到元素");
                automationElements[0].SetForeground();
                automationElements[0].Focus();
            }

            ///发送热键
            List<FlaUI.Core.WindowsAPI.VirtualKeyShort> keys = new List<FlaUI.Core.WindowsAPI.VirtualKeyShort>();
            if (Alt) keys.Add(FlaUI.Core.WindowsAPI.VirtualKeyShort.ALT);
            if (Ctrl) keys.Add(FlaUI.Core.WindowsAPI.VirtualKeyShort.CONTROL);
            if (Shift) keys.Add(FlaUI.Core.WindowsAPI.VirtualKeyShort.SHIFT);
            if (Win) keys.Add(FlaUI.Core.WindowsAPI.VirtualKeyShort.LWIN);

            if (!string.IsNullOrEmpty(this.Key))
            {
                foreach (FlaUI.Core.WindowsAPI.VirtualKeyShort item in Enum.GetValues(typeof(FlaUI.Core.WindowsAPI.VirtualKeyShort)))
                {
                    if (this.Key == item.ToString())
                    {
                        keys.Add(item);
                        break;
                    }
                }
            }

            try
            {
                FlaUI.Core.Input.Keyboard.TypeSimultaneously(keys.ToArray());//会出 0x80040201 这个问题，提示 事件无法调用任何订户
                //可能的原因是元素不存了 https://social.msdn.microsoft.com/Forums/en-US/36cbac92-cdb1-4c60-b4fd-54fc6b72c75e/an-event-was-unable-to-invoke-any-of-the-subscribers-ui-automation?forum=winappswithnativecode
            }
            catch
            {
                System.Threading.Thread.Sleep(1000);
                FlaUI.Core.Input.Keyboard.TypeSimultaneously(keys.ToArray());
            }
            context.WriteLog("热键发送成功");
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new SendHotkeyUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (!CurMousePosition)
            {
                this.UIConfig.Validate(context);
            }
            if (!this.Alt && !this.Ctrl && !Shift && !Win && string.IsNullOrWhiteSpace(this.Key)) throw new Exception("控制键和按键至少选一个");
        }
    }
}
