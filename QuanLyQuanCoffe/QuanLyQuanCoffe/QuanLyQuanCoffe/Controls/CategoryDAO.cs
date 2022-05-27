using QuanLyQuanCoffe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Controls
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from FoodCategory";

            DataTable data = DataProvide.Instace.ExcuteQuerry(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "select * from FoodCategory where id = " + id;

            DataTable data = DataProvide.Instace.ExcuteQuerry(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }

        public int GetCategoryIDFromName(string name)
        {
            Category category = null;

            string query = "select * from FoodCategory where name =N'" + name + "'";

            DataTable data = DataProvide.Instace.ExcuteQuerry(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category.IdCategory;
            }

            return 0;
        }
    }
}
