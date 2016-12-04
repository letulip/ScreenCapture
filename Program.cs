using System;
using System.IO;
using System.Text;
using IWshRuntimeLibrary;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace ScreenCapture
{
    class Program
    {
        
        public static void Main()
        {
            Form SCForm = new Form1();
            
            
            // Specify the directory you want to manipulate.
            //string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Screen shot_screen №Y.png";

            //try
            //{
            //    for (int i = 0; i < Screen.AllScreens.Length; i++)
            //    {
            //        Bitmap printscreen = new Bitmap(Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height);

            //        Graphics graphics = Graphics.FromImage(printscreen as Image);

            //        graphics.CopyFromScreen(Screen.AllScreens[i].Bounds.X, Screen.AllScreens[i].Bounds.Y, 0, 0, printscreen.Size);

            //        printscreen.Save(filePath.AppendTimeStamp(i+1), ImageFormat.Png);
            //    }
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
        }
    }
}
