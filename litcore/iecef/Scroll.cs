using litcore.ictype;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    public class Scroll : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "滚动条移动";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        /// <summary>
        /// 滚动方式
        /// </summary>
        public ScrollType ScrollType = ScrollType.Botton;

        /// <summary>
        ///  滚动像素
        /// </summary>
        public string ScrollBy = "";

        /// <summary>
        /// 元素位置
        /// </summary>
        public string XpathStr = "";

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            ///不用做什么
        }

        public override void Execute(ActivityContext context)
        {
            if (this.ScrollType == ScrollType.DownBy || this.ScrollType == ScrollType.UpBy)
            {
                if (string.IsNullOrEmpty(this.ScrollBy)) throw new Exception("滚动像素数不能为空");
            }
        }
    }
}