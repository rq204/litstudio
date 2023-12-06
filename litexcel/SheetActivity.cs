using litsdk;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litexcel
{
    [litsdk.ActivityInfo(Name = "工作表操作", Description = "新建、删除或是切换Sheet页", RefFile = ExcelLoad.RefFile, IsLinux = true, Index = 30)]
    public class SheetActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "工作表操作";

        public override ActivityGroup Group => ActivityGroup.Excel;

        public SheetType SheetType = SheetType.AddNew;

        public string ExcelName = "";

        public string SheetName = "";

        public bool SwitchAfterChange = true;

        public override void Execute(ActivityContext context)
        {
            string excelName = context.ReplaceVar(this.ExcelName);
            ExcelLoad load = ExcelLoad.GetExcel(excelName);
            if (load == null) throw new Exception($"Excel对象{excelName}没有打开");

            string sheetName = context.ReplaceVar(this.SheetName);
            switch (this.SheetType)
            {
                case SheetType.AddNew:
                    ISheet sheetAdd = load.sheet.Workbook.CreateSheet(sheetName);
                    if (this.SwitchAfterChange) load.sheet = sheetAdd;
                    context.WriteLog($"成功添加工作表{sheetName}");
                    break;
                case SheetType.DeleteCur:
                case SheetType.Delete:
                    if (this.SheetType == SheetType.DeleteCur) sheetName = load.sheet.SheetName;
                    if (load.sheet.Workbook.NumberOfSheets == 1)
                    {
                        throw new Exception("当前只有一个工作表，禁止删除");
                    }
                    else
                    {
                        load.sheet.Workbook.RemoveName(sheetName);
                        load.sheet = load.sheet.Workbook.GetSheetAt(0);
                        context.WriteLog($"成功删除当前工作表{sheetName}");
                    }
                    break;
                case SheetType.Copy:
                    if (load.sheet.SheetName == sheetName)
                    {
                        throw new Exception("当前工作表和要复制的新工作表名不能一样");
                    }
                    ISheet copy = load.sheet.CopySheet(sheetName, true);
                    if (this.SwitchAfterChange) load.sheet = copy;
                    context.WriteLog($"成功复制当前工作表至{sheetName}");
                    break;
                case SheetType.Switch:
                    ISheet select = load.sheet.Workbook.GetSheet(sheetName);
                    if (select == null) throw new Exception("没有找到要切换的工作表");
                    load.sheet = select;
                    context.WriteLog($"成功切换工作表至{sheetName}");
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
            if (this.SheetType != SheetType.DeleteCur && string.IsNullOrEmpty(this.SheetName)) throw new Exception("工作表名不能为空");
        }
    }
}
