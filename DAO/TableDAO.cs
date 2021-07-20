using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.DTO;

namespace WindowsFormsApp9.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        private TableDAO() { }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public List<Table> GetListTable()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from tablefood");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public bool InsertTable(string name, string status)
        {
            string query = "insert into tablefood(name,status) values (N'" + name + "', N'" + status + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateTable(string name, string status, int id)
        {
            string query = "update tablefood set name =N'" + name + "', status = N'" + status + "' where id = " + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteTable(int id)
        {
            BillDAO.Instance.DeleteBillByTableId(id);
            string query = "Delete tablefood where id=" + id + " and status =N'Trống'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
