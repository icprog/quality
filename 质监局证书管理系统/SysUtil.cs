using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 质监局证书管理系统
{
    public class SysUtil
    {
        public SysUtil()
        {
        }
        public static string GetFileExt(string filename)
        {
            return filename.Substring(filename.IndexOf("."), filename.Length - filename.IndexOf(".")).ToLower();
        }
           
    }
}
