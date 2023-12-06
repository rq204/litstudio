using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    /// <summary>
    /// 元素等待
    /// </summary>
    public class Wait : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "元素等待";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        /// <summary>
        /// 等待出现，反之为消失
        /// </summary>
        public bool WaitAppear = true;

        /// <summary>
        ///xpath
        /// </summary>
        public string XPathStr { get; set; }

        /// <summary>
        /// 框架名称
        /// </summary>
        public string FrameName { get; set; }

        /// <summary>
        /// 等待框架
        /// </summary>
        public bool WaitIframe { get; set; }

        /// <summary>
        /// 等待毫秒
        /// </summary>
        public int TimeOutMillisecond = 10000;

        protected DateTime lastLogTime = DateTime.Now;

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.XPathStr)) throw new Exception("XPath不能为空");
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Execute(ActivityContext context)
        {

        }
    }
}
