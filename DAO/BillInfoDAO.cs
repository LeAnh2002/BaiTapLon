using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.DTO;

namespace WindowsFormsApp9.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }

        public void DeleteBillInfoByFoodId(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete billinfo where idfood =" + id);
        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select*from billinfo where idbill =" + id);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }
        public void InsertBillInfo(int idbill, int idfood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("InsertBillInfo @idBill , @idfood , @count", new object[] { idbill, idfood, count });
        }
    }
}
