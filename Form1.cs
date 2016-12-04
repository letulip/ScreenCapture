using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // делаем невидимой нашу иконку в трее
            notifyIcon1.Visible = true;
            ShowInTaskbar = false;
        }

        private void btnScrshot_Click(object sender, EventArgs e)
        {
            //Program.Main.Activated();
        }

        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            //Program.Main.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // добавляем Эвент или событие по 2му клику мышки, 
            //вызывая функцию  notifyIcon1_MouseDoubleClick
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }
    }
}
