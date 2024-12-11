using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litext
{
    [ActivityInfo(Name = "Ini读写")]
    public class IniActivity : litsdk.ProcessActivity
    {
        private string name = "Ini读写";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.File;

        public List<IniConfig> IniConfigs = new List<IniConfig>();

        public bool ReadIni = true;

        public string IniFile = "";

        public override void Execute(ActivityContext context)
        {
            string file = context.ReplaceVar(this.IniFile);
            INI n = new INI(file);
            foreach (IniConfig config in this.IniConfigs)
            {
                string section = context.ReplaceVar(config.Section);
                string key = context.ReplaceVar(config.Key);

                if (this.ReadIni)
                {
                    string data = n.IniReadValue(section, key);
                    if (context.ContainsStr(config.VarName))
                    {
                        context.SetVarStr(config.VarName, data);
                        context.WriteLog($"读取到字符变量{config.VarName}值长度{data.Length}");
                    }
                    else if (context.ContainsInt(config.VarName))
                    {
                        int idata = 0;
                        int.TryParse(data, out idata);
                        context.SetVarInt(config.VarName, idata);
                        context.WriteLog($"读取到数字变量{config.VarName}值{idata}");
                    }
                }
                else
                {
                    string data = "";
                    if (context.ContainsStr(config.VarName))
                    {
                        data = context.GetStr(config.VarName);
                    }
                    else if (context.ContainsInt(config.VarName))
                    {
                        data = context.GetInt(config.VarName).ToString();
                    }
                    n.IniWriteValue(section, key, data);
                    context.WriteLog($"写入ini值长度{data.Length}到变量{config.VarName}");
                }
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new IniUI());
        }

        public override void Validate(ActivityContext context)
        {
            foreach (IniConfig config in this.IniConfigs)
            {
                if (!context.ContainsStr(config.VarName) && !context.ContainsInt(config.VarName)) throw new Exception("找不到字符或数字变量名：" + config.VarName);
            }
        }
    }
}