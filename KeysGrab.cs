﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace ScreenCapture
{
    static public class KeysGrab
    {

        //static public void Form_KeyDown(object sender, KeyEventArgs e)
        //{
        //    /* If the 'Alt' and 'PrntScr' keys are pressed, make screenshot. */
        //    if (e.Alt && e.KeyCode == Keys.PrintScreen)
        //        SCMethod.MakeSC();

        //    /* If the 'Ctrl' and 'PrntScr' keys are pressed, make screenshot. */
        //    if (e.Control && e.KeyCode == Keys.PrintScreen)
        //        SCMethod.MakeSC();

        //    /* If the 'Shift' and 'PrntScr' keys are pressed, make screenshot. */
        //    if (e.Shift && e.KeyCode == Keys.PrintScreen)
        //        SCMethod.MakeSC();

        //    /* If 'PrntScr' key is pressed, make screenshot. */
        //    if (e.KeyCode == Keys.PrintScreen)
        //        SCMethod.MakeSC();
        //}

        //private const int WH_KEYBOARD_LL = 13;
        //private const int WM_KEYDOWN = 0x0100;
        //private const int WM_KEYUP = 0x101;
        //private const int WM_SYSKEYDOWN = 0x104;
        //private const int VK_F1 = 0x70;
        //private static LowLevelKeyboardProc _proc = HookCallback;
        //private static bool pressed = false;
        //public static IntPtr _hookID = IntPtr.Zero;

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
        //            if (pressed && wParam == (IntPtr)261 && Keys.Control == Control.ModifierKeys && number == Keys.PrintScreen)
        //            {
        //                // Ctrl+PrintScreen
        //                SCMethod.MakeSC();
        //                pressed = false;
        //            }
        //            if (pressed && wParam == (IntPtr)261 && Keys.Shift == Control.ModifierKeys && number == Keys.PrintScreen)
        //            {
        //                // Shift+PrintScreen
        //                SCMethod.MakeSC();
        //                pressed = false;
        //            }
        //            if (pressed && wParam == (IntPtr)261 && Keys.Alt == Control.ModifierKeys && number == Keys.PrintScreen)
        //            {
        //                // Alt+PrintScreen
        //                SCMethod.MakeSC();
        //                pressed = false;
        //            }
        //            if (pressed && wParam == (IntPtr)257 && number == Keys.PrintScreen)
        //            {
        //                // PrintScreen
        //                SCMethod.MakeSC();
        //                pressed = false;
        //            }
        //        }
        //    }

        //    return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        //}

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        //[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
