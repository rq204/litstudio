using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Xml;

namespace litcore.type
{
    /// <summary>
    /// 字符串编码类型
    /// </summary>
    public enum Encodetype
    {
        HTMLEncode = 1,
        HTMLDecode = 3,
        ToBase64 = 5,
        FromBase64 = 6,
        JSEncode = 7,
        JSDecode = 9,
        URLEncode = 10,
        URLDecode = 11,
        ToMd5 = 12,
        ToSha256 = 13,
        ToLower = 18,
        ToUpper = 19,
    }
}
