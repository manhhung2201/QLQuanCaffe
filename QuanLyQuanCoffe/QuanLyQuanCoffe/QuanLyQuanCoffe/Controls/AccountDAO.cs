﻿using QuanLyQuanCoffe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Controls
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value;
        }

        private AccountDAO()
        {
           
        }
        public bool Login(string UserName, string Password)
        {
            string querry = "USP_Login @username , @password ";
            DataTable result = DataProvide.Instace.ExcuteQuerry(querry, new object[] { UserName, Password });

            return result.Rows.Count > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvide.Instace.ExcuteQuerry("Select * from account where UserName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
        public string GetNameFromID(string ID)
        {
            string querry = "Select * From Employee Where idEmployee=\'" + ID + "\'";
            DataTable result = DataProvide.Instace.ExcuteQuerry(querry);

            return result.Rows[0]["Name"].ToString();
        }
         

        public void ChangePassword(String username, String newpass)
        {
            string query = "exec USP_ChangePassword @username , @newpass ";
            DataProvide.Instace.ExcuteNonQuerry(query, new object[] { username, newpass });
        }

    }
}
