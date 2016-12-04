using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCapture
{
    static public class AppendDate
    {
        public static string AppendTimeStamp(this string fileName, int n)
        {
            string filePath = fileName.Replace("Y", Convert.ToString(n));
            filePath = filePath.Replace(".", DateTime.Now.ToString(" yyyy-MM-dd HH.mm.ss."));

            return filePath;
        }
    }
}
