using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CSharpWin_JD.CaptureImage
{
    internal class OperateObject
    {
        private OperateType _operateType;
        private Color _color;
        private object _data;

        public OperateObject() { }

        public OperateObject(
            OperateType operateType, Color color, object data)
        {
            _operateType = operateType;
            _color = color;
            _data = data;
        }

        public OperateType OperateType
        {
            get { return _operateType; }
            set { _operateType = value; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public object Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}
