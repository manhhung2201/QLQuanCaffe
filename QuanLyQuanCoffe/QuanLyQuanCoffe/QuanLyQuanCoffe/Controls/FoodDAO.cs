using QuanLyQuanCoffe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCoffe.Controls
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food where idCategory = " + id;

            DataTable data = DataProvide.Instace.ExcuteQuerry(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food";

            DataTable data = DataProvide.Instace.ExcuteQuerry(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

       /* public void UpdateFood(int id, string name, int type, int price, string image)
        {
            string querry = " exec USP_UpdateProductInf " + id + " , N'" + name + "' , " + type + " , " + price + " , N'" + image + "'";
            DataProvide.Instace.ExcuteNonQuerry(querry);
        }

        public void InsertFood(string name, int type, int price, string image)
        {
            string querry = " exec USP_InsertFood  N'" + name + "' , " + type + " , " + price + " , N'" + image + "'";
            DataProvide.Instace.ExcuteNonQuerry(querry);
        }

        public void RemoveFood(String id)
        {
            string querry = "DELETE FROM [dbo].[Food] where idFood = '" + id + "'";
            DataProvide.Instace.ExcuteNonQuerry(querry);
        }

        */

       
    }
}
