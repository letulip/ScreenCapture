using System;
using System.IO;
using System.Text;
using IWshRuntimeLibrary;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace ScreenCapture
{
    class Program
    {
        public static void Main()
        {
            // Specify the directory you want to manipulate.
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\hello.txt";

            try
            {
                using (FileStream fs = System.IO.File.Create(filePath.AppendTimeStamp()))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("Hello there! I'm your first saved file!");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }




        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    _hookID = SetHook(_proc);
        //    Application.Run();

        //    UnhookWindowsHookEx(_hookID);
        //}

        //private const int WH_KEYBOARD_LL = 13;
        //private const int WM_KEYDOWN = 0x0100;
        //private const int VK_F1 = 0x70;
        //private static LowLevelKeyboardProc _proc = HookCallback;
        //private static IntPtr _hookID = IntPtr.Zero;

        //private static IntPtr SetHook(LowLevelKeyboardProc proc)
        //{
        //    using (Process curProcess = Process.GetCurrentProcess())
        //    using (ProcessModule curModule = curProcess.MainModule)
        //    {
        //        return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
        //    }
        //}

        //private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        //private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        //{
        //    if (nCode >= 0)
        //    {
        //        Keys number = (Keys)Marshal.ReadInt32(lParam);
        //        //MessageBox.Show(number.ToString());
        //        if (number == Keys.PrintScreen)
        //        {
        //            if (wParam == (IntPtr)261 && Keys.Alt == Control.ModifierKeys && number == Keys.PrintScreen)
        //            {
        //                // Alt+PrintScreen
        //            }
        //            else if (wParam == (IntPtr)257 && number == Keys.PrintScreen)
        //            {
        //                // PrintScreen
        //            }
        //        }
        //    }

        //    return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        //}

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        //[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
