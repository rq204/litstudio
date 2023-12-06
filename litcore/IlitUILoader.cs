using litsdk;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace litcore
{
    public static class IlitUILoader
    {
        public static void LoadIlitUIs()
        {
            Type type = typeof(litsdk.ILitUI);
            List<string> ignores = "Appium.Net.dll,CefSharp.BrowserSubprocess.Core.dll,CefSharp.Core.dll,CefSharp.dll,FlaUI.Core.dll,FlaUI.UIA2.dll,FlaUI.UIA3.dll,Gma.UserActivityMonitor.dll,Interop.TURING.dll,Interop.UIAutomationClient.dll,chrome_elf.dll,d3dcompiler_47.dll,libcef.dll,libEGL.dll,libGLESv2.dll,pepflashplayer.dll,StackExchange.Redis.dll,WindowsAccessBridge-32.dll,WindowsAccessBridge-64.dll,WindowsAccessBridge.dll,CefSharp.WinForms.dll,NPOI.dll,NPOI.OOXML.dll,NPOI.OpenXml4Net.dll,NPOI.OpenXmlFormats.dll,ICSharpCode.SharpZipLib.dll,FluentFTP.dll,Interop.SHDocVw.dll,Microsoft.mshtml.dll,MailKit.dll,MimeKit.dll,BouncyCastle.Crypto.dll,mb.dll,node.dll,MongoDB.Bson.dll,MongoDB.Driver.dll,MongoDB.Driver.Core.dll,MongoDB.Libmongocrypt.dll,DnsClient.dll,MongoDB.Driver.Legacy.dll,SharpCompress.dll,Crc32C.NET.dll,Snappy.NET.dll,System.Buffers.dll,mongocrypt.dll,FiddlerCore4.dll,zxing.dll,zxing.presentation.dll,MySql.Data.dll,System.Data.SQLite.dll,SQLite.Interop.dll,TURING.dll,Castle.Core.dll,litbridge.dll,litbuild.dll,litworks.dll,Newtonsoft.Json.dll,Pipelines.Sockets.Unofficial.dll,SeleniumExtras.PageObjects.dll,WebDriver.dll,WebDriver.Support.dll,websocket-sharp.dll,WindowsAccessBridgeInterop.dll,AntiVC23.dll,AntiVC25.dll,AntiVC26.dll,ClearScriptV8-64.dll,GetWord.dll,GetWordNT.dll,GetWordNT_x64.dll,GetWord_x64.dll,keybox.dll,libgnurx-0.dll,libmagic-1.dll,SmartX1App.dll,v8-base-ia32.dll,v8-base-x64.dll,v8-ia32.dll,v8-x64.dll,v8-zlib-ia32.dll,v8-zlib-x64.dll,litruntm.dll,ClearScript.dll,ClearScriptV8-32.dll,DepthsData.dll,FastCGI.dll,HtmlAgilityPack.dll,litpdf.dll,litword.dll,Microsoft.Win32.Primitives.dll,Mime.dll,MimeTypesMap.dll,Minio.dll,netstandard.dll,Renci.SshNet.dll,RestSharp.dll,System.AppContext.dll,System.Collections.Concurrent.dll,System.Collections.dll,System.Collections.NonGeneric.dll,System.Collections.Specialized.dll,System.ComponentModel.dll,System.ComponentModel.EventBasedAsync.dll,System.ComponentModel.Primitives.dll,System.ComponentModel.TypeConverter.dll,System.Console.dll,System.Data.Common.dll,System.Data.SQLite.EF6.dll,System.Data.SQLite.Linq.dll,System.Diagnostics.Contracts.dll,System.Diagnostics.Debug.dll,System.Diagnostics.FileVersionInfo.dll,System.Diagnostics.PerformanceCounter.dll,System.Diagnostics.Process.dll,System.Diagnostics.StackTrace.dll,System.Diagnostics.TextWriterTraceListener.dll,System.Diagnostics.Tools.dll,System.Diagnostics.TraceSource.dll,System.Diagnostics.Tracing.dll,System.dll,System.Drawing.dll,System.Drawing.Primitives.dll,System.Dynamic.Runtime.dll,System.Globalization.Calendars.dll,System.Globalization.dll,System.Globalization.Extensions.dll,System.IO.Compression.dll,System.IO.Compression.ZipFile.dll,System.IO.dll,System.IO.FileSystem.dll,System.IO.FileSystem.DriveInfo.dll,System.IO.FileSystem.Primitives.dll,System.IO.FileSystem.Watcher.dll,System.IO.IsolatedStorage.dll,System.IO.MemoryMappedFiles.dll,System.IO.Pipelines.dll,System.IO.Pipes.dll,System.IO.UnmanagedMemoryStream.dll,System.Linq.dll,System.Linq.Expressions.dll,System.Linq.Parallel.dll,System.Linq.Queryable.dll,System.Memory.dll,System.Net.Http.dll,System.Net.NameResolution.dll,System.Net.NetworkInformation.dll,System.Net.Ping.dll,System.Net.Primitives.dll,System.Net.Requests.dll,System.Net.Security.dll,System.Net.Sockets.dll,System.Net.WebHeaderCollection.dll,System.Net.WebSockets.Client.dll,System.Net.WebSockets.dll,System.Numerics.Vectors.dll,System.ObjectModel.dll,System.Reactive.Linq.dll,System.Reflection.dll,System.Reflection.Extensions.dll,System.Reflection.Primitives.dll,System.Resources.Reader.dll,System.Resources.ResourceManager.dll,System.Resources.Writer.dll,System.Runtime.CompilerServices.Unsafe.dll,System.Runtime.CompilerServices.VisualC.dll,System.Runtime.dll,System.Runtime.Extensions.dll,System.Runtime.Handles.dll,System.Runtime.InteropServices.dll,System.Runtime.InteropServices.RuntimeInformation.dll,System.Runtime.Numerics.dll,System.Runtime.Serialization.Formatters.dll,System.Runtime.Serialization.Json.dll,System.Runtime.Serialization.Primitives.dll,System.Runtime.Serialization.Xml.dll,System.Security.Claims.dll,System.Security.Cryptography.Algorithms.dll,System.Security.Cryptography.Csp.dll,System.Security.Cryptography.Encoding.dll,System.Security.Cryptography.Primitives.dll,System.Security.Cryptography.X509Certificates.dll,System.Security.Principal.dll,System.Security.SecureString.dll,System.Text.Encoding.dll,System.Text.Encoding.Extensions.dll,System.Text.RegularExpressions.dll,System.Threading.Channels.dll,System.Threading.dll,System.Threading.Overlapped.dll,System.Threading.Tasks.dll,System.Threading.Tasks.Extensions.dll,System.Threading.Tasks.Parallel.dll,System.Threading.Thread.dll,System.Threading.ThreadPool.dll,System.Threading.Timer.dll,System.ValueTuple.dll,System.Windows.Forms.dll,System.Xml.ReaderWriter.dll,System.Xml.XDocument.dll,System.Xml.XmlDocument.dll,System.Xml.XmlSerializer.dll,System.Xml.XPath.dll,System.Xml.XPath.XDocument.dll,WindowsBase.dll,Google.Protobuf.dll,mscorlib.dll,SafeObjectPool.dll,System.Configuration.ConfigurationManager.dll,System.Security.Cryptography.OpenSsl.dll,System.Security.Cryptography.ProtectedData.dll,litstudio.exe,litcore.dll,litwcore.dll,litsdk.dll,DotNetZip.dll,Xceed.Document.NET.dll,Xceed.Words.NET.dll,DmProvider.dll,ffmpeg.dll,FreeSql.dll,FreeSql.Provider.Dameng.dll,FreeSql.Provider.KingbaseES.dll,FreeSql.Provider.MySql.dll,FreeSql.Provider.Oracle.dll,FreeSql.Provider.PostgreSQL.dll,FreeSql.Provider.ShenTong.dll,FreeSql.Provider.Sqlite.dll,FreeSql.Provider.SqlServer.dll,K4os.Compression.LZ4.dll,K4os.Compression.LZ4.Streams.dll,K4os.Hash.xxHash.dll,Kdbndp.dll,Microsoft.Bcl.AsyncInterfaces.dll,Mono.Security.dll,NetTopologySuite.dll,NetTopologySuite.IO.PostGis.dll,Npgsql.dll,Npgsql.LegacyPostgis.dll,Npgsql.NetTopologySuite.dll,Oracle.ManagedDataAccess.dll,System.Data.OscarClient.dll,System.Data.SqlClient.dll,Ubiety.Dns.Core.dll,Zstandard.Net.dl".Split(',').ToList();
            List<string> others = new List<string>();
            foreach (string lib in new string[] { "", "libs" })
            {
                string dir = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, lib);
                if (!System.IO.Directory.Exists(dir)) return;
                foreach (var file in Directory.GetFiles(dir, "*.dll"))
                {
                    string filename = System.IO.Path.GetFileName(file);
                    if (ignores.Contains(filename)) continue;
                    try
                    {
                        Assembly appAssembly = Assembly.LoadFrom(file);
                        int oldCount = ilitUIsTypeDic.Count;
                        foreach (Type tmpType in appAssembly.GetTypes())
                        {
                            if ((!tmpType.IsAbstract) && (tmpType.IsClass && type.IsAssignableFrom(tmpType)))
                            {
                                litsdk.ILitUI litui = Activator.CreateInstance(tmpType) as litsdk.ILitUI;
                                if (string.IsNullOrEmpty(litui.ActivityType)) continue;
                                if (!ilitUIsTypeDic.ContainsKey(litui.ActivityType))
                                {
                                    if (litui.ActivityType == "litcore.sqldb.SqlDBActivity")
                                    {
                                        foreach (litsdk.ActivityInfo af in litcore.ActivityLoader.GetActivityInfos())
                                        {
                                            if (af.ActivityFullName.StartsWith("litsqldb") || af.ActivityFullName.StartsWith("litcnsqldb"))
                                            {
                                                ilitUIsTypeDic.Add(af.ActivityFullName, tmpType);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        ilitUIsTypeDic.Add(litui.ActivityType, tmpType);
                                    }
                                }
                            }
                        }
                        ///这个是保存不使用的类库
                        if (oldCount == ilitUIsTypeDic.Count) others.Add(filename);
                    }
                    catch { others.Add(filename); }
                }
            }
            //if (others.Count > 0)
            //{
            //    System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Other.txt", string.Join(",", others.ToArray()), System.Text.Encoding.UTF8);
            //}
        }


        private static IDictionary<string, Type> ilitUIsTypeDic = new Dictionary<string, Type>();

        public static bool Contains(string activityFullName)
        {
            return ilitUIsTypeDic.ContainsKey(activityFullName);
        }

        public static ILitUI GetInstance(string activityFullName)
        {
            if (ilitUIsTypeDic.ContainsKey(activityFullName))
            {
                return Activator.CreateInstance(ilitUIsTypeDic[activityFullName]) as litsdk.ILitUI;
            }
            else
            {
                return null;
            }
        }

        public static Type GetIlitUIType(string activityFullName)
        {
            if (ilitUIsTypeDic.ContainsKey(activityFullName)) return ilitUIsTypeDic[activityFullName];
            return null;
        }
    }
}