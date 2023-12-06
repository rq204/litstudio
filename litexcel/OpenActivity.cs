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
    [litsdk.ActivityInfo(Name = "打开Excel", Description = "打开或是新建Excel文件", RefFile = ExcelLoad.RefFile, Index = 5, IsLinux = true)]
    public class OpenActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "打开Excel";

        public override ActivityGroup Group => ActivityGroup.Excel;

        /// <summary>
        /// 打开的路径
        /// </summary>
        public string ExcelPath = "";

        /// <summary>
        /// 工作表
        /// </summary>
        public string SheetName = "";

        /// <summary>
        /// 保存至
        /// </summary>
        public string ExcelName = "";

        public override void Execute(ActivityContext context)
        {
            string filePath = context.ReplaceVar(this.ExcelPath);
            string excelName = context.ReplaceVar(this.ExcelName);

            HSSFWorkbook wk = null;
            XSSFWorkbook xk = null;
            FileStream fs = null;
            ISheet sheet = null;

            bool exist = System.IO.File.Exists(filePath);
            string sheetName = context.ReplaceVar(this.SheetName);// string.IsNullOrEmpty(this.SheetName)?"sheet1"


            if (exist)
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);  //打开myxls.xls文件
                if (filePath.EndsWith(".xls", StringComparison.OrdinalIgnoreCase))
                {
                    wk = new HSSFWorkbook(fs);   //把xls文件中的数据写入wk中
                }
                else
                {
                    xk = new XSSFWorkbook(fs);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(sheetName)) sheetName = "sheet1";
                if (filePath.EndsWith(".xls", StringComparison.OrdinalIgnoreCase))
                {
                    wk = new HSSFWorkbook();   //把xls文件中的数据写入wk中
                    wk.CreateSheet(sheetName);
                }
                else
                {
                    xk = new XSSFWorkbook();
                    xk.CreateSheet(sheetName);
                }
            }

            if (fs != null) fs.Close();
            if (string.IsNullOrEmpty(sheetName))
            {
                sheet = wk == null ? xk.GetSheetAt(0) : wk.GetSheetAt(0);
            }
            else
            {
                sheet = wk == null ? xk.GetSheet(sheetName) : wk.GetSheet(sheetName);
            }
            if (sheet == null) throw new Exception($"Excel当中没有找到Sheet表:{sheetName}");
            ExcelLoad load = new ExcelLoad() { wk = wk, xk = xk, file = filePath, sheet = sheet, name = excelName };
            ExcelLoad.SetExcel(load);

            context.WriteLog($"成功打开文件:{filePath}");
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.ExcelPath)) throw new Exception("Excel文件路径不能为空");
            if (string.IsNullOrEmpty(this.ExcelName)) throw new Exception("Excel对象名不能为空");
        }
    }
}