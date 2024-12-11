using System;
using System.Text;
using System.Runtime.InteropServices;


/// <summary>
/// StructuredStorageWrapper
/// </summary>
namespace litext.FileAttriWrapper
{
    public enum SummaryPropId : int
    {
        Title = 0x00000002,
        Subject = 0x00000003,
        Author = 0x00000004,
        Keywords = 0x00000005,
        Comments = 0x00000006,
        Template = 0x00000007,
        LastSavedBy = 0x00000008,
        RevisionNumber = 0x00000009,
        TotalEditingTime = 0x0000000A,
        LastPrinted = 0x0000000B,
        CreateDateTime = 0x0000000C,
        LastSaveDateTime = 0x0000000D,
        NumPages = 0x0000000E,
        NumWords = 0x0000000F,
        NumChars = 0x00000010,
        Thumbnail = 0x00000011,
        AppName = 0x00000012,
        Security = 0x00000013
    }


    public enum STGC : int
    {
        DEFAULT = 0,
        OVERWRITE = 1,
        ONLYIFCURRENT = 2,
        DANGEROUSLYCOMMITMERELYTODISKCACHE = 4,
        CONSOLIDATE = 8
    }


    public enum PROPSETFLAG : int
    {
        DEFAULT = 0,
        NONSIMPLE = 1,
        ANSI = 2,
        UNBUFFERED = 4,
        CASE_SENSITIVE = 8
    }


    public enum STGM : int
    {
        READ = 0x00000000,
        WRITE = 0x00000001,
        READWRITE = 0x00000002,
        SHARE_DENY_NONE = 0x00000040,
        SHARE_DENY_READ = 0x00000030,
        SHARE_DENY_WRITE = 0x00000020,
        SHARE_EXCLUSIVE = 0x00000010,
        PRIORITY = 0x00040000,
        CREATE = 0x00001000,
        CONVERT = 0x00020000,
        FAILIFTHERE = 0x00000000,
        DIRECT = 0x00000000,
        TRANSACTED = 0x00010000,
        NOSCRATCH = 0x00100000,
        NOSNAPSHOT = 0x00200000,
        SIMPLE = 0x08000000,
        DIRECT_SWMR = 0x00400000,
        DELETEONRELEASE = 0x04000000
    }


    public enum STGFMT : int
    {
        STORAGE = 0,
        FILE = 3,
        ANY = 4,
        DOCFILE = 5
    }


    [StructLayout(LayoutKind.Explicit, Size = 8, CharSet = CharSet.Unicode)]
    public struct PropSpec
    {
        [FieldOffset(0)]
        public int ulKind;
        [FieldOffset(4)]
        public IntPtr Name_Or_ID;
    }


    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PropVariant
    {
        [FieldOffset(0)]
        public short variantType;
        [FieldOffset(8)]
        public IntPtr pointerValue;
        [FieldOffset(8)]
        public byte byteValue;
        [FieldOffset(8)]
        public long longValue;


        public void FromObject(object obj)
        {
            if (obj.GetType() == typeof(string))
            {
                this.variantType = (short)VarEnum.VT_LPWSTR;
                this.pointerValue = Marshal.StringToHGlobalUni((string)obj);
            }
        }
    }


    [ComVisible(true), ComImport(),
    Guid("0000013A-0000-0000-C000-000000000046"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPropertySetStorage
    {
        uint Create(
            [In, MarshalAs(UnmanagedType.Struct)] ref System.Guid rfmtid,
      [In] IntPtr pclsid,
      [In] int grfFlags,
            [In] int grfMode,
      ref IPropertyStorage propertyStorage);


        int Open(
            [In, MarshalAs(UnmanagedType.Struct)] ref System.Guid rfmtid,
            [In] int grfMode,
                  [Out] IPropertyStorage propertyStorage);
    }


    [ComVisible(true), ComImport(),
    Guid("00000138-0000-0000-C000-000000000046"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPropertyStorage
    {
        int ReadMultiple(
            uint numProperties,
            PropSpec[] propertySpecifications,
            PropVariant[] propertyValues);


        int WriteMultiple(
            uint numProperties,
            [MarshalAs(UnmanagedType.Struct)] ref PropSpec
propertySpecification,
            ref PropVariant propertyValues,
            int propIDNameFirst);


        uint Commit(
            int commitFlags);
    }


    public enum HResults : uint
    {
        S_OK = 0,
        STG_E_FILEALREADYEXISTS = 0x80030050
    }


    public class ole32
    {
        [StructLayout(LayoutKind.Explicit, Size = 12,
CharSet = CharSet.Unicode)]
        public struct STGOptions
        {
            [FieldOffset(0)]
            ushort usVersion;
            [FieldOffset(2)]
            ushort reserved;
            [FieldOffset(4)]
            uint uiSectorSize;
            [FieldOffset(8), MarshalAs(UnmanagedType.LPWStr)]
            string
pwcsTemplateFile;
        }


        [DllImport("ole32.dll", CharSet = CharSet.Unicode)]
        public static extern uint StgCreateStorageEx(
            [MarshalAs(UnmanagedType.LPWStr)] string name,
            int accessMode, int storageFileFormat, int fileBuffering,
            IntPtr options, IntPtr reserved, ref System.Guid riid,
            [MarshalAs(UnmanagedType.Interface)] ref IPropertySetStorage
propertySetStorage);


        [DllImport("ole32.dll", CharSet = CharSet.Unicode)]
        public static extern uint StgOpenStorageEx(
            [MarshalAs(UnmanagedType.LPWStr)] string name,
            int accessMode, int storageFileFormat, int fileBuffering,
            IntPtr options, IntPtr reserved, ref System.Guid riid,
            [MarshalAs(UnmanagedType.Interface)] ref IPropertySetStorage
propertySetStorage);
    }

}