using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    public class Exist : litsdk.DecisionActivity
    {
        public override string Name { get; set; } = "元素存在";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        /// <summary>
        ///xpath
        /// </summary>
        public string XPathStr { get; set; }

        /// <summary>
        /// 框架名称
        /// </summary>
        public string FrameName { get; set; }

        public string XPosVarName { get; set; }

        public string YPosVarName { get; set; }

        public override bool Execute(ActivityContext context)
        {
            return true;
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.XPathStr)) throw new Exception("XPath不能为空");
        }
    }
}
