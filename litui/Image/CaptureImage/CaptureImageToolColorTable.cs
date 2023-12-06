using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CSharpWin_JD.CaptureImage
{


    public class CaptureImageToolColorTable
    {
        private static readonly Color _borderColor = Color.FromArgb(65, 173, 236);
        private static readonly Color _backColorNormal = Color.FromArgb(229, 243, 251);
        private static readonly Color _backColorHover = Color.FromArgb(65, 173, 236);
        private static readonly Color _backColorPressed = Color.FromArgb(24, 142, 206);
        private static readonly Color _foreColor = Color.FromArgb(12, 83, 124);

        public CaptureImageToolColorTable() { }

        public virtual Color BorderColor
        {
            get { return _borderColor; }
        }

        public virtual Color BackColorNormal
        {
            get { return _backColorNormal; }
        }

        public virtual Color BackColorHover
        {
            get { return _backColorHover; }
        }

        public virtual Color BackColorPressed
        {
            get { return _backColorPressed; }
        }

        public virtual Color ForeColor
        {
            get { return _foreColor; }
        }
    }
}
