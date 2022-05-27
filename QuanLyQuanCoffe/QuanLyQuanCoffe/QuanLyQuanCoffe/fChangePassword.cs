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
    public partial class fChangePassword : Form
    {
        private Account CurrentSession;
        public fChangePassword(Account session)
        {
            InitializeComponent();
            CurrentSession = session;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text.Equals(String.Empty))
            {
                MessageBox.Show("Chưa nhập mật khẩu cũ");
                return;
            }

            if (txtNewPassword.Text.Equals(String.Empty))
            {
                MessageBox.Show("Chưa nhập mật khẩu mới");
                return;
            }

            if (txtConfirmPassword.Text.Equals(String.Empty))
            {
                MessageBox.Show("Chưa nhập lại mật khẩu mới");
                return;
            }

            if (!txtOldPassword.Text.Equals(CurrentSession.Password))
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                return;
            }

            if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Hai mật khẩu mới không khớp");
                return;
            }

            AccountDAO.Instance.ChangePassword(CurrentSession.UserName, txtNewPassword.Text);
            MessageBox.Show("Thay đổi mật khẩu thành công");


            this.Close();
        }

        private void fChangePassword_Load(object sender, EventArgs e)
        {

        }
    
    private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
