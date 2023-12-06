using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using litsdk;
using System.Net;
using System.IO;
using System.IO.Compression;

namespace litcore.activity
{
    [ActivityInfo(Name = "网页请求", Description = "发起一个http请求并将返回结果保存到变量当中", RefFile = "", Search = "http请求，下载网页", IsLinux = true, Index = 0)]
    /// <summary>
    /// http请求设置，各种设置
    /// </summary>
    public class HttpRequestActivity : litsdk.ProcessActivity
    {
        public void InitRequestHeader()
        {
            this.RequestHeaders.Add(new KeyValuePair<string, string>("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.130 Safari/537.36"));
            this.RequestHeaders.Add(new KeyValuePair<string, string>("Accept", "text/css,*/*;q=0.1"));
            this.RequestHeaders.Add(new KeyValuePair<string, string>("Accept-Language", "zh-CN,zh;q=0.8,zh-TW;q=0.7,zh-HK;q=0.5,en-US;q=0.3,en;q=0.2"));
            this.RequestHeaders.Add(new KeyValuePair<string, string>("Accept-Encoding", "gzip, deflate"));
            this.RequestHeaders.Add(new KeyValuePair<string, string>("Connection", "keep-alive"));
        }

        public override void Execute(ActivityContext context)
        {
            string msg = "";
            this.html = "";
            error = "";
            address = "";
            this.filename = "";
            this.extension = "";
            statuscode = 0;
            contentlength = 0;

            try
            {
                this.HttpRequest(context);
            }
            finally
            {
                if (!this.AttachDown)
                {
                    context.SetVarStr(this.SaveToVarName, "");
                }
            }

            msg = string.Format($"请求网页{address}，状态码:{statuscode}，长度{contentlength}");

            if (!string.IsNullOrEmpty(this.HttpStatusVarName)) context.SetVarInt(this.HttpStatusVarName, statuscode);

            if (!string.IsNullOrEmpty(this.error))
            {
                context.LastError = error;
                msg += "，发生错误:" + this.error;
            }
            else
            {
                if (!this.AttachDown)
                {
                    context.SetVarStr(this.SaveToVarName, this.html);
                }
                else
                {
                    if (this.NotAttachDownIfNot200 && this.statuscode != 200)
                    {
                        msg += ",http状态码非200，本次不下载文件";
                        if (string.IsNullOrEmpty(this.SaveToFileVar)) context.SetVarStr(this.SaveToFileVar, "");
                    }
                    else
                    {
                        string path = context.ReplaceVar(this.AttachPath);
                        foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                        {
                            if (this.filename != "") this.filename = this.filename.Replace(c, '_');
                            if (!string.IsNullOrEmpty(this.extension)) this.extension = this.extension.Replace(c, '_');
                        }
                        if (path.Contains("[原文件全名]")) path = path.Replace("[原文件全名]", this.filename);
                        if (path.Contains("[随机文件名]"))
                        {
                            string rnd = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
                            path = path.Replace("[随机文件名]", rnd);
                        }
                        if (path.Contains("[原扩展名]")) path = path.Replace("[原扩展名]", this.extension);

                        path = TrimInvalidPath(path);

                        string dir = System.IO.Path.GetDirectoryName(path);
                        if (!System.IO.Directory.Exists(dir)) System.IO.Directory.CreateDirectory(dir);
                        System.IO.File.WriteAllBytes(path, responsebt);
                        msg += "，成功保存文件至：" + path;
                        if (!string.IsNullOrEmpty(this.SaveToFileVar)) context.SetVarStr(this.SaveToFileVar, path);
                    }
                }
            }
            context.WriteLog(msg);
        }

        public static string TrimInvalidPath(string path)
        {
            List<string> parr = path.Split('\\').ToList();
            for (int i = 1; i < parr.Count - 1; i++)
            {
                foreach (char c in System.IO.Path.GetInvalidPathChars())
                {
                    if (!string.IsNullOrEmpty(parr[i])) parr[i] = parr[i].Replace(c, '_');
                }
            }
            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                if (!string.IsNullOrEmpty(parr[parr.Count - 1])) parr[parr.Count - 1] = parr[parr.Count - 1].Replace(c, '_');
            }
            path = string.Join("\\", parr.ToArray());
            return path;
        }

