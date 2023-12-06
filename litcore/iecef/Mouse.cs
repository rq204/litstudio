using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    public class Mouse : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "键鼠操作";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        public ictype.MouseType MouseType = ictype.MouseType.PosClick;

        public string PosX = "";

 
        public string PosY = "";


        public string HotKey = "ENTER";

    
        public string TextInPut = "";


        public override void Execute(ActivityContext context)
        {
            
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            switch (this.MouseType)
            {
                case ictype.MouseType.PosClick:
                    if (string.IsNullOrEmpty(this.PosX)) throw new Exception($"点击坐标X字符变量名不能为空");
                    if (string.IsNullOrEmpty(this.PosY)) throw new Exception($"点击坐标Y字符变量名不能为空");
                    break;
                case ictype.MouseType.HotKey:
                    if (string.IsNullOrEmpty(this.HotKey)) throw new Exception($"点击坐标Y字符变量名不能为空");
                    break;
                case ictype.MouseType.TextInPut:
                    if (string.IsNullOrEmpty(this.TextInPut)) throw new Exception($"点击坐标Y字符变量名不能为空");
                    break;
            }
        }

        //public static int GetKeyCode(string key)
        //{
        //    switch (key)
        //    {
        //        case "ENTER":
        //            return Convert.ToInt32(Keys.Enter);
        //        case "TAB":
        //            return Convert.ToInt32(Keys.Tab);
        //        case "NEXT":
        //            return Convert.ToInt32(Keys.Next);
        //        case "LEFT":
        //            return Convert.ToInt32(Keys.Left);
        //        case "UP":
        //            return Convert.ToInt32(Keys.Up);
        //        case "RIGHT":
        //            return Convert.ToInt32(Keys.Right);
        //        case "DOWN":
        //            return Convert.ToInt32(Keys.Down);
        //        case "BACK":
        //            return Convert.ToInt32(Keys.Back);
        //        case "PAUSE":
        //            return Convert.ToInt32(Keys.Pause);
        //        case "ALT":
        //            return Convert.ToInt32(Keys.Alt);
        //        case "SHIFT":
        //            return Convert.ToInt32(Keys.Shift);
        //        case "END":
        //            return Convert.ToInt32(Keys.End);
        //        case "HOME":
        //            return Convert.ToInt32(Keys.Home);
        //        case "INSERT":
        //            return Convert.ToInt32(Keys.Insert);
        //        case "DELETE":
        //            return Convert.ToInt32(Keys.Delete);
        //        case "PRIOR":
        //            return Convert.ToInt32(Keys.Prior);
        //        case "F1":
        //            return Convert.ToInt32(Keys.F1);
        //        case "F2":
        //            return Convert.ToInt32(Keys.F2);
        //        case "F3":
        //            return Convert.ToInt32(Keys.F3);
        //        case "F4":
        //            return Convert.ToInt32(Keys.F4);
        //        case "F5":
        //            return Convert.ToInt32(Keys.F5);
        //        case "F6":
        //            return Convert.ToInt32(Keys.F6);
        //        case "F7":
        //            return Convert.ToInt32(Keys.F7);
        //        case "F8":
        //            return Convert.ToInt32(Keys.F8);
        //        case "F9":
        //            return Convert.ToInt32(Keys.F9);
        //        case "F10":
        //            return Convert.ToInt32(Keys.F10);
        //        case "F11":
        //            return Convert.ToInt32(Keys.F11);
        //        case "F12":
        //            return Convert.ToInt32(Keys.F12);
        //    }
        //    return 0;
        //}
    }
}
