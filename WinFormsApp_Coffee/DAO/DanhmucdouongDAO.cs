using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    public class DanhmucdouongDAO
    {
        private static DanhmucdouongDAO instance;

        public static DanhmucdouongDAO Instance
        {
            get { if (instance == null) instance = new DanhmucdouongDAO(); return DanhmucdouongDAO.instance; }
            private set { DanhmucdouongDAO.instance = value; }
        }

        private DanhmucdouongDAO() { }

        public List<DMDoUong> GetListCategory()
        {
            List<DMDoUong> list = new List<DMDoUong>();

            string query = "select * from DANHMUCDOUONG";

            DataTable data = clsDB.Instance.execQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DMDoUong category = new DMDoUong(item);
                list.Add(category);
            }
            return list;
        }
    }
}
