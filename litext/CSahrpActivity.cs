using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litext
{
    public class CSahrpActivity : litsdk.ProcessActivity
    {
        private string name = "执行C#代码";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Snippet;

        public override bool IsFront => false;

        public override bool IsWinForm => false;

        public override void ShowConfig()
        {
            JsUI jsUI = new JsUI();
            litsdk.API.ShowConfigForm(this, jsUI);
        }

        public override void Validate(ActivityContext context)
        {
            if (VarNames.Count == 0)
            {
                throw new Exception("操作的变量不能为空");
            }
            foreach (string v in this.VarNames)
            {
                if (!context.Contains(v))
                {
                    throw new Exception("不存在变量:" + v);
                }
            }
            if (string.IsNullOrEmpty(this.Code))
            {
                throw new Exception("运行代码不能为空");
            }
        }

        public override void Execute(ActivityContext context)
        {
            //string
            //string json = "";
            //var obj3 = JSON.parse(str);
        }

        public void TestExecute(ActivityContext context)
        {

        }

        /// <summary>
        /// 要执行的代码
        /// </summary>
        public string Code = "";

        /// <summary>
        /// 要操作的变量
        /// </summary>
        public List<string> VarNames = new List<string>();
    }
}