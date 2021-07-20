using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.DTO;

namespace WindowsFormsApp9.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select*from bill where idtable =" + id + " and status=0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void CheckOut(int id, int discount, float totalprice)
        {
            string query = "update bill set datecheckout = getdate(), status =1 ," + " discount = " + discount + ", totalprice= " + totalprice + " where id=" + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec InsertBill @idTable", new object[] { id });
        }
        public DataTable GetBillListByDate(DateTime checkin, DateTime checkout)
        {
            return DataProvider.Instance.ExecuteQuery("exec GetListBillByDate @chechin , @checkout", new object[] { checkin, checkout });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(id) from bill");
            }
            catch
            {
                return 1;
            }
        }
        public void DeleteBillByTableId(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete bill where idtable = " + id);
        }
    }
}
