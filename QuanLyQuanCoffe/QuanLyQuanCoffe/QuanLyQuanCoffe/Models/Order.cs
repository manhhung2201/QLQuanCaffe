using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Models
{
    public class Order
    {
        public Order(string name, float price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
            this.total = price * amount;
        }

        private string name;
        private float price;
        private int amount;
        private float total;

        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public float Total { get => total; set => total = value; }
    }
}
