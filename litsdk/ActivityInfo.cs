using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsdk
{
    /// <summary>
    /// 作者及打包信息
    /// </summary>
    public class ActivityInfo : Attribute
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name = "";

        /// <summary>
        /// 英文名
        /// </summary>
        public string NameEN = "";

        /// <summary>
        /// 作者
        /// </summary>
        public string Author = "litrpa";

        /// <summary>
        /// 网站
        /// </summary>
        public string WebSite = "http://www.litrpa.com";

        /// <summary>
        /// 引用文件
        /// </summary>
        public string RefFile = "";

        /// <summary>
        ///  描述
        /// </summary>
        public string Description = "";

        /// <summary>
        /// 英文描述
        /// </summary>
        public string DescriptionEN = "";

        /// <summary>
        /// 搜索字段
        /// </summary>
        public string Search = "";

        /// <summary>
        /// 英文搜索字段
        /// </summary>
        public string SearchEN = "";

        /// <summary>
        /// 是否会产生界面独占
        /// 有则不能同时运行多个此类项目
        /// </summary>
        public bool IsFront = false;

        /// <summary>
        /// 是否要windows消息，如ie和chrome等操作需要界面
        /// </summary>
        public bool IsWinForm = false;

        /// <summary>
        /// 是否linux的
        /// </summary>
        public bool IsLinux = false;

        /// <summary>
        /// 活动名称
        /// </summary>
        public string ActivityFullName = "";

        /// <summary>
        /// 索引，位置排序使用
        /// </summary>
        public int Index = 0;

        /// <summary>
        /// 在序列中显示
        /// </summary>
        public bool InSequence = true;
    }
}
