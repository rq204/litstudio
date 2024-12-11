using litsdk;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace litext
{
    internal class Common
    {
        internal static string LoadEnvPath(string name)
        {
            string sPath = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);

            var paths = sPath.Split(';');

            foreach (var p in paths)
            {
                string path = System.IO.Path.Combine(p, name);
                if (System.IO.File.Exists(path))
                {
                    return path;
                }
            }

            sPath = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.User);

            paths = sPath.Split(';');

            foreach (var p in paths)
            {
                string path = System.IO.Path.Combine(p, name);
                if (System.IO.File.Exists(path))
                {
                    return path;
                }
            }

            return "";
        }

        internal static string StartProcess(string file, string workdirectory, string args, System.Diagnostics.ProcessWindowStyle style, System.Text.Encoding ed)
        {
            System.Diagnostics.Process myprocess = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(file, args);
            startInfo.WindowStyle = style;
            startInfo.WorkingDirectory = workdirectory;
            myprocess.StartInfo = startInfo;
            myprocess.StartInfo.UseShellExecute = false;
            myprocess.StartInfo.CreateNoWindow = true;
            myprocess.StartInfo.RedirectStandardError = true;
            myprocess.StartInfo.RedirectStandardInput = true;
            myprocess.StartInfo.RedirectStandardOutput = true;
            myprocess.StartInfo.StandardOutputEncoding = ed;
            myprocess.Start();

            string outstr = myprocess.StandardOutput.ReadToEnd();
            if (string.IsNullOrEmpty(outstr))
            {
                StreamReader myStreamReader = myprocess.StandardError;// 读取错误流
                outstr = myStreamReader.ReadToEnd();
            }
            myprocess.WaitForExit();

            return outstr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="scriptFile"></param>
        /// <param name="exePath"></param>
        /// <param name="varlist"></param>
        /// <param name="exeargs">exe执行传入的参数</param>
        public static void Execute(ActivityContext context, string scriptFile, string exePath, List<string> varlist,string exeargs="")
        {
            string content = "";
            List<Variable> list = context.Variables.FindAll((f) => varlist.Contains(f.Name));
            Dictionary<string, object> dic = new Dictionary<string, object>();

            foreach (Variable v in list)
            {
                switch (v.VariableType)
                {
                    case VariableType.Int:
                        dic.Add(v.Name, v.IntValue);
                        break;
                    case VariableType.String:
                        dic.Add(v.Name, v.StrValue);
                        break;
                    case VariableType.List:
                        dic.Add(v.Name, v.ListValue??new List<string>());
                        break;
                }
            }

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(dic);
            content = System.Web.HttpUtility.UrlEncode(json, System.Text.Encoding.UTF8);

            string pytempfile = null;
            string args = "";
            if (exeargs == "")//不使用模板
            {
                args = string.Format("\"{0}\"", scriptFile);

                if (args.Length + content.Length > 30000)//原来是32732，这个现在去除目录和网址长度2000
                {
                    pytempfile = System.IO.Path.GetTempFileName();
                    System.IO.File.WriteAllText(pytempfile, content, new System.Text.UTF8Encoding(false));
                    args += " \"" + pytempfile + "\"";
                }
                else args += " \"" + content + "\"";
            }
            else//命令行使用模板
            {
                args = exeargs;
            }

            string result = Common.StartProcess(exePath, "", args, System.Diagnostics.ProcessWindowStyle.Hidden, System.Text.Encoding.UTF8);

            Dictionary<string, object> variables = new Dictionary<string, object>();

            try
            {
                variables = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
            }
            catch
            {
                System.Windows.Forms.Clipboard.SetText($"\"{ exePath }\" {args}");
                throw new Exception($"执行错误，返回{result}，\r\n请执行以下命令手工测试（已复制到剪贴板）： \"{ exePath }\" {args}");
            }

            try
            {
                if (pytempfile != null && System.IO.File.Exists(pytempfile)) System.IO.File.Delete(pytempfile);
            }
            catch { }

            foreach (Variable v in list)
            {
                if (!variables.ContainsKey(v.Name)) continue;

                switch (v.VariableType)
                {
                    case VariableType.Int:
                        v.IntValue = Convert.ToInt32(variables[v.Name]);
                        break;
                    case VariableType.List:
                        if(variables[v.Name] is Newtonsoft.Json.Linq.JArray jarr)
                        {
                            List<string> ls = new List<string>();
                            foreach (Newtonsoft.Json.Linq.JToken token in jarr) ls.Add(token.ToString());
                            v.ListValue = ls;
                        }
                        break;
                    case VariableType.String:
                        v.StrValue = variables[v.Name].ToString();
                        break;
                }
            }
        }
    }
}
