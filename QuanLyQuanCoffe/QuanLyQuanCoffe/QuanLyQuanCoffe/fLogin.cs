using QuanLyQuanCoffe.Controls;
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

namespace QuanLyQuanCoffe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do you want to exit?","Notification ?",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = txtUsername.Text;
            string Password = txtPassword.Text;

            if(Login(UserName, Password))
            {
                Account session = AccountDAO.Instance.GetAccountByUserName(UserName);
                if (session.Type.Equals("staff"))
                {
                    fOrders f = new fOrders(session);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    fManageAdmin f = new fManageAdmin(session);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }

            }
                else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }    
        }
        bool Login(string UserName, string Password)
        {
            return AccountDAO.Instance.Login(UserName, Password);
        }


        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
