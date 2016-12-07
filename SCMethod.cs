using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ScreenCapture
{
    public static class SCMethod
    {
        public static void MakeSC()
        {
            
            // Specify the directory you want to manipulate.
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Screen shot_screen №Y.png";

            try
            {
                for (int i = 0; i < Screen.AllScreens.Length; i++)
                {
                    Bitmap printscreen = new Bitmap(Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height);

                    Graphics graphics = Graphics.FromImage(printscreen as Image);

                    graphics.CopyFromScreen(Screen.AllScreens[i].Bounds.X, Screen.AllScreens[i].Bounds.Y, 0, 0, printscreen.Size);

                    printscreen.Save(filePath.AppendTimeStamp(i + 1), ImageFormat.Png);

                    printscreen.Dispose();
                    graphics.Dispose();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
