using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace litstudio
{
    internal class Option
    {
        [Obfuscation(Exclude = true)]
        public bool AutoSave = false;

        [Obfuscation(Exclude = true)]
        /// <summary>
        /// 调试间隔
        /// </summary>
        public int DebugSleep = 0;

        public static Option option = new Option();
        private static string file = AppDomain.CurrentDomain.BaseDirectory + "User\\Option.json";

        [Obfuscation(Exclude = true)]
        /// <summary>
        /// 打开列表
        /// </summary>
        public List<string> OpenList = new List<string>();

        public static void Read()
        {
            if (System.IO.File.Exists(file))
            {
                string json = System.IO.File.ReadAllText(file, System.Text.Encoding.UTF8);
                option = Newtonsoft.Json.JsonConvert.DeserializeObject<Option>(json);
            }
            else
            {
                string dir = System.IO.Path.GetDirectoryName(file);
                if (!System.IO.Directory.Exists(dir)) System.IO.Directory.CreateDirectory(dir);
            }
        }

        public static void Save()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(option);
            System.IO.File.WriteAllText(file, json, System.Text.Encoding.UTF8);
        }

        public static void SetOpenList(string fileName)
        {
            option.OpenList.Remove(fileName);
            option.OpenList.Insert(0, fileName);
            if (option.OpenList.Count > 30) option.OpenList = option.OpenList.GetRange(0, 30);
       
            Save();
        }
    }
}
