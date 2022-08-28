using WhatsAppLinkMaker.Business;
using System;
using System.Windows.Forms;

namespace WhatsAppLinkMaker
{
    public partial class MainForm : Form
    {    
        // Make Form Moveable by Mouse
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // End Make Form Moveable by Mouse

        public MainForm()
        {
            InitializeComponent();
        }


        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.Image = Properties.Resources.icons8_close_window_32px_1;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = Properties.Resources.icons8_close_window_32px;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            fncCreate();
        }

        private void fncCreate()
        {
            txtLink.Text = new CreateLink().fncCreateLink(txtNumber.Text.Replace("-", ""), txtInputText.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fncClear();
        }

        private void fncClear()
        {
            txtInputText.Text = "";
            txtLink.Text = "";
            txtNumber.Text = "";
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            txtNumber.Focus();
        }
    }
}