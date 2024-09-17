using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litftp
{
    /// <summary>
    /// ftp操作类型
    /// </summary>
    public enum FtpType
    {
        Upload = 0,
        Download = 1,
        Delete = 2,
        ListDirFile = 3,
        ListDirDir = 4,
        UploadDir = 5,
        DownloadDir = 6,
        DeleteDir = 7,
    }
}
