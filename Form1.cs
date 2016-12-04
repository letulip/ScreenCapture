using System;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // делаем видимой нашу иконку в трее
            notifyIcon1.Visible = true;
            ShowInTaskbar = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                Hide();
        }


    private void btnScrshot_Click(object sender, EventArgs e)
        {
            SCMethod.MakeSC();   
        }

        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // добавляем Эвент или событие по 1му клику мышки, 
            //вызывая функцию  notifyIcon1_MouseClick
            this.notifyIcon1.MouseClick += new MouseEventHandler(notifyIcon1_MouseClick);
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
