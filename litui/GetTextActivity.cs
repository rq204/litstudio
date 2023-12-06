using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "提取数据", RefFile = UIConfig.RefFile, IsFront = true, Index = 35)]
    public class GetTextActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "提取数据";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        public UIConfig UIConfig = new UIConfig();

        public bool NoFindEmpty = false;

        /// <summary>
        /// 属性名
        /// </summary>
        //public string AttName = "";

        public string SaveVarName = "";


        public override void Execute(ActivityContext context)
        {
            List<FlaUI.Core.AutomationElements.AutomationElement> automationElements = this.UIConfig.GetElements(context);
            if (automationElements.Count == 0)
            {
                if (NoFindEmpty)
                {
                    if (context.ContainsStr(SaveVarName))
                    {
                        context.SetVarStr(this.SaveVarName, "");
                        context.WriteLog($"没有发现元素，设置{SaveVarName}变量值为空");
                        return;
                    }
                    else if (context.ContainsList(this.SaveVarName))
                    {
                        context.SetVarList(this.SaveVarName, new List<string>());
                        context.WriteLog($"没有发现元素，设置{SaveVarName}变量值为空");
                        return;
                    }
                }
                else
                {
                    throw new Exception("没有找到元素");
                }
            }
            List<string> results = new List<string>();

            if (context.ContainsStr(SaveVarName))
            {
                string data = UIConfig.GetText(automationElements[0]);
                context.SetVarStr(this.SaveVarName, data);
                context.WriteLog($"成功获取元素数据，长度为{data.Length}");
            }
            else if (context.ContainsList(this.SaveVarName))
            {
                foreach (FlaUI.Core.AutomationElements.AutomationElement aue in automationElements)
                {
                    results.Add(UIConfig.GetText(aue));
                }
                context.SetVarList(this.SaveVarName, results);
                context.WriteLog($"成功获取{results.Count}个元素数据");
            }
        }



        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new GetTextUI());
        }

        public override void Validate(ActivityContext context)
        {
            this.UIConfig.Validate(context);
            if (string.IsNullOrEmpty(this.SaveVarName)) throw new Exception("保存变量名不能为空");
            if (!context.Contains(this.SaveVarName)) throw new Exception($"保存变量名不存在：{this.SaveVarName}");
        }
    }
}