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
        static public void Program_KeyDown(object sender, KeyEventArgs e)
        {
            /* If the 'Alt' and 'PrntScr' keys are pressed, make screenshot. */
            if (e.Alt && e.KeyCode == Keys.PrintScreen)
                SCMethod.MakeSC();

            /* If the 'Ctrl' and 'PrntScr' keys are pressed, make screenshot. */
            if (e.Control && e.KeyCode == Keys.PrintScreen)
                SCMethod.MakeSC();

            /* If the 'Shift' and 'PrntScr' keys are pressed, make screenshot. */
            if (e.Shift && e.KeyCode == Keys.PrintScreen)
                SCMethod.MakeSC();

            /* If 'PrntScr' key is pressed, make screenshot. */
            if (e.KeyCode == Keys.PrintScreen)
                SCMethod.MakeSC();
        }

        public static void Main()
        {
            Form SCForm = new Form1();
            Application.Run(SCForm);
        }
    }
}
