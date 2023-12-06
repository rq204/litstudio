using CSharpWin_JD.CaptureImage;
using litsdk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litui
{
    public class ImgConfig
    {
        /// <summary>
        /// 要找图片base64
        /// </summary>
        public string ImgBase64 = "";

        /// <summary>
        /// 是全屏还是激活窗体
        /// </summary>
        public bool IsFullScreen = true;

        /// <summary>
        /// 相似度
        /// </summary>
        public int Similarity = 99;

        /// <summary>
        /// 多图时第一个
        /// </summary>
        public int ImageNum = 1;

        /// <summary>
        /// X偏移
        /// </summary>
        public int MoveX = 0;

        /// <summary>
        /// Y偏移
        /// </summary>
        public int MoveY = 0;

        /// <summary>
        /// 返回null代表成功
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        internal string GetClickablePoint(ref Point result)
        {
            Bitmap source = null;
            int rowindex = this.ImageNum - 1;

            if (IsFullScreen)
            {
                source = GetDestopImage(Screen.PrimaryScreen.Bounds);// FlaUI.Core.Capturing.Capture.Screen().Bitmap;
            }
            else
            {
                IntPtr ip = GetForegroundWindow();
                System.Drawing.Rectangle rECT = new Rectangle();
                if (GetWindowRect(ip, ref rECT))
                {
                    source = GetDestopImage(rECT);// FlaUI.Core.Capturing.Capture.Rectangle(rECT).Bitmap;
                }
                else
                {
                    return "没有找到活动窗口";
                }
            }

            //if (source.PixelFormat != PixelFormat.Format24bppRgb)
            //{
            //    source = Convert32bppTo24bpp(source);
            //}

            Bitmap p_bitmap = null;
            p_bitmap = Base64StringToImage(this.ImgBase64);
            //p_bitmap = Convert32bppTo24bpp(p_bitmap);

            int simlar = (int)((100 - this.Similarity) * 255 * 0.01);
            List<Point> points = BmpColor.FindPic(0, 0, source.Width, source.Height, source, p_bitmap, simlar);

            if (rowindex < points.Count)
            {
                result = points[rowindex];
            }
            else
            {
                if (points.Count == 0)
                {
                    return "没有找到匹配的结果";
                }
                else
                {
                    return $"多图取指定位图片不存在，结果只有{points.Count}个";
                }
            }

            //大图，小图，
            result = new Point(result.X + p_bitmap.Width / 2, result.Y + p_bitmap.Height / 2);
            result.X += this.MoveX;
            result.Y += this.MoveY;
            return null;
        }

        //图片转为base64编码的字符串
        public static string ImgToBase64String(Bitmap bmp)
        {
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] arr = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(arr, 0, (int)ms.Length);
            ms.Close();
            return Convert.ToBase64String(arr);
        }

        //threeebase64编码的字符串转为图片
        public static Bitmap Base64StringToImage(string strbase64)
        {
            byte[] arr = Convert.FromBase64String(strbase64);
            MemoryStream ms = new MemoryStream(arr);
            Bitmap bmp = new Bitmap(ms);
            ms.Close();
            return bmp;
        }
        


        /// <summary>
        /// 截取完整屏幕图片
        /// </summary>
        /// <returns></returns>
        public static Bitmap GetDestopImage(Rectangle rect)
        {
            Bitmap bmp = new Bitmap(
                rect.Width, rect.Height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bmp);

            IntPtr gHdc = g.GetHdc();
            IntPtr deskHandle = NativeMethods.GetDesktopWindow();

            IntPtr dHdc = NativeMethods.GetDC(deskHandle);
            NativeMethods.BitBlt(
                gHdc,
                0,
                0,
                rect.Width,
                rect.Height,
                dHdc,
                0,
                0,
                NativeMethods.TernaryRasterOperations.SRCCOPY);
            NativeMethods.ReleaseDC(deskHandle, dHdc);
            g.ReleaseHdc(gHdc);
            return bmp;
        }

        public static Bitmap Convert32bppTo24bpp(Bitmap bmpSource)
        {
            Bitmap bmpDest = null;
            //When 32 bpp bitmap, convert to 24 bpp bitmap
            if (bmpSource != null &&
            (PixelFormat.Format32bppArgb == bmpSource.PixelFormat ||
            PixelFormat.Format32bppPArgb == bmpSource.PixelFormat ||
            PixelFormat.Format32bppRgb == bmpSource.PixelFormat))
            {
                //Convert to 24-bit Bitmap
                bmpDest = new Bitmap(bmpSource.Width, bmpSource.Height, PixelFormat.Format24bppRgb);
                bmpDest.SetResolution(bmpSource.HorizontalResolution, bmpSource.VerticalResolution);
                using (Graphics g = Graphics.FromImage(bmpDest))
                {
                    //Use high quality graphics to draw
                    g.SmoothingMode = SmoothingMode.HighSpeed;
                    g.CompositingQuality = CompositingQuality.HighSpeed;
                    g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                    g.InterpolationMode = InterpolationMode.NearestNeighbor;
                    g.DrawImage(bmpSource, 0, 0);
                }
            }
            return bmpDest;
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref System.Drawing.Rectangle lpRect);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        internal void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.ImgBase64)) throw new Exception("需查找的图片不能为空");
        }
    }
}