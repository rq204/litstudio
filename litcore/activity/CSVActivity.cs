using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using litsdk;

namespace litcore.activity
{
    [ActivityInfo(Name = "CSV操作", IsLinux = true)]
    public class CSVActivity : litsdk.ProcessActivity
    {
        private string name = "CSV操作";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.CSV;

        /// <summary>
        /// 读取csv还是写入
        /// </summary>
        public bool Read = false;

        /// <summary>
        /// 是覆盖还是增加
        /// </summary>
        public bool OverWrite = true;

        /// <summary>
        /// 操作变量名
        /// </summary>
        public string TableVarName = "";

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FileVarName = "";

        public override void Execute(ActivityContext context)
        {
            string path = context.GetStr(this.FileVarName);

            if (this.Read)
            {
                DataTable old = context.GetTable(this.TableVarName);
                if (!System.IO.File.Exists(path)) throw new Exception("不存在csv文件:" + path);
                string csvStr = System.IO.File.ReadAllText(path, System.Text.Encoding.UTF8);

                DataTable addTable = CSVToDataTable(csvStr, true);

                List<string> headers = context.GetTableColumns(this.TableVarName);

                Variable variable = context.Variables.Find((f) => f.Name == this.TableVarName);

                if (OverWrite)//覆盖只需要处理表头即可的
                {
                    if (headers.Count > 0)
                    {
                        //添加和移除表头
                        List<string> removes = new List<string>();
                        foreach (string name in headers)
                        {
                            if (!addTable.Columns.Contains(name))
                            {
                                addTable.Columns.Add(name);
                            }
                        }
                        foreach (DataColumn dataColumn in addTable.Columns)
                        {
                            if (!headers.Contains(dataColumn.ColumnName)) removes.Add(dataColumn.ColumnName);
                        }
                        foreach (string name in removes)
                        {
                            addTable.Columns.Remove(name);
                        }
                    }
                    variable.TableValue = addTable;
                }
                else
                {
                    foreach (DataRow dataRow in addTable.Rows)
                    {
                        DataRow dr = variable.TableValue.NewRow();
                        foreach (DataColumn dc in old.Columns)
                        {
                            if (addTable.Columns.Contains(dc.ColumnName))
                            {
                                dr[dc.ColumnName] = dataRow[dc.ColumnName];
                            }
                            else
                            {
                                dr[dc.ColumnName] = "";
                            }
                        }
                        old.Rows.Add(dr);
                    }
                }
            }
            else
            {
                System.Data.DataTable dataTable = context.GetTable(this.TableVarName);

                string dir = System.IO.Path.GetDirectoryName(path);
                if (!System.IO.Directory.Exists(dir)) System.IO.Directory.CreateDirectory(dir);

                string data = DataTableToCSVString(dataTable, true);
                string datanoheader = DataTableToCSVString(dataTable, false);
                if (this.OverWrite)
                {
                    System.IO.File.WriteAllText(path, data, System.Text.Encoding.UTF8);
                }
                else
                {
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.AppendAllText(path, datanoheader, System.Text.Encoding.UTF8);
                    }
                    else
                    {
                        System.IO.File.WriteAllText(path, data, System.Text.Encoding.UTF8);
                    }
                }
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (!context.ContainsTable(this.TableVarName)) throw new Exception($"不存在表格变量{this.TableVarName}");
            if (!context.ContainsStr(this.FileVarName)) throw new Exception($"不存在字符变量{this.FileVarName}");
        }

