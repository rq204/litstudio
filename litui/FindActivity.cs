using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "元素存在", RefFile = UIConfig.RefFile, IsFront = true, Index = 30)]
    public class FindActivity : litsdk.DecisionActivity
    {
        public override string Name { get; set; } = "元素存在";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        public UIConfig UIConfig = new UIConfig();

        /// <summary>
        /// 保存XPath的路径
        /// </summary>
        public string XpathVarName = "";

        /// <summary>
        /// 取相反值
        /// </summary>
        public bool Reverse = false;

        public override bool Execute(ActivityContext context)
        {
            bool exsit = false;
            string add = "";
            try
            {
                List<FlaUI.Core.AutomationElements.AutomationElement> automationElements = this.UIConfig.GetElements(context);
                exsit = automationElements.Count > 0;
                List<string> xpaths = new List<string>();
                if (exsit && !string.IsNullOrEmpty(this.XpathVarName))
                {
                    foreach (FlaUI.Core.AutomationElements.AutomationElement ae in automationElements) xpaths.Add(FlaUI.Core.Debug.GetXPathToElement(ae));
                    if (context.ContainsStr(this.XpathVarName))
                    {
                        context.SetVarStr(this.XpathVarName, xpaths[0]);
                        add = "成功保存XPath：" + xpaths[0];
                    }
                    else
                    {
                        context.SetVarList(this.XpathVarName, xpaths);
                        add = $"成功保存{xpaths.Count}个元素的XPath";
                    }
                }
            }
            catch
            {
            }
            string log = "元素查找结果：" + (exsit ? "存在" : "不存在");
            if (Reverse)
            {
                exsit = !exsit;
                log += "，取相反值为:" + exsit.ToString();
            }
            context.WriteLog(log);
            return exsit;
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new FindUI());
        }

        public override void Validate(ActivityContext context)
        {
            this.UIConfig.Validate(context);
            if (!string.IsNullOrEmpty(this.XpathVarName))
            {
                if (!context.ContainsList(this.XpathVarName) && !context.ContainsStr(this.XpathVarName)) throw new Exception($"不存在字符或列表变量{this.XpathVarName}，请检查");
            }
        }
    }
}