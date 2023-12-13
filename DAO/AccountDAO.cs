using EpistWinform.DTO;
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

        public DataTable Login(string userName, string passWord, ref int status)
        {
            string query = "Login @userName , @passWord";
            DataTable result = new DataTable();
            try
            {
                result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            }
            catch (Exception)
            {
                //MessageBox.Show("caught");
                status = -1;
            }

            //return result.Rows.Count > 0;
            return result;
        }

        //public Account GetAccount()
        //{

        //    Account a = new Account();
        //}
    }
}
