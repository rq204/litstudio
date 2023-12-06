using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.activity
{
    [ActivityInfo(Name = "自定义日志", IsLinux = true, Index = 999)]
    public class LogActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "自定义日志";

        public override ActivityGroup Group => ActivityGroup.General;

        public string LogFormat = "";

        public override void Execute(ActivityContext context)
        {
            string log = context.ReplaceVar(this.LogFormat);
            context.WriteLog(log);
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.LogFormat)) throw new Exception("日志内容不能为空");
        }
    }
}
