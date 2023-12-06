using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.activity
{
    [ActivityInfo(Name = "时间转化", Index = 52, IsLinux = true)]
    public class TimeActivity : litsdk.ProcessActivity
    {
        /// <summary>
        /// 时间来源是否当前时间
        /// </summary>
        public bool IsTimeNow = true;

        /// <summary>
        /// 时间来源
        /// </summary>
        public ictype.TimeType TimeType = ictype.TimeType.None;

        /// <summary>
        /// 最近周几
        /// </summary>
        public int DayOfWeek = 0;

        /// <summary>
        /// 指定变量名
        /// </summary>
        public string TimeVarName = "";

        /// <summary>
        /// 指定时间是否时间戳
        /// </summary>
        public bool TimeIsTimeStamp = false;

        /// <summary>
        /// 增加月份
        /// </summary>
        public int Month = 0;

        /// <summary>
        /// 增加天数
        /// </summary>
        public int Day = 0;

        /// <summary>
        /// 增加时
        /// </summary>
        public int Hour = 0;

        /// <summary>
        /// 增加分
        /// </summary>
        public int Minite = 0;

        /// <summary>
        /// 增加秒
        /// </summary>
        public int Sencond = 0;

        /// <summary>
        /// 减去
        /// </summary>
        public bool UseMinus = false;

        /// <summary>
        /// 保存时间格式
        /// </summary>
        public type.TimeSaveType TimeSaveType = type.TimeSaveType.TimeFormat;

        /// <summary>
        /// 指定时间格式
        /// </summary>
        public string TimeFormat = "";

        /// <summary>
        /// 保存结果至变量
        /// </summary>
        public string SaveVarName = "";

        private string name = "时间转化";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Variable;

        public override void Execute(ActivityContext context)
        {
            if (this.TimeType == ictype.TimeType.None)
            {
                if (IsTimeNow) this.TimeType = ictype.TimeType.TimeNow;
                else this.TimeType = ictype.TimeType.SpecialTime;
            }

            DateTime dt = DateTime.UtcNow;
            int miniseconds = 0;

            try
            {
                if (this.TimeType == ictype.TimeType.SpecialTime)
                {
                    string timestr = context.ContainsStr(this.TimeVarName) ? context.GetStr(this.TimeVarName) : context.GetInt(this.TimeVarName).ToString();
                    if (this.TimeIsTimeStamp)
                    {
                        if (!System.Text.RegularExpressions.Regex.IsMatch(timestr, "\\d+")) throw new Exception("时间变量格式错误非时间戳");
                        if (timestr.Length == 10)
                        {
                            dt = dt1970.AddSeconds(double.Parse(timestr));
                        }
                        else if (timestr.Length == 13)
                        {
                            dt = dt1970.AddSeconds(double.Parse(timestr.Substring(0, 10)));
                            string l3 = timestr.Substring(10, 3).TrimStart('0');
                            if (!string.IsNullOrEmpty(l3)) miniseconds = Convert.ToInt32(l3);
                        }
                        else throw new Exception("时间变量格式错误非时间戳");
                    }
                    else
                    {
                        dt = Convert.ToDateTime(timestr).ToUniversalTime();
                    }
                }
                else if (this.TimeType == ictype.TimeType.LastDayOfWeek)//最近周几
                {
                    for (int d = 0; d < 7; d++)
                    {
                        dt = DateTime.Now.AddDays(0 - d);
                        int dayofweek = (int)dt.DayOfWeek;
                        if (dayofweek == this.DayOfWeek)
                        {
                            break;
                        }
                    }
                }

                if (this.UseMinus)
                {
                    dt = dt.AddMonths(0 - this.Month).AddDays(0 - this.Day).AddHours(0 - this.Hour).AddMinutes(0 - this.Minite).AddSeconds(0 - this.Sencond);
                }
                else
                {
                    dt = dt.AddMonths(this.Month).AddDays(this.Day).AddHours(this.Hour).AddMinutes(this.Minite).AddSeconds(this.Sencond);
                }

                TimeSpan diff = dt - dt1970;

                switch (this.TimeSaveType)
                {
                    case type.TimeSaveType.TimeFormat:
                        string timere = ToFixedDateString(dt.ToLocalTime(), this.TimeFormat);// //、、 dt.ToLocalTime().ToString(this.TimeFormat);
                        context.SetVarStr(this.SaveVarName, timere);
                        context.WriteLog($"时间转化{this.TimeFormat}结果为{timere}");
                        break;
                    case type.TimeSaveType.TimeStamp10:
                        string r10 = diff.TotalSeconds.ToString().Split('.')[0];
                        context.SetVarStr(this.SaveVarName, r10);
                        context.WriteLog($"时间转化结果为时间戳{r10}");
                        break;
                    case type.TimeSaveType.TimeStamp13:
                        double re = diff.TotalSeconds * 1000 + miniseconds;
                        string ree = re.ToString().Split('.')[0];
                        context.SetVarStr(this.SaveVarName, ree);
                        context.WriteLog($"时间转化结果为13位时间戳{ree}");
                        break;
                }
            }
            catch (Exception ex)
            {
                context.WriteLog($"时间转换异常:" + ex.Message);
            }
        }

        static DateTime dt1970 = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

        public static string ToTimeStamp10(DateTime dateTime)
        {
            TimeSpan diff = dateTime - dt1970;
            return diff.TotalSeconds.ToString().Split('.')[0];
        }

        public static DateTime FromTimeStamp10(string timestr)
        {
            DateTime dt = DateTime.Now;
            if (timestr.Length == 10)
            {
                dt = dt1970.AddSeconds(double.Parse(timestr));
            }
            else if (timestr.Length == 13)
            {
                dt = dt1970.AddSeconds(double.Parse(timestr.Substring(0, 10)));
            }
            return dt;
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (this.TimeType == ictype.TimeType.SpecialTime)
            {
                if (string.IsNullOrEmpty(this.TimeVarName))
                {
                    throw new Exception($"指定时间为变量时变量名不能为空");
                }
                if (!context.ContainsStr(this.TimeVarName) && !context.ContainsInt(this.TimeVarName))
                {
                    throw new Exception($"指定时间为变量时变量名{this.TimeVarName}不存在");
                }
            }
            if (this.TimeSaveType == type.TimeSaveType.TimeFormat)
            {
                if (string.IsNullOrEmpty(this.TimeFormat)) throw new Exception("指定时间格式不能为空");
                try
                {
                    string time = DateTime.Now.ToString(this.TimeFormat);
                }
                catch
                {
                    throw new Exception($"指定时间格式错误，无法转化，格式为{this.TimeFormat}");
                }
            }
        }

        /// <summary>
        /// 混合的时间格式
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="dateFormat"></param>
        /// <returns></returns>
        public static string ToFixedDateString(DateTime dateTime, string dateFormat)
        {
            List<string> darr = new List<string>();
            //yyyyMMddHHmmss
            System.Text.RegularExpressions.MatchCollection mc = System.Text.RegularExpressions.Regex.Matches(dateFormat, "[yMdHms]+");
            for (int i = 0; i < mc.Count; i++)
            {
                string hit = mc[i].Groups[0].Value;
                int pos = dateFormat.IndexOf(hit);
                string time = dateTime.ToString(hit);
                if (pos > 0)//第一个
                {
                    darr.Add(dateFormat.Substring(0, pos));
                    dateFormat = dateFormat.Substring(pos, dateFormat.Length - pos);
                }
                darr.Add(time);
                dateFormat = dateFormat.Substring(hit.Length, dateFormat.Length - hit.Length);
            }

            return string.Join("", darr.ToArray());
        }
    }
}