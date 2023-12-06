using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    /// <summary>
    /// 配置
    /// </summary>
    public class ChrSetting
    {
        /// <summary>
        /// 默认空使用系统
        /// </summary>
        public string ChromePath = "";

        /// <summary>
        /// 启动参数
        /// </summary>
        public string Arguments = "";

        /// <summary>
        /// 用户配置
        /// </summary>
        public string UserData="";

        /// <summary>
        /// 使用默认用户配置
        /// </summary>
        public bool UseDefaultUserData = false;

        /// <summary>
        /// 是外置谷歌
        /// </summary>
        public static bool IsChrome = false;

        /// <summary>
        /// 远程调试
        /// </summary>
        public bool RemoteDebugging = false;

        /// <summary>
        /// 驱动Path
        /// </summary>
        public string DriverPath = "";

        /// <summary>
        /// Crx扩展
        /// </summary>
        public string CrxVarName = "";


        public bool Mobile = false;
    }
}