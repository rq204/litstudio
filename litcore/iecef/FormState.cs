using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    public class FormState : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "窗口控制";


        public bool Show = true;


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
