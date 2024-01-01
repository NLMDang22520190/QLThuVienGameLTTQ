using EpistWinform.DTO;
using EpistWinform.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EpistWinform.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public DataTable Login(string userName, string passWord, ref int status)
        {
            string query = "Login @userName , @passWord";
            DataTable result = new DataTable();
            try
            {
                result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
                if (result.Rows.Count <= 0)
                    throw new RowNotInTableException();
                    
            }
            catch (RowNotInTableException e)
            {
                //MessageBox.Show(e.Message);
                status = 0;
            }
            catch(Exception e)
            {
                MessageBox.Show(
                    "Connection error: The database is currently in maintenance mode or experiencing a temporary issue. Please wait 2-3 minutes before attempting to log in again. If the problem persists, please contact support.",
                    "Database Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                ); 
                status = -1;
            }

            //return result.Rows.Count > 0;
            return result;
        }
        // Khai báo một biến static để lưu userID của người dùng đăng nhập
        public static int loggedInUserID;

        
        
        public bool GetUserId(string username, string password)
        {
            // Thực hiện truy vấn để kiểm tra thông tin đăng nhập và lấy userID từ cơ sở dữ liệu
            string query = "SELECT userID FROM UserInfo WHERE username = @username AND password = @password";
            object[] parameters = new object[] { username, password };

            // Sử dụng DataProvider để thực hiện truy vấn
            object result = DataProvider.Instance.ExecuteScalar(query, parameters);

            int userID;
            if (result != null && int.TryParse(result.ToString(), out userID))
            {
                // Nếu truy vấn thành công và có lấy được userID từ cơ sở dữ liệu, lưu vào biến loggedInUserID
                loggedInUserID = userID;
                return true;
            }
            else
            {
                return false; // Đăng nhập không thành công
            }
        }
        //public Account GetAccount()
        //{

        //    Account a = new Account();
        //}


        public List<Account> LoadAccountList()
        {
            List<Account> accountsList = new List<Account>();

            string query = "GetAccountList";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Account account = new Account(row);
                accountsList.Add(account);
            }

            return accountsList;
        }

        private List<Account> allAccountsList = new List<Account>();
        public List<Account> ListAllAccounts
        {
            get
            {
                if (allAccountsList.Count <= 0) allAccountsList = LoadAccountList();
                return allAccountsList;
            }
        }

        public bool Add(int userID, string userName, string passWord, string displayName, string gmail, int isAdmin)
        {
            string query = string.Format("INSERT INTO dbo.UserInfo (userID, userName, password, display_name, gmail, isAdmin) VALUES ({0}, N'{1}', N'{2}', N'{3}', N'{4}', {5})", userID, userName, passWord, displayName, gmail, isAdmin);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Remove(int userID)
        {
            string query = string.Format("DELETE FROM dbo.UserInfo WHERE userID = {0}", userID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool RemoveAllGameFromUser(int userID)
        {
            string query = string.Format("DELETE FROM dbo.OwnedGame WHERE userID = {0}", userID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Edit(int userID, string userName, string passWord, string displayName, string gmail, int isAdmin)
        {
            string query = string.Format("UPDATE dbo.UserInfo SET userName = N'{1}', password = N'{2}', display_name = N'{3}', gmail = N'{4}', isAdmin = {5} WHERE userID = {0}", userID, userName, passWord, displayName, gmail, isAdmin);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
