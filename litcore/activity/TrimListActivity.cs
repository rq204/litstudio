using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using litsdk;

namespace litcore.activity
{
    [ActivityInfo(Name = "列表操作",Index = 20, IsLinux = true)]
    /// <summary>
    /// 对list的二次处理，如去除空白list
    /// </summary>
    public class TrimListActivity : litsdk.ProcessActivity
    {
        /// <summary>
        /// 原要处理的变量名
        /// </summary>
        public string ListVarName = "";

        /// <summary>
        /// 去掉为空的数据
        /// </summary>
        public bool TrimEmpty = false;

        /// <summary>
        /// 去掉重复值
        /// </summary>
        public bool TrimRepeat = false;

        /// <summary>
        /// 升序
        /// </summary>
        public bool AscList = false;

        /// <summary>
        ///  降序
        /// </summary>
        public bool DescList = false;

        /// <summary>
        /// 乱序排序
        /// </summary>
        public bool RandomList = false;

        /// <summary>
        /// 清空
        /// </summary>
        public bool ClearAll = false;

        /// <summary>
        /// 反转
        /// </summary>
        public bool Reverse = false;

        /// <summary>
        /// 开始
        /// </summary>

        public bool GetFirst = false;

        /// <summary>
        /// 结束
        /// </summary>
        public bool GetLast = false;

        /// <summary>
        /// 随机
        /// </summary>
        public bool GetRandom = false;

        /// <summary>
        /// 固定值
        /// </summary>
        public bool GetFixed = false;


        public int PosNum = 2;

        /// <summary>
        /// 获得后删除
        /// </summary>
        public bool DeleteWhenGet = false;

        /// <summary>
        /// 取值保存至变量
        /// </summary>
        public string SaveVarName = "";

        /// <summary>
        /// 
        /// </summary>
        public bool ListEmptyReturnEmpty = true;

        public override void Execute(ActivityContext context)
        {
            string msg = this.ListVarName + " ";
            List<string> ls = context.GetList(this.ListVarName);

            if (this.ClearAll)
            {
                ls.Clear();
                msg += $"清空变量{this.ListVarName},";
            }

            if (this.TrimEmpty)
            {
                int emptycount = 0;
                List<string> ls2 = new List<string>();
                foreach (string s in ls)
                {
                    if (!string.IsNullOrEmpty(s)) ls2.Add(s);
                    else emptycount++;
                }
                msg += string.Format("去掉空值{0}个,", emptycount);
                ls = ls2;
            }

            if (this.TrimRepeat)
            {
                int oldcount = ls.Count;
                ls = ls.Distinct().ToList();
                int result = oldcount - ls.Count;
                msg += string.Format("移除重复值{0}个,", result);
            }

            if (this.AscList)
            {
                ls.Sort();
                msg += $"变量{this.ListVarName}升序排序,";
            }
            else if (this.DescList)
            {
                ls.Sort();
                ls.Reverse();
                msg += $"变量{this.ListVarName}降序排序,";
            }
            else if (this.Reverse)
            {
                ls.Reverse();
                msg += $"变量{this.ListVarName}顺序反转,";
            }
            else if (this.RandomList)
            {
                List<string> temp = new List<string>();
                while (ls.Count > 0)
                {
                    int pos = new Random(System.Guid.NewGuid().GetHashCode()).Next(0, ls.Count);
                    temp.Add(ls[pos]);
                    ls.RemoveAt(pos);
                }
                ls = temp;
                msg += $"变量{this.ListVarName}乱序排序,";
            }


            if (!string.IsNullOrEmpty(this.SaveVarName))
            {
                if (ls.Count == 0)
                {
                    if (this.ListEmptyReturnEmpty)
                    {
                        msg += $",列表变量{this.ListVarName}的元素数为空，设置{this.SaveVarName}取值结果为空,";
                        context.SetVarStr(this.SaveVarName, "");
                    }
                    else
                    {
                        throw new Exception($"变量{this.ListVarName}列表值为空，不能取值,");
                    }
                }
                else
                {
                    int index = 0;
                    if (this.GetFirst) index = 0;
                    else if (this.GetLast) index = ls.Count - 1;
                    else if (this.GetRandom) index = new Random(System.Guid.NewGuid().GetHashCode()).Next(0, ls.Count);
                    else if (this.GetFixed) index = this.PosNum - 1;

                    if (ls.Count - 1 < index)
                    {
                        if (this.ListEmptyReturnEmpty)
                        {
                            msg += $",列表变量{this.ListVarName}的指定位置{this.PosNum}超过元素数{ls.Count}，设置{this.SaveVarName}取值结果为空,";
                            context.SetVarStr(this.SaveVarName, "");
                        }
                        else
                        {
                            throw new Exception($"变量{this.ListVarName}指定位置超出列表数，不能取值,");
                        }
                    }
                    else
                    {
                        context.SetVarStr(this.SaveVarName, ls[index]);
                        msg += $"取值索引为{index},";
                        if (this.DeleteWhenGet)
                        {
                            ls.RemoveAt(index);
                            msg += "，移除该索引变量";
                        }
                    }
                }
            }

            context.SetVarList(this.ListVarName, ls);
            context.WriteLog(msg.TrimEnd(','));
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.ListVarName)) throw new Exception("列表变量不能为空");
            if (!string.IsNullOrEmpty(this.SaveVarName) && !context.ContainsStr(this.SaveVarName)) throw new Exception("列表取值的保存变量不存在：" + this.SaveVarName);
        }


        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        private string name = "列表操作";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Variable;
    }
}