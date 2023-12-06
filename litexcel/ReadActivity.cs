using litsdk;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace litexcel
{
    [litsdk.ActivityInfo(Name = "读取内容", RefFile = ExcelLoad.RefFile, IsLinux = true, Index = 10)]
    public class ReadActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "读取内容";

        public override ActivityGroup Group => ActivityGroup.Excel;

        public string ExcelName = "";

        public ReadType ReadType = ReadType.Cell;

        /// <summary>
        /// 行开始
        /// </summary>
        public string RowStart = "1";

        /// <summary>
        /// 行结束
        /// </summary>
        public string RowEnd = "";

        /// <summary>
        /// 列开始
        /// </summary>
        public string ColStart = "A";

        /// <summary>
        /// 列结束
        /// </summary>
        public string ColEnd = "";

        /// <summary>
        /// 最后一行
        /// </summary>
        public bool LastRow = false;

        /// <summary>
        /// 最后一列
        /// </summary>
        public bool LastCol = false;

        /// <summary>
        /// 第一行是表头
        /// </summary>
        public bool SelectFirstIsHeader = false;

        /// <summary>
        /// 获取内容为链接
        /// </summary>
        public bool FromHref = false;

        /// <summary>
        /// 保存至变量
        /// </summary>
        public string SaveVarName = "";

        public override void Execute(ActivityContext context)
        {
            string excelName = context.ReplaceVar(this.ExcelName);
            ExcelLoad load = ExcelLoad.GetExcel(excelName);
            if (load == null) throw new Exception("不存在的Excel对象，请确认要先打开");

            string sRowStart = context.ReplaceVar(this.RowStart);
            string sRowEnd = context.ReplaceVar(this.RowEnd);
            string sColStart = context.ReplaceVar(this.ColStart);
            string sColEnd = context.ReplaceVar(this.ColEnd);

            int rowStartIndex = 0, rowEndIndex = 0, colStartIndex = 0, lastcol = 0;
            List<string> ls = new List<string>();

            List<string> header = new List<string>();
            if (load.sheet.PhysicalNumberOfRows > 0 && this.SelectFirstIsHeader)
            {
                IRow iir = load.sheet.GetRow(0);
                for (int c = 0; c < iir.LastCellNum; c++)
                {
                    ICell crow = iir.GetCell(c);
                    string cdata = ExcelLoad.GetCellStr(crow,this.FromHref);
                    header.Add(cdata);
                }
            }

            switch (this.ReadType)
            {
                case ReadType.Cell:
                    colStartIndex = ExcelLoad.ToIndex(sColStart);
                    if (header.Contains(sColStart)) colStartIndex = header.IndexOf(sColStart);
                    if (colStartIndex == -1) throw new Exception("不存在的列名:" + sColStart);
                    if (int.TryParse(sRowStart, out rowStartIndex))
                    {
                        rowStartIndex--;
                        IRow row1 = load.sheet.GetRow(rowStartIndex);
                        if (row1 == null || row1.GetCell(colStartIndex) == null)
                        {
                            if (context.ContainsStr(this.SaveVarName)) context.SetVarStr(this.SaveVarName, "");
                            else
                            {
                                context.SetVarInt(this.SaveVarName, 0);
                            }
                            context.WriteLog("行号或是列号值为空，取值为空");
                        }
                        else
                        {
                            ICell ic = row1.GetCell(colStartIndex);
                            string sdata = ExcelLoad.GetCellStr(ic,FromHref);
                            if (context.ContainsStr(this.SaveVarName)) context.SetVarStr(this.SaveVarName, sdata);
                            else
                            {
                                try
                                {
                                    if (ic.CellType == CellType.Numeric)
                                    {
                                        context.SetVarInt(this.SaveVarName, (int)ic.NumericCellValue);
                                    }
                                    else
                                    {
                                        int num = Convert.ToInt32(sdata);
                                        context.SetVarInt(this.SaveVarName, num);
                                    }
                                }
                                catch
                                {
                                    context.SetVarInt(this.SaveVarName, 0);
                                }
                            }
                            context.WriteLog("获取Cell值成功");
                        }
                    }
                    else
                    {
                        throw new Exception("行号错误:" + sRowStart);
                    }
                    break;
                case ReadType.Col:
                    colStartIndex = ExcelLoad.ToIndex(sColStart);
                    if (header.Contains(sColStart)) colStartIndex = header.IndexOf(sColStart);
                    if (colStartIndex == -1) throw new Exception("不存在的列名:" + sColStart);
                    if (load.sheet.PhysicalNumberOfRows == 0)
                    {
                        context.WriteLog($"当前列没有值，跳过获取");
                    }
                    else
                    {
                        for (int i = 0; i <= load.sheet.LastRowNum; i++)
                        {
                            IRow rrow = load.sheet.GetRow(i);
                            string data = "";
                            if (rrow != null)
                            {
                                ICell cell = rrow.GetCell(colStartIndex);
                                if (cell != null) data = ExcelLoad.GetCellStr(cell,FromHref);
                            }
                            ls.Add(data);
                        }
                        if (this.SelectFirstIsHeader) ls.RemoveAt(0);
                        context.SetVarList(this.SaveVarName, ls);
                        context.WriteLog($"获取列{sColStart}值成功，结果数为{ls.Count}");
                    }
                    break;
                case ReadType.Row:
                    if (int.TryParse(sRowStart, out rowStartIndex))
                    {
                        rowStartIndex--;
                        IRow ir = load.sheet.GetRow(rowStartIndex);
                        if (ir != null)
                        {
                            for (int c = 0; c < ir.PhysicalNumberOfCells; c++)
                            {
                                ICell crow = ir.GetCell(c);
                                string cdata = ExcelLoad.GetCellStr(crow,FromHref);
                                ls.Add(cdata);
                            }
                        }
                        else
                        {
                            throw new Exception("不存在列:" + rowStartIndex + 1);
                        }
                        context.SetVarList(this.SaveVarName, ls);
                        context.WriteLog($"获取行{sColStart}值成功，结果数为{ls.Count}");
                    }
                    else
                    {
                        throw new Exception("行号错误");
                    }
                    break;

                case ReadType.Region:
                    colStartIndex = ExcelLoad.ToIndex(sColStart);
                    if (header.Contains(sColStart)) colStartIndex = header.IndexOf(sColStart);
                    if (colStartIndex == -1) throw new Exception("不存在的列名:" + sColStart);
                    if (load.sheet.PhysicalNumberOfRows == 0)
                    {
                        throw new Exception("当前Excel无任何数据");
                    }

                    List<string> headers = new List<string>();

                    if (!int.TryParse(sRowStart, out rowStartIndex) || rowStartIndex < 1) throw new Exception("开始行号错误");

                    rowStartIndex--;
                    if (LastRow) rowEndIndex = load.sheet.LastRowNum;
                    else
                    {
                        if (!int.TryParse(sRowEnd, out rowEndIndex))
                        {
                            throw new Exception("结束行号错误");
                        }
                        rowEndIndex--;
                    }

                    if (this.SelectFirstIsHeader)
                    {
                        IRow head = load.sheet.GetRow(rowStartIndex);
                        for (int r = 0; r < head.LastCellNum; r++) headers.Add(ExcelLoad.GetCellStr(head.GetCell(r),FromHref));
                        rowStartIndex++;
                    }
                    else
                    {
                        IRow head = load.sheet.GetRow(0);
                        for (int r = 0; r < head.LastCellNum; r++) headers.Add(ExcelLoad.GetCellStr(head.GetCell(r),FromHref));
                        if (rowStartIndex == 0) rowStartIndex++;
                    }

                    if (!LastCol)
                    {
                        lastcol = ExcelLoad.ToIndex(sColEnd);
                        if (lastcol >= headers.Count) throw new Exception("列超出了范围");
                        else headers = headers.GetRange(colStartIndex, lastcol + 1);
                    }


                    System.Data.DataTable table = context.GetTable(this.SaveVarName);
                    if (table == null) table = new System.Data.DataTable();
                    foreach (string h in headers)
                    {
                        if (!table.Columns.Contains(h)) table.Columns.Add(h);
                    }

                    int add = 0;
                    for (int n = rowStartIndex; n <= rowEndIndex; n++)
                    {
                        System.Data.DataRow dr = table.NewRow();
                        List<object> lbo = new List<object>();
                        IRow rangeRow = load.sheet.GetRow(n);

                        for (int p = 0; p < headers.Count; p++)
                        {
                            string data = "";
                            if (rangeRow != null)
                            {
                                ICell cc = rangeRow.GetCell(p);
                                data = ExcelLoad.GetCellStr(cc,FromHref);
                            }
                            lbo.Add(data);
                        }
                        dr.ItemArray = lbo.ToArray();
                        add++;
                        table.Rows.Add(dr);
                    }

                    context.WriteLog($"获取区域数据成功，共获取数据{add}条");
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
            switch (this.ReadType)
            {
                case ReadType.Cell:
                    if (string.IsNullOrEmpty(this.RowStart)) throw new Exception("单元格行号不能为空");
                    if (string.IsNullOrEmpty(this.ColStart)) throw new Exception("单元格列名不能为空");
                    if (!context.ContainsStr(this.SaveVarName) && !context.ContainsInt(this.SaveVarName)) throw new Exception("不存在字符或数字变量：" + this.SaveVarName);
                    break;
                case ReadType.Col:
                    if (string.IsNullOrEmpty(this.ColStart)) throw new Exception("列名不能为空");
                    if (!context.ContainsList(this.SaveVarName)) throw new Exception("不存在列表变量：" + this.SaveVarName);
                    break;
                case ReadType.Region:
                    if (string.IsNullOrEmpty(this.RowStart)) throw new Exception("行号不能为空");
                    if (string.IsNullOrEmpty(this.ColStart)) throw new Exception("列名不能为空");
                    if (!this.LastRow && string.IsNullOrEmpty(this.RowEnd)) throw new Exception("结束行号不能为空");
                    if (!this.LastRow && string.IsNullOrEmpty(this.ColStart)) throw new Exception("结束列名不能为空");
                    if (!context.ContainsTable(this.SaveVarName)) throw new Exception("不存在表格变量：" + this.SaveVarName);
                    break;
                case ReadType.Row:
                    if (string.IsNullOrEmpty(this.RowStart)) throw new Exception("行号不能为空");
                    if (!context.ContainsList(this.SaveVarName)) throw new Exception("不存在列表变量：" + this.SaveVarName);
                    break;
            }
        }
    }
}