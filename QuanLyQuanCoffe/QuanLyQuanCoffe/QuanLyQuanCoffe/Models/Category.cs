using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Models
{
    public class Category
    {
        public Category(int id, string name)
        {
            this.idCategory = id;
            this.groupName = name;
        }

        public Category(DataRow row)
        {
            this.idCategory = (int)row["id"];
            this.groupName = row["name"].ToString();
        }

        private int idCategory;
        private string groupName;

        public int IdCategory { get => idCategory; set => idCategory = value; }
        public string GroupName { get => groupName; set => groupName = value; }


    }
}
