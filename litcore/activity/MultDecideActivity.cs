using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.activity
{
    [litsdk.ActivityInfo(Name = "多值比较", IsLinux = true, Index = 99, InSequence = true)]
    /// <summary>
    /// 多值比较
    /// </summary>
    public class MultDecideActivity : litsdk.DecisionActivity
    {
        public override string Name { get; set; } = "多值比较";

        public override ActivityGroup Group => ActivityGroup.Variable;

        /// <summary>
        /// 变量值
        /// </summary>
        public List<string> VarNames = new List<string>();

        /// <summary>
        /// 所有值不为空
        /// </summary>
        public type.MultDecideType MultDecideType = type.MultDecideType.AllIsNotEmpty;


        public override bool Execute(ActivityContext context)
        {
            bool result = false;
            bool hasempty = false;
            bool hasfill = false;

            foreach (string name in this.VarNames)
            {
                litsdk.Variable variable = context.Variables.Find((f) => f.Name == name);
                switch (variable.VariableType)
                {
                    case VariableType.String:
                        string txt = context.GetStr(name);
                        if (string.IsNullOrEmpty(txt))
                        {
                            hasempty = true;
                        }
                        else
                        {
                            hasfill = true;
                        }
                        break;
                    case VariableType.Int:
                        int num = context.GetInt(name);
                        if (num <= 0)
                        {
                            hasempty = true;
                        }
                        else
                        {
                            hasfill = true;
                        }
                        break;
                    case VariableType.List:
                        List<string> lst = context.GetList(name);
                        if (lst.Count == 0)
                        {
                            hasempty = true;
                        }
                        else
                        {
                            hasfill = true;
                        }
                        break;
                    case VariableType.Table:
                        System.Data.DataTable table = context.GetTable(name);
                        if (table == null || table.Rows.Count == 0)
                        {
                            hasempty = true;
                        }
                        else
                        {
                            hasfill = true;
                        }
                        break;

                }
            }

            switch (this.MultDecideType)
            {
                case type.MultDecideType.AllIsNotEmpty:
                    result = !hasempty && hasfill;
                    break;
                case type.MultDecideType.OneMoreIsEmpty:
                    result = hasempty && hasfill;
                    break;
                case type.MultDecideType.AllIsEmpty:
                    result = hasempty && !hasfill;
                    break;
            }

            string log = $"多值比较结果为 {result}";

            context.WriteLog(log);
            return result;
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (VarNames.Count <= 1) throw new Exception("变量数必须大于1");
            foreach (string s in VarNames)
            {
                if (!context.Contains(s)) throw new Exception("不存在变量名：" + s);
            }
        }
    }
}