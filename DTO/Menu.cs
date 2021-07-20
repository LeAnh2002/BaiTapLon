using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9.DTO
{
   public  class Menu
    {
        public Menu(string foodname, int count, float price, float totalPrice = 0)
        {
            this.Foodname = foodname;
            this.Count = count;
            this.Price = price;
            this.Totalprice = totalPrice;
        }
        public Menu(DataRow row)
        {
            this.Foodname = row["name"].ToString();
            this.Count = (int)row["count"];

            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Totalprice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }
        private float totalprice;
        public float Totalprice { get => totalprice; set => totalprice = value; }

        private float price;
        public float Price { get => price; set => price = value; }

        private int count;
        public int Count { get => count; set => count = value; }

        private string foodname;
        public string Foodname { get => foodname; set => foodname = value; }

    }
}
