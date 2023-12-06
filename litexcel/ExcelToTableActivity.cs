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
    [litsdk.ActivityInfo(Name = "读写表格", RefFile = ExcelLoad.RefFile, Index = 100, IsLinux = true)]
    /// <summary>
    /// 可以将sheet的表格读写入表格
    /// </summary>
    public class ExcelToTableActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "读写表格";


        public ExcelToTableType ExcelToTableType = ExcelToTableType.ExcelDataToTable;

        /// <summary>
        /// excel文档
        /// </summary>
        public string ExcelFilePath = "";

        public string SheetName = "";

        /// <summary>
        /// 覆盖原来数据
        /// </summary>
        public bool OverWrite = false;

        /// <summary>
        /// 表格变量
        /// </summary>
        public string TableVarName = "";

        public override ActivityGroup Group => ActivityGroup.Excel;

        public override void Execute(ActivityContext context)
        {
            string filepath = context.ReplaceVar(this.ExcelFilePath);
            string sheetname = context.ReplaceVar(this.SheetName);
            if (string.IsNullOrEmpty(sheetname)) throw new Exception("sheet名称不能为空");

            HSSFWorkbook wk = null;
            XSSFWorkbook xk = null;
            FileStream fs = null;
            ISheet sheet = null;

            try
            {
                switch (this.ExcelToTableType)
                {
                    case ExcelToTableType.ExcelDataToTable:
                        if (!System.IO.File.Exists(filepath)) throw new Exception("Excel文件不存在:" + filepath);
                        fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);  //打开myxls.xls文件

                        if (filepath.EndsWith(".xls", StringComparison.OrdinalIgnoreCase))
                        {
                            wk = new HSSFWorkbook(fs);   //把xls文件中的数据写入wk中
                        }
                        else
                        {
                            xk = new XSSFWorkbook(fs);
                        }

                        sheet = wk == null ? xk.GetSheet(sheetname) : wk.GetSheet(sheetname);
                        if (sheet == null) throw new Exception($"没有找到sheet名{sheetname}");

                        System.Data.DataTable table = context.GetTable(this.TableVarName);
                        if (this.OverWrite) table = new System.Data.DataTable();

                        if (sheet.PhysicalNumberOfRows == 0)
                        {
                            context.WriteLog("Excel数据为空，当前数据导出到表格为空");
                            context.Variables.Find((F) => F.Name == this.TableVarName).TableValue = table;
                        }
                        else
                        {
                            List<int> pos = new List<int>();
                            for (int i = 0; i <= sheet.LastRowNum; i++)  //NumberOfSheets是myxls.xls中总共的表数
                            {
                                IRow row = sheet.GetRow(i);
                                System.Data.DataRow dr = table.NewRow();
                                for (int j = 0; j < row.LastCellNum; j++)
                                {
                                    string value = "";
                                    if (row.Cells[j].CellType == CellType.Numeric) value = row.Cells[j].NumericCellValue.ToString();
                                    else if (row.Cells[j].CellType == CellType.String) value = row.Cells[j].StringCellValue;

                                    if (i == 0)
                                    {
                                        if (!table.Columns.Contains(value))
                                        {
                                            table.Columns.Add(value, typeof(string));
                                        }
                                        pos.Add(table.Columns.IndexOf(value));
                                    }
                                    else
                                    {
                                        dr[pos[j]] = value;
                                    }
                                }
                                if (i > 0) table.Rows.Add(dr);
                            }
                        }
                        context.Variables.Find((f) => f.Name == this.TableVarName).TableValue = table;
                        context.WriteLog($"成功读取Excel文件{table.Rows.Count}条数据至表格变量 {this.TableVarName}");
                        break;
                    case ExcelToTableType.TableDataToExcel:
                        int maxrow = 1048576;
                        if (this.OverWrite && System.IO.File.Exists(filepath)) System.IO.File.Delete(filepath);
                        //1048576 65536
                        if (System.IO.File.Exists(filepath))
                        {
                            fs = new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite);  //打开myxls.xls文件

                            if (filepath.EndsWith(".xls", StringComparison.OrdinalIgnoreCase))
                            {
                                wk = new HSSFWorkbook(fs);   //把xls文件中的数据写入wk中
                                maxrow = 65536;
                            }
                            else
                            {
                                xk = new XSSFWorkbook(fs);
                            }
                            fs.Close();
                            sheet = wk == null ? xk.GetSheet(sheetname) : wk.GetSheet(sheetname);
                            if (sheet == null)
                            {
                                sheet = wk == null ? xk.CreateSheet(sheetname) : wk.CreateSheet(sheetname);
                            }
                        }
                        else
                        {
                            if (filepath.EndsWith(".xls", StringComparison.OrdinalIgnoreCase))
                            {
                                wk = new HSSFWorkbook();   //把xls文件中的数据写入wk中
                                maxrow = 65536;
                            }
                            else
                            {
                                xk = new XSSFWorkbook();
                            }
                            sheet = wk == null ? xk.CreateSheet(sheetname) : wk.CreateSheet(sheetname);
                        }

                        System.Data.DataTable dt = context.GetTable(this.TableVarName);

                        if (dt.Rows.Count == 0)
                        {
                            context.WriteLog("表格变量数据为空，将写入空数据");
                        }

                        Dictionary<string, int> indexdic = new Dictionary<string, int>();
                        if (sheet.PhysicalNumberOfRows == 0)//要添加
                        {
                            IRow one = sheet.CreateRow(0);
                            for (int r = 0; r < dt.Columns.Count; r++)
                            {
                                one.CreateCell(r).SetCellValue(dt.Columns[r].ColumnName);
                                indexdic.Add(dt.Columns[r].ColumnName, r);
                            }
                        }
                        else
                        {
                            for (int y = 0; y < sheet.GetRow(0).PhysicalNumberOfCells; y++)
                            {
                                string name = sheet.GetRow(0).Cells[y].StringCellValue;
                                indexdic.Add(name, y);
                            }
                            for (int r = 0; r < dt.Columns.Count; r++)
                            {
                                if (!indexdic.ContainsKey(dt.Columns[r].ColumnName))
                                {
                                    sheet.GetRow(0).CreateCell(indexdic.Count).SetCellValue(dt.Columns[r].ColumnName);
                                    indexdic.Add(dt.Columns[r].ColumnName, indexdic.Count + 1);
                                }
                            }
                        }

                        int rowindex = sheet.LastRowNum;
                        for (int q = 0; q < dt.Rows.Count; q++)
                        {
                            if (sheet.LastRowNum == maxrow - 1)//最后一行时
                            {
                                for (int n = 2; n < 1000; n++)
                                {
                                    string sheetn = sheetname + n.ToString();
                                    ISheet sheet2 = sheet.Workbook.GetSheet(sheetn);
                                    if (sheet2 == null)
                                    {
                                        sheet2 = sheet.Workbook.CreateSheet(sheetn);
                                        IRow sheet2first = sheet2.CreateRow(0);
                                        IRow sheetfistrt = sheet.GetRow(0);
                                        for (int f = 0; f < sheetfistrt.LastCellNum; f++)
                                        {
                                            sheet2first.CreateCell(f).SetCellValue(sheetfistrt.Cells[f].StringCellValue);
                                        }
                                        sheet = sheet2;
                                        rowindex = 0;
                                        break;
                                    }
                                    else//sheet2还是不为空时
                                    {
                                        if (sheet2.LastRowNum == maxrow - 1) continue;
                                        else
                                        {
                                            if (sheet2.LastRowNum == -1)//没有数据
                                            {
                                                IRow sheet2first = sheet2.CreateRow(0);
                                                IRow sheetfistrt = sheet.GetRow(0);
                                                for (int f = 0; f < sheetfistrt.LastCellNum; f++)
                                                {
                                                    sheet2first.CreateCell(f).SetCellValue(sheetfistrt.Cells[f].StringCellValue);
                                                }
                                                sheet = sheet2;
                                                rowindex = 0;
                                                break;
                                            }
                                            else//有数据
                                            {
                                                sheet = sheet2;
                                                rowindex = sheet.LastRowNum;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }

                            IRow row = sheet.CreateRow(rowindex + 1);
                            rowindex++;
                            foreach (KeyValuePair<string, int> kv in indexdic)
                            {
                                string value = "";
                                if (dt.Columns.Contains(kv.Key))
                                {
                                    value = dt.Rows[q][kv.Key] == null ? "" : dt.Rows[q][kv.Key].ToString();
                                }
                                row.CreateCell(kv.Value).SetCellValue(value);
                            }

                        }

                        fs = new FileStream(filepath, FileMode.Create, FileAccess.ReadWrite);
                        if (wk != null) wk.Write(fs);
                        if (xk != null) xk.Write(fs);
                        context.WriteLog($"成功写入Excel文件{filepath}共{dt.Rows.Count}条数据");
                        break;
                }
            }
            finally
            {
                if (wk != null) wk.Close();
                if (xk != null) xk.Close();
                if (fs != null) fs.Close();
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.TableVarName)) throw new Exception("表格变量名称不能为空");
            if (!context.ContainsTable(this.TableVarName)) throw new Exception($"不存在表格变量{this.TableVarName}");
            if (string.IsNullOrEmpty(this.ExcelFilePath)) throw new Exception("Excel操作文档不能为空");
            if (string.IsNullOrEmpty(this.SheetName)) throw new Exception("Sheet名称不能为空");
        }
    }
}