using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litchrome
{
    [litsdk.ActivityInfo(Name = "执行Js", IsFront = false, IsWinForm = true, RefFile = ChrLoad.RefFile, Index = 24)]
    public class ChrRunJs : litcore.iecef.RunJs
    {
        public override void Execute(ActivityContext context)
        {
            ChrLoad.LoadChromeSetting(context);

            string code = context.ReplaceVar(this.JsCode);

            string data = "";
            try
            {
                var result = ChrLoad.Driver.ExecuteScript(code);
                if (result != null) data = result.ToString();
            }
            catch
            {
                context.WriteLog("执行JS代码5秒超时");
            }

            if (string.IsNullOrEmpty(this.SaveVarName))
            {
                context.WriteLog("成功执行JS代码");
            }
            else
            {
                context.SetVarStr(this.SaveVarName, data);
                context.WriteLog($"成功执行JS代码并保存结果至变量{this.SaveVarName}，返回结果长度{data.Length}");
            }
            System.Threading.Thread.Sleep(200);
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            base.Validate(context);
        }

        public override ActivityGroup Group => ActivityGroup.Chrome;
    }
}