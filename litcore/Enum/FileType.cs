using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.type
{
    public enum FileType
    {
        DeleteFile = 0,
        MoveFile = 1,
        CopyFile = 2,
        CreateDir = 3,
        DeleteDir=4,
    }
}