using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Models
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int foodID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["IdBillInf"];
            this.BillID = (int)row["IdBill"];
            this.FoodID = (int)row["IdFood"];
            this.Count = (int)row["Count"];
        }
        
        private int count;
        private int foodID;
        private int billID;
        private int iD;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
