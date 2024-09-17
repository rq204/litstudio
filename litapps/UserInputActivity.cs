using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litapps
{
    [litsdk.ActivityInfo(Name = "用户输入", IsWinForm = true, IsFront = true)]
    public class UserInputActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "用户输入";

        public override ActivityGroup Group => ActivityGroup.Other;

        /// <summary>
        /// 窗体标题
        /// </summary>
        public string FormTitle = "";

        /// <summary>
        /// 可关闭窗口
        /// </summary>
        public bool CanCloseForm = false;

        /// <summary>
        /// 超时关闭
        /// </summary>
        public bool TimeOutClose = false;

        /// <summary>
        /// 超时时间秒
        /// </summary>
        public int TimeOutSenconds = 30;

        /// <summary>
        /// 配置
        /// </summary>
        public List<UserInputConfig> Configs = new List<UserInputConfig>();

        public override void Execute(ActivityContext context)
        {
            FrmUserInput userInput = new FrmUserInput(this, context);
            litsdk.API.GetMainForm().Invoke((EventHandler)delegate
            {
                userInput.ShowDialog(litsdk.API.GetMainForm());
            });
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new UserInputUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.FormTitle)) throw new Exception("窗口标题不能为空");
            if (Configs.Count == 0) throw new Exception("用户输入配置不能为空");
            foreach (UserInputConfig config in this.Configs)
            {
                switch (config.Type)
                {
                    case UserInputType.TextBox:
                    case UserInputType.MulTextBox:
                        if (!context.ContainsStr(config.ValueVarName)) throw new Exception("找不到保存字符变量：" + config.ValueVarName);
                        if (!string.IsNullOrEmpty(config.DefaultVarName) && !context.ContainsStr(config.DefaultVarName)) throw new Exception("找不到默认字符变量：" + config.DefaultVarName);
                        break;
                    case UserInputType.ComboBox:
                    case UserInputType.RadioButton:
                        if (!context.ContainsStr(config.ValueVarName)) throw new Exception("找不到保存字符变量：" + config.ValueVarName);
                        if (string.IsNullOrEmpty(config.DefaultVarName) || !context.ContainsList(config.DefaultVarName)) throw new Exception("找不到默认列表变量：" + config.DefaultVarName);
                        break;
                    case UserInputType.CheckBox:
                        if (string.IsNullOrEmpty(config.DefaultVarName)) throw new Exception("默认变量不能为空：" + config.DefaultVarName);
                        if (string.IsNullOrEmpty(config.ValueVarName)) throw new Exception("保存变量不能为空：" + config.ValueVarName);
                        if (context.ContainsList(config.DefaultVarName) && !context.ContainsList(config.ValueVarName)) throw new Exception("默认值为列表变量时，保存值也必须为列表变量");
                        if (context.ContainsStr(config.DefaultVarName) && !context.ContainsStr(config.ValueVarName)) throw new Exception("默认值为字符变量时，保存值也必须字符变量");
                        break;
                    case UserInputType.NumericUpDwon:
                        if (!context.ContainsInt(config.ValueVarName)) throw new Exception("找不到保存数字变量：" + config.ValueVarName);
                        if (!string.IsNullOrEmpty(config.DefaultVarName) && !context.ContainsInt(config.DefaultVarName)) throw new Exception("找不到默认数字变量：" + config.DefaultVarName);
                        break;
                }

            }
        }
    }
}
