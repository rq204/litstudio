using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using litsdk;

namespace litcore.activity
{
    [ActivityInfo(Name = "字符类型",Index = 36, IsLinux = true)]
    public class StrLogicActivity : litsdk.DecisionActivity
    {
        private string name = "字符类型";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group =>  ActivityGroup.Variable;

        /// <summary>
        /// 字符类型
        /// </summary>
        public litcore.type.StrType StrType = type.StrType.Number;

        /// <summary>
        /// 正则内容
        /// </summary>
        public string RegexPattern = "";

        /// <summary>
        /// 变量名
        /// </summary>
        public string VarName = "";

        public override bool Execute(ActivityContext context)
        {
            string text = context.GetStr(this.VarName);
            switch (this.StrType)
            {
                case type.StrType.Number:
                    return System.Text.RegularExpressions.Regex.IsMatch(text, "^\\d+$");
                case type.StrType.Phone:
                    return Regex.IsMatch(text, @"^(?:\+?86)?1(?:3\d{3}|5[^4\D]\d{2}|8\d{3}|7(?:[01356789]\d{2}|4(?:0\d|1[0-2]|9\d))|9[189]\d{2}|6[567]\d{2}|4(?:[14]0\d{3}|[68]\d{4}|[579]\d{2}))\d{6}$");//https://www.cnblogs.com/hzzjj/p/10665264.html
                case type.StrType.Email:
                    return Regex.IsMatch(text, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", RegexOptions.IgnoreCase);
                case type.StrType.DateTime:
                    DateTime dt;
                    return DateTime.TryParse(text, out dt);
                case type.StrType.Letter:
                    return System.Text.RegularExpressions.Regex.IsMatch(text, "^[a-zA-Z]+?$");
                case type.StrType.Chinese:
                    return Regex.IsMatch(text, @"^[\u4e00-\u9fa5]+$", RegexOptions.IgnoreCase);
                case type.StrType.Url:
                    return Regex.IsMatch(text, @"^(((file|gopher|news|nntp|telnet|http|ftp|https|ftps|sftp)://)|(www\.))+(([a-zA-Z0-9\._-]+\.[a-zA-Z]{2,6})|([0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}))(/[a-zA-Z0-9\&amp,;%_\./-~-]*)?$", RegexOptions.IgnoreCase);
                case type.StrType.IP:
                    return Regex.IsMatch(text, @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$", RegexOptions.IgnoreCase);
                case type.StrType.Regex:
                    return System.Text.RegularExpressions.Regex.IsMatch(text,this.RegexPattern);
            }
            return true;
        }


        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (!context.ContainsStr(this.VarName)) throw new Exception($"不存在字符变量{this.VarName}");
            if (this.StrType == type.StrType.Regex && string.IsNullOrEmpty(this.RegexPattern)) throw new Exception("正则表达式不能为空");
        }
    }
}