        private string address = "", error = "", html = "", filename = "", extension = "";
        private int statuscode, contentlength;
        private byte[] responsebt = null;

        /// <summary>
        /// 返回header存入变量
        /// </summary>
        public string ResponseHeaderSaveToVar = "";

        /// <summary>
        /// http请求时的编码，空为自动识别，POST时要强制指定
        /// </summary>
        public string Encoding = "";

        /// <summary>
        /// 请求的网址
        /// </summary>
        public string Address = "";

        /// <summary>
        /// 保存到哪个变量
        /// </summary>

        public string SaveToVarName = "";

        /// <summary>
        /// Post的表单表格变量
        /// </summary>
        public string PostTableVar = "";

        /// <summary>
        /// 提交方式
        /// </summary>
        public litcore.type.BodyType BodyType = type.BodyType.FormUrlencode;

        /// <summary>
        /// 请求头信息
        /// </summary>
        public List<KeyValuePair<string, string>> RequestHeaders = new List<KeyValuePair<string, string>>();

        /// <summary>
        /// 自动跳转
        /// </summary>
        public bool AllowAutoRedirect = true;

        /// <summary>
        /// 请求的方法
        /// </summary>
        public string Method = "GET";

        /// <summary>
        /// 请求超时秒
        /// </summary>

        public int TimeOutSecond = 30;

        /// <summary>
        /// 是否上传证书的
        /// </summary>

        public bool X509Cert = false;
        /// <summary>
        /// 是否只使用tls10
        /// </summary>

        public bool Tls10 = false;

        /// <summary>
        /// cookie保存入变量
        /// </summary>
        public string CookieVarName = "";

        /// <summary>
        /// 二进制文件路径
        /// </summary>
        public string BinaryFilePath = "";

        /// <summary>
        /// raw类型
        /// Text JavaScript JSON HTML XML
        /// </summary>
        public string RawType = "";

        /// <summary>
        /// raw内容
        /// </summary>
        public string RawContent = "";

        /// <summary>
        /// 存入返回请求至文件
        /// </summary>
        public string SaveToFileVar = "";

        /// <summary>
        /// 存入路径，支持原文件名，原后缀
        /// </summary>
        public string AttachPath = "";

        /// <summary>
        /// http状态码保存变量
        /// </summary>
        public string HttpStatusVarName = "";

        /// <summary>
        /// form-data的值
        /// </summary>
        public List<KeyValuePair<string, string>> FormDatas = new List<KeyValuePair<string, string>>();

        /// <summary>
        /// form-data中的文件
        /// </summary>
        public List<string> FormFileKeys = new List<string>();

        /// <summary>
        /// form-urlencode数据
        /// </summary>
        public List<KeyValuePair<string, string>> FormUrlEncodes = new List<KeyValuePair<string, string>>();

        /// <summary>
        /// 非200不下载文件
        /// </summary>
        public bool NotAttachDownIfNot200 = true;

        public override ActivityGroup Group => litsdk.ActivityGroup.NetWork;


        public override string Name { get; set; } = "网页请求";

        /// <summary>
        /// 使用文件下载
        /// </summary>
        public bool AttachDown = false;

        /// <summary>
        /// 创建一个http请求
        /// </summary>
        /// <param name="varInfo"></param>
        /// <returns></returns>
        private void HttpRequest(ActivityContext context)
        {
            System.Net.HttpWebRequest request = null;
            System.Net.HttpWebResponse response = null;
            System.IO.StreamReader sreader = null;
            System.IO.Stream swriter = null;

            try
            {
                this.address = context.ReplaceVar(this.Address);
                request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(this.address);

                System.Text.Encoding ed = System.Text.Encoding.GetEncoding(this.Encoding);
                Dictionary<string, string> cookiedic = new Dictionary<string, string>();

                foreach (KeyValuePair<string, string> item in this.RequestHeaders)
                {
                    string headerName = context.ReplaceVar(item.Key);
                    string headValue = context.ReplaceVar(item.Value);// kv[1];
                    switch (headerName.ToLower())
                    {
                        case "accept":
                            request.Accept = headValue;
                            break;
                        case "if-modified-since":
                            DateTime dateTime;
                            if (DateTime.TryParse(headValue, out dateTime))
                            {
                                request.IfModifiedSince = dateTime;
                            }
                            break;
                        case "cookie":
                            CookieCollection cc = CookieFromString(headValue, cookiedic);
                            if (headValue.Contains("\t"))
                            {
                                string ccc = CookieToString(cc);
                                request.Headers.Set(HttpRequestHeader.Cookie, ccc);
                            }
                            else
                            {
                                request.Headers.Set(HttpRequestHeader.Cookie, headValue);
                            }
                            break;
                        case "accept-encoding":
                            request.Headers.Set("Accept-Encoding", headValue);
                            break;
                        case "host":
                            break;
                        case "range":
                            break;
                        case "proxy-connection":
                            break;
                        case "connection":
                            request.KeepAlive = headValue.Equals("keep-alive", StringComparison.OrdinalIgnoreCase);
                            break;
                        case "content-length":
                            break;
                        case "expect":
                            break;
                        case "accept-language":
                            request.Headers.Add("Accept-Language", headValue);
                            break;
                        case "proxy":
                            if (headValue.Contains(":"))
                            {
                                request.Proxy = new WebProxy(headValue);
                            }
                            break;
                        case "user-agent":
                            request.UserAgent = headValue;
                            break;
                        case "referer":
                            request.Referer = headValue;
                            break;
                        case "content-type":
                            request.ContentType = headValue;
                            break;
                        default:
                            request.Headers[headerName] = headValue;
                            break;
                    }
                }

                //request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.AllowAutoRedirect = this.AllowAutoRedirect;
                request.Timeout = this.TimeOutSecond * 1000;

                byte[] btpost = null;
                request.Method = this.Method;

                if (this.Method == "POST" || this.Method == "PUT" || this.Method == "DELETE")
                {
                    switch (this.BodyType)
                    {
                        case type.BodyType.None:
                            break;
                        case type.BodyType.FormUrlencode:
                            request.ContentType = "application/x-www-form-urlencoded";
                            StringBuilder sb = new StringBuilder();
                            Dictionary<string, string> forms = new Dictionary<string, string>();
                            foreach (KeyValuePair<string, string> p in this.FormUrlEncodes)
                            {
                                string k = context.ReplaceVar(p.Key);
                                string v = context.ReplaceVar(p.Value);
                                sb.Append($"{k}={System.Web.HttpUtility.UrlEncode(v, ed)}&");
                                if (forms.ContainsKey(k))
                                {
                                    forms[k] = v;
                                }
                                else
                                {
                                    forms.Add(k, v);
                                }
                            }

                            if (!string.IsNullOrEmpty(this.PostTableVar))
                            {
                                System.Data.DataTable table = context.GetTable(this.PostTableVar);
                                if (table.Columns.Contains("name") && table.Columns.Contains("value"))
                                {
                                    foreach (System.Data.DataRow dr in table.Rows)
                                    {
                                        string key = dr["name"] == null ? "" : dr["name"].ToString();
                                        string value = dr["value"] == null ? "" : dr["value"].ToString();

                                        if (!string.IsNullOrEmpty(key) && !forms.ContainsKey(key)) sb.Append($"{System.Web.HttpUtility.UrlEncode(key, ed)}={System.Web.HttpUtility.UrlEncode(value, ed)}&");
                                    }
                                }
                            }
                            btpost = ed.GetBytes(sb.ToString().TrimEnd('&'));
                            break;
                        case type.BodyType.FormData:
                            string boundary = "----" + Guid.NewGuid().ToString().Replace("-", "");
                            request.ContentType = "multipart/form-data; boundary=" + boundary;
                            byte[] beginBoundaryBytes = ed.GetBytes("--" + boundary + "\r\n");  // 边界符开始。【☆】右侧必须要有 \r\n 。
                            byte[] endBoundaryBytes = ed.GetBytes("--" + boundary + "--\r\n"); // 边界符结束。【☆】两侧必须要有 --\r\n 。
                            byte[] newLineBytes = ed.GetBytes("\r\n"); //换一行
                            List<byte[]> arrayList = new List<byte[]>();
                            arrayList.Add(beginBoundaryBytes);
                            string formDataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n" +
           "{1}\r\n";
                            string filePartHeaderTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n" +
            "Content-Type: application/octet-stream\r\n\r\n";
                            List<string> filekeys = new List<string>();
                            foreach (string f in this.FormFileKeys) filekeys.Add(context.ReplaceVar(f));

                            List<string> names = new List<string>();
                            int pos = 0;
                            foreach (KeyValuePair<string, string> kv in this.FormDatas)
                            {
                                pos++;
                                string keyname = context.ReplaceVar(kv.Key);
                                names.Add(keyname);
                                string keyvalue = context.ReplaceVar(kv.Value);
                                if (filekeys.Contains(keyname))
                                {
                                    if (keyvalue == "")
                                    {
                                        string fdata = string.Format(filePartHeaderTemplate, keyname, "") + "\r\n";
                                        arrayList.Add(ed.GetBytes(fdata));
                                    }
                                    else
                                    {
                                        string fname = System.IO.Path.GetFileName(keyvalue);
                                        string fdata = string.Format(filePartHeaderTemplate, keyname, fname);
                                        arrayList.Add(ed.GetBytes(fdata));
                                        byte[] fbyte = System.IO.File.ReadAllBytes(keyvalue);
                                        arrayList.Add(fbyte);
                                        arrayList.Add(newLineBytes);
                                    }
                                }
                                else
                                {
                                    string fdata = string.Format(formDataTemplate, keyname, keyvalue);
                                    arrayList.Add(ed.GetBytes(fdata));
                                }
                                if (pos < this.FormDatas.Count) arrayList.Add(beginBoundaryBytes);
                            }

                            if (!string.IsNullOrEmpty(this.PostTableVar))
                            {
                                System.Data.DataTable table = context.GetTable(this.PostTableVar);
                                if (table.Columns.Contains("name") && table.Columns.Contains("value"))
                                {
                                    foreach (System.Data.DataRow dr in table.Rows)
                                    {
                                        string key = dr["name"] == null ? "" : dr["name"].ToString();
                                        string value = dr["value"] == null ? "" : dr["value"].ToString();
                                        if (!names.Contains(key))
                                        {
                                            arrayList.Add(beginBoundaryBytes);
                                            string fdata = string.Format(formDataTemplate, key, value);
                                            arrayList.Add(ed.GetBytes(fdata));
                                        }
                                    }
                                }
                            }

                            arrayList.Add(endBoundaryBytes);
                            btpost = new byte[arrayList.Sum((F) => F.Length)];
                            int offset = 0;
                            foreach (byte[] array in arrayList)
                            {
                                System.Buffer.BlockCopy(array, 0, btpost, offset, array.Length);
                                offset += array.Length;
                            }
                            break;
                        case type.BodyType.Raw:
                            switch (this.RawType)
                            {
                                case "Text":
                                    request.ContentType = "text/plain";
                                    break;
                                case "JavaScript":
                                    request.ContentType = "application/x-javascript";
                                    break;
                                case "JSON":
                                    request.ContentType = "application/json";
                                    break;
                                case "HTML":
                                    request.ContentType = "text/html";
                                    break;
                                case "XML":
                                    request.ContentType = "text/xml";
                                    break;
                                case "X-WWW-FORM-URLENCODE":
                                    request.ContentType = "application/x-www-form-urlencoded";
                                    break;
                            }
                            string data = context.ReplaceVar(this.RawContent);
                            btpost = ed.GetBytes(data);
                            break;
                        case type.BodyType.Binary:
                            request.ContentType = "application/octet-stream";
                            string filename = context.ReplaceVar(this.BinaryFilePath);
                            if (!System.IO.File.Exists(filename)) throw new Exception("不存在文件:" + filename);
                            btpost = System.IO.File.ReadAllBytes(filename);
                            break;
                    }
                }

                try
                {
                    if (btpost != null)
                    {
                        request.ContentLength = btpost.Length;
                        if (btpost.Length < 1024 * 1024) request.ServicePoint.Expect100Continue = false;//如果于1m就直接发
                        swriter = request.GetRequestStream();
                        swriter.Write(btpost, 0, btpost.Length);
                    }
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException webex)
                {
                    if (webex.Response != null)
                    {
                        response = (HttpWebResponse)webex.Response;
                    }
                    else throw webex;
                }

                this.statuscode = (int)response.StatusCode;

                System.IO.Stream stream = response.GetResponseStream();
                if (!string.IsNullOrEmpty(response.ContentEncoding))
                {
                    if (response.ContentEncoding.Contains("gzip"))
                    {
                        stream = new GZipStream(stream, CompressionMode.Decompress);
                    }
                    else if (response.ContentEncoding.Contains("deflate"))
                    {
                        stream = new DeflateStream(stream, CompressionMode.Decompress);
                    }
                }

                if (!this.AttachDown)
                {
                    System.Text.Encoding edresp = System.Text.Encoding.GetEncoding(this.Encoding);
                    if (!string.IsNullOrEmpty(response.CharacterSet))
                    {
                        edresp = System.Text.Encoding.GetEncoding(response.CharacterSet);
                    }

                    System.IO.StreamReader streamReader = new System.IO.StreamReader(stream, edresp);
                    html = streamReader.ReadToEnd();
                    if (this.statuscode == 302 || this.statuscode == 301)
                    {
                        if (response.Headers["Location"] != null)
                        {
                            html = edresp.GetString(System.Text.Encoding.GetEncoding("iso-8859-1").GetBytes(response.Headers["Location"]));//Header内信息都是iso-8859-1存储的
                        }
                    }
                    this.contentlength = html.Length;
                }
                else
                {
                    byte[] buffer = new byte[16 * 1024];
                    using (MemoryStream ms = new MemoryStream())
                    {
                        int read;
                        while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            ms.Write(buffer, 0, read);
                        }
                        responsebt = ms.ToArray();
                    }
                    this.contentlength = responsebt.Length;

                    string sLoca = response.Headers["Content-Disposition"];

                    if (sLoca != null)
                    {
                        sLoca = ed.GetString(System.Text.Encoding.GetEncoding("iso-8859-1").GetBytes(sLoca));

                        if (sLoca.Contains("filename="))
                        {
                            int fstart = sLoca.LastIndexOf("filename=") + 9;
                            int dstart = sLoca.IndexOf(';', fstart);
                            if (dstart > 0)
                            {
                                this.filename = sLoca.Substring(fstart, dstart - fstart).Trim().Trim('"');
                            }
                            else
                            {
                                this.filename = sLoca.Substring(fstart).Trim().TrimEnd('"').TrimStart('"');
                            }
                            //以fileanme的扩展名为准
                            string fileext = System.IO.Path.GetExtension(this.filename).TrimStart('.');
                            if (!string.IsNullOrEmpty(fileext)) this.extension = fileext;
                        }
                    }
                    else
                    {
                        List<string> urlarr = this.address.Split('/').ToList();
                        string fname = urlarr[urlarr.Count - 1];
                        if (!string.IsNullOrEmpty(fname))
                        {
                            if (fname.Contains("?")) fname = fname.Split('?')[0];
                            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                            {
                                fname = fname.Replace(c, '_');
                            }

                            this.filename = fname;
                            if (string.IsNullOrEmpty(this.extension)) this.extension = System.IO.Path.GetExtension(filename).TrimStart('.');
                        }
                    }
                }

                if (!string.IsNullOrEmpty(this.CookieVarName))
                {
                    foreach (string key in response.Headers.AllKeys)
                    {
                        //thw=cn; Path=/; Domain=.taobao.com; Expires=Thu, 03-Dec-20 08:31:06 GMT;;
                        if (key.Equals("Set-Cookie", StringComparison.OrdinalIgnoreCase))
                        {
                            string cdata = response.Headers[key];
                            CookieCollection cc = GetAllCookiesFromHeader(cdata, new Uri(this.address).Host);
                            foreach (Cookie c in cc)
                            {
                                if (cookiedic.ContainsKey(c.Name))
                                {
                                    cookiedic[c.Name] = c.Value;
                                }
                                else
                                {
                                    cookiedic.Add(c.Name, c.Value);
                                }
                            }

                        }
                    }
                    StringBuilder sb = new StringBuilder();
                    foreach (KeyValuePair<string, string> kv in cookiedic) sb.Append($"{kv.Key}={kv.Value};");
                    context.SetVarStr(this.CookieVarName, sb.ToString());
                }

                if (!string.IsNullOrEmpty(this.ResponseHeaderSaveToVar))
                {
                    StringBuilder sblj = new StringBuilder();
                    sblj.AppendLine($"HTTP/{response.ProtocolVersion} {response.StatusCode} {response.StatusDescription}");
                    foreach (string key in response.Headers.AllKeys)
                    {
                        sblj.AppendLine($"{key}:{response.Headers[key]}");
                    }
                    context.SetVarStr(this.ResponseHeaderSaveToVar, sblj.ToString());
                }
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
            }
            finally
            {
                if (sreader != null) { sreader.Close(); }
                if (swriter != null) { swriter.Close(); }
                if (response != null)
                {
                    response.Close();
                }
            }
        }

        /// <summary>
        /// 将header中的cookie写到 https://blog.csdn.net/suleil1/article/details/49471699
        /// </summary>
        /// <param name="strHeader"></param>
        /// <param name="strHost"></param>
        /// <returns></returns>
        public static CookieCollection GetAllCookiesFromHeader(string strHeader, string strHost)
        {
            ArrayList al = new ArrayList();
            CookieCollection cc = new CookieCollection();
            if (strHeader != string.Empty)
            {
                al = ConvertCookieHeaderToArrayList(strHeader);
                cc = ConvertCookieArraysToCookieCollection(al, strHost);
            }
            return cc;
        }

        private static ArrayList ConvertCookieHeaderToArrayList(string strCookHeader)
        {
            strCookHeader = strCookHeader.Replace("\r", "");
            strCookHeader = strCookHeader.Replace("\n", "");
            string[] strCookTemp = strCookHeader.Split(',');
            ArrayList al = new ArrayList();
            int i = 0;
            int n = strCookTemp.Length;
            while (i < n)
            {
                if (strCookTemp[i].IndexOf("expires=", StringComparison.OrdinalIgnoreCase) > 0)
                {
                    //linux下cookie名有空格会报错jessie
                    al.Add(strCookTemp[i].Trim() + "," + strCookTemp[i + 1].Trim());
                    i = i + 1;
                }
                else
                {
                    if (strCookTemp[i] != "HttpOnly;Secure" && strCookTemp[i] != "HttpOnly" && strCookTemp[i] != "Secure")//20210624，Jessie反馈的问题
                    {
                        al.Add(strCookTemp[i].Trim());
                    }
                }
                i = i + 1;
            }
            return al;
        }

        private static CookieCollection ConvertCookieArraysToCookieCollection(ArrayList al, string strHost)
        {
            CookieCollection cc = new CookieCollection();

            int alcount = al.Count;
            string strEachCook;
            string[] strEachCookParts;
            for (int i = 0; i < alcount; i++)
            {
                strEachCook = al[i].ToString();
                strEachCookParts = strEachCook.Split(';');
                int intEachCookPartsCount = strEachCookParts.Length;
                string strCNameAndCValue = string.Empty;
                string strPNameAndPValue = string.Empty;
                string strDNameAndDValue = string.Empty;
                string[] NameValuePairTemp;
                Cookie cookTemp = new Cookie();

                for (int j = 0; j < intEachCookPartsCount; j++)
                {
                    if (j == 0)
                    {
                        strCNameAndCValue = strEachCookParts[j];
                        if (strCNameAndCValue != string.Empty)
                        {
                            int firstEqual = strCNameAndCValue.IndexOf("=");
                            string firstName = strCNameAndCValue.Substring(0, firstEqual);
                            string allValue = strCNameAndCValue.Substring(firstEqual + 1, strCNameAndCValue.Length - (firstEqual + 1));
                            cookTemp.Name = firstName;
                            cookTemp.Value = allValue;
                        }
                        continue;
                    }
                    if (strEachCookParts[j].IndexOf("path", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        strPNameAndPValue = strEachCookParts[j];
                        if (strPNameAndPValue != string.Empty)
                        {
                            NameValuePairTemp = strPNameAndPValue.Split('=');
                            if (NameValuePairTemp[1] != string.Empty)
                            {
                                cookTemp.Path = NameValuePairTemp[1];
                            }
                            else
                            {
                                cookTemp.Path = "/";
                            }
                        }
                        continue;
                    }

                    if (strEachCookParts[j].IndexOf("domain", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        strPNameAndPValue = strEachCookParts[j];
                        if (strPNameAndPValue != string.Empty)
                        {
                            NameValuePairTemp = strPNameAndPValue.Split('=');

                            if (NameValuePairTemp[1] != string.Empty)
                            {
                                cookTemp.Domain = NameValuePairTemp[1];
                            }
                            else
                            {
                                cookTemp.Domain = strHost;
                            }
                        }
                        continue;
                    }
                }

                if (cookTemp.Path == string.Empty)
                {
                    cookTemp.Path = "/";
                }
                if (cookTemp.Domain == string.Empty)
                {
                    cookTemp.Domain = strHost;
                }
                cc.Add(cookTemp);
            }
            return cc;
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.Address))
            {
                throw new Exception("请求的网址不得为空");
            }

            if (string.IsNullOrEmpty(this.Encoding))
            {
                throw new Exception("网页编码不得为空");
            }
            try
            {
                System.Text.Encoding ed = System.Text.Encoding.GetEncoding(this.Encoding);
            }
            catch
            {
                throw new Exception("网页编码错误：" + this.Encoding);
            }

            if (this.AttachDown)
            {
                if (string.IsNullOrEmpty(this.AttachPath)) throw new Exception("本地保存文件名不能为空");
                if (!string.IsNullOrEmpty(this.SaveToFileVar))
                {
                    if (!context.ContainsStr(SaveToFileVar)) throw new Exception("保存文件的字符变量名不存在:" + SaveToFileVar);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(SaveToVarName))
                {
                    if (!context.ContainsStr(SaveToVarName)) throw new Exception("保存的字符变量名不存在:" + SaveToVarName);
                }
                else
                {
                    throw new Exception("保存的字符变量名不能为空");
                }
            }

            if (!string.IsNullOrEmpty(this.ResponseHeaderSaveToVar) && !context.ContainsStr(this.ResponseHeaderSaveToVar))
            {
                throw new Exception("找不到返回头信息保存变量:" + this.ResponseHeaderSaveToVar);
            }

            if (this.RequestHeaders.Count == 0) throw new Exception("请求头信息不能全为空");

            if (!string.IsNullOrEmpty(this.CookieVarName) && !context.ContainsStr(this.CookieVarName))
            {
                throw new Exception("找不到cookie保存变量:" + this.CookieVarName);
            }

            if (this.Method.Equals("POST", StringComparison.OrdinalIgnoreCase))
            {
                switch (this.BodyType)
                {
                    case type.BodyType.None:
                        break;
                    case type.BodyType.FormUrlencode:
                        if (string.IsNullOrEmpty(this.PostTableVar))
                        {
                            if (this.FormUrlEncodes.Count == 0) throw new Exception("使用x-www-form-urlencode时字段不能为空");
                        }
                        else
                        {
                            if (!context.ContainsTable(this.PostTableVar)) throw new Exception("使用x-www-form-urlencode时选用了不存在的表单表格变量：" + this.PostTableVar);
                        }
                        break;
                    case type.BodyType.FormData:
                        if (this.FormDatas.Count == 0) throw new Exception("使用form-data时字段不能为空");
                        break;
                    case type.BodyType.Raw:
                        if (string.IsNullOrEmpty(this.RawContent)) throw new Exception("使用raw方式时字段不能为空");
                        break;
                    case type.BodyType.Binary:
                        if (string.IsNullOrEmpty(this.BinaryFilePath)) throw new Exception("使用binary方式时文件不能为空");
                        break;
                }
            }

            if (!string.IsNullOrEmpty(this.HttpStatusVarName) && !context.ContainsInt(this.HttpStatusVarName)) throw new Exception($"不存在保存http状态码的变量名{this.HttpStatusVarName}");
        }

        public override void ShowConfig()
        {
            if (this.RequestHeaders.Count == 0) this.InitRequestHeader();
            litsdk.API.ShowSystemConfigForm(this);
        }

        /// <summary>
        /// 文本转cookie
        /// </summary>
        /// <param name="cookiestr"></param>
        /// <returns></returns>
        private static System.Net.CookieCollection CookieFromString(string cookiestr, Dictionary<string, string> cookiesDics)
        {
            System.Net.CookieCollection cookieok = new System.Net.CookieCollection();

            string new_ckcstr = cookiestr;
            string path = "/", domain = "";

            string[] cookies = new_ckcstr.Split(';');

            foreach (string s in cookies)
            {
                string cookie = s.Trim();
                if (cookie.StartsWith("path=", StringComparison.OrdinalIgnoreCase))
                {
                    path = cookie.Split('=')[1];
                }
                else if (cookie.StartsWith("Expires=", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                else if (cookie == "=")
                {
                    continue;
                }
                else if (cookie.IndexOf("=") > -1)
                {
                    string[] ckks = cookie.Split('=');
                    if (!cookiesDics.ContainsKey(ckks[0])) cookiesDics.Add(ckks[0], cookie.Remove(0, ckks[0].Length + 1));
                }
            }

            foreach (KeyValuePair<string, string> kv in cookiesDics)
            {
                if (domain != "")
                    cookieok.Add(new System.Net.Cookie(kv.Key, kv.Value.Replace(",", "%2C"), path, domain));
                else
                    cookieok.Add(new System.Net.Cookie(kv.Key, kv.Value.Replace(",", "%2C"), path));
            }
            return cookieok;
        }

        private static string CookieToString(CookieCollection cc)
        {
            List<string> kk = new List<string>();
            foreach (System.Net.Cookie c in cc)
            {
                kk.Add($"{c.Name}={c.Value}");
            }
            return string.Join(";", kk.ToArray());
        }


        static HttpRequestActivity()
        {
            //遇到不安全的https时需手工确认的处理办法
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            }
            catch { }
            System.Net.ServicePointManager.DefaultConnectionLimit = 500;
        }

        /// <summary>
        /// 单纯http请求
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string OnlyGetUtf8Html(string url)
        {
            HttpRequestActivity activity = new HttpRequestActivity();
            activity.Address = url;
            activity.Encoding = "utf-8";
            activity.TimeOutSecond = 30;
            activity.SaveToVarName = "html";
            List<litsdk.Variable> vs = new List<Variable>();
            vs.Add(new Variable() { VariableType = VariableType.String, Name = "html" });
            litsdk.ActivityContext context = new ActivityContext(vs);
            context.WriteLog = (a) => { };
            activity.Execute(context);
            return context.GetStr("html");
        }

    }
}