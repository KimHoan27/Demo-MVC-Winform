using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
     public class ChitietKMDAO
    {
        private static ChitietKMDAO instance;

        public static ChitietKMDAO Instance
        {
            get { if (instance == null) instance = new ChitietKMDAO(); return ChitietKMDAO.instance; }
            private set { ChitietKMDAO.instance = value; }
        }
        private ChitietKMDAO() { }
        /*
         CREATE PROC USP_LayDanhSachKM
        @madotkm int
         AS
        SELECT a.tendouong, b.tendotkm, c.tilegiamgia
        FROM dbo.DOUONG as a, dbo.DOTKHUYENMAI as b, dbo.CHITIETKHUYENMAI as c 
        WHERE a.madouong = c.madouong and c.madotkm = b.madotkm and b.madotkm = @madotkm
         */
        public List<ChitietKM> loadDanhSachKM(int madotkm)
        {
            List<ChitietKM> danhSachKM = new List<ChitietKM>();
            DataTable data = clsDB.Instance.execQuery("USP_LayDanhSachKM @madotkm ", new object[] { madotkm });//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                ChitietKM ban = new ChitietKM(item);
                danhSachKM.Add(ban);
            }
            return danhSachKM;
        }
        /*
          create proc USP_ThemSanPhamKM
          @madotkm int,
        @madouong int,
        @tlgiamgia float
        AS
        BEGIN
        INSERT dbo.CHITIETKHUYENMAI(madotkm,madouong,tilegiamgia) VALUES (@madotkm,@madouong,@tlgiamgia)
        END
         */
        public bool themSanPhamKM(int madotkm, int madouong, double tlgiamgia)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_ThemSanPhamKM @madotkm , @madouong , @tlgiamgia", new object[] { madotkm , madouong , tlgiamgia });
            return result > 0;
        }
        /*
         CREATE PROC USP_SuaSanPhamKM
        @madotkm int,
        @madouong int,
        @tlgiamgia float
        AS
        BEGIN
        UPDATE dbo.CHITIETKHUYENMAI set tilegiamgia = @tlgiamgia where madotkm = @madotkm and madouong = @madouong
        END
         */
        public bool suaSanPhamKM(int madotkm, int madouong, double tlgiamgia)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_SuaSanPhamKM @madotkm , @madouong , @tlgiamgia", new object[] { madotkm, madouong, tlgiamgia });
            return result > 0;
        }
        /*
          create proc USP_xoaSanPhamKM
         @madotkm int,
         @madouong int
         as 
            begin 
	            delete from dbo.CHITIETKHUYENMAI where madotkm=@madotkm and madouong=@madouong
         end
         */
        public bool xoaSanPhamKM(int madotkm, int madouong)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_xoaSanPhamKM @madotkm , @madouong", new object[] { madotkm, madouong});
            return result > 0;
        }
        public DataTable loadTenDotKM()
        {
            string SQL = "select * from dbo.DOTKHUYENMAI";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            return dt;
        }
        public DataTable loadTenDoUong()
        {
            string SQL = "select * from dbo.DOUONG";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            return dt;
        }
    }
}
