using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    public class DouongDAO
    {
        private static DouongDAO instance;

        public static DouongDAO Instance
        {
            get { if (instance == null) instance = new DouongDAO(); return DouongDAO.instance; }
            private set { DouongDAO.instance = value; }
        }

        private DouongDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from DOUONG where madanhmuc = " + id + " and trangthaidouong = 1";

            DataTable data = clsDB.Instance.execQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
    }
}