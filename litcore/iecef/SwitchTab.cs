using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    /// <summary>
    /// 新建切换关闭标签页
    /// </summary>
    public class SwitchTab : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "标签页切换";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        /// <summary>
        /// 操作类型
        /// </summary>
        public ictype.SwitchTabType SwitchTabType = ictype.SwitchTabType.Create;

        /// <summary>
        /// 标签页名称
        /// </summary>
        public string TabName = "";

        /// <summary>
        /// 是否使用正则
        /// </summary>
        public bool UseRegex = false;

        /// <summary>
        /// 是否默认
        /// </summary>
        public bool DefaultTab = false;

        /// <summary>
        /// 默认页的名称
        /// </summary>
        public static string DefaultTabName = System.Threading.Thread.CurrentThread.CurrentCulture.Name == "zh-TW" ? "Index" : "默认页";

        /// <summary>
        /// 显示出来的浏览器主窗口名称
        /// </summary>
        public static string BrowserFormName = System.Threading.Thread.CurrentThread.CurrentCulture.Name == "zh-TW" ? "Browser" : "内置浏览器";

        /// <summary>
        /// 最近创建的标签页
        /// </summary>
        public bool LastTab = false;

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