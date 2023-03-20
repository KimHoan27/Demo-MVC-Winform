using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    public class BanDAO
    {
        private static BanDAO instance;
        //Thiết kế patern singleton
        public static BanDAO Instance
        {
            get { if (instance == null) instance = new BanDAO(); return BanDAO.instance; }
            private set { BanDAO.instance = value; }
        }

        public static int TableWidth = 170;
        public static int TableHeight = 170;

        private BanDAO() { }
        public void SwitchTable(int id1, int id2)
        {
            clsDB.Instance.execQuery("usp_SwitchTable @id1 , @id2", new object[] { id1, id2 });
        }
        //Load danh sách bàn
        /*
         * CREATE PROC USP_LayDanhSachBan2
           AS SELECT * from dbo.BAN
           GO
         */
        public List<Ban> LoadDanhSachBan()
        {
            List<Ban> tableList = new List<Ban>();

            DataTable data = clsDB.Instance.execQuery("USP_LayDanhSachBan");

            foreach (DataRow item in data.Rows)
            {
                Ban table = new Ban(item);
                tableList.Add(table);
            }

            return tableList;
        }     
    }
}
