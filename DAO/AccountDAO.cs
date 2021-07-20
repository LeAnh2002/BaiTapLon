using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.DTO;

namespace WindowsFormsApp9.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {

            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string usename, string passwork)
        {
            string query = " USP_Login @usename , @passwork";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { usename, passwork });
            return result.Rows.Count > 0;
        }
        public bool UpdateAccount(string usename, string displayname, string pass, string newpass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec UpdateAccount @usename , @displayname , @passwork , @newpasswork ", new object[] { usename, displayname, pass, newpass });
            return result > 0;
        }
        public Account GetAccountByUseName(string usename)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from account where usename = '" + usename + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select usename,displayname,type from account");
        }
        public bool InsertAccount(string name, string displayname, int type)
        {
            string query = "insert into Account(usename, displayname, type) values (N'" + name + "', N'" + displayname + "' ,  " + type + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateAccount(string name, string displayname, int type)
        {
            string query = "update Account set  displayname = N'" + displayname + "',type = " + type + " where usename =N'" + name + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteAccount(string usename)
        {
            string query = "Delete Account where usename =N'" + usename + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool ResetPassWord(string name)
        {
            string query = "Update Account set passwork =N'0' where usename =N'" + name + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
