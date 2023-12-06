using litsdk;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore
{
    public class Utility
    {
        /// <summary>
        /// 获取不可用的活动列表
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static List<string> GetUnavailableActivity(string json)
        {
            List<string> ls = new List<string>();
            foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(json, "\"Activity\": {\r\n\\s+?\"\\$type\": \"([^,]*?),"))
            {
                if (!litcore.ActivityLoader.Contains(m.Groups[1].Value)) ls.Add(m.Groups[1].Value);
            }
            ls = ls.Distinct().ToList();
            return ls;
        }

        /// <summary>
        /// 检查当前流程的front和winform
        /// </summary>
        /// <param name="activity"></param>
        /// <param name="IsFront"></param>
        /// <param name="IsWinForm"></param>
        public static void CheckActivity(litsdk.Activity activity, ref bool IsFront, ref bool IsWinForm, ref bool IsBrowser)
        {
            if (activity is litcore.activity.ProjectActivity)//引用的处理
            {
                litcore.activity.ProjectActivity projectActivity = activity as litcore.activity.ProjectActivity;
                string projectstr = projectActivity.ProjectStr;
                if (string.IsNullOrEmpty(projectstr))
                {
                    string pfilePath = projectActivity.FilePath.Replace("[当前目录]", AppDomain.CurrentDomain.BaseDirectory);
                    if (System.IO.File.Exists(pfilePath)) projectstr = System.IO.File.ReadAllText(pfilePath, System.Text.Encoding.UTF8);
                }
                if (!string.IsNullOrEmpty(projectstr))
                {
                    Project pnew = Project.GetProject(projectstr);
                    pnew.CheckCreateApp(ref IsFront, ref IsWinForm, ref IsBrowser);
                }
            }
            else if (activity is litcore.activity.SequenceActivity seq)
            {
                foreach (litsdk.Activity a in seq.Activities)
                {
                    CheckActivity(a, ref IsFront, ref IsWinForm, ref IsBrowser);
                }
            }
            else
            {
                foreach (Object attributes in activity.GetType().GetCustomAttributes(false))
                {
                    if (attributes is ActivityInfo authorAttribute)
                    {
                        if (authorAttribute.IsFront) IsFront = true;
                        if (authorAttribute.IsWinForm) IsWinForm = true;
                    }
                }
                if (activity.Group == ActivityGroup.Broswer || activity.Group == ActivityGroup.CefBroswer) IsBrowser = true;
            }
        }

        ///// <summary>
        ///// 复制文件夹
        ///// https://docs.microsoft.com/zh-tw/dotnet/standard/io/how-to-copy-directories
        ///// </summary>
        ///// <param name="sourceDirName"></param>
        ///// <param name="destDirName"></param>
        ///// <param name="copySubDirs"></param>
        //public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs = true)
        //{
        //    // Get the subdirectories for the specified directory.
        //    DirectoryInfo dir = new DirectoryInfo(sourceDirName);

        //    if (!dir.Exists)
        //    {
        //        throw new DirectoryNotFoundException(
        //            "Source directory does not exist or could not be found: "
        //            + sourceDirName);
        //    }

        //    DirectoryInfo[] dirs = dir.GetDirectories();
        //    // If the destination directory doesn't exist, create it.
        //    if (!Directory.Exists(destDirName))
        //    {
        //        Directory.CreateDirectory(destDirName);
        //    }

        //    // Get the files in the directory and copy them to the new location.
        //    FileInfo[] files = dir.GetFiles();
        //    foreach (FileInfo file in files)
        //    {
        //        string temppath = Path.Combine(destDirName, file.Name);
        //        file.CopyTo(temppath, true);
        //    }

        //    // If copying subdirectories, copy them and their contents to new location.
        //    if (copySubDirs)
        //    {
        //        foreach (DirectoryInfo subdir in dirs)
        //        {
        //            string temppath = Path.Combine(destDirName, subdir.Name);
        //            DirectoryCopy(subdir.FullName, temppath, copySubDirs);
        //        }
        //    }
        //}

        //private static bool CopyFilesExt(string SourceDir, string DestDir)
        //{
        //    string[] FileNames = Directory.GetFiles(SourceDir);
        //    // Copy files into dest dir
        //    // If file exists, then overwrite
        //    for (int i = 0; i < FileNames.Length; i++)
        //        System.IO.File.Copy(FileNames[i],
        //            DestDir + FileNames[i].Substring(SourceDir.Length), true);
        //    return true;
        //}

        ///// <summary>
        ///// 将引用流程解析处理进来
        ///// </summary>
        ///// <param name="activity"></param>
        ///// <param name="br"></param>
        //public static void ParseProject(litsdk.Activity activity, BotRunner br)
        //{
        //    if (activity is litcore.activity.ProjectActivity)
        //    {
        //        litcore.activity.ProjectActivity pa = activity as litcore.activity.ProjectActivity;

        //        string pjpath = br.ActivityContext.ReplaceVar(pa.FilePath);

        //        string refProject = "";

        //        if (litsdk.API.GetRefProject == null)
        //        {
        //            refProject = System.IO.File.ReadAllText(pjpath, System.Text.Encoding.UTF8);
        //        }
        //        else
        //        {
        //            refProject = litsdk.API.GetRefProject(pjpath);
        //        }

        //        if (string.IsNullOrEmpty(refProject))
        //        {
        //            throw new Exception("不存在引用流程文件：" + pjpath);
        //        }
        //        else
        //        {
        //            pa.ProjectStr = refProject;
        //        }

        //        litsdk.Project p2 = litsdk.Project.GetProject(pa.ProjectStr);
        //        foreach (litsdk.Node node in p2.Nodes)
        //        {
        //            if (node is StartNode || node is EndNode) continue;

        //            // 如果没有任何链接到就不处理
        //            if (p2.Nodes.Find((f) => f.Ports.Find((m) => m.NextNodeId == node.Id) != null) == null)
        //            {
        //                continue;
        //            }
        //            ParseProject(node.Activity, br);
        //        }
        //        pa.ProjectStr = p2.ToJson();
        //        return;
        //    }
        //    Type ltype = typeof(litsdk.Activity);

        //    foreach (System.Reflection.PropertyInfo info in activity.GetType().GetProperties())
        //    {
        //        if (info.PropertyType == ltype)
        //        {
        //            ParseProject(info.GetValue(activity) as litsdk.Activity, br);
        //        }
        //        else if (info.PropertyType == typeof(List<litsdk.Activity>))
        //        {
        //            foreach (litsdk.Activity a in (info.GetValue(activity) as List<litsdk.Activity>))
        //            {
        //                ParseProject(a, br);
        //            }
        //        }
        //        else if (info.PropertyType == typeof(List<litsdk.ProcessActivity>))
        //        {
        //            foreach (litsdk.Activity a in (info.GetValue(activity) as List<litsdk.ProcessActivity>))
        //            {
        //                ParseProject(a, br);
        //            }
        //        }
        //    }
        //    foreach (System.Reflection.FieldInfo info in activity.GetType().GetFields())
        //    {
        //        if (info.FieldType == ltype)
        //        {
        //            ParseProject(info.GetValue(activity) as litsdk.Activity, br);
        //        }
        //        else if (info.FieldType == typeof(List<litsdk.Activity>))
        //        {
        //            foreach (litsdk.Activity a in (info.GetValue(activity) as List<litsdk.Activity>))
        //            {
        //                ParseProject(a, br);
        //            }
        //        }
        //        else if (info.FieldType == typeof(List<litsdk.ProcessActivity>))
        //        {
        //            foreach (litsdk.Activity a in (info.GetValue(activity) as List<litsdk.ProcessActivity>))
        //            {
        //                ParseProject(a, br);
        //            }
        //        }
        //    }
        //}

    }
}
