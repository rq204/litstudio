using FlaUI.Core.Input;
using litsdk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "移动鼠标", RefFile = UIConfig.RefFile, IsFront = true, IsWinForm = false, Index = 7)]
    public class MouseMoveActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "移动鼠标";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        public MouseMoveType MouseMoveType = MouseMoveType.FullScreen;

        public string XLocation = "";

        public string YLocation = "";


        public override void Execute(ActivityContext context)
        {
            Point point = new Point() { X = 0, Y = 0 };
            switch (this.MouseMoveType)
            {
                case MouseMoveType.ActivityForm:
                    IntPtr awin = GetForegroundWindow();    //获取当前窗口句柄
                    RECT rect = new RECT();
                    GetWindowRect(awin, ref rect);
                    point.X += rect.Left;
                    point.Y += rect.Top;
                    break;
                case MouseMoveType.CurLocation:
                    point = Mouse.Position;
                    break;
            }


            string xs = context.ReplaceVar(this.XLocation);
            string ys = context.ReplaceVar(this.YLocation);
            int x = 0, y = 0;
            if (!int.TryParse(xs, out x))
            {
                throw new Exception($"X坐标数据错误不为数字 {xs}");
            }
            if (!int.TryParse(ys, out y))
            {
                throw new Exception($"Y坐标数据错误不为数字 {ys}");
            }

            point.X += x;
            point.Y += y;
            FlaUI.Core.Input.Mouse.MoveTo(point);
            context.WriteLog($"鼠标成功移动至X{point.X},Y{point.Y}");
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;                             //最左坐标
            public int Top;                             //最上坐标
            public int Right;                           //最右坐标
            public int Bottom;                        //最下坐标
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new MouseMoveUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.XLocation)) throw new Exception("X坐标不能为空");
            if (string.IsNullOrEmpty(this.YLocation)) throw new Exception("Y坐标不能为空");
        }
    }
}