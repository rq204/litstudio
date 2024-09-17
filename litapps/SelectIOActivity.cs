using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litapps
{
    [litsdk.ActivityInfo(Name = "选择文件", IsWinForm = true,IsFront =true)]
    public class SelectIOActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "选择文件";

        public override ActivityGroup Group => ActivityGroup.App;


        public bool SelectFile = true;

        public string Title = "";

        public string Filter = "*.*";

        public string SaveVarName = "";

        /// <summary>
        /// 必须选择
        /// </summary>
        public bool MustSelect = false;

        /// <summary>
        /// 可以多选
        /// </summary>
        public bool FileCanMultSelect = false;

        /// <summary>
        /// 必须多选
        /// </summary>
        public bool FileMustMultSelect = false;

        public override void Execute(ActivityContext context)
        {
            string title = context.ReplaceVar(this.Title);

            litsdk.API.GetMainForm().Invoke((EventHandler)delegate
            {
                if (this.SelectFile)
                {
                    while (true)
                    {
                        OpenFileDialog ofd = new OpenFileDialog();
                        ofd.CheckFileExists = true;
                        ofd.Title = title;

                        if (!string.IsNullOrEmpty(this.Filter))
                        {
                            List<string> add = new List<string>();
                            foreach (string filter in this.Filter.Split('|'))
                            {
                                add.Add(filter);
                            }
                            ofd.Filter = "文件类型|" + string.Join(";", add.ToArray());
                        }

                        if (this.FileCanMultSelect || this.FileMustMultSelect) ofd.Multiselect = true;
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            if (ofd.Multiselect)//多选
                            {
                                if (this.FileMustMultSelect)
                                {
                                    if (ofd.FileNames.Length > 1)
                                    {
                                        context.SetVarList(this.SaveVarName, ofd.FileNames.ToList());
                                        context.WriteLog($"成功选择{ofd.FileNames.Length}个文件");
                                        break;
                                    }
                                    else
                                    {
                                        context.WriteLog("必须选择多个文件，请重新选择");
                                    }
                                }
                                else
                                {
                                    if (ofd.FileNames.Length > 0)
                                    {
                                        context.SetVarList(this.SaveVarName, ofd.FileNames.ToList());
                                        context.WriteLog($"成功选择{ofd.FileNames.Length}个文件");
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                context.SetVarStr(this.SaveVarName, ofd.FileName);
                                context.WriteLog("成功选择一个文件：" + ofd.FileName);
                                break;
                            }
                        }
                        else
                        {
                            if (this.MustSelect)
                            {
                                if (this.FileMustMultSelect)
                                {
                                    context.WriteLog("必须选择多个文件，请重新选择");
                                }
                                else
                                {
                                    context.WriteLog("必须选择一个或多个文件，请重新选择");
                                }
                            }
                            else
                            {
                                context.WriteLog("没有选择任何文件，继续下一步");
                                break;
                            }
                        }
                    }

                }
                else//文件夹
                {
                    while (true)
                    {
                        FolderBrowserDialog folder = new FolderBrowserDialog();
                        folder.Description = title;
                        //folder.ShowNewFolderButton = true;
                        if (folder.ShowDialog() == DialogResult.OK)
                        {
                            context.SetVarStr(this.SaveVarName, folder.SelectedPath);
                            context.WriteLog("成功选择文件夹：" + folder.SelectedPath);
                            break;
                        }
                        else
                        {
                            if (this.MustSelect)
                            {
                                context.WriteLog("必须选择一个文件夹，请重新选择");
                            }
                            else
                            {
                                context.WriteLog("没有选择任何文件夹，继续下一步");
                                break;
                            }
                        }
                    }
                }
            });
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new SelectIOUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.Title))
            {
                throw new Exception("提示信息不能为空");
            }

            if (string.IsNullOrEmpty(this.SaveVarName)) throw new Exception("保存变量名不能为空");

            if (this.FileCanMultSelect || this.FileMustMultSelect)
            {
                if (!context.ContainsList(this.SaveVarName)) throw new Exception($"不存在列表变量{this.SaveVarName}");
            }
            else
            {
                if (!context.ContainsStr(this.SaveVarName)) throw new Exception($"不存在字符变量{this.SaveVarName}");
            }
        }
    }
}