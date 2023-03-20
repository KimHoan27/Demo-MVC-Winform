using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT f.tendouong, bi.soluong, bi.giatien, bi.tlgiamgia, bi.tongtien AS totalPrice FROM dbo.CHITIETHOADON AS bi, dbo.HOADON AS b, dbo.DOUONG AS f WHERE bi.mahoadon = b.mahoadon AND bi.madouong = f.madouong AND b.trangthaihoadon = 0 AND b.maban = " + id;
            DataTable data = clsDB.Instance.execQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
