using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Models
{

    public class Promotion
    {
        public Promotion(string idPromo, DateTime startDate, DateTime endDate, string des, int pricePromo)
        {
            this.IdPromo = idPromo;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Des = des;
            this.PricePromo = pricePromo;
        }

        public Promotion(DataRow row)
        {
            this.IdPromo = row["idPromotion"].ToString();
            this.StartDate = (DateTime)row["StartDate"];
            this.EndDate = (DateTime)row["EndDate"];
            this.Des = row["Description"].ToString();
            this.PricePromo = Int32.Parse(row["PricePromotion"].ToString());
        }
        private string idPromo;
        private DateTime startDate;
        private DateTime endDate;
        private string des;
        private int pricePromo;

        public string IdPromo { get => idPromo; set => idPromo = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string Des { get => des; set => des = value; }
        public int PricePromo { get => pricePromo; set => pricePromo = value; }
    }
}
