﻿using System;
using System.IO;
using System.Text;
using IWshRuntimeLibrary;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;

namespace ScreenCapture
{
    class Program
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x101;
        private const int WM_SYSKEYDOWN = 0x104;
        private const int VK_F1 = 0x70;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static bool pressed = true;
        public static IntPtr _hookID = IntPtr.Zero;

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                Keys number = (Keys)Marshal.ReadInt32(lParam);

                if (pressed && number == Keys.PrintScreen)
                {
                    // PrintScreen
                    SCMethod.MakeSC();
                    pressed = false;

                    //if (Keys.Control == Control.ModifierKeys && number == Keys.PrintScreen)
                    //{
                    //    // Ctrl+PrintScreen
                    //    SCMethod.MakeSC();
                    //}
                    //if (Keys.Shift == Control.ModifierKeys && number == Keys.PrintScreen)
                    //{
                    //    // Shift+PrintScreen
                    //    SCMethod.MakeSC();
                    //}
                    //if (Keys.Alt == Control.ModifierKeys && number == Keys.PrintScreen)
                    //{
                    //    // Alt+PrintScreen
                    //    SCMethod.MakeSC();
                    //}
                    //if (number == Keys.PrintScreen)
                    //{
                    //    // PrintScreen
                    //    SCMethod.MakeSC();
                    //}
                }
                else
                {
                    pressed = true;
                }
            }
            return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        public static void Main()
        {
            Form SCForm = new Form1();

            Assembly assembly = Assembly.GetExecutingAssembly();

            Application.EnableVisualStyles();
            _hookID = SetHook(_proc);
            Application.Run(SCForm);

            UnhookWindowsHookEx(_hookID);
        }
    }
}
