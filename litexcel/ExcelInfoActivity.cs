using litsdk;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace litexcel
{
    [litsdk.ActivityInfo(Name = "文件信息", RefFile = ExcelLoad.RefFile, Index = 35, IsLinux = true)]
    public class ExcelInfoActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "文件信息";

        public override ActivityGroup Group => ActivityGroup.Excel;

        public string ExcelName = "";

        public string SheetNamesVarName = "";

        public string SheetHeaderVarName = "";

        public string SheetRowCountVarName = "";


        public override void Execute(ActivityContext context)
        {
            string excelName = context.ReplaceVar(this.ExcelName);
            ExcelLoad load = ExcelLoad.GetExcel(excelName);
            if (load == null) throw new Exception("不存在的Excel对象，请确认要先打开");

            List<string> logs = new List<string>();
            if (!string.IsNullOrEmpty(this.SheetHeaderVarName))
            {
                List<string> ls = new List<string>();
                if (load.sheet.LastRowNum >= 0)
                {
                    IRow ir = load.sheet.GetRow(0);
                    for (int j = 0; j < ir.LastCellNum; j++)
                    {
                        ls.Add(ir.Cells[j].StringCellValue);
                    }
                }
                context.SetVarList(this.SheetHeaderVarName, ls);
                logs.Add($"获取到Sheet表列名个数为{ls.Count}");
            }

            if (!string.IsNullOrEmpty(this.SheetNamesVarName))
            {
                List<string> ls = new List<string>();
                for (int i = 0; i < load.sheet.Workbook.NumberOfSheets; i++)
                {
                    ls.Add(load.sheet.Workbook.GetSheetName(i));
                }
                context.SetVarList(this.SheetNamesVarName, ls);
                logs.Add($"获取到Sheet个数为{ls.Count}");
            }

            if (!string.IsNullOrEmpty(this.SheetRowCountVarName))
            {
                context.SetVarInt(this.SheetRowCountVarName, load.sheet.LastRowNum + 1);
                logs.Add($"获取到当前Sheet行数为{load.sheet.LastRowNum + 1}");
            }

            context.WriteLog(string.Join(",", logs.ToArray()));
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.ExcelName)) throw new Exception("Excel对象不能为空");
            if (!string.IsNullOrEmpty(this.SheetHeaderVarName) && !context.ContainsList(this.SheetHeaderVarName)) throw new Exception($"不存在列表变量{this.SheetHeaderVarName}");
            if (!string.IsNullOrEmpty(this.SheetNamesVarName) && !context.ContainsList(this.SheetNamesVarName)) throw new Exception($"不存在列表变量{this.SheetHeaderVarName}");
            if (!string.IsNullOrEmpty(this.SheetRowCountVarName) && !context.ContainsInt(this.SheetRowCountVarName)) throw new Exception($"不存在数字变量{this.SheetHeaderVarName}");
        }
    }
}
