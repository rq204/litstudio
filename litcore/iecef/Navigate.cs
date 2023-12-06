using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    /// <summary>
    /// 打开网页
    /// </summary>
    public class Navigate : ProcessActivity
    {
        public override string Name { get; set; } = "打开网页";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        /// <summary>
        /// 要打开的网页网址
        /// </summary>
        public string Url = "";

        /// <summary>
        /// 来源页面
        /// </summary>
        public string Referer = "";

        /// <summary>
        /// 是否支持来源页面
        /// </summary>
        public static bool SupportReferer = true;

        /// <summary>
        /// 支持基本用户验证
        /// </summary>
        public static bool SupportAuthCredentials = false;

        /// <summary>
        /// 新窗口
        /// </summary>
        public bool NewWindow = false;

        /// <summary>
        /// 
        /// </summary>
        public string AcceptLanguage = "";

        /// <summary>
        /// 超时秒
        /// </summary>
        public int TimeOutSenconds = 20;

        public string UserName = "";

        public string Password = "";


        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.Url)) throw new Exception("打开的网址不能为空");
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