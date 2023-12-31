﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpistWinform.DTO
{
    public class Account
    {
        private int userID;

        private string displayName;

        private string userName;

        private string passWord;

        private string gmail;

        private int isAdmin;
        public int UserID { get => userID; set => userID = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int IsAdmin { get => isAdmin; set => isAdmin = value; }
        public string Gmail { get => gmail; set => gmail = value; }

        public Account(int userID, string displayName, string userName, string passWord, int isAdmin, string gmail)
        {
            this.userID = userID;
            this.displayName = displayName;
            this.userName = userName;
            this.passWord = passWord;
            this.isAdmin = isAdmin;
            this.gmail = gmail;
        }

        public Account(DataRow row)
        {
            this.userID = (int)row["userID"];
            this.displayName = row["display_name"].ToString();
            this.userName = row["username"].ToString();
            this.passWord = row["password"].ToString();
            this.gmail = row["gmail"].ToString();
            this.isAdmin = (int)row["isAdmin"];
        }
    }
}
