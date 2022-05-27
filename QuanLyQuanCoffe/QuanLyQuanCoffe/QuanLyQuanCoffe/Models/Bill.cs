using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Models
{
    public class Bill
    {
        public Bill(string idbill, DateTime? time, string idEmployee, string idPromotion)
        {
            this.IdBill = idbill;
            this.Time = time;
            this.IdEmployee = idEmployee;
            this.IdPromotion = idPromotion;
        }

        public Bill(DataRow row)
        {
            this.IdBill = row["idBill"].ToString();
            this.Time = (DateTime?)row["Time"];
            this.IdEmployee = row["idEmployee"].ToString();
            this.IdPromotion = row["idPromotion"].ToString();
        }


        private string idBill;
        private DateTime? time;
        private string idEmployee;
        private string idPromotion;

        public string IdBill { get => idBill; set => idBill = value; }
        public DateTime? Time { get => time; set => time = value; }
        public string IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string IdPromotion { get => idPromotion; set => idPromotion = value; }
    }
}
