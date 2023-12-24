﻿using EpistWinform.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public DataTable Login(string userName, string passWord)
        {
            string query = "Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            //return result.Rows.Count > 0;
            return result;
        }
        // Khai báo một biến static để lưu userID của người dùng đăng nhập
        private static int loggedInUserID;

        // Thuộc tính public cho phép truy cập đến userID của người dùng đã đăng nhập
        public static int LoggedInUserID
        {
            get { return loggedInUserID; }
            private set { loggedInUserID = value; }
        }
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
    }
}