        /// <summary>
        /// 表格变csv字符并加
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="header"></param>
        public static string DataTableToCSVString(DataTable dt, bool header)
        {
            StringBuilder sb = new StringBuilder();
            string data = "";

            if (header)
            {
                for (int i = 0; i < dt.Columns.Count; i++)//写入列名
                {
                    data += dt.Columns[i].ColumnName.ToString();
                    if (i < dt.Columns.Count - 1)
                    {
                        data += ",";
                    }
                }
                sb.AppendLine(data);
            }

            for (int i = 0; i < dt.Rows.Count; i++) //写入各行数据
            {
                data = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string str = dt.Rows[i][j].ToString();
                    str = str.Replace("\"", "\"\"");//替换英文冒号 英文冒号需要换成两个冒号
                    if (str.Contains(',') || str.Contains('"')
                        || str.Contains('\r') || str.Contains('\n')) //含逗号 冒号 换行符的需要放到引号中
                    {
                        str = string.Format("\"{0}\"", str);
                    }

                    data += str;
                    if (j < dt.Columns.Count - 1)
                    {
                        data += ",";
                    }
                }
                sb.AppendLine(data);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 将CSV数据转换为DataTable
        /// </summary>
        /// <param name="csvStr">包含以","分隔的CSV数据的字符串</param>
        /// <param name="isRowHead">是否将第一行作为字段名</param>
        /// <returns></returns>
        public static DataTable CSVToDataTable(string csvStr, bool isRowHead)
        {
            DataTable dt = null;
            if (!string.IsNullOrEmpty(csvStr))
            {
                dt = new DataTable();
                string split = csvStr.Contains("\r\n") ? "\r\n" : "\n";
                string[] csvRows = csvStr.Split(new string[] { split }, StringSplitOptions.RemoveEmptyEntries);
                string[] csvColumns = null;
                if (csvRows != null)
                {
                    if (csvRows.Length > 0)
                    {
                        //第一行作为字段名,添加第一行记录并删除csvRows中的第一行数据
                        if (isRowHead)
                        {
                            csvColumns = FromCsvLine(csvRows[0]);
                            csvRows[0] = null;
                            for (int i = 0; i < csvColumns.Length; i++)
                            {
                                dt.Columns.Add(csvColumns[i]);
                            }
                        }

                        for (int i = 0; i < csvRows.Length; i++)
                        {
                            if (csvRows[i] != null)
                            {
                                csvColumns = FromCsvLine(csvRows[i]);
                                //检查列数是否足够,不足则补充
                                if (dt.Columns.Count < csvColumns.Length)
                                {
                                    int columnCount = csvColumns.Length - dt.Columns.Count;
                                    for (int c = 0; c < columnCount; c++)
                                    {
                                        dt.Columns.Add();
                                    }
                                }
                                dt.Rows.Add(csvColumns);
                            }
                        }
                    }
                }
            }

            return dt;
        }
        /// <summary>
        /// 解析一行CSV数据
        /// </summary>
        /// <param name="csv">csv数据行</param>
        /// <returns></returns>
        private static string[] FromCsvLine(string csv)
        {
            List<string> csvLiAsc = new List<string>();
            List<string> csvLiDesc = new List<string>();

            if (!string.IsNullOrEmpty(csv))
            {
                //顺序超找
                int lastIndex = 0;
                int quotCount = 0;
                //剩余的字符串
                string lstr = string.Empty;
                for (int i = 0; i < csv.Length; i++)
                {
                    if (csv[i] == '"')
                    {
                        quotCount++;
                    }
                    else if (csv[i] == ',' && quotCount % 2 == 0)
                    {
                        csvLiAsc.Add(ReplaceQuote(csv.Substring(lastIndex, i - lastIndex)));
                        lastIndex = i + 1;
                        if (lastIndex == csv.Length)//以,结尾时再加空内容
                        {
                            csvLiAsc.Add("");
                        }
                    }
                    if (i == csv.Length - 1 && lastIndex < csv.Length)
                    {
                        lstr = csv.Substring(lastIndex, i - lastIndex + 1);
                    }
                }
                if (!string.IsNullOrEmpty(lstr))
                {
                    //倒序超找
                    lastIndex = 0;
                    quotCount = 0;
                    string revStr = Reverse(lstr);
                    for (int i = 0; i < revStr.Length; i++)
                    {
                        if (revStr[i] == '"')
                        {
                            quotCount++;
                        }
                        else if (revStr[i] == ',' && quotCount % 2 == 0)
                        {
                            csvLiDesc.Add(ReplaceQuote(Reverse(revStr.Substring(lastIndex, i - lastIndex))));
                            lastIndex = i + 1;
                        }
                        if (i == revStr.Length - 1 && lastIndex < revStr.Length)
                        {
                            csvLiDesc.Add(ReplaceQuote(Reverse(revStr.Substring(lastIndex, i - lastIndex + 1))));
                            lastIndex = i + 1;
                        }

                    }
                    string[] tmpStrs = csvLiDesc.ToArray();
                    Array.Reverse(tmpStrs);
                    csvLiAsc.AddRange(tmpStrs);
                }
            }

            return csvLiAsc.ToArray();
        }
        /// <summary>
        /// 反转字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string Reverse(string str)
        {
            string revStr = string.Empty;
            foreach (char chr in str)
            {
                revStr = chr.ToString() + revStr;
            }
            return revStr;
        }
        /// <summary>
        /// 替换CSV中的双引号转义符为正常双引号,并去掉左右双引号
        /// </summary>
        /// <param name="csvValue">csv格式的数据</param>
        /// <returns></returns>
        private static string ReplaceQuote(string csvValue)
        {
            string rtnStr = csvValue;
            if (!string.IsNullOrEmpty(csvValue))
            {
                //首尾都是"
                Match m = Regex.Match(csvValue, "^\"(.*?)\"$");
                if (m.Success)
                {
                    rtnStr = m.Result("${1}").Replace("\"\"", "\"");
                }
                else
                {
                    rtnStr = rtnStr.Replace("\"\"", "\"");
                }
            }
            return rtnStr;

        }
    }

}