using FlaUI.Core.Input;
using litsdk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "鼠标点击", RefFile = UIConfig.RefFile, IsFront = true, Index = 5)]
    public class ClickActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "鼠标点击";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        public UIConfig UIConfig = new UIConfig();

        public FlaUI.Core.Input.MouseButton MouseButton = FlaUI.Core.Input.MouseButton.Left;

        /// <summary>
        /// 点击类型
        /// </summary>
        public ClickType ClickType = ClickType.Click;

        /// <summary>
        /// 使用自动化接口点击
        /// </summary>
        public bool InterFaceClick = true;

        /// <summary>
        /// 模拟人工点击
        /// </summary>
        //public bool SimulationClick = true;

        /// <summary>
        /// 当前光标位置
        /// </summary>
        public bool CurMousePosition = false;

        public override void Execute(ActivityContext context)
        {
            Point point = new Point();
            FlaUI.Core.AutomationElements.AutomationElement find = null;
            if (!CurMousePosition)
            {
                List<FlaUI.Core.AutomationElements.AutomationElement> automationElements = this.UIConfig.GetElements(context);
                if (automationElements.Count == 0) throw new Exception("没有找到元素");

                find = automationElements[0];
                if (!this.InterFaceClick)
                {
                    find.SetForeground();
                    point = this.UIConfig.GetClickablePoint(find);
                    if (point.X >= 0 && point.Y >= 0)
                    {
                        try
                        {
                            FlaUI.Core.Input.Mouse.MoveTo(point);
                        }
                        catch
                        {
                            SetCursorPos(point.X, point.Y);
                        }
                    }
                    else
                    {
                        throw new Exception("没有找到可点击的位置");
                    }
                }
            }
            else
            {
                point = Mouse.Position;
            }

            string keyname = "左键";
            if (this.MouseButton == MouseButton.Right) keyname = "右键";
            if (this.MouseButton == MouseButton.Middle) keyname = "中键";

            bool interClickFail = false;

            if (InterFaceClick && !CurMousePosition)
            {
                try
                {
                    if (this.ClickType == ClickType.Click)
                    {
                        switch (this.MouseButton)
                        {
                            case MouseButton.Left:
                                find.Click();
                                context.WriteLog($"鼠标{keyname}自动化接口点击成功");
                                break;
                            case MouseButton.Right:
                                find.RightClick();
                                context.WriteLog($"鼠标{keyname}自动化接口右键点击成功");
                                break;
                        }
                    }
                    else if (this.ClickType == ClickType.DoubleClick)
                    {
                        switch (this.MouseButton)
                        {
                            case MouseButton.Left:
                                find.DoubleClick();
                                context.WriteLog($"鼠标{keyname}自动化接口双击成功");
                                break;
                            case MouseButton.Right:
                                find.RightDoubleClick();
                                context.WriteLog($"鼠标{keyname}自动化接口右键双击成功");
                                break;
                        }
                    }
                }
                catch(FlaUI.Core.Exceptions.NoClickablePointException)
                {
                    point = this.UIConfig.GetClickablePoint(find);
                    try
                    {
                        FlaUI.Core.Input.Mouse.MoveTo(point);
                    }
                    catch
                    {
                        SetCursorPos(point.X, point.Y);
                    }
                    interClickFail = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (!this.InterFaceClick || this.CurMousePosition || interClickFail)
            {
                switch (this.ClickType)
                {
                    case ClickType.Click:
                        FlaUI.Core.Input.Mouse.Click(this.MouseButton);
                        context.WriteLog($"鼠标{keyname}点击成功，点击位置X{point.X},Y{point.Y}");
                        break;
                    case ClickType.DoubleClick:
                        FlaUI.Core.Input.Mouse.DoubleClick(this.MouseButton);
                        context.WriteLog($"鼠标{keyname}双击成功，点击位置X{point.X},Y{point.Y}");
                        break;
                    case ClickType.Down:
                        FlaUI.Core.Input.Mouse.Down(this.MouseButton);
                        context.WriteLog($"鼠标{keyname}按下成功，点击位置X{point.X},Y{point.Y}");
                        break;
                    case ClickType.Up:
                        FlaUI.Core.Input.Mouse.Up(this.MouseButton);
                        context.WriteLog($"鼠标{keyname}弹起成功，点击位置X{point.X},Y{point.Y}");
                        break;
                    case ClickType.Hover:
                        context.WriteLog($"鼠标悬浮成功，位置X{point.X},Y{point.Y}");
                        break;
                }
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SetCursorPos(int x, int y);

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new ClickUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (!CurMousePosition)
            {
                this.UIConfig.Validate(context);
            }
        }
    }
}