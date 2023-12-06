using litsdk;
using NPOI.HSSF.UserModel;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litexcel
{
    [litsdk.ActivityInfo(Name = "单元格写入", RefFile = ExcelLoad.RefFile, IsLinux = true, Index = 13)]
    /// <summary>
    /// 单元格写入
    /// https://blog.csdn.net/u013986317/article/details/102502794
    /// https://blog.csdn.net/dingsi7709/article/details/101738685
    /// </summary>
    public class WriteActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "单元格写入";

        public override ActivityGroup Group => ActivityGroup.Excel;

        public string ExcelName = "";

        /// <summary>
        /// 行号
        /// </summary>
        public string RowStart = "";

        /// <summary>
        /// 列名
        /// </summary>
        public string ColStart = "";

        /// <summary>
        /// 行高
        /// </summary>
        public string RowHeight = "270";

        /// <summary>
        /// 列宽
        /// </summary>
        public string ColWidth = "8";

        /// <summary>
        /// 写入变量名
        /// </summary>
        public string WriteVarName = "";

        /// <summary>
        /// 是图片
        /// </summary>
        public bool IsImage = false;

        /// <summary>
        /// 图片属性
        /// </summary>
        public AnchorType AnchorType = AnchorType.MoveDontResize;

        public override void Execute(ActivityContext context)
        {
            string excelName = context.ReplaceVar(this.ExcelName);
            ExcelLoad load = ExcelLoad.GetExcel(excelName);
            if (load == null) throw new Exception($"Excel对象{excelName}没有打开");

            int rowStart = 0, colStart = 0, rowHeight = 0, colWidth = 0;
            string rowS = context.ReplaceVar(this.RowStart);
            string rowH = context.ReplaceVar(this.RowHeight);
            string colS = context.ReplaceVar(this.ColStart);
            string colW = context.ReplaceVar(this.ColWidth);

            if (!int.TryParse(rowS, out rowStart)) throw new Exception("行号数据错误：" + rowS);
            if (!int.TryParse(rowH, out rowHeight)) throw new Exception("行高数据错误：" + rowH);
            if (!int.TryParse(colW, out colWidth)) throw new Exception("列宽数据错误：" + colW);
            rowStart--;

            if (rowHeight < 270 || rowHeight > 27000) throw new Exception($"行号数据范围{rowH}错误，应在 270-27000间");
            if (colWidth < 1) throw new Exception("列宽数据范围错误：" + colW);
            if (rowStart < 0) throw new Exception("行号范围错误：" + rowS);

            colStart = ExcelLoad.ToIndex(colS);

            IRow row = load.sheet.GetRow(rowStart);
            if (row == null) row = load.sheet.CreateRow(rowStart);

            ///高度
            if (rowHeight != 0) row.Height = (short)rowHeight;
            ICell cell = row.GetCell(colStart);
            if (cell == null) cell = row.CreateCell(colStart);
            load.sheet.SetColumnWidth(colStart, colWidth * 256);

            if (this.IsImage)
            {
                string imgPath = context.GetStr(this.WriteVarName);
                if (!System.IO.File.Exists(imgPath)) throw new Exception("不存在要写入的图片文件");
                byte[] bytes = System.IO.File.ReadAllBytes(imgPath);
                int picIndx = load.sheet.Workbook.AddPicture(bytes, PictureType.JPEG);

                IDrawing drawing = load.sheet.CreateDrawingPatriarch();

                IClientAnchor anchor = null;
                if (load.wk != null)
                {
                    anchor = new HSSFClientAnchor(0, 0, 0, 0, colStart, rowStart, colStart + 1, rowStart + 1);
                }
                else
                {
                    anchor = new XSSFClientAnchor(0, 0, 0, 0, colStart, rowStart, colStart + 1, rowStart + 1);
                }


                anchor.AnchorType = (NPOI.SS.UserModel.AnchorType)System.Enum.Parse(typeof(AnchorType), ((int)this.AnchorType).ToString());

                //IClientAnchor anchor1 = new
                drawing.CreatePicture(anchor, picIndx);
                context.WriteLog($"成功写入图片至单元格：{imgPath}");
                //创建画布
                //                XSSFDrawing patriarch = (XSSFDrawing)sheet.CreateDrawingPatriarch();
                //                //设置图片坐标与大小
                //                //函数原型：XSSFClientAnchor(int dx1, int dy1, int dx2, int dy2, int col1, int row1, int col2, int row2)；
                //                //坐标(col1,row1)表示图片左上角所在单元格的位置，均从0开始，比如(5,2)表示(第五列，第三行),即F3；注意：图片左上角坐标与(col1,row1)单元格左上角坐标重合
                //                //坐标(col2,row2)表示图片右下角所在单元格的位置，均从0开始，比如(10,3)表示(第十一列，第四行),即K4；注意：图片右下角坐标与(col2,row2)单元格左上角坐标重合
                //                //坐标(dx1,dy1)表示图片左上角在单元格(col1,row1)基础上的偏移量(往右下方偏移)；(dx1，dy1)的最大值为(1023, 255),为一个单元格的大小
                //                //坐标(dx2,dy2)表示图片右下角在单元格(col2,row2)基础上的偏移量(往右下方偏移)；(dx2,dy2)的最大值为(1023, 255),为一个单元格的大小
                //                //注意：目前测试发现，对于.xlsx后缀的Excel文件，偏移量设置(dx1,dy1)(dx2,dy2)无效；只会对.xls生效
                //                XSSFClientAnchor anchor = new XSSFClientAnchor(0, 0, 0, 0, 5, 2, 10, 3);
                //                //正式在指定位置插入图片
                //                XSSFPicture pict = (XSSFPicture)patriarch.CreatePicture(anchor, pictureIdx);
                //————————————————
                //版权声明：本文为CSDN博主「水煮 鱼」的原创文章，遵循CC 4.0 BY - SA版权协议，转载请附上原文出处链接及本声明。
                //原文链接：https://blog.csdn.net/u013986317/article/details/102502794
            }
            else
            {
                if (context.ContainsStr(this.WriteVarName))
                {
                    string s = context.GetStr(this.WriteVarName);
                    cell.SetCellValue(s);
                    cell.SetCellType(CellType.String);
                    context.WriteLog($"成功写入字符至单元格，长度为{s.Length}");
                }
                else if (context.ContainsInt(this.WriteVarName))
                {
                    int i = context.GetInt(this.WriteVarName);
                    cell.SetCellType(CellType.Numeric);
                    cell.SetCellValue(i);
                    context.WriteLog($"成功写入数字至单元格，值为{i}");
                }
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.ExcelName)) throw new Exception("Excel对象不能为空");
            if (string.IsNullOrEmpty(this.RowStart)) throw new Exception("行号不能为空");
            if (string.IsNullOrEmpty(this.ColStart)) throw new Exception("列数不能为空");
            if (string.IsNullOrEmpty(this.RowHeight)) throw new Exception("行高不能为空");
            if (string.IsNullOrEmpty(this.ColWidth)) throw new Exception("列宽不能为空");

            if (string.IsNullOrEmpty(this.WriteVarName)) throw new Exception("写入变量名不能为空");
            if (!context.ContainsStr(this.WriteVarName) && !context.ContainsInt(this.WriteVarName)) throw new Exception($"不存在字符或数字变量：{this.WriteVarName}");
        }
    }
}