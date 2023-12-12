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

                MessageBox.Show("Gửi thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public Forgot()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1395, 1039);
            this.MaximumSize = new Size(1395, 1039);
            string imagePath = Path.Combine(Application.StartupPath, "Icon", "code.png");
            Code_picturebox.BackgroundImage = Image.FromFile(imagePath);
            Code_picturebox.BackgroundImageLayout = ImageLayout.Stretch;
            this.label_countdown.Visible = false;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            this.label_countdown.Visible = false;
            timer.Tick += Timer_Tick;
            connect_to_database();
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

        private void button_sendcode_Click(object sender, EventArgs e)
        {
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
            int n = 3;
            if (check_password() == false) 
            {
                n--;
            }
            if (check_user() == false)
            {
                n--;
            }
            if (check_code() == false)
            {
                n--;
            }
            if (n == 3)
            {
                update_data();
                MessageBox.Show("Confirm completely");
            }
            else
            {
                MessageBox.Show("Please check your information again.");
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
    }
}
