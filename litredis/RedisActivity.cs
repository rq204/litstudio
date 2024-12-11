using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSRedis;
using litsdk;

namespace litredis
{
    [litsdk.ActivityInfo(Name = "Redis", IsLinux = true, RefFile = "CSRedisCore.dll,", Index = 50, IsFront = false, IsWinForm = false)]
    public class RedisActivity : litsdk.ProcessActivity
    {
        private string name = "Redis";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Database;

        public RedisType RedisType = RedisType.set;

        /// <summary>
        /// 服务器地址
        /// </summary>
        public string Host = "";

        /// <summary>
        /// 密码
        /// </summary>
        public string Password = "";

        /// <summary>
        /// 数据库
        /// </summary>
        public string DatabaseNum = "";

        /// <summary>
        /// 变量key名
        /// </summary>
        public string Key = "";

        static Dictionary<string, CSRedisClient> redisDic = new Dictionary<string, CSRedisClient>();
        static object redislock = new object();

        /// <summary>
        /// 变量值
        /// </summary>
        public string ValueVarName = "";

        /// <summary>
        /// 操作结果变量名
        /// </summary>
        public string ResultVarName = "";

        public override void Execute(ActivityContext context)
        {
            string host = context.ReplaceVar(this.Host);
            string password = context.ReplaceVar(this.Password);
            string key = context.ReplaceVar(this.Key);

            int dbindex = 0;
            string database = context.ReplaceVar(this.DatabaseNum);
            if (!int.TryParse(database, out dbindex))
            {
                throw new Exception("数据库配置错误：" + this.DatabaseNum);
            }

            string conn = $"{host},password={password},defaultDatabase={dbindex},poolsize=5,ssl=false";

            CSRedisClient redisManger = redisDic.ContainsKey(conn) ? redisDic[conn] : null;

            if (redisManger == null)
            {
                lock (redislock)
                {
                    redisManger = new CSRedisClient(conn);
                    if (!redisDic.ContainsKey(conn))
                    {
                        redisDic.Add(conn, redisManger);
                    }
                }
            }

            List<string> pushs = new List<string>();
            if (this.RedisType == RedisType.lpush || this.RedisType == RedisType.rpush || this.RedisType == RedisType.set || this.RedisType == RedisType.sadd)
            {
                if (context.ContainsStr(this.ValueVarName)) pushs.Add(context.GetStr(this.ValueVarName));
                else if (context.ContainsList(this.ValueVarName)) pushs.AddRange(context.GetList(this.ValueVarName));
            }
            string result = null;
            switch (this.RedisType)
            {
                case RedisType.set:
                    if (redisManger.Set(key, pushs))
                    {
                        context.WriteLog($"字符{key}成功写值长度{CutShow(string.Join(",", pushs.ToArray()))}");
                        result = "1";
                    }
                    else
                    {
                        context.WriteLog($"字符{key}写值失败");
                        result = "0";
                    }
                    break;
                case RedisType.get:
                    context.SetVarStr(this.ResultVarName, "");
                    string value = redisManger.Get(key);
                    if (value == null) value = "";
                    result = value;
                    context.WriteLog($"键名 {key} 取值成功 {CutShow(value)}");
                    break;
                case RedisType.lpush:
                    long l = redisManger.LPush<string>(key, pushs.ToArray());
                    result = l.ToString();
                    context.WriteLog($"键名 {key} lpush成功");
                    break;
                case RedisType.rpush:
                    long l2 = redisManger.RPush<string>(key, pushs.ToArray());
                    result = l2.ToString();
                    context.WriteLog($"键名 {key} rpush成功");
                    break;
                case RedisType.rpop:
                    context.SetVarStr(this.ResultVarName, "");
                    string rvalue = redisManger.RPop(key);
                    if (rvalue == null) rvalue = "";
                    result = rvalue;
                    context.WriteLog($"键名 {key}rpush 成功 {CutShow(rvalue)}");
                    break;
                case RedisType.lpop:
                    context.SetVarStr(this.ResultVarName, "");
                    string lvalue = redisManger.LPop(key);
                    if (lvalue == null) lvalue = "";
                    result = lvalue;
                    context.WriteLog($"键名 {key} lpop成功 {CutShow(lvalue)}");
                    break;
                case RedisType.sadd:
                    result = redisManger.SAdd<string>(key, pushs.ToArray()).ToString();
                    context.WriteLog($"键名 {key} sadd 值  {string.Join(",", pushs.ToArray())}成功 {CutShow(result)}");
                    break;
                case RedisType.sismember:
                    string sis = context.GetStr(this.ValueVarName);
                    result = redisManger.SIsMember(key, sis) ? "1" : "0";
                    context.WriteLog($"键名 {key} sismember 值  {sis} 结果为 {result}");
                    break;
            }
            if (!string.IsNullOrEmpty(this.ResultVarName))
            {
                context.SetVarStr(this.ResultVarName, result);
            }
        }

        public static string CutShow(string txt, int len = 10)
        {
            if (txt.Length > len) return $"长度{txt.Length}";
            else return txt;
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.Host)) throw new Exception("服务器地址不能为空");
            if (string.IsNullOrEmpty(this.DatabaseNum)) throw new Exception("数据库不能为空");
            if (string.IsNullOrEmpty(this.Key)) throw new Exception("键名不能为空");

            ///这些是要设置键值
            if (this.RedisType == RedisType.set || this.RedisType == RedisType.lpush || this.RedisType == RedisType.rpush || this.RedisType == RedisType.sadd || this.RedisType == RedisType.sismember)
            {
                if (string.IsNullOrEmpty(this.ValueVarName)) throw new Exception("键值不能为空");
                if (!context.ContainsStr(this.ValueVarName) && !context.ContainsList(this.ValueVarName)) throw new Exception($"不存在字符或列表变量：{this.ValueVarName}");
            }

            if (string.IsNullOrEmpty(this.ValueVarName) && string.IsNullOrEmpty(this.ResultVarName)) throw new Exception("键值和操作结果变量不能同时为空");

            //这些获取的值为string
            if (this.RedisType == RedisType.get || this.RedisType == RedisType.lpop || this.RedisType == RedisType.rpop)
            {
                if (!context.ContainsStr(this.ResultVarName))
                {
                    throw new Exception("当前要保存数据至字符变量");
                }
            }

            //键值类型
            if (this.RedisType == RedisType.lpush || this.RedisType == RedisType.rpush || this.RedisType == RedisType.set || this.RedisType == RedisType.sadd)
            {
                if (!context.ContainsStr(this.ValueVarName) && !context.ContainsList(this.ValueVarName)) throw new Exception($"不存在字符或列表变量：{this.ValueVarName}");
            }
            else if (this.RedisType == RedisType.get || this.RedisType == RedisType.lpop || this.RedisType == RedisType.rpop)//不需要
            {

            }
            else if (this.RedisType == RedisType.sadd || this.RedisType == RedisType.sismember)
            {
                if (!context.ContainsStr(this.ValueVarName)) throw new Exception($"不存在字符变量：{this.ValueVarName}");
            }
        }
    }
}