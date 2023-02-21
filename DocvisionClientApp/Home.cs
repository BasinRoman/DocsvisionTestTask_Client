using DocsvisionClientApp.UserControls;
using System.Windows.Forms;

namespace DocvisionClientApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();   
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
            MainDialogBody.Controls.Clear();
            MainDialogBody.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SenEmailButton_Click(object sender, EventArgs e)
        {
            UC_SendEmail UC_SendEmail = new UC_SendEmail();
            addUserControl(UC_SendEmail);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Collapse_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        //drag drop form control
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //
    }
}