using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace litsdk
{
    /// <summary>
    ///  litrpa对外公开api
    /// </summary>
    public class API
    {
        /// <summary>
        /// 得到设计器中当前上下文内容
        /// </summary>
        public static Func<ActivityContext> GetDesignActivityContext;

        /// <summary>
        /// 弹出基于相关性的配置窗口
        /// </summary>
        public static Action<Activity> ShowSystemConfigForm;

        /// <summary>
        /// 退出整个程序时要做的事情
        /// </summary>
        public static Action OnExit;

        /// <summary>
        /// 设置 xpath
        /// </summary>
        public static Action<string, List<string>> SetXPath;

        /// <summary>
        /// 获取设计器中当前指定名称的组件
        /// </summary>
        public static Func<string, List<Activity>> GetDesignActivity;

        /// <summary>
        /// 当在设计器当中切换流程时,主要是关闭相关的资源
        /// </summary>
        public static Action OnChangeProject;

        /// <summary>
        /// 对BotStart进行修改和编码
        /// </summary>
        public static Func<BotStart, string> BotStartEncode;

        /// <summary>
        /// 获取引用流程
        /// </summary>
        public static Func<string, string> GetRefProject;


#if NET461
        /// <summary>
        /// 设计器或是winform主窗口
        /// </summary>
        public static Func<System.Windows.Forms.Form> GetMainForm;

        /// <summary>
        /// 弹出基于litui的指定配置窗口
        /// </summary>
        public static Action<Activity, System.Windows.Forms.UserControl> ShowConfigForm;

        /// <summary>
        /// 弹出变量设置窗体
        /// </summary>
        public static Action ShowVariableForm;

#endif
    }
}
