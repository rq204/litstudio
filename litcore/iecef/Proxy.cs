using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    public class Proxy : ProcessActivity
    {
        public override string Name { get; set; } = "设置代理";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        /// <summary>
        /// 代理设置
        /// </summary>
        public string ProxySetting = "";

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {

        }

        public override void Execute(ActivityContext context)
        {
      
        }
    }
}
