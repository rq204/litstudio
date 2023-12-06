using litcore.type;
using litsdk;
using System;

namespace litcore.activity
{
    /// <summary>
    /// 循环
    /// </summary>
    public sealed class LoopStartActivity : Activity
    {
        private string name = "循环";
        public override string Name { set { name = value; } get => name; }

        public override ActivityGroup Group =>  ActivityGroup.General;

        public void Execute(ActivityContext context)
        {
            
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            //循环数字变量是否存在，list是否存在，新变量存在否
            if (this.LoopType == LoopType.List)
            {
                if (!context.ContainsList(this.ListVarName))
                {
                    throw new Exception("不存在 列表 变量:" + this.ListVarName);
                }
                if (!context.ContainsStr(this.SaveVarName))
                {
                    throw new Exception("不存在 字符 变量:" + this.SaveVarName);
                }
            }
            else if(this.LoopType== LoopType.Table)
            {
                if (!context.ContainsTable(this.TableVarName))
                {
                    throw new Exception("不存在 表格 变量:" + this.TableVarName);
                }
            }
            else
            {
                if (this.LoopType == LoopType.IntVar)
                {
                    if (!context.ContainsInt(this.IntVarName))
                    {
                        throw new Exception("不存在 列表 变量:" + this.IntVarName);
                    }
                }
                if (!string.IsNullOrEmpty(this.SaveVarName) && !context.ContainsInt(this.SaveVarName))
                {
                    throw new Exception("不存在 数字 变量:" + this.IntVarName);
                }
            }
        }

        /// <summary>
        /// 循环类型
        /// </summary>
        public LoopType LoopType = LoopType.List;

        /// <summary>
        /// 循环指定次数
        /// </summary>
        public int Number = 10;

        /// <summary>
        /// 循环指定list变量名
        /// </summary>
        public string ListVarName = "";

        /// <summary>
        /// list循环中保存变量到哪个变量
        /// </summary>
        public string SaveVarName = "";

        /// <summary>
        /// 循环指定数字变量
        /// </summary>
        public string IntVarName = "";

        /// <summary>
        /// 循环指定Table变量名
        /// </summary>
        public string TableVarName = "";
    }
}
