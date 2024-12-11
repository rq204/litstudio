using litsdk;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace litext
{
    [litsdk.ActivityInfo(Name = "执行C#代码")]
    public class CSharpActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "执行C#代码";

        public override ActivityGroup Group => ActivityGroup.Other;

        public string Code = "";

        private static Dictionary<string, object> codemd5Method = new Dictionary<string, object>();

        /// <summary>
        /// https://www.cnblogs.com/vic_lu/p/9278636.html
        /// </summary>
        /// <param name="context"></param>
        public override void Execute(ActivityContext context)
        {
            string code = context.ReplaceVar(this.Code);
            string codemd5 = "";
            using (MD5 sHA = MD5.Create())
            {
                byte[] bIn = System.Text.Encoding.UTF8.GetBytes(code);
                codemd5 = BitConverter.ToString(sHA.ComputeHash(bIn)).Replace("-", "");
            }
            codemd5 = "C" + codemd5;
            object objHelloWorld = null;

            if (codemd5Method.ContainsKey(codemd5))
            {
                objHelloWorld = codemd5Method[codemd5];
            }
            else
            {
                // 1.CSharpCodePrivoder
                CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();

                // 3.CompilerParameters
                CompilerParameters objCompilerParameters = new CompilerParameters();
                objCompilerParameters.ReferencedAssemblies.Add("System.dll");
                objCompilerParameters.ReferencedAssemblies.Add("Microsoft.CSharp.dll");
                objCompilerParameters.ReferencedAssemblies.Add("System.Xml.dll");
                objCompilerParameters.ReferencedAssemblies.Add("System.Data.dll");
                objCompilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
                objCompilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
                objCompilerParameters.ReferencedAssemblies.Add("System.Drawing.Design.dll");
                objCompilerParameters.ReferencedAssemblies.Add("System.Management.dll");
                objCompilerParameters.ReferencedAssemblies.Add("System.Configuration.dll");
                objCompilerParameters.ReferencedAssemblies.Add("System.Web.dll");
                objCompilerParameters.ReferencedAssemblies.Add(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll");
                objCompilerParameters.ReferencedAssemblies.Add(AppDomain.CurrentDomain.BaseDirectory + "litsdk.dll");
                objCompilerParameters.ReferencedAssemblies.Add(AppDomain.CurrentDomain.BaseDirectory + "litcore.dll");
                objCompilerParameters.GenerateExecutable = false;
                objCompilerParameters.GenerateInMemory = true;

                // 4.CompilerResults
                CompilerResults cr = objCSharpCodePrivoder.CompileAssemblyFromSource(objCompilerParameters, GenerateCode(code, codemd5));

                if (cr.Errors.HasErrors)
                {
                    StringBuilder sberror = new StringBuilder();
                    sberror.Append("编译错误：");
                    foreach (CompilerError err in cr.Errors)
                    {
                        sberror.Append(err.ErrorText + "\r\n");
                    }
                    throw new Exception(sberror.ToString());
                }
                else
                {
                    // 通过反射，调用HelloWorld的实例
                    Assembly objAssembly = cr.CompiledAssembly;
                    objHelloWorld = objAssembly.CreateInstance("DynamicCodeGenerate." + codemd5);
                    codemd5Method.Add(codemd5, objHelloWorld);
                }
            }
            MethodInfo objMI = objHelloWorld.GetType().GetMethod("Execute");
            objMI.Invoke(objHelloWorld, new object[] { context });
            context.WriteLog("成功执行C#代码");
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new CSharpUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.Code)) throw new Exception("C#代码不能为空");
        }

        static string GenerateCode(string CSharpCode, string ClassName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;");
            sb.Append(Environment.NewLine);
            sb.Append("using System.Collections.Generic;");
            sb.Append(Environment.NewLine);
            sb.Append("using System.Text;");
            sb.Append(Environment.NewLine);
            sb.Append("using System.Threading;");
            sb.Append(Environment.NewLine);
            sb.Append("using System.Threading.Tasks;");
            sb.Append(Environment.NewLine);
            sb.Append("using litsdk;");
            sb.Append(Environment.NewLine);
            sb.Append("using litcore;");
            sb.Append(Environment.NewLine);
            sb.Append("namespace DynamicCodeGenerate");
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append("    public class " + ClassName);
            sb.Append(Environment.NewLine);
            sb.Append("    {");
            sb.Append(Environment.NewLine);
            sb.Append("        public void Execute(ActivityContext context)");
            sb.Append(Environment.NewLine);
            sb.Append("        {");
            sb.Append(Environment.NewLine);
            sb.Append(CSharpCode);
            sb.Append(Environment.NewLine);
            sb.Append("        }");
            sb.Append(Environment.NewLine);
            sb.Append("    }");
            sb.Append(Environment.NewLine);
            sb.Append("}");

            string code = sb.ToString();
            return code;
        }
    }
}