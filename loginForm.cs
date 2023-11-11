using EpistWinform.DAO;
using System.Runtime.InteropServices;

namespace EpistWinform
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (Login(usernameTextBox.Text, passwordTextBox.Text))
            {
                var mainWindowForm = new MainWindowForm();
                this.Hide();
                mainWindowForm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Incorrect Username or Password");


        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void controlBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '*')
            {
                passwordTextBox.PasswordChar = '\0';
                showPassBtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;


            }
            else
            {
                passwordTextBox.PasswordChar = '*';
                showPassBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }
    }
}