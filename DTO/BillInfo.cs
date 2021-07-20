using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9.DTO
{
    public class BillInfo
    {
         public BillInfo(int id, int idbill,int idfood, int count)
        {
            this.ID = id;
            this.BillID = idbill;
            this.FoodID = idfood;
            this.Count = count;
        }
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID=(int)row["idBill"];
            this.FoodID=(int)row["idFood"];
            this.Count = (int)row["count"];
        }
        private int count;
        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        private int foodID;
        public int FoodID
        {
            get { return foodID; }
            private set { foodID = value; }
        }
        private int billID;
        public int BillID
        {
            get { return billID; }
            private set { billID = value; }
        }
        private int iD;
        public int ID
        {
            get { return iD; }
            private set { iD = value; }
        }
    }
}
