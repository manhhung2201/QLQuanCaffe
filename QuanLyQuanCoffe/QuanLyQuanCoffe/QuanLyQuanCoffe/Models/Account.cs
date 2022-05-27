using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCoffe.Models
{
    public class Account
    {

        public Account(string userName, string type, string idEmployee, string password = null)
        {
            this.UserName = userName;
            this.idEmployee = idEmployee;
            this.Type = type;
            this.Password = password;
        }

        public Account()
        {

        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.Password = row["password"].ToString();
            this.Type = row["type"].ToString();
            this.idEmployee = row["idEmployee"].ToString();
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string idEmployee;

        public string IdEmployee
        {
            get { return idEmployee; }
            set { idEmployee = value; }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
