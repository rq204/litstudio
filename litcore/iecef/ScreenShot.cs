using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    /// <summary>
    /// 网页截图，可以分为全部截图，
    /// </summary>
    public class ScreenShot : ProcessActivity
    {
        public override string Name { get; set; } = "网页截图";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        public litcore.ictype.ScreenShotType ScreenShotType = ictype.ScreenShotType.XPath;

        /// <summary>
        /// 全屏截图支持
        /// </summary>
        public static bool FullSupport = true;

        /// <summary>
        /// Xpath
        /// </summary>
        public string XPathStr = "";

        /// <summary>
        /// 框架名称
        /// </summary>
        public string FrameName = "";

        /// <summary>
        /// 图片格式，这里写后缀
        /// </summary>
        public string ImageFormat = "bmp";

        /// <summary>
        /// 保存地址
        /// </summary>
        public string SaveFilePathVarName = "";

        /// <summary>
        /// 是否使用系统临时文件名保存
        /// </summary>
        public bool UseTempPath = false;

        /// <summary>
        /// 存入剪切板
        /// </summary>
        public bool SaveToClipboard = false;

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.SaveFilePathVarName)) throw new Exception("图片保存变量不能为空");
            if (!this.SaveToClipboard)
            {
                if (!context.ContainsStr(this.SaveFilePathVarName))
                {
                    throw new Exception("图片保存字符变量不存在，请检查：" + this.SaveFilePathVarName);
                }
            }
           
            if(this.ScreenShotType== ictype.ScreenShotType.XPath && string.IsNullOrEmpty(this.XPathStr))
            {
                throw new Exception("当前使用了元素截图，但没有设置XPath，请检查");
            }
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
