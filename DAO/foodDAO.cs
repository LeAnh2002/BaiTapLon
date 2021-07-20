using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.DTO;

namespace WindowsFormsApp9.DAO
{
    public class foodDAO
    {
        private static foodDAO instance;
        public static foodDAO Instance
        {
            get { if (instance == null) instance = new foodDAO(); return foodDAO.instance; }
            private set { foodDAO.instance = value; }
        }
        private foodDAO() { }
        public List<food> GetFoodByCategoryID(int id)
        {
            List<food> list = new List<food>();
            string query = "select*from food where idcategory=" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                food food = new food(item);
                list.Add(food);
            }
            return list;
        }
        public List<food> GetListFood()
        {
            List<food> list = new List<food>();
            string query = "select*from food ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                food food = new food(item);
                list.Add(food);
            }
            return list;
        }
        public bool InsertFood(string name, int id, float price)
        {
            string query = "insert into food(name, idcategory, price) values (N'" + name + "', " + id + " ,  " + price + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateFood(int idfood, string name, int id, float price)
        {
            string query = "update food set name =N' " + name + "', idcategory = " + id + ",price = " + price + " where id=" + idfood;
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteFood(int idfood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodId(idfood);
            string query = "Delete food where id=" + idfood;
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public void DeleteFoodByCategoryId(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete food where idcategory =" + id);
        }
        public List<food> SearchFoodByName(string name)
        {
            List<food> list = new List<food>();
            string query = "select* from food where dbo.non_unicode_convert(name) like N'%'+dbo.non_unicode_convert(N'" + name + "') + '%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                food food = new food(item);
                list.Add(food);
            }
            return list;
        }
    }
}
