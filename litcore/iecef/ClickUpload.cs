using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    public class ClickUpload : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "点击上传";

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
        /// 文件保存路径变量
        /// </summary>
        public string FileVarName { get; set; }

        /// <summary>
        /// 上传超时秒
        /// </summary>
        public int TimeOutSecond { get; set; } = 1800;


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
            if (!string.IsNullOrEmpty(this.FileVarName) && !context.ContainsStr(this.FileVarName)&&!context.ContainsList(this.FileVarName)) throw new Exception("不存在y文件地址变量：" + this.FileVarName);
        }
    }
}
