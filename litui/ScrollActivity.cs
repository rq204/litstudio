using litsdk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "鼠标滚动", RefFile = UIConfig.RefFile, IsFront = true, Index = 75)]
    public class ScrollActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "鼠标滚动";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        public UIConfig UIConfig = new UIConfig();

        public int ScrollLines = 10;

        public string ScrollVarName = "";

        public bool CurMousePosition = false;

        /// <summary>
        /// 向上滚动
        /// </summary>
        public bool Reverse = false;

        public override void Execute(ActivityContext context)
        {
            Point point = new Point();
            if (this.CurMousePosition)
            {
                point = FlaUI.Core.Input.Mouse.Position;
            }
            else
            {
                List<FlaUI.Core.AutomationElements.AutomationElement> automationElements = this.UIConfig.GetElements(context);
                if (automationElements.Count == 0) throw new Exception("没有找到元素");
                automationElements[0].SetForeground();

                point = this.UIConfig.GetClickablePoint(automationElements[0]);
                FlaUI.Core.Input.Mouse.MoveTo(point);
            }

            int scroll = this.ScrollLines;
            if (!string.IsNullOrEmpty(this.ScrollVarName)) scroll = context.GetInt(this.ScrollVarName);
            if (this.Reverse) scroll = 0 - scroll;
            FlaUI.Core.Input.Mouse.Scroll(scroll);
            context.WriteLog($"成功鼠标滚动{scroll}行");
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new ScrollUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (!string.IsNullOrEmpty(this.ScrollVarName) && context.ContainsInt(this.ScrollVarName)) throw new Exception($"数字变量{this.ScrollVarName}不存在");
            if (!this.CurMousePosition)
            {
                this.UIConfig.Validate(context);
            }
        }
    }
}