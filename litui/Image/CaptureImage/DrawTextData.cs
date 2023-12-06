using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CSharpWin_JD.CaptureImage
{
    internal class DrawTextData
    {
        private string _text;
        private Font _font;
        private Rectangle _textRect;
        private bool _completed;

        public DrawTextData() { }

        public DrawTextData(string text, Font font, Rectangle textRect) 
        {
            _text = text;
            _font = font;
            _textRect = textRect;
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public Font Font
        {
            get { return _font; }
            set { _font = value; }
        }

        public Rectangle TextRect
        {
            get { return _textRect; }
            set { _textRect = value; }
        }

        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }
    }
}
