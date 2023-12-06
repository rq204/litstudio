using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litcore.activity
{
    [ActivityInfo(Name = "获取文件列表", IsLinux = true)]
    public class GetFileListActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "获取文件列表";

        public override ActivityGroup Group => ActivityGroup.File;

        /// <summary>
        /// 文件夹地址
        /// </summary>
        public string DirPath = "";
        /// <summary>
        /// 文件类型
        /// </summary>
        public string Filter = "*.*";

        /// <summary>
        /// 保存入文件
        /// </summary>
        public string ListVarName = "";

        /// <summary>
        /// 只保留文件名
        /// </summary>
        public bool OnlyFileName = false;

        /// <summary>
        /// 保留文件名并去扩展名
        /// </summary>
        public bool OnlyFileNameWithoutExt = false;

        /// <summary>
        /// 获取目录列表
        /// </summary>
        public bool DirList = false;

        public override void Execute(ActivityContext context)
        {
            string dir = context.ReplaceVar(this.DirPath);

            List<string> add = new List<string>();

            if (!System.IO.Directory.Exists(dir))
            {
                context.WriteLog($"不存在目录{dir}，提取数据为空");

            }
            else
            {
                if (DirList)
                {
                    string[] dirs = System.IO.Directory.GetDirectories(dir);
                    if (this.OnlyFileName || this.OnlyFileNameWithoutExt)
                    {
                        foreach (string s in dirs)
                        {
                            add.Add(System.IO.Path.GetFileName(s));
                        }
                    }
                    else
                    {
                        add.AddRange(dirs);
                    }
                    context.WriteLog($"{dir}共获取到文件夹{add.Count}个");
                }
                else
                {
                    foreach (string filter in this.Filter.Split('|'))
                    {
                        string part = context.ReplaceVar(filter);
                        List<string> files = System.IO.Directory.GetFiles(dir, part).ToList();
                        add.AddRange(files);
                    }
                    add = add.Distinct().ToList();
                    foreach (string a in add.ToArray())
                    {
                        if (ishide(a)) add.Remove(a);
                    }
                    if (this.OnlyFileName || this.OnlyFileNameWithoutExt)
                    {
                        for (int j = 0; j < add.Count; j++)
                        {
                            if (this.OnlyFileNameWithoutExt)
                            {
                                add[j] = System.IO.Path.GetFileNameWithoutExtension(add[j]);
                            }
                            else
                            {
                                add[j] = System.IO.Path.GetFileName(add[j]);
                            }
                        }
                    }
                    context.WriteLog($"{dir}共获取到符合条件的文件{add.Count}个");
                }
            }
            context.AddVarListList(this.ListVarName, add);
        }

        public bool ishide(string item)
        {
            return (new FileInfo(item).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden;  //必须进行与运算，因为默认文件是“Hidden”+归档（二进制11）。而Hidden是10.因此与运算才可以判断
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.DirPath)) throw new Exception("文件夹目录不得为空");
            if (string.IsNullOrEmpty(this.Filter)) throw new Exception("扩展名筛选不得为空");
            if (!context.ContainsList(this.ListVarName)) throw new Exception($"不存在列表变量{this.ListVarName}");
        }
    }
}
