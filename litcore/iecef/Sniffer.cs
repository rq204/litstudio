using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{

    public class Sniffer : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "缓存数据";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        /// <summary>
        /// 网址
        /// </summary>
        public string Urls = "";

        /// <summary>
        /// 使用正则
        /// </summary>
        public bool UseRegex = false;

        /// <summary>
        /// 保存至变量
        /// </summary>
        public string DataVarName = "";

        /// <summary>
        /// 保存为文件
        /// </summary>
        public bool DataIsFile = false;

        /// <summary>
        /// 字符的编码
        /// </summary>
        public string Encoding = "UTF-8";

        /// <summary>
        /// 是否网址匹配
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public bool IsMatch(string url, List<string> urllist)
        {
            foreach (string u in urllist)
            {
                if (this.UseRegex)
                {
                    return System.Text.RegularExpressions.Regex.IsMatch(url, u, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                }
                else
                {
                    return url.Contains(u);
                }
            }
            return false;
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.Urls)) throw new Exception("匹配规则不能为空");
            if (string.IsNullOrEmpty(this.DataVarName)) throw new Exception("保存变量不能为空");
            if (!context.ContainsTable(this.DataVarName)) throw new Exception($"不存在表格变量 {this.DataVarName}");
        }

        public override void Execute(ActivityContext context)
        {
            
        }
    }
}
