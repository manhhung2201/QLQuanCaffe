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
    public partial class ItemOrder : UserControl
    {
        public ItemOrder(Models.Food item)
        {
            InitializeComponent();
            itemName.Text = item.Name;
            itemPrice.Text = item.Price.ToString();
            string filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", string.Empty) + "Asset\\Resources\\FoodIMG\\";
            itemImage.ImageLocation = filepath + item.Image;
        }
        private void btnAdd2_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.SeaGreen;
        }

        private void btnAdd2_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Gray;
        }
        private void itemName_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void itemImage_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
