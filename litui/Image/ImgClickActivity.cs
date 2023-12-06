using litsdk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "点击图像", IsFront = true, IsWinForm = false, RefFile = UIConfig.RefFile, Index = 85)]
    public class ImgClickActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "点击图像";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        public ImgConfig ImgConfig = new ImgConfig();

        public FlaUI.Core.Input.MouseButton MouseButton = FlaUI.Core.Input.MouseButton.Left;

        /// <summary>
        /// 点击类型
        /// </summary>
        public ClickType ClickType = ClickType.Click;


        public override void Execute(ActivityContext context)
        {
            Point point = new Point();

            string result = this.ImgConfig.GetClickablePoint(ref point);

            if (result == null)
            {
                FlaUI.Core.Input.Mouse.MoveTo(point);

                switch (this.ClickType)
                {
                    case ClickType.Click:
                        FlaUI.Core.Input.Mouse.Click(this.MouseButton);
                        context.WriteLog($"图片点击成功，点击位置X{point.X},Y{point.Y}");
                        break;
                    case ClickType.DoubleClick:
                        FlaUI.Core.Input.Mouse.DoubleClick(this.MouseButton);
                        context.WriteLog($"图片双击成功，点击位置X{point.X},Y{point.Y}");
                        break;
                    case ClickType.Down:
                        FlaUI.Core.Input.Mouse.Down(this.MouseButton);
                        context.WriteLog($"图片按下成功，点击位置X{point.X},Y{point.Y}");
                        break;
                    case ClickType.Up:
                        FlaUI.Core.Input.Mouse.Up(this.MouseButton);
                        context.WriteLog($"图片弹起成功，点击位置X{point.X},Y{point.Y}");
                        break;
                    case ClickType.Hover:
                        break;
                }
            }
            else
            {
                throw new Exception("没有找到元素：" + result);
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new ImgClickUI());
        }

        public override void Validate(ActivityContext context)
        {
            this.ImgConfig.Validate(context);
        }
    }
}