using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    /// <summary>
    /// 大图找小图
    /// </summary>
    internal class BmpColor
    {
        /// <summary>
        /// 在大图里找小图
        /// </summary>
        /// <param name="S_bmp">大图</param>
        /// <param name="P_bmp">小图</param>
        /// <param name="similar">容错值 取值0--255，数值越高效率越低，不建议超过50</param>
        /// <returns></returns>
        public static List<Point> FindPic(int left, int top, int width, int height, Bitmap S_bmp, Bitmap P_bmp, int similar)
        {
            if (S_bmp.PixelFormat != PixelFormat.Format24bppRgb) { throw new Exception("颜色格式只支持24位bmp"); }
            if (P_bmp.PixelFormat != PixelFormat.Format24bppRgb) { throw new Exception("颜色格式只支持24位bmp"); }
            int S_Width = S_bmp.Width;
            int S_Height = S_bmp.Height;
            int P_Width = P_bmp.Width;
            int P_Height = P_bmp.Height;
            //取出4个角的颜色
            int px1 = P_bmp.GetPixel(0, 0).ToArgb(); //左上角
            int px2 = P_bmp.GetPixel(P_Width - 1, 0).ToArgb(); //右上角
            int px3 = P_bmp.GetPixel(0, P_Height - 1).ToArgb(); //左下角
            int px4 = P_bmp.GetPixel(P_Width - 1, P_Height - 1).ToArgb(); //右下角
            Color BackColor = P_bmp.GetPixel(0, 0); //背景色
            BitmapData S_Data = S_bmp.LockBits(new Rectangle(0, 0, S_Width, S_Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData P_Data = P_bmp.LockBits(new Rectangle(0, 0, P_Width, P_Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            List<Point> List;
            if (px1 == px2 && px1 == px3 && px1 == px4) //如果4个角的颜色相同
            {
                //透明找图
                List = _FindPic(left, top, width, height, S_Data, P_Data, GetPixelData(P_Data, BackColor), similar);
            }
            else if (similar > 0)
            {
                //相似找图
                List = _FindPic(left, top, width, height, S_Data, P_Data, similar);
            }
            else
            {
                //全匹配找图效率最高
                List = _FindPic(left, top, width, height, S_Data, P_Data);
            }
            S_bmp.UnlockBits(S_Data);
            P_bmp.UnlockBits(P_Data);
            return List;
        }
        /// <summary>
        /// 全匹配找图
        /// </summary>
        /// <param name="S_Data">大图数据</param>
        /// <param name="P_Data">小图数据</param>
        /// <returns></returns>
        private static unsafe List<Point> _FindPic(int left, int top, int width, int height, BitmapData S_Data, BitmapData P_Data)
        {
            List<Point> List = new List<Point>();
            int S_stride = S_Data.Stride;
            int P_stride = P_Data.Stride;
            IntPtr S_Iptr = S_Data.Scan0;
            IntPtr P_Iptr = P_Data.Scan0;
            byte* S_ptr;
            byte* P_ptr;
            bool IsOk = false;
            int _BreakW = width - P_Data.Width + 1;
            int _BreakH = height - P_Data.Height + 1;
            for (int h = top; h < _BreakH; h++)
            {
                for (int w = left; w < _BreakW; w++)
                {
                    P_ptr = (byte*)(P_Iptr);
                    for (int y = 0; y < P_Data.Height; y++)
                    {
                        for (int x = 0; x < P_Data.Width; x++)
                        {
                            S_ptr = (byte*)((int)S_Iptr + S_stride * (h + y) + (w + x) * 3);
                            P_ptr = (byte*)((int)P_Iptr + P_stride * y + x * 3);
                            if (S_ptr[0] == P_ptr[0] && S_ptr[1] == P_ptr[1] && S_ptr[2] == P_ptr[2])
                            {
                                IsOk = true;
                            }
                            else
                            {
                                IsOk = false; break;
                            }
                        }
                        if (IsOk == false) { break; }
                    }
                    if (IsOk) { List.Add(new Point(w, h)); }
                    IsOk = false;
                }
            }
            return List;
        }
        /// <summary>
        /// 相似找图
        /// </summary>
        /// <param name="S_Data">大图数据</param>
        /// <param name="P_Data">小图数据</param>
        /// <param name="similar">误差值</param>
        /// <returns></returns>
        private static unsafe List<Point> _FindPic(int left, int top, int width, int height, BitmapData S_Data, BitmapData P_Data, int similar)
        {
            List<Point> List = new List<Point>();
            int S_stride = S_Data.Stride;
            int P_stride = P_Data.Stride;
            IntPtr S_Iptr = S_Data.Scan0;
            IntPtr P_Iptr = P_Data.Scan0;
            byte* S_ptr;
            byte* P_ptr;
            bool IsOk = false;
            int _BreakW = width - P_Data.Width + 1;
            int _BreakH = height - P_Data.Height + 1;
            for (int h = top; h < _BreakH; h++)
            {
                for (int w = left; w < _BreakW; w++)
                {
                    P_ptr = (byte*)(P_Iptr);
                    for (int y = 0; y < P_Data.Height; y++)
                    {
                        for (int x = 0; x < P_Data.Width; x++)
                        {
                            S_ptr = (byte*)((int)S_Iptr + S_stride * (h + y) + (w + x) * 3);
                            P_ptr = (byte*)((int)P_Iptr + P_stride * y + x * 3);
                            if (ScanColor(S_ptr[0], S_ptr[1], S_ptr[2], P_ptr[0], P_ptr[1], P_ptr[2], similar))  //比较颜色
                            {
                                IsOk = true;
                            }
                            else
                            {
                                IsOk = false; break;
                            }
                        }
                        if (IsOk == false) { break; }
                    }
                    if (IsOk) { List.Add(new Point(w, h)); }
                    IsOk = false;
                }
            }
            return List;
        }
        /// <summary>
        /// 透明找图
        /// </summary>
        /// <param name="S_Data">大图数据</param>
        /// <param name="P_Data">小图数据</param>
        /// <param name="PixelData">小图中需要比较的像素数据</param>
        /// <param name="similar">误差值</param>
        /// <returns></returns>
        private static unsafe List<Point> _FindPic(int left, int top, int width, int height, BitmapData S_Data, BitmapData P_Data, int[,] PixelData, int similar)
        {
            List<Point> List = new List<Point>();
            int Len = PixelData.GetLength(0);
            int S_stride = S_Data.Stride;
            int P_stride = P_Data.Stride;
            IntPtr S_Iptr = S_Data.Scan0;
            IntPtr P_Iptr = P_Data.Scan0;
            byte* S_ptr;
            byte* P_ptr;
            bool IsOk = false;
            int _BreakW = width - P_Data.Width + 1;
            int _BreakH = height - P_Data.Height + 1;
            for (int h = top; h < _BreakH; h++)
            {
                for (int w = left; w < _BreakW; w++)
                {
                    for (int i = 0; i < Len; i++)
                    {
                        S_ptr = (byte*)((int)S_Iptr + S_stride * (h + PixelData[i, 1]) + (w + PixelData[i, 0]) * 3);
                        P_ptr = (byte*)((int)P_Iptr + P_stride * PixelData[i, 1] + PixelData[i, 0] * 3);
                        if (ScanColor(S_ptr[0], S_ptr[1], S_ptr[2], P_ptr[0], P_ptr[1], P_ptr[2], similar))  //比较颜色
                        {
                            IsOk = true;
                        }
                        else
                        {
                            IsOk = false; break;
                        }
                    }
                    if (IsOk) { List.Add(new Point(w, h)); }
                    IsOk = false;
                }
            }
            return List;
        }

        #region FindColor
        /// <summary>
        /// 找色
        /// </summary>
        public static unsafe List<Point> FindColor(int left, int top, int width, int height, Bitmap S_bmp, Color clr, int similar)
        {
            if (S_bmp.PixelFormat != PixelFormat.Format24bppRgb) { throw new Exception("颜色格式只支持24位bmp"); }
            BitmapData S_Data = S_bmp.LockBits(new Rectangle(0, 0, S_bmp.Width, S_bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            IntPtr _Iptr = S_Data.Scan0;
            byte* _ptr;
            List<Point> List = new List<Point>();
            for (int y = top; y < height; y++)
            {
                for (int x = left; x < width; x++)
                {
                    _ptr = (byte*)((int)_Iptr + S_Data.Stride * (y) + (x) * 3);
                    if (ScanColor(_ptr[0], _ptr[1], _ptr[2], clr.B, clr.G, clr.R, similar))
                    {
                        List.Add(new Point(x, y));
                    }
                }
            }
            S_bmp.UnlockBits(S_Data);
            return List;
        }
        #endregion

        #region IsColor
        /// <summary>
        /// 比较两个 Color 
        /// </summary>
        /// <param name="similar">容错值</param>
        /// <returns></returns>
        public static bool IsColor(Color clr1, Color clr2, int similar = 0)
        {
            if (ScanColor(clr1.B, clr1.G, clr1.R, clr2.B, clr2.G, clr2.R, similar))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region CopyScreen
        /// <summary>
        /// 屏幕截图
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static Bitmap CopyScreen(Rectangle rect)
        {
            Bitmap bitmap = new Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size);
                g.Dispose();
            }
            System.GC.Collect();
            return bitmap;
        }
        #endregion
        #region 私有方法
        private static unsafe int[,] GetPixelData(BitmapData P_Data, Color BackColor)
        {
            byte B = BackColor.B, G = BackColor.G, R = BackColor.R;
            int Width = P_Data.Width, Height = P_Data.Height;
            int P_stride = P_Data.Stride;
            IntPtr P_Iptr = P_Data.Scan0;
            byte* P_ptr;
            int[,] PixelData = new int[Width * Height, 2];
            int i = 0;
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    P_ptr = (byte*)((int)P_Iptr + P_stride * y + x * 3);
                    if (B == P_ptr[0] & G == P_ptr[1] & R == P_ptr[2])
                    {

                    }
                    else
                    {
                        PixelData[i, 0] = x;
                        PixelData[i, 1] = y;
                        i++;
                    }
                }
            }
            int[,] PixelData2 = new int[i, 2];
            Array.Copy(PixelData, PixelData2, i * 2);
            return PixelData2;
        }

        //找图BGR比较
        private static unsafe bool ScanColor(byte b1, byte g1, byte r1, byte b2, byte g2, byte r2, int similar)
        {
            if ((Math.Abs(b1 - b2)) > similar) { return false; } //B
            if ((Math.Abs(g1 - g2)) > similar) { return false; } //G
            if ((Math.Abs(r1 - r2)) > similar) { return false; } //R
            return true;
        }

        #endregion
    }
}
