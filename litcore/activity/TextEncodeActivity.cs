using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Xml;
using litcore.type;
using litsdk;

namespace litcore.activity
{
    [ActivityInfo(Name = "编码解码",Index = 48, IsLinux = true)]
    public class TextEncodeActivity : litsdk.ProcessActivity
    {

        public litcore.type.Encodetype CodeType;

        public string Encoding = "utf-8";

        /// <summary>
        ///  操作的变量名
        /// </summary>
        public string StrVarName = "";

        /// <summary>
        ///  保存到变量
        /// </summary>
        public string SaveVarName = "";

        private string name = "编码解码";

        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Variable;


        internal static string HtmlEncode(string sInput)
        {
            if (sInput == null)
            {
                return null;
            }
            return HttpUtility.HtmlEncode(sInput);
        }

        public override void Execute(ActivityContext context)
        {
            string text = context.GetStr(this.StrVarName);
            string save = "";
            Encoding _encoding = null;
            if (CodeType == Encodetype.URLDecode || this.CodeType == Encodetype.URLEncode) _encoding = System.Text.Encoding.GetEncoding(Encoding);

            try
            {
                save = TextEncode(text, _encoding, this.CodeType);
            }
            catch (Exception ex)
            {
                context.WriteLog($"字符编码出错：{ex.Message}");
            }

            context.WriteLog($"字符{this.StrVarName}编码成功,原长度{text.Length}编码后{save.Length}");
            context.SetVarStr(this.SaveVarName, save);
        }

        public static string  TextEncode(string text, Encoding _encoding, Encodetype codetype)
        {
            string save = "";

            switch (codetype)
            {
                case Encodetype.URLEncode:
                    save = System.Web.HttpUtility.UrlEncode(text, _encoding);
                    break;
                case Encodetype.URLDecode:
                    save = HttpUtility.UrlDecode(text, _encoding);
                    break;
                case Encodetype.HTMLEncode:
                    save = HtmlEncode(text);
                    break;
                case Encodetype.HTMLDecode:
                    save = HttpUtility.HtmlDecode(text);
                    break;
                case Encodetype.ToBase64:
                    save = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));
                    break;
                case Encodetype.FromBase64:
                    text = _PrepareForBase64Decode(text);
                    save = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
                    break;
                case Encodetype.JSEncode:
                    save = EncodeJSString(text);
                    break;
                case Encodetype.JSDecode:
                    save = DecodeJSString(text);
                    break;
                case Encodetype.ToSha256:
                    using (SHA256 sHA = SHA256.Create())
                    {
                        byte[] bIn = System.Text.Encoding.UTF8.GetBytes(text);
                        save = BitConverter.ToString(sHA.ComputeHash(bIn));
                    }
                    break;
                case Encodetype.ToMd5:
                    save = Md5(text).ToLower();
                    break;
                case Encodetype.ToLower:
                    save = text.ToLower();
                    break;
                case Encodetype.ToUpper:
                    save = text.ToUpper();
                    break;
            }
            return save;
        }

        /// <summary>
        /// 来自fiddler的base64的预处理
        /// </summary>
        /// <param name="sText"></param>
        /// <returns></returns>
        private static string _PrepareForBase64Decode(string sText)
        {
            sText = sText.Replace('-', '+').Replace('_', '/');
            switch (sText.Length % 4)
            {
                case 2:
                    sText += "==";
                    break;
                case 3:
                    sText += "=";
                    break;
                default:
                    throw new Exception("Invalid length for a base64 string.");
                case 0:
                    break;
            }
            return sText;
        }

        public static string Md5(string text)
        {
            using (MD5 sHA = MD5.Create())
            {
                byte[] bIn = System.Text.Encoding.UTF8.GetBytes(text);
                string save = BitConverter.ToString(sHA.ComputeHash(bIn)).Replace("-", "");
                return save;
            }
        }

        #region js的处理，来自fiddler
        private static string EncodeJSString(string sInput)
        {
            StringBuilder stringBuilder = new StringBuilder(sInput);
            stringBuilder.Replace("\\", "\\\\");
            stringBuilder.Replace("\r", "\\r");
            stringBuilder.Replace("\n", "\\n");
            stringBuilder.Replace("\"", "\\\"");
            sInput = stringBuilder.ToString();
            stringBuilder = new StringBuilder();
            string text = sInput;
            foreach (char c in text)
            {
                if ('\u007f' < c)
                {
                    stringBuilder.AppendFormat("\\u{0:X4}", (int)c);
                }
                else
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString();
        }

        private static int HexToInt(char h)
        {
            if (h >= '0' && h <= '9')
            {
                return h - 48;
            }
            if (h >= 'a' && h <= 'f')
            {
                return h - 97 + 10;
            }
            if (h >= 'A' && h <= 'F')
            {
                return h - 65 + 10;
            }
            return -1;
        }


        private static string DecodeJSString(string s)
        {
            if (string.IsNullOrEmpty(s) || !s.Contains("\\"))
            {
                return s;
            }
            StringBuilder stringBuilder = new StringBuilder();
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                char c = s[i];
                if (c == '\\')
                {
                    if (i < length - 5 && s[i + 1] == 'u')
                    {
                        int num = HexToInt(s[i + 2]);
                        int num2 = HexToInt(s[i + 3]);
                        int num3 = HexToInt(s[i + 4]);
                        int num4 = HexToInt(s[i + 5]);
                        if (num >= 0 && num2 >= 0 && num3 >= 0 && num4 >= 0)
                        {
                            c = (char)((num << 12) | (num2 << 8) | (num3 << 4) | num4);
                            i += 5;
                            stringBuilder.Append(c);
                            continue;
                        }
                    }
                    else if (i < length - 3 && s[i + 1] == 'x')
                    {
                        int num5 = HexToInt(s[i + 2]);
                        int num6 = HexToInt(s[i + 3]);
                        if (num5 >= 0 && num6 >= 0)
                        {
                            c = (char)((num5 << 4) | num6);
                            i += 3;
                            stringBuilder.Append(c);
                            continue;
                        }
                    }
                    else if (i < length - 1)
                    {
                        switch (s[i + 1])
                        {
                            case 'n':
                                stringBuilder.Append("\n");
                                i++;
                                continue;
                            case 't':
                                stringBuilder.Append("\t");
                                i++;
                                continue;
                            case '\\':
                                stringBuilder.Append("\\");
                                i++;
                                continue;
                        }
                    }
                }
                stringBuilder.Append(c);
            }
            return stringBuilder.ToString();
        }
        #endregion

        public override void Validate(ActivityContext context)
        {
            System.Text.Encoding _encoding = null;
            if (CodeType == Encodetype.URLEncode || CodeType == Encodetype.URLDecode)
            {
                try
                {
                    _encoding = System.Text.Encoding.GetEncoding(Encoding);
                }
                catch
                {
                    throw new Exception("错误的编码" + Encoding);
                }
            }
            if (!context.ContainsStr(this.StrVarName)) throw new Exception($"不存在变量{this.StrVarName}");
            if (!context.ContainsStr(this.SaveVarName)) throw new Exception($"不存在保存变量{this.SaveVarName}");
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

    }
}
