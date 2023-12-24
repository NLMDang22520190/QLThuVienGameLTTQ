using EpistWinform.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpistWinform.Forms
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
            // Gắn sự kiện Load cho Form
            this.Load += new EventHandler(userForm_Load);
            // Gắn sự kiện click cho các nút
            EditButton.Click += new EventHandler(EditButton_Click);
            SaveButton.Click += new EventHandler(SaveButton_Click);
            CancelButton.Click += new EventHandler(CancelButton_Click);
        }
        private void userForm_Load(object sender, EventArgs e)
        {
            DisplayUserData();
            SetTextBoxesReadOnly(true);

        }
        private void DisplayUserData()
        {
            // Ví dụ: Lấy thông tin của người dùng có userID = 1 từ cơ sở dữ liệu
            string query = "SELECT display_name, username, password FROM UserInfo WHERE userID = @userID";
            object[] parameters = new object[] { 1 }; // Thay 1 bằng userID mong muốn

            DataTable userData = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (userData.Rows.Count > 0)
            {
                DataRow row = userData.Rows[0];
                DisplayNameTextBox.Text = row["display_name"].ToString();
                UsernameTextBox.Text = row["username"].ToString();
                PasswordTextBox.Text = row["password"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng!");
            }
        }
        private void SetTextBoxesReadOnly(bool readOnly)
        {
            DisplayNameTextBox.ReadOnly = readOnly;
            UsernameTextBox.ReadOnly = readOnly;
            PasswordTextBox.ReadOnly = readOnly;
            // Kiểm tra nếu TextBox Password đang ở trạng thái readOnly, hiển thị dấu *
            if (readOnly)
            {
                PasswordTextBox.UseSystemPasswordChar = true; // Sử dụng ký tự dấu * để ẩn mật khẩu
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = false; // Khi chỉnh sửa, hiển thị bình thường
            }
        }

        private bool AreTextBoxesReadOnly()
        {
            return DisplayNameTextBox.ReadOnly && UsernameTextBox.ReadOnly && PasswordTextBox.ReadOnly;
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            bool isReadOnly = !AreTextBoxesReadOnly();
            SetTextBoxesReadOnly(isReadOnly);
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE UserInfo SET display_name = @display_name , password = @password WHERE userID = @userID";
            object[] parameters = new object[] { DisplayNameTextBox.Text, PasswordTextBox.Text, 1 }; // Thay 1 bằng userID cần update

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Thay đổi đã được lưu thành công!");
                SetTextBoxesReadOnly(true);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu thay đổi!");
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Hiển thị lại dữ liệu ban đầu từ cơ sở dữ liệu
            DisplayUserData();
            SetTextBoxesReadOnly(true);
        }
    }
}
