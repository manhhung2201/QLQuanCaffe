using QuanLyQuanCoffe.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffe
{
    public partial class fManageAdmin : Form
    {
        public fManageAdmin(Models.Account session)
        {
            InitializeComponent();
        }

        private void fManageAdmin_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            fOrderAdmin f = new fOrderAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
