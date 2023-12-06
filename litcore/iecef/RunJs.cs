using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    /// <summary>
    /// 执行js
    /// </summary>
    public class RunJs : ProcessActivity
    {
        public override string Name { get; set; } = "执行Js";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.JsCode)) throw new Exception("Js代码不能为空");
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Execute(ActivityContext context)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public string JsCode = "";

        /// <summary>
        /// 框架名
        /// </summary>
        public string FrameName = "";

        /// <summary>
        /// 保存执行结果至变量
        /// </summary>
        public string SaveVarName = "";

        /// <summary>
        /// 支持写入返回结果
        /// </summary>
        public static bool SupportSaveJsReturn = true;

        /// <summary>
        /// 获取frame的方法
        /// </summary>
        public static string GetFrameJs = Resource.getframe;
    }
}
