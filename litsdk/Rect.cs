using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Xml.Serialization;

namespace litsdk
{
    public struct Rect
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Rect(int x, int y, int width, int height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        public static implicit operator Rectangle(Rect r) => new Rectangle(r.X, r.Y, r.Width, r.Height);

        public static implicit operator Rect(Rectangle r) => new Rect(r.X, r.Y, r.Width, r.Height);

        public static implicit operator RectangleF(Rect r) => new RectangleF(r.X, r.Y, r.Width, r.Height);

        public static implicit operator Rect(RectangleF r) => new Rect((int)r.X, (int)r.Y, (int)r.Width, (int)r.Height);

        [JsonIgnore]
        public int Top => this.Y;

        [JsonIgnore]
        public int Left => this.X;

        [JsonIgnore]
        public int Right => this.X + this.Width;

        [JsonIgnore]
        public int Bottom => this.Y + this.Height;

        [JsonIgnore]
        public Point Center => new Point(this.X + this.Width / 2, this.Y + this.Height / 2);

        [JsonIgnore]
        public Point CenterTop => new Point(this.Center.X, this.Top);

        [JsonIgnore]
        public Point CenterLeft => new Point(this.Left, this.Center.Y);

        [JsonIgnore]
        public Point CenterRight => new Point(this.Right, this.Center.Y);

        [JsonIgnore]
        public Point CenterBottom => new Point(this.Center.X, this.Bottom);
    }
}