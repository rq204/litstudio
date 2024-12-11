using litext.FileAttriWrapper;
using litsdk;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litext
{
    public class FileAttriActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "读写文件属性";

        public override ActivityGroup Group => ActivityGroup.File;

        public string FilePath = "";

        public FileAttriType FileAttriType = FileAttriType.GetCreationTime;

        /// <summary>
        /// 操作变量名
        /// </summary>
        public string OptVarName = "";


        public override void Execute(ActivityContext context)
        {
            string path = context.ReplaceVar(this.FilePath);
            if (!System.IO.File.Exists(path)) throw new Exception("文件不存在:" + path);

            string data = context.GetStr(this.OptVarName);

            FileInfo fileInfo = new FileInfo(path);
            switch (this.FileAttriType)
            {
                case FileAttriType.GetCreationTime:
                    data = fileInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss");
                    context.SetVarStr(this.OptVarName, data);
                    break;
                case FileAttriType.GetLastWriteTime:
                    data = fileInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss");
                    context.SetVarStr(this.OptVarName, data);
                    break;
                case FileAttriType.GetLastAccessTime:
                    data = fileInfo.LastAccessTime.ToString("yyyy-MM-dd HH:mm:ss");
                    context.SetVarStr(this.OptVarName, data);
                    break;
                case FileAttriType.SetCreationTime:
                    fileInfo.CreationTime = DateTime.Parse(data);
                    break;
                case FileAttriType.SetLastWriteTime:
                    fileInfo.LastWriteTime = DateTime.Parse(data);
                    break;
                case FileAttriType.SetLastAccessTime:
                    fileInfo.LastAccessTime = DateTime.Parse(data);
                    break;
            }

            context.WriteLog("文件属性处理完毕");
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new FileAttriUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.OptVarName)) throw new Exception("操作变量不能为空");
            if (!context.ContainsStr(this.OptVarName)) throw new Exception($"字符变量 {this.OptVarName} 不存在");
            if (string.IsNullOrEmpty(this.FilePath)) throw new Exception("文件路径不能为空");
        }

        public static void SetProperty(string filename, string msg, SummaryPropId summaryType)
        {
            // first you need to either create or open a file and its 
            // property set stream 
            //申明接口(指针)
            IPropertySetStorage propSetStorage = null;
            //com 组件的 clsid 参见IPropertySetStorage定义
            Guid IID_PropertySetStorage = new
Guid("0000013A-0000-0000-C000-000000000046");

            //Applications written for Windows 2000, Windows Server 2003 and Windows XP must use StgCreateStorageEx rather than StgCreateDocfile to take advantage of the enhanced Windows 2000 and Windows XP Structured Storage features            
            uint hresult = ole32.StgOpenStorageEx(
                filename,
                (int)(STGM.SHARE_EXCLUSIVE | STGM.READWRITE),
                (int)STGFMT.FILE,
                0,
                (IntPtr)0,
                (IntPtr)0,
                ref IID_PropertySetStorage,
                ref propSetStorage); //返回指针


            // next you need to create or open the Summary Information property set 
            Guid fmtid_SummaryProperties = new
Guid("F29F85E0-4FF9-1068-AB91-08002B27B3D9");
            IPropertyStorage propStorage = null;


            hresult = propSetStorage.Create(
                ref fmtid_SummaryProperties,
                (IntPtr)0,
                (int)PROPSETFLAG.DEFAULT,
                (int)(STGM.CREATE | STGM.READWRITE |
STGM.SHARE_EXCLUSIVE),
                ref propStorage);


            // next, you assemble a property descriptor for the property you 
            // want to write to, in our case the Comment property 
            PropSpec propertySpecification = new PropSpec();
            propertySpecification.ulKind = 1;
            propertySpecification.Name_Or_ID = new
IntPtr((int)summaryType);


            //now, set the value you want in a property variant 
            PropVariant propertyValue = new PropVariant();
            propertyValue.FromObject(msg);


            // Simply pass the property spec and its new value to the WriteMultiple 
            // method and you're almost done 
            propStorage.WriteMultiple(1, ref propertySpecification, ref
propertyValue, 2);


            // the only thing left to do is commit your changes.  Now you're done! 
            hresult = propStorage.Commit((int)STGC.DEFAULT);


            //下面的很关键,如何关闭一个非托管的指针,如果不关闭,则本程序不关闭,文件被锁定!
            System.Runtime.InteropServices.Marshal.ReleaseComObject(propSetStorage);
            propSetStorage = null;
            GC.Collect();
        }
    }
}
