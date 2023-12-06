using NPOI.HSSF.UserModel;
using NPOI.SS.Formula;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace litexcel
{
    internal class ExcelLoad
    {
        static ExcelLoad()
        {
            litsdk.API.OnExit += ClearSheet;
            if (litsdk.API.GetDesignActivityContext != null)
            {
                litsdk.API.OnChangeProject += ClearSheet;
            }
        }

        private static void ClearSheet()
        {
            lock (lk)
            {
                foreach (ExcelLoad el in sheetList)
                {
                    el.sheet.Workbook.Close();
                }
                sheetList.Clear();
            }
        }

        private static object lk = new object();
        /// <summary>
        /// 当下这个对象对应的sheet表
        /// </summary>
        private static List<ExcelLoad> sheetList = new List<ExcelLoad>();
        /// <summary>
        /// 设置Excel对像
        /// </summary>
        /// <param name="name"></param>
        public static void SetExcel(ExcelLoad el)
        {
            lock (lk)
            {
                ExcelLoad find = sheetList.Find((f) => f.name == el.name);
                if (find != null) sheetList.Remove(find);
                sheetList.Add(el);
            }
        }

        /// <summary>
        /// 获取Excel对像
        /// </summary>
        /// <param name="name"></param>
        public static ExcelLoad GetExcel(string name)
        {
            lock (lk)
            {
                ExcelLoad find = sheetList.Find((f) => f.name == name);
                return find;
            }
        }

        public string name = "";
        public HSSFWorkbook wk = null;
        public XSSFWorkbook xk = null;
        //public FileStream fs = null;
        public ISheet sheet = null;
        public string file = "";


        public const string RefFile = "NPOI.dll,NPOI.OOXML.dll,NPOI.OpenXml4Net.dll,NPOI.OpenXmlFormats.dll,ICSharpCode.SharpZipLib.dll,BouncyCastle.Crypto.dll";


        /// <summary>
                /// 将excel中字符列转换为数字
                /// </summary>
                /// <param name="columnName">字母列名称</param>
                /// <returns></returns>
        public static int ToIndex(string columnName)
        {
            if (!Regex.IsMatch(columnName.ToUpper(), @"^[A-Z]+$")) { return -1; }


            int index = 0;
            char[] chars = columnName.ToUpper().ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                index += ((int)chars[i] - (int)'A' + 1) * (int)Math.Pow(26, chars.Length - i - 1);
            }
            return index - 1;
        }

        /// <summary>
        /// 将数字转换为excel中字母列
        /// </summary>
        /// <param name="index">数字</param>
        /// <returns></returns>
        public static string ToName(int index)
        {
            if (index < 0) { throw new Exception("invalid parameter"); }

            List<string> chars = new List<string>();
            do
            {
                if (chars.Count > 0) index--;
                chars.Insert(0, ((char)(index % 26 + (int)'A')).ToString());
                index = (int)((index - index % 26) / 26);
            } while (index > 0);

            return String.Join(string.Empty, chars.ToArray());
        }

        public static string GetCellStr(ICell cc,bool href)
        {
            string data = "";
            if (cc == null) return "";
            if (href)
            {
                data = cc.Hyperlink == null ? "" : cc.Hyperlink.Address;
                return data;
            }
            try
            {
                switch (cc.CellType)
                {
                    case CellType.Boolean:
                        data = cc.BooleanCellValue.ToString();
                        break;
                    case CellType.Numeric:
                        if (DateUtil.IsCellDateFormatted(cc))
                        {
                            data = cc.DateCellValue == null ? "" : cc.DateCellValue.ToString();
                        }
                        else
                        {
                            data = cc.NumericCellValue.ToString();
                        }
                        break;
                    case CellType.String:
                        data = cc.StringCellValue;
                        break;
                    case CellType.Blank:
                        data = "";
                        break;
                    case CellType.Formula://公式
                        HSSFFormulaEvaluator eva = new HSSFFormulaEvaluator(cc.Sheet.Workbook);
                        data = eva.Evaluate(cc).StringValue;
                        break;
                    default:
                        data = cc.StringCellValue;
                        break;
                }
            }
            catch { }
            return data;
        }
    }
}
