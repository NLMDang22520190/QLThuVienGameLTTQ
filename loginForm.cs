using EpistWinform.DAO;

namespace EpistWinform
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }



        private void loginForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(58, 175, 131);
            this.loginLabel.ForeColor = Color.White;
            this.usernameLabel.ForeColor = Color.White;
            this.passwordLabel.ForeColor = Color.White;
            this.forgotpassLabel.ForeColor = Color.White;
            this.createAccountLabel.ForeColor = Color.White;
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

    }
}