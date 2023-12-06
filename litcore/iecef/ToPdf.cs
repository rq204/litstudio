using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    public class ToPdf : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "生成PDF";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        public string PdfPath = "";

        /// <summary>
        /// 页面缩放
        /// </summary>
        public int ScaleFactor = 100;

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(PdfPath)) throw new Exception("pdf路径不能为空");
        }

        public override void Execute(ActivityContext context)
        {
        }
    }
}
