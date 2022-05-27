using QuanLyQuanCoffe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffe.user_controls.Orderf
{
    public partial class ItemStandbyOrder : UserControl
    {
        public Food item;
        
        public ItemStandbyOrder(Food item)
        {
            InitializeComponent();
            itemName.Text = item.Name;
            itemPrice.Text = item.Price.ToString();
            this.item = item;
        }

        private void ItemStandbyOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            string t = txtAmount.Text;
            txtAmount.Text = (Int32.Parse(t) + 1).ToString();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            string t = txtAmount.Text;
            if (Int32.Parse(t) > 0)
            {

                txtAmount.Text = (Int32.Parse(t) - 1).ToString();
            }
        }
    }
}
