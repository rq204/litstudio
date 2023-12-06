using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;

namespace CSharpWin_JD.CaptureImage
{
    internal class OperateManager : IDisposable
    {
        private List<OperateObject> _operateList;

        private static readonly int MaxOperateCount = 1000;

        public OperateManager()
        {
        }

        public List<OperateObject> OperateList
        {
            get
            {
                if (_operateList == null)
                {
                    _operateList = new List<OperateObject>(100);
                }
                return _operateList;
            }
        }

        public int OperateCount
        {
            get { return OperateList.Count; }
        }

        public void AddOperate(
            OperateType operateType, 
            Color color,
            object data)
        {
            OperateObject obj = new OperateObject(
                operateType, color, data);
            if (OperateList.Count > MaxOperateCount)
            {
                OperateList.RemoveAt(0);
            }
            OperateList.Add(obj);
        }

        public bool RedoOperate()
        {
            if (OperateList.Count > 0)
            {
                OperateList.RemoveAt(OperateList.Count - 1);
                return true;
            }
            return false;
        }

        public void Clear()
        {
            OperateList.Clear();
        }

        #region IDisposable 成员

        public void Dispose()
        {
            if (_operateList != null)
            {
                _operateList.Clear();
                _operateList = null;
            }
        }

        #endregion
    }
}
