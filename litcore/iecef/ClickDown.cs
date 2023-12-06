using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    public class ClickDown : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "点击下载";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        /// <summary>
        ///xpath
        /// </summary>
        public string XPathStr { get; set; }

        /// <summary>
        /// 框架名称
        /// </summary>
        public string FrameName { get; set; }

        /// <summary>
        /// 文件保存路径
        /// </summary>
        public string SavePath { get; set; }

        /// <summary>
        /// 下载超时秒
        /// </summary>
        public int TimeOutSecond { get; set; } = 1800;

        /// <summary>
        /// 地址存入
        /// </summary>
        public string SaveVarName { get; set; }

        public override void Execute(ActivityContext context)
        {

        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.XPathStr)) throw new Exception("XPath不能为空");
            if (string.IsNullOrEmpty(this.SavePath)) throw new Exception("文件保存路径不能为空");
            if (!string.IsNullOrEmpty(this.SaveVarName) && !context.ContainsStr(this.SaveVarName)) throw new Exception("不存在地址存入字符变量：" + this.SaveVarName);
        }
    }
}
