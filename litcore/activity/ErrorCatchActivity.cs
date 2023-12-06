using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litcore.activity
{
    [litsdk.ActivityInfo(Name ="异常捕获", IsLinux = true)]
    public sealed class ErrorCatchActivity : litsdk.DecisionActivity
    {
        public override string Name { set { } get => "异常捕获"; }

        public override ActivityGroup Group => ActivityGroup.General;

        public override bool Execute(ActivityContext context)
        {
            bool flag = !string.IsNullOrEmpty(context.LastError);
            string add = string.IsNullOrEmpty(context.LastError) ? "" : "，错误内容：" + context.LastError;
            context.WriteLog($"上一步流程异常检查结果是{flag}{add}");
            context.LastError = null;
            return flag;
        }

        public override void ShowConfig()
        {

        }

        public override void Validate(ActivityContext context) { }
    }
}
