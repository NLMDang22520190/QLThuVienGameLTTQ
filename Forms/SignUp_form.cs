using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace EpistWinform.Forms
{
    public partial class SignUp_form : Form
    {
        public String code;
        public System.Windows.Forms.Timer timer;
        public int CountDown;
        SqlConnection connection;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void connect_to_database()
        {
            string connectionString = "Data Source=lttqquanlygame.database.windows.net;Initial Catalog=quanlygame;User ID=quanlygameadmin;Password= Quanlygame123@";
            this.connection = new SqlConnection(connectionString);
            try
            {
                this.connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("connection open is error");
            }
        }

        public SignUp_form()
        {
            InitializeComponent();
            create_image();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            this.label_countdown.Visible = false;
            timer.Tick += Timer_Tick;
            this.Text = string.Empty;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //connect_to_database();
        }

        private void SignUp_form_Load(object sender, EventArgs e)
        {

        }
        private Icon CreateIconFromControl()
        {
            Image image = this.logoPictureBox.Image;
            Bitmap bitmap = new Bitmap(image);
            IntPtr hicon = bitmap.GetHicon();
            Icon icon = Icon.FromHandle(hicon);

            return icon;
        }
        public void create_image()
        {
            Icon icon = CreateIconFromControl();
            this.Icon = icon;
            string imagePath = Path.Combine(Application.StartupPath, "Icon", "code.png");
            Code_picturebox.BackgroundImage = Image.FromFile(imagePath);
            Code_picturebox.BackgroundImageLayout = ImageLayout.Stretch;
            string imagePath1 = Path.Combine(Application.StartupPath, "Icon", "gmail_icon.png");
            Gmail_picturebox.BackgroundImage = Image.FromFile(imagePath1);
            Gmail_picturebox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button_sendcode_Click(object sender, EventArgs e)
        {
            if (this.gmail_textfield.Text != "")
            {
                SetTimeline();
                this.button_sendcode.Enabled = false;
                SendCode(this.gmail_textfield.Text);
                this.label_countdown.Visible = true;
            }
        }
        private void SetTimeline()
        {
            // Bắt đầu đếm thời gian
            CountDown = 61;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            CountDown--;
            this.label_countdown.Text = CountDown + "";
            if (CountDown <= 0)
            {
                this.label_countdown.Visible = false;
                timer.Stop();
                this.button_sendcode.Enabled = true;
            }
        }
        private void SendCode(string to)
        {
            try
            {
                string from = "tandungnguyen918@gmail.com";

                string pass = "oese kloq vtgv mxii";

                // Tạo đối tượng MailMessage
                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Subject = "Code to sign up into epicst game";
                Random rd = new Random();
                int x1 = rd.Next(1, 10);
                int x2 = rd.Next(0, 10);
                int x3 = rd.Next(0, 10);
                int x4 = rd.Next(0, 10);
                this.code = x1 + "" + x2 + "" + x3 + "" + x4;
                mail.Body = "Your code is " + code;

                // Tạo đối tượng SmtpClient
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false; // Tắt sử dụng thông tin xác thực mặc định

                // Cấu hình thông tin xác thực
                smtp.Credentials = new NetworkCredential(from, pass);

                // Gửi email
                smtp.Send(mail);

                MessageBox.Show("Gửi thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private Boolean check_username()
        {
            if (this.usernameTextBox.Text == "")
            {
                return false;
            }
            string selectQuery = "select username from userinfo where username = '" + this.usernameTextBox.Text + "'";
            int n = 0;
            using (SqlCommand command = new SqlCommand(selectQuery, this.connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        n++;
                    }
                }
            }
            if (n == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Boolean Checkcode()
        {
            if (code == this.code_textfield.Text)
            {
                return true;
            }
            return false;
        }
        private Boolean check_password()
        {
            if (this.passwordTextBox.Text != "")
            {
                return true;
            }
            return false;
        }
        public Boolean Check_display()
        {
            if (this.DisplayName_Textfield.Text != "")
            {
                return true;
            }
            return false;
        }
        public static int Flag_connect = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            String s1 = "";
            String s2 = "";
            String s3 = "";
            String s4 = "";
            if (Flag_connect == 0)
            {
                Flag_connect = 1;
                connect_to_database();
            
            }
            int n = 4;
            if (Check_display() == false)
            {
                n = n - 1;
                s1 = "DisplayName must be not null";
            }
            if (check_username() == false)
            {
                n = n - 1;
                s2 = "User must be not null or it already been signed up";
            }
            if (check_password() == false)
            {
                n = n - 1;
                s3 = "Password must be not null";
            }
            if (Checkcode() == false)
            {
                n = n - 1;
                s4 = "Code is must be not null or code is wrong";
            }
            if (n == 4)
            {
                put_data();
            }
            else
            {
                String s = "";
                if (s1 != "")
                {
                    s = s + s1 + ". \n";
                }
                if (s2 != "")
                {
                    s = s + s2 + ". \n";
                }
                if (s3 != "")
                {
                    s = s + s3 + ". \n";
                }
                if (s4 != "")
                {
                    s = s + s4 + ". \n";
                }
                MessageBox.Show("Please check your information: \n" + s);
            }
        }
        public int userid()
        {
            string selectQuery = "select max(userID) from userinfo";
            using (SqlCommand command = new SqlCommand(selectQuery, this.connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return (int)reader.GetInt32(0) + 1;
                    }
                }
            }
            return 0;
        }
        public void put_data()
        {
            String query = "insert into userinfo (userid, display_name, username, password, gmail, isadmin) values (@1, @2, @3, @4, @5, @6)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@1", userid());
                command.Parameters.AddWithValue("@2", this.DisplayName_Textfield.Text);
                command.Parameters.AddWithValue("@3", this.usernameTextBox.Text);
                command.Parameters.AddWithValue("@4", this.passwordTextBox.Text);
                command.Parameters.AddWithValue("@5", this.gmail_textfield.Text);
                command.Parameters.AddWithValue("@6", "0");
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Sign up completely");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }


}
