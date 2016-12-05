using System;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Form1 : Form
    {
        private ContextMenu contextMenu1;
        private MenuItem menuItem1;
        private MenuItem menuItem2;

        public Form1()
        {
            InitializeComponent();
            // делаем видимой нашу иконку в трее
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "ScreenCapture";
            ShowInTaskbar = false;
            notifyIcon1.BalloonTipTitle = "Программа была спрятана";
            notifyIcon1.BalloonTipText = "Обратите внимание что программа была спрятана в трей и продолжит свою работу.";
            notifyIcon1.ShowBalloonTip(5000); // Параметром указываем количество миллисекунд, которое будет показываться подсказка

            this.contextMenu1 = new ContextMenu();
            this.menuItem1 = new MenuItem();
            this.menuItem2 = new MenuItem();

            // Initialize contextMenu1
            this.contextMenu1.MenuItems.AddRange(
                    new MenuItem[] { this.menuItem1, this.menuItem2 });

            // Initialize menuItem1
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Make Screenshot";
            this.menuItem1.Click += new EventHandler(this.menuItem1_Click);

            // Initialize menuItem2
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Close program";
            this.menuItem2.Click += new EventHandler(this.menuItem2_Click);

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            notifyIcon1.ContextMenu = this.contextMenu1;
        }

        private void menuItem1_Click(object Sender, EventArgs e)
        {
            SCMethod.MakeSC();

            notifyIcon1.BalloonTipTitle = "Скриншот сохранен на рабочем столе";
        }

        private void menuItem2_Click(object Sender, EventArgs e)
        {            
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        static public void Form1_KeyDown(object sender, KeyEventArgs e)
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
    }
}
