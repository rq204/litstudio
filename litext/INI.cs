using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace litext
{
    internal class INI
    {
        //ini文件的路径
        public string Path;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,
            int size, string filepath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal,
            int size, string filepath);
        public INI(string inipath)
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            Path = inipath;      //绝对路径哈
        }

        /// <summary>
        /// 写ini文件
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.Path);
        }

        /// <summary>
        /// 获取所有节点名称
        /// </summary>
        /// <param name="SectionList"></param>
        /// <returns></returns>
        public List<string> ReadSections()
        {
            StringCollection SectionList = new StringCollection();
            Byte[] byBuffer = new Byte[65535];

            // 通过GetPrivateProfileString（）方法读取的结果存放在byBuffer中，以整数值的形式存在。

            int nBufLen = GetPrivateProfileString(null, null, null, byBuffer, 2550, this.Path);

            if (nBufLen == 0)
            {

                return null ;

            }



            SearchStringsFromBuffer(byBuffer, nBufLen, SectionList);

            List<string> ls = new List<string>();
            foreach (string s in SectionList) ls.Add(s);
            return ls;
        }

        private void SearchStringsFromBuffer(Byte[] Buffer, int bufLen, StringCollection Strings)
        {

            Strings.Clear();



            int start = 0;

            for (int i = 0; i < bufLen; i++)
            {

                if ((Buffer[i] == 0) && ((i - start) > 0))
                {

                    String s = Encoding.GetEncoding(0).GetString(Buffer, start, i - start);

                    Strings.Add(s);

                    start = i + 1;

                }

            }

        }

        /// <summary>
        /// 读ini文件
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(2550);
            int i = GetPrivateProfileString(Section, Key, "", temp, 2550, this.Path);
            return temp.ToString();
        }
    }
}
