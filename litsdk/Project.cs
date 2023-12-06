using litsdk;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace litsdk
{
    /// <summary>
    /// 项目配置文件，两大核心，行为和数据
    /// </summary>
    public class Project
    {
        public Project()
        {
            this.Id = Guid.NewGuid();
            this.Nodes = new List<Node>();
            this.Variables = new List<litsdk.Variable>();
        }

        public Guid Id { get; set; }

        /// <summary>
        /// 所有配置节点
        /// </summary>
        public List<Node> Nodes { get; set; }

        /// <summary>
        /// 所有的变量
        /// </summary>
        public List<litsdk.Variable> Variables { get; set; }

        /// <summary>
        /// 作者加密后显示，要不就空
        /// </summary>
        public string Auth = "";

        /// <summary>
        /// 作者
        /// </summary>
        public string Author = "";

        /// <summary>
        /// 模板必须字段
        /// </summary>
        public List<string> VariableMust = new List<string>();

        /// <summary>
        /// 启动参数
        /// </summary>
        public List<string> StartVars = new List<string>();

        /// <summary>
        /// 返回参数
        /// </summary>
        public List<string> ReturnVars = new List<string>();

        /// <summary>
        /// 项目的描述
        /// </summary>
        public string Notes = "";

        /// <summary>
        /// 用户自定义配置
        /// </summary>
        public Dictionary<string, object> UserConfigs = new Dictionary<string, object>();

        public void SetUserConfig(string configName, object config)
        {
            if (UserConfigs.ContainsKey(configName))
            {
                UserConfigs[configName] = config;
            }
            else
            {
                UserConfigs.Add(configName, config);
            }
        }

        public object GetUserConfig(string configName)
        {
            if (UserConfigs.ContainsKey(configName)) return UserConfigs[configName];
            else return null;
        }

        private Node GetNodeById(Guid id)
        {
            return this.Nodes.FirstOrDefault(x => x.Id == id);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
        }

        /// <summary>
        /// 清空变量
        /// </summary>
        public void ClearVariables()
        {
            foreach (litsdk.Variable v in this.Variables)
            {
                v.IntValue = 0;
                v.ListValue = new List<string>();
                v.TableValue = new System.Data.DataTable();
                v.StrValue = "";
            }
        }

        public static Newtonsoft.Json.Serialization.ErrorEventArgs PaserError = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static Project GetProject(string json)
        {
            try
            {
                json = convertOld(json);
                Project pj = JsonConvert.DeserializeObject<Project>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Error = new EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>((a, b) => PaserError = b) });
                return pj;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 转换旧版本
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        private static string convertOld(string json)
        {
            json = json.Replace("litsqldb.SqlDBActivity", "litsqldb.MySqlActivity").Replace("litsqldb.SqlDBConfig, litsqldb", "litcore.sqldb.SqlDBConfig, litcore");
            //原超过36长度的缩短
            //            正则提取 litcore.activity.CollectStrListActivity 39  litcore.activity.RegexActivity
            //异常捕获 litcore.activity.ErrorDecisionActivity 38  litcore.activity.ErrorCatchActivity
            //文件存在 litcore.activity.FileFolderExistsActivity 41 litcore.activity.IOResExistsActivity
            //变量比较 litcore.activity.LogicDecisionActivity 38   litcore.activity.LogicDecideActivity
            //读写文件 litcore.activity.ReadWriteTextActivity 38  litcore.activity.RWTextActivity
            json = json.Replace("litcore.activity.CollectStrListActivity", "litcore.activity.RegexActivity");
            json = json.Replace("litcore.activity.ErrorDecisionActivity", "litcore.activity.ErrorCatchActivity");
            json = json.Replace("litcore.activity.FileFolderExistsActivity", "litcore.activity.IOResExistsActivity");
            json = json.Replace("litcore.activity.LogicDecisionActivity", "litcore.activity.LogicDecideActivity");
            json = json.Replace("litcore.activity.ReadWriteTextActivity", "litcore.activity.RWTextActivity");
            json = json.Replace("litcaptcha.CaptchaActivity, litcaptcha", "litcaptcha.CaptchaActivity, litstand");
            json = json.Replace("litcaptcha.CaptchaErrorActivity, litcaptcha", "litcaptcha.CaptchaErrorActivity, litstand");
            //json = json.Replace("litcore.StartNode, litcore", "litsdk.StartNode, litsdk");
            json = json.Replace("litcore.NextPort, litcore", "litsdk.NextPort, litsdk");
            json = json.Replace("litcore.TruePort, litcore", "litsdk.TruePort, litsdk");
            json = json.Replace("litcore.FalsePort, litcore", "litsdk.FalsePort, litsdk");
            //json = json.Replace("litcore.StartNode, litcore", "litsdk.StartNode, litsdk");

            json = json.Replace("litcore.activity.CollectStrListActivity", "litcore.activity.RegexActivity");
            json = json.Replace("litcore.activity.LogicDecisionActivity", "litcore.activity.LogicDecideActivity");
            return json;
        }
    }
}