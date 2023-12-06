using litsdk;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litexcel
{
    /// <summary>
    /// 一张Excel工作百表，对于是office excel 2003及以下版本最度大行数为知65536行，最道大列数256列；对于是office excel 2007及以上版版本最大行数为权1048576行，最大列数为16384列。 
    /// </summary>
    [litsdk.ActivityInfo(Name = "删除行", Description = "删除指定行或是所有行", Index = 20, IsLinux = true, RefFile = ExcelLoad.RefFile)]
    /// <summary>
    /// 删除行
    /// </summary>
    public class DeleteRowActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "删除行";

        public override ActivityGroup Group => ActivityGroup.Excel;

        /// <summary>
        /// 删除的方式
        /// </summary>
        public DeleteRowType DeleteRowType = DeleteRowType.Last;

        /// <summary>
        /// 行号开始
        /// </summary>
        public string RowStart = "";

        /// <summary>
        /// 行号结束 
        /// </summary>
        public string RowEnd = "";

        /// <summary>
        /// 结束行号为最后一行
        /// </summary>
        public bool LastRowNum = false;

        /// <summary>
        /// 要操作的Excel
        /// </summary>
        public string ExcelName = "";

        public override void Execute(ActivityContext context)
        {
            ExcelLoad load = ExcelLoad.GetExcel(this.ExcelName);
            if (load == null) throw new Exception("不存在的Excel对象，请确认要先打开");

            string log = "";
            int rStart = 0, rEnd = 0;
            switch (this.DeleteRowType)
            {
                case DeleteRowType.All:
                    rStart = 0;
                    rEnd = load.sheet.LastRowNum;
                    log = "成功删除所有行";
                    break;
                case DeleteRowType.First:
                    rStart = 0;
                    rEnd = 0;
                    log = "成功删除第一行";
                    break;
                case DeleteRowType.Last:
                    rStart = load.sheet.LastRowNum;
                    rEnd = load.sheet.LastRowNum;
                    log = "成功删除最后一行";
                    break;
                case DeleteRowType.Range:
                    string sStart = context.ReplaceVar(this.RowStart);
                    string sEnd = context.ReplaceVar(this.RowEnd);
                    if (!int.TryParse(sStart, out rStart) || !int.TryParse(sEnd, out rEnd))
                    {
                        throw new Exception("指定删除行区间错误");
                    }
                    else
                    {
                        rStart--;
                        rEnd--;
                    }
                    log = $"成功删除行起始{sStart}，行结束{sEnd}";
                    break;
            }

            for (int i = rEnd; i >= rStart; i--)
            {
                load.sheet.ShiftRows(i + 1, load.sheet.LastRowNum, -1);
            }

            context.WriteLog(log);
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.ExcelName)) throw new Exception("Excel对象不能为空");
        }
    }
}