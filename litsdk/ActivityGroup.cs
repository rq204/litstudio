using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsdk
{
    /// <summary>
    /// 工具箱中内容的分类
    /// </summary>
    [Serializable]
    public enum ActivityGroup
    {
        /// <summary>
        ///  常规操作
        /// </summary>
        General = 0,

        /// <summary>
        /// UI自动化
        /// </summary>
        UIAutomation = 1,

        /// <summary>
        /// 浏览器
        /// </summary>
        Broswer = 2,

        /// <summary>
        /// Excel
        /// </summary>
        Excel = 3,

        /// <summary>
        /// 变量处理
        /// </summary>
        Variable = 4,

        /// <summary>
        /// 文件
        /// </summary>
        File = 5,

        /// <summary>
        /// 数据库
        /// </summary>
        Database = 6,

        /// <summary>
        /// 图像识别，人工智能
        /// </summary>
        AI = 7,

        /// <summary>
        /// 网络,如邮件收发，FTP上传下载等
        /// </summary>
        NetWork = 8,

        /// <summary>
        /// 其它操作
        /// </summary>
        Other = 10,

        /// <summary>
        /// App的打开关闭等操作
        /// </summary>
        App = 11,

        /// <summary>
        /// 内置浏览器
        /// </summary>
        CefBroswer = 20,

        /// <summary>
        /// 谷歌浏览器
        /// </summary>
        Chrome = 23,

        /// <summary>
        /// CSV相关操作
        /// </summary>
        CSV = 31,
    }
}