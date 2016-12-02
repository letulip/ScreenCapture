using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenCapture
{
    static public class AppendDate
    {
        public static string AppendTimeStamp(this string fileName)
        {
            string filePath = fileName.Replace(".", DateTime.Now.ToString(" yyyy-MM-dd HH.mm.ss."));

            return filePath;
        }
    }
}
