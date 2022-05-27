using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Controls
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
        public void InsertBill(string idEmp,string idPromo,int totalPrice)
        {
            DataProvide.Instace.ExcuteNonQuerry("exec USP_InsertBill @idEmp,@idPromo,@totalPrice", new object[] { idEmp, idPromo, totalPrice });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvide.Instace.ExcuteScalar("SELECT MAX(id) FROM Bill");
            }
            catch
            {
                return 1;
            }
        }
    }

}
