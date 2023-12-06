using litsdk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "图片截取")]
    public class ImageCutActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "图片截取";

        public override ActivityGroup Group => ActivityGroup.Other;

        public string SourceVarName = "";

        public string BasePoint = "";

        public string CutSize = "";

        /// <summary>
        /// 朝向
        /// </summary>
        public OrientType OrientType = OrientType.RightBottom;

        /// <summary>
        /// 保存的变量
        /// </summary>
        public string SaveVarName = "";

        /// <summary>
        /// 图片格式
        /// </summary>
        public string ImageFormat = "jpg";

        /// <summary>
        /// 保存为临时文件
        /// </summary>
        public bool SaveTempPath = false;

        /// <summary>
        /// 是否使用图片
        /// </summary>
        public bool UseImage = false;

        /// <summary>
        /// 图片base64
        /// </summary>
        public string ImgBase64 = "";

        /// <summary>
        /// 相似度
        /// </summary>
        public int Similarity = 99;


        public override void Execute(ActivityContext context)
        {
            string oldPath = context.GetStr(this.SourceVarName);
            if (!System.IO.File.Exists(oldPath)) throw new Exception("原图片不存在:" + oldPath);

            int bX = 0, bY = 0;
            string basePoint = context.ReplaceVar(this.BasePoint);

            if (this.UseImage)
            {
                Bitmap source = (Bitmap)System.Drawing.Image.FromStream(new System.IO.MemoryStream(System.IO.File.ReadAllBytes(oldPath)));//加载图片

                Bitmap p_bitmap = null;
                p_bitmap =ImgConfig.Base64StringToImage(this.ImgBase64);

                try
                {
                    int simlar = (int)((100 - this.Similarity) * 255 * 0.01);
                    List<Point> points = BmpColor.FindPic(0, 0, source.Width, source.Height, source, p_bitmap, simlar);
                    if (points.Count == 0) throw new Exception("小图没有找到");

                    switch (this.OrientType)
                    {
                        case OrientType.LeftTop:
                            bX = points[0].X;
                            bY = points[0].Y;
                            break;
                        case OrientType.RightTop:
                            bX = points[0].X + p_bitmap.Width;
                            bY = points[0].Y;
                            break;
                        case OrientType.LeftBottom:
                            bX = points[0].X;
                            bY = points[0].Y + p_bitmap.Height;
                            break;
                        case OrientType.RightBottom:
                            bX = points[0].X + p_bitmap.Width;
                            bY = points[0].Y + p_bitmap.Height;
                            break;
                    }
                }
                finally
                {
                    if (source != null) source.Dispose();
                    if (p_bitmap != null) p_bitmap.Dispose();
                }
            }
            else
            {
                string[] arr = basePoint.Split(',');
                if (arr.Length != 2) throw new Exception("基点坐标格式错误：" + basePoint);
                if (!int.TryParse(arr[0], out bX) || !int.TryParse(arr[1], out bY)) throw new Exception("基点坐标数据错误：" + basePoint);
            }

            string sizeData = context.ReplaceVar(this.CutSize);
            string[] arr2 = sizeData.Split(',');
            if (arr2.Length != 2) throw new Exception("截图大小格式错误：" + sizeData);
            int width = 0, height = 0;
            if (!int.TryParse(arr2[0], out width) || !int.TryParse(arr2[1], out height)) throw new Exception("截图大小数据错误：" + sizeData);

            int x = 0, y = 0;
            switch (this.OrientType)
            {
                case OrientType.LeftTop:
                    x = bX - width;
                    y = bY - height;
                    break;
                case OrientType.RightTop:
                    x = bX;
                    y = bY - height;
                    break;
                case OrientType.LeftBottom:
                    x = bX - width;
                    y = bY;
                    break;
                case OrientType.RightBottom:
                    x = bX;
                    y = bY;
                    break;
            }

            System.Drawing.Image img = System.Drawing.Image.FromStream(new System.IO.MemoryStream(System.IO.File.ReadAllBytes(oldPath)));//加载图片

            System.Drawing.Image cimg = CutPic(img, x, y, width, height);

            string savePath = context.GetStr(this.SaveVarName);
            if (this.SaveTempPath)
            {
                savePath = System.IO.Path.GetTempFileName();
                context.SetVarStr(this.SaveVarName, savePath);
            }

            cimg.Save(savePath);
            context.WriteLog($"成功保存截图至{savePath}");
            cimg.Dispose();
            img.Dispose();
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new ImageCutUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.SourceVarName)) throw new Exception("源图片变量不能为空");
            if (string.IsNullOrEmpty(this.SaveVarName)) throw new Exception("保存图片变量不能为空");

            if (!context.ContainsStr(this.SourceVarName)) throw new Exception("源图片字符变量不存在");
            if (!context.ContainsStr(this.SaveVarName)) throw new Exception("保存图片字符变量不存在");

          
            if (string.IsNullOrEmpty(this.CutSize)) throw new Exception("截图大小不能为空");

            if (this.UseImage)
            {
                if (string.IsNullOrEmpty(this.ImgBase64)) throw new Exception("使用图片定位时小图数据不能为空");
            }
            else
            {
                if (string.IsNullOrEmpty(this.BasePoint)) throw new Exception("基点坐标不能为空");
            }
        }


        /// <summary>
        /// 截图https://www.cnblogs.com/zhup520/p/6108520.html
        /// </summary>
        /// <param name="img"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public System.Drawing.Image CutPic(System.Drawing.Image img, int x, int y, int width, int height)
        {
            Rectangle cropArea = new System.Drawing.Rectangle(x, y, width, height); //要截取的区域大小
            //判断超出的位置否
            if ((img.Width < x + width) || img.Height < y + height)
            {
                img.Dispose();
                throw new Exception("截取的区域超过了图片本身的高度、宽度.");
            }
            Bitmap bmpImage = new System.Drawing.Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);

            bmpImage.Dispose();
            return bmpCrop;
        }
    }
}