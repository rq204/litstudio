using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.activity
{
    [ActivityInfo(Name = "随机数据",Index = 44, IsLinux = true)]
    public class RandomActivity : litsdk.ProcessActivity
    {
        static RandomActivity()
        {
            string letter = "abcdefghjklmnpqrstuvwxyz";
            for (int i = 0; i < letter.Length; i++)
            {
                letterlowers.Add(letter[i].ToString());
                letterupppers.Add(letter[i].ToString().ToUpper());
            }
            letter = "~!@#$%^&*()_+:\"|<>,./";
            for (int i = 0; i < letter.Length; i++)
            {
                others.Add(letter[i].ToString());
            }
        }
        private string name = "随机数据";
        /// <summary>
        /// 随机数生成
        /// </summary>
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Variable;

        public bool Number = false;

        public bool LetterLower = false;

        public bool LetterUpper = false;

        public bool Other = false;

        public int Length = 6;

        public int ListCount = 6;

        public string SaveVarName = "";

        private static List<string> numbers = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        private static List<string> letterlowers = new List<string>();

        private static List<string> letterupppers = new List<string>();

        private static List<string> others = new List<string>();

        public override void Execute(ActivityContext context)
        {
            List<string> sources = new List<string>();
            if (this.Number) sources.AddRange(numbers);
            if (this.LetterLower) sources.AddRange(letterlowers);
            if (this.LetterUpper) sources.AddRange(letterupppers);
            if (this.Other) sources.AddRange(others);

            List<string> data = new List<string>();

            try
            {
                if (context.ContainsStr(this.SaveVarName))
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        data.Add(sources[new Random(Guid.NewGuid().GetHashCode()).Next(0, sources.Count)]);
                    }
                    context.SetVarStr(this.SaveVarName, string.Join("", data.ToArray()));
                    context.WriteLog($"变量{this.SaveVarName}生成长度{ this.Length}的随机数成功");
                }
                else if (context.ContainsInt(this.SaveVarName))
                {
                    int start = (int)Math.Pow(10, this.Length - 1);
                    int end = (int)Math.Pow(10, this.Length);
                    int num = new Random(Guid.NewGuid().GetHashCode()).Next(start, end);
                    context.SetVarInt(this.SaveVarName, num);
                    context.WriteLog($"变量{this.SaveVarName}生成长度{ this.Length}的随机数为{num}");
                }
                else if (context.ContainsList(this.SaveVarName))
                {
                    System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
                    stopwatch.Start();
                    while (data.Count < this.ListCount)
                    {
                        List<string> temp = new List<string>();
                        for (int i = 0; i < this.Length; i++)
                        {
                            temp.Add(sources[new Random(Guid.NewGuid().GetHashCode()).Next(0, sources.Count)]);
                        }
                        string result = string.Join("", temp.ToArray());
                        if (!data.Contains(result)) data.Add(result);

                        if (stopwatch.ElapsedMilliseconds > 20000) throw new Exception("生成超过20秒，请检查是否设置错误");
                    }
                    stopwatch.Stop();
                    context.SetVarList(this.SaveVarName, data);
                    context.WriteLog($"列表变量{this.SaveVarName}生成长度{ this.Length}的随机数{this.ListCount}个成功");
                }
            }
            catch (Exception ex)
            {
                context.WriteLog($"生成随机数出错：{ex.Message}");
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (this.Length == 0) throw new Exception("随机数长度不能为空");
            if (context.ContainsList(this.SaveVarName) && this.ListCount == 0) throw new Exception("列表变量元素数不能为空");
            if (!context.Contains(this.SaveVarName) || context.ContainsTable(this.SaveVarName)) throw new Exception("生成结果必存入字符、数字或是列表变量");
            if (!this.Number && !this.LetterLower && !this.LetterUpper && !this.Other && !context.ContainsInt(this.SaveVarName)) throw new Exception("生成来源必须选中一项");
        }
    }
}
