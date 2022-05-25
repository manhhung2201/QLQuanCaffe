using QuanLyQuanCoffe.UserControls;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            fUser1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            fOrder f =new fOrder();
            this.Hide();
            f.ShowDialog();
            this.Show();


        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //fLogin f1=new fLogin();
            //f1.Show();
            
        }
    }
}
