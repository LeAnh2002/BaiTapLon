using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.DTO;

namespace WindowsFormsApp9.DAO
{
    public  class CategoryDAO
    {
        private static CategoryDAO instance;
        
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() { }
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "select*from foodcategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);

                list.Add(category);
            }
            return list;
        }
        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "select*from foodcategory where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);

                return category;
            }
            return category;
        }

        public bool InsertCategory(string name)
        {
            string query = "insert into foodcategory(name) values (N'" + name + " ')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateCategory(string name, int id)
        {
            string query = "update foodcategory set name =N' " + name + "' where id = " + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCategory(int id)
        {
           foodDAO.Instance.DeleteFoodByCategoryId(id);
            string query = "Delete foodcategory where id =" + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
