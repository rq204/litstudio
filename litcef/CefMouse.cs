using CefSharp;
using CefSharp.WinForms;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "键鼠操作", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 88)]
    public class CefMouse : litcore.iecef.Mouse
    {
        public override ActivityGroup Group => litsdk.ActivityGroup.CefBroswer;

        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            var host = Browser_Select.GetBrowser().GetHost();

            switch (this.MouseType)
            {
                case litcore.ictype.MouseType.PosClick:
                    int x = 0, y = 0;
                    string sx = context.ReplaceVar(this.PosX);
                    string sy = context.ReplaceVar(this.PosY);
                    if (int.TryParse(sx, out x) && int.TryParse(sy, out y))
                    {
                        host.SendMouseClickEvent(new CefSharp.MouseEvent(x, y, CefSharp.CefEventFlags.None), CefSharp.MouseButtonType.Left, false, 1);
                        host.SendMouseClickEvent(new CefSharp.MouseEvent(x, y, CefSharp.CefEventFlags.None), CefSharp.MouseButtonType.Left, true, 1);
                        context.WriteLog($"成功点击坐标X{sx} Y{sy}");
                    }
                    else
                    {
                        throw new Exception($"坐标转换失败，X：{this.PosX}Y：{this.PosY}");
                    }
                    break;
                case litcore.ictype.MouseType.HotKey:
                    CefSharp.KeyEvent ke = new KeyEvent() { IsSystemKey = true, FocusOnEditableField = true, Type = KeyEventType.RawKeyDown, WindowsKeyCode = GetKeyCode(this.HotKey) };
                    host.SendKeyEvent(ke);
                    context.WriteLog($"成功发送按键{this.HotKey}");
                    break;
                case litcore.ictype.MouseType.TextInPut:

                    break;
            }
        }

        public static int GetKeyCode(string key)
        {
            switch (key)
            {
                case "ENTER":
                    return Convert.ToInt32(Keys.Enter);
                case "TAB":
                    return Convert.ToInt32(Keys.Tab);
                case "NEXT":
                    return Convert.ToInt32(Keys.Next);
                case "LEFT":
                    return Convert.ToInt32(Keys.Left);
                case "UP":
                    return Convert.ToInt32(Keys.Up);
                case "RIGHT":
                    return Convert.ToInt32(Keys.Right);
                case "DOWN":
                    return Convert.ToInt32(Keys.Down);
                case "BACK":
                    return Convert.ToInt32(Keys.Back);
                case "PAUSE":
                    return Convert.ToInt32(Keys.Pause);
                case "ALT":
                    return Convert.ToInt32(Keys.Alt);
                case "SHIFT":
                    return Convert.ToInt32(Keys.Shift);
                case "END":
                    return Convert.ToInt32(Keys.End);
                case "HOME":
                    return Convert.ToInt32(Keys.Home);
                case "INSERT":
                    return Convert.ToInt32(Keys.Insert);
                case "DELETE":
                    return Convert.ToInt32(Keys.Delete);
                case "PRIOR":
                    return Convert.ToInt32(Keys.Prior);
                case "F1":
                    return Convert.ToInt32(Keys.F1);
                case "F2":
                    return Convert.ToInt32(Keys.F2);
                case "F3":
                    return Convert.ToInt32(Keys.F3);
                case "F4":
                    return Convert.ToInt32(Keys.F4);
                case "F5":
                    return Convert.ToInt32(Keys.F5);
                case "F6":
                    return Convert.ToInt32(Keys.F6);
                case "F7":
                    return Convert.ToInt32(Keys.F7);
                case "F8":
                    return Convert.ToInt32(Keys.F8);
                case "F9":
                    return Convert.ToInt32(Keys.F9);
                case "F10":
                    return Convert.ToInt32(Keys.F10);
                case "F11":
                    return Convert.ToInt32(Keys.F11);
                case "F12":
                    return Convert.ToInt32(Keys.F12);
            }
            return 0;
        }

    }
}