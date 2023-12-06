using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using litcore.type;
using litsdk;


namespace litcore.activity
{
    [ActivityInfo(Name = "加减乘除",Index = 24, IsLinux = true)]
    /// <summary>
    /// 数字操作，分为重置，增加，乘以
    /// </summary>
    public class IntActivity : litsdk.ProcessActivity
    {
        /// <summary>
        /// 数字操作类型，有重置，乘以，增加
        /// </summary>

        public IntType IntType = IntType.Add;

        /// <summary>
        /// 要操作的变量
        /// </summary>

        public string IntVarName = "";

        /// <summary>
        /// 操作的值大小
        /// </summary>

        public int SetValue = 1;

        /// <summary>
        /// 操作变量值
        /// </summary>
        public string SetVarName = "";

        /// <summary>
        /// 保存至变量
        /// </summary>
        public string SaveVarMame = "";

        public override void Execute(ActivityContext context)
        {
            string msg = "";
            int value = context.GetInt(this.IntVarName);
            int setvalue = this.SetValue;
            if (!string.IsNullOrEmpty(this.SetVarName))
            {
                setvalue = context.GetInt(this.SetVarName);
            }

            try
            {
                switch (this.IntType)
                {
                    case IntType.Add:
                        value += setvalue;
                        msg = string.Format("数字{2}增加{0},新值为{1}", setvalue, value, IntVarName);
                        break;
                    case IntType.Multiplied:
                        value *= setvalue;
                        msg = string.Format("数字{2}乘以{0},新值为{1}", setvalue, value, IntVarName);
                        break;
                    case IntType.Minus:
                        value -= setvalue;
                        msg = string.Format("数字{0}减去{2}为{1}", IntVarName, value, setvalue);
                        break;
                    case IntType.Round:
                        value = (int)Math.Round(value / (setvalue * 1.0), 0);
                        msg = string.Format("数字{0}除以{1}四舍五入为{2}", IntVarName, setvalue, value);
                        break;
                    case IntType.RoundUp:
                        value = (int)Math.Ceiling(value / (setvalue * 1.0));
                        msg = string.Format("数字{0}除以{1}向上取位为{2}", IntVarName, setvalue, value);
                        break;
                    case IntType.RoundDown:
                        value = (int)Math.Floor(value / (setvalue * 1.0));
                        msg = string.Format("数字{0}除以{1}向下取位为{2}", IntVarName, setvalue, value);
                        break;
                }
            }
            catch (Exception ex)
            {
                context.WriteLog("加减乘除中发生异常：" + ex.Message);
            }
            context.SetVarInt(this.SaveVarMame, value);
            context.WriteLog(msg);
        }

        public override void Validate(ActivityContext context)
        {
            //查看变量是否存在
            if (!context.ContainsInt(this.IntVarName))
            {
                throw new Exception("数字变量名不存在:" + this.IntVarName);
            }
            //乘法中，不能用0
            if (this.IntType == IntType.Multiplied && this.SetValue == 0 && string.IsNullOrEmpty(this.SetVarName))
            {
                throw new Exception("数字变量不能为0:" + this.IntVarName);
            }
            if (string.IsNullOrEmpty(this.SaveVarMame) || !context.ContainsInt(this.SaveVarMame))
            {
                throw new Exception("保存变量名不能为空或是不存在：" + this.SaveVarMame);
            }
            if (!string.IsNullOrEmpty(this.SetVarName) && !context.ContainsInt(this.SetVarName))
            {
                throw new Exception("操作数字变量名不存在：" + this.SetVarName);
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override ActivityGroup Group => ActivityGroup.Variable;


        private string name = "加减乘除";
        public override string Name { set => name = value; get => name; }
    }
}