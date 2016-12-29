using System;
using System.Windows.Forms;
using System.IO;

namespace ScreenCapture
{
    public partial class Form1 : Form
    {
        private ContextMenu contextMenu1;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private MenuItem menuItem3;

        IniFile INI = new IniFile("config.ini");

        public Form1()
        {
            InitializeComponent();
            auto_read();
            
            // делаем видимой нашу иконку в трее
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "ScreenCapture";
            ShowInTaskbar = false;
            notifyIcon1.BalloonTipTitle = "Программа была спрятана";
            notifyIcon1.BalloonTipText = "Обратите внимание, что программа была спрятана в трей и продолжит свою работу.";
            notifyIcon1.ShowBalloonTip(5000); // Параметром указываем количество миллисекунд, которое будет показываться подсказка

            this.contextMenu1 = new ContextMenu();
            this.menuItem1 = new MenuItem();
            this.menuItem2 = new MenuItem();
            this.menuItem3 = new MenuItem();

            // Initialize contextMenu1
            this.contextMenu1.MenuItems.AddRange(
                    new MenuItem[] { this.menuItem1, this.menuItem2, this.menuItem3 });

            // Initialize menuItem1
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Make Screenshot";
            this.menuItem1.Click += new EventHandler(this.menuItem1_Click);

            // Initialize menuItem2
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Options";
            this.menuItem2.Click += new EventHandler(this.menuItem2_Click);

            // Initialize menuItem3
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "Close program";
            this.menuItem3.Click += new EventHandler(this.menuItem3_Click);

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            notifyIcon1.ContextMenu = this.contextMenu1;
        }

        private void menuItem1_Click(object Sender, EventArgs e)
        {
            SCMethod.MakeSC();

            notifyIcon1.BalloonTipTitle = "Скриншот сохранен на рабочем столе";
            notifyIcon1.ShowBalloonTip(3000);
        }

        private void menuItem2_Click(object Sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void menuItem3_Click(object Sender, EventArgs e)
        {            
            this.Close();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void auto_read()
        {
            
            if (INI.KeyExists("SettingForm1", "Width"))
                txtbxHotkey.Text = INI.ReadINI("UserHotKey", "Text");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            INI.Write("UserHotKey", "Text", txtbxHotkey.Text);
            MessageBox.Show("Настройки SettingForm1 и Other сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Говорим пользователю, что сохранили текст.
        }

        private void txtbxHotkey_KeyDown(Object sender, KeyPressEventArgs e)
        {
            txtbxHotkey.Text += e.KeyChar;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtbxHotkey.Clear();
            INI.Write("UserHotKey", "Text", Keys.PrintScreen.ToString());
        }
    }
}
