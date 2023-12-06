using litsdk;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litexcel
{
    [litsdk.ActivityInfo(Name = "保存关闭", RefFile = ExcelLoad.RefFile, IsLinux = true, Index = 40)]
    public class SaveActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "保存关闭";

        public override ActivityGroup Group => ActivityGroup.Excel;

        /// <summary>
        /// Excel对像
        /// </summary>
        public string ExcelName = "";

        /// <summary>
        /// 保存后关闭
        /// </summary>
        public bool CloseAfterSave = true;

        /// <summary>
        /// 操作方式
        /// </summary>
        public SaveType SaveType = SaveType.Save;

        /// <summary>
        /// 另存为路径
        /// </summary>
        public string SaveAsPath = "";

        public override void Execute(ActivityContext context)
        {
            string excelName = context.ReplaceVar(this.ExcelName);
            ExcelLoad load = ExcelLoad.GetExcel(excelName);
            if (load == null) throw new Exception($"Excel对象{excelName}没有打开");

            switch (this.SaveType)
            {
                case SaveType.Save:
                    FileStream sv = new FileStream(load.file, FileMode.Create, FileAccess.ReadWrite);
                    load.sheet.Workbook.Write(sv);
                    load.sheet.Workbook.Close();
                    sv.Close();

                    if (!this.CloseAfterSave)
                    {
                        FileStream fs = new FileStream(load.file, FileMode.OpenOrCreate, FileAccess.ReadWrite);  //打开myxls.xls文件
                        load.xk = null;
                        load.wk = null;

                        if (load.file.EndsWith(".xls", StringComparison.OrdinalIgnoreCase))
                        {
                            load.wk = new HSSFWorkbook(fs);   //把xls文件中的数据写入wk中
                        }
                        else
                        {
                            load.xk = new XSSFWorkbook(fs);
                        }
                        load.sheet = load.wk == null ? load.xk.GetSheetAt(0) : load.wk.GetSheetAt(0);
                    }
                    context.WriteLog("成功保存Excel文件:" + load.file);
                    break;
                case SaveType.SaveAs:
                    string savepath = context.ReplaceVar(this.SaveAsPath);
                    FileStream fs2 = new FileStream(savepath, FileMode.Create, FileAccess.ReadWrite);
                    load.sheet.Workbook.Write(fs2);
                    load.sheet.Workbook.Close();
                    fs2.Close();
                    context.WriteLog("成功另存为Excel文件:" + savepath);
                    break;
                case SaveType.OnlyClose:
                    load.sheet.Workbook.Close();
                    context.WriteLog("成功关闭Excel文件:" + load.file);
                    break;
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.ExcelName)) throw new Exception("Excel对象不能为空");
            if (this.SaveType == SaveType.SaveAs && string.IsNullOrEmpty(this.SaveAsPath)) throw new Exception("另存时文件地址不存在");
        }
    }
}