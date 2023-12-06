using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litcore.activity
{
    [ActivityInfo(Name = "读写文件", IsLinux = true)]
    public class RWTextActivity : litsdk.ProcessActivity
    {
        public override ActivityGroup Group => ActivityGroup.File;

        public override void Execute(ActivityContext context)
        {
            string path = context.ReplaceVar(this.FilePath);
            System.Text.Encoding ed = System.Text.Encoding.GetEncoding(this.Encoding);
            string content = string.Empty;

            if (this.IsWrite)
            {
                if (this.Encoding == "UTF-8") ed = new UTF8Encoding(false);
                if (context.ContainsStr(this.Content))
                {
                    content = context.GetStr(this.Content);
                }
                else if (context.ContainsInt(this.Content))
                {
                    content = context.GetInt(this.Content).ToString();
                }
                else if (context.ContainsList(this.Content))
                {
                    content = string.Join("\r\n", context.GetList(this.Content).ToArray());
                }
                string dir = System.IO.Path.GetDirectoryName(path);
                if (!System.IO.Directory.Exists(dir)) System.IO.Directory.CreateDirectory(dir);

                if (this.Append)
                {
                    if (this.AppendLine) content += "\r\n";
                    System.IO.File.AppendAllText(path, content, ed);
                }
                else System.IO.File.WriteAllText(path, content, ed);
                System.Threading.Thread.Sleep(50);
                context.WriteLog($"写入数据至{path}，长度{content.Length}");
            }
            else
            {
                if (System.IO.File.Exists(path))
                {
                    if (context.ContainsStr(this.Content))
                    {
                        content = System.IO.File.ReadAllText(path, ed);
                        context.SetVarStr(this.Content, content);
                    }
                    else if (context.ContainsInt(this.Content))
                    {
                        content = System.IO.File.ReadAllText(path, ed);
                        int oint = -1;
                        int.TryParse(content, out oint);
                        context.SetVarInt(this.Content, oint);
                    }
                    else if (context.ContainsList(this.Content))
                    {
                        string[] lines = System.IO.File.ReadAllLines(path, ed);
                        content = string.Join("\r\n", lines);
                        context.SetVarList(this.Content, lines.ToList());
                    }
                    context.WriteLog($"读取{path}数据成功，长度{content.Length}");
                }
                else
                {
                    throw new Exception("文件不存在:" + path);
                }
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                throw new Exception( "文件路径不能为空");
            }
            if (string.IsNullOrEmpty(this.Encoding))
            {
                throw new Exception("文件编码不能为空");
            }
            if (string.IsNullOrEmpty(this.Content))
            {
                throw new Exception("读取或写入变量名不能为空");
            }
            if (!context.Contains(this.Content)||context.ContainsTable(this.Content))
            {
                throw new Exception("变量名不存在或不能为表格变量");
            }
        }

        /// <summary>
        /// 是否写入
        /// </summary>
        public bool IsWrite { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 读取或写入的内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 是否跟加写入
        /// </summary>
        public bool Append { get; set; }

        /// <summary>
        /// 文件编码
        /// </summary>
        public string Encoding { get; set; }

        /// <summary>
        /// 增加换行
        /// </summary>
        public bool AppendLine { get; set; }


        private string name = "读写文件";
        public override string Name { get => name; set => name = value; }
    }
}
