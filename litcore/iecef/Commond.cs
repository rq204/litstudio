using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    /// <summary>
    /// 单条命令的执行，go back stop refresh
    /// </summary>
    public class Commond : ProcessActivity
    {
        public override string Name { get; set; } = "后退刷新";

        /// <summary>
        /// 命令类型
        /// </summary>
        public ictype.CommondType CmdType { get; set; }

        /// <summary>
        /// 标签页名称
        /// </summary>
        public string TabName { get; set; }

        public override ActivityGroup Group => ActivityGroup.Broswer;

        public override void Execute(ActivityContext context)
        {

        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {

        }
    }
}