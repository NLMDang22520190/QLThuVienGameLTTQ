using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;

namespace EpistWinform.Forms
{
    public partial class Forgot : Form
    {
        public System.Windows.Forms.Timer timer;
        public int CountDown;
        public string code;
        SqlConnection connection;
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
                mail.Subject = "Code to confirm new password.";
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

                MessageBox.Show("Gửi thành công tới: " + to + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private Icon CreateIconFromControl()
        {
            Image image = this.logoPictureBox.Image;
            Bitmap bitmap = new Bitmap(image);
            IntPtr hicon = bitmap.GetHicon();
            Icon icon = Icon.FromHandle(hicon);

            return icon;
        }
        public Forgot()
        {

            InitializeComponent();
            this.Icon = CreateIconFromControl();
            string imagePath = Path.Combine(Application.StartupPath, "Icon", "code.png");
            Code_picturebox.BackgroundImage = Image.FromFile(imagePath);
            Code_picturebox.BackgroundImageLayout = ImageLayout.Stretch;
            this.label_countdown.Visible = false;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            this.label_countdown.Visible = false;
            timer.Tick += Timer_Tick;
            this.Text = string.Empty;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

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
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public static int send_code = 0;
        private void button_sendcode_Click(object sender, EventArgs e)
        {
            if (send_code == 0)
            {
                connect_to_database();
                send_code++;
            }
            if (this.usernameTextBox.Text != "")
            {
                SetTimeline();
                this.button_sendcode.Enabled = false;
                SendCode(get_email());
                this.label_countdown.Visible = true;
            }
        }
        private String get_email()
        {
            string selectQuery = "select gmail from userinfo where username = '" + this.usernameTextBox.Text + "'";
            using (SqlCommand command = new SqlCommand(selectQuery, this.connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }
            }
            return null;
        }
        private Boolean check_user()
        {
            if (this.usernameTextBox.Text != "")
            {
                return true;
            }
            return false;
        }
        private Boolean check_password()
        {
            if (this.passwordTextBox.Text != "" && this.passwordTextBox.Text == this.reenter.Text)
            {
                return true;
            }
            return false;
        }
        private Boolean check_code()
        {
            if (this.code_textfield.Text == code)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s1 = "";
            String s2 = "";
            String s3 = "";
            int n = 3;
            if (check_password() == false)
            {
                s1 = "Password is error";
                n--;
            }
            if (check_user() == false)
            {
                s2 = "User must be not null or not exists";
                n--;
            }
            if (check_code() == false)
            {
                s3 = "Code must be not null or it is wrong";
                n--;
            }
            if (n == 3)
            {
                update_data();
                MessageBox.Show("Confirm completely");
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
                MessageBox.Show("Please check your information again: \n" + s);
            }
        }
        private void update_data()
        {
            string query = "update userinfo set password = '" + this.passwordTextBox.Text + "' where username = '" + this.usernameTextBox.Text + "'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
