using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsdk
{
    /// <summary>
    /// 设置
    /// </summary>
    public class Setting
    {
        /// <summary>
        /// cef浏览器的缓存目录，每个bot都不一样的
        /// </summary>
        public static string CefCacheDir = "";

        /// <summary>
        /// flash启用
        /// </summary>
        public static bool FlashEnable = true;

        /// <summary>
        /// 谷歌浏览器的ua
        /// </summary>
        public static string CefUserAgent = "";

        /// <summary>
        /// say hello
        /// </summary>
        public static void SayHello()
        {
            Console.WriteLine("本软件litrpa为合肥立特科技有限公司自主研发，开发者为汶锐权，仿冒和破解将受到法律的制裁！");
        }


    }
}
