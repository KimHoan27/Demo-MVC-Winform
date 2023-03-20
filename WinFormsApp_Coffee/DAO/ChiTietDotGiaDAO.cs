using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    class ChiTietDotGiaDAO
    {
        private static ChiTietDotGiaDAO instance;
        //Thiết kế patern singleton
        public static ChiTietDotGiaDAO Instance
        {
            get { if (instance == null) instance = new ChiTietDotGiaDAO(); return ChiTietDotGiaDAO.instance; }
            private set { ChiTietDotGiaDAO.instance = value; }
        }

        private ChiTietDotGiaDAO() { }
        public List<ChiTietDotGia> loadChiTietDotGia(int madotgia)
        {
            List<ChiTietDotGia> danhSachChiTietDoUong = new List<ChiTietDotGia>();
            DataTable data = clsDB.Instance.execQuery("USP_LayChiTietDoUong @madotgia",new object[] { madotgia });//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                ChiTietDotGia ctdouong = new ChiTietDotGia(item);
                danhSachChiTietDoUong.Add(ctdouong);
            }
            return danhSachChiTietDoUong;
        }
        public DataTable loadTendouong()
        {
            string SQL = "select * from dbo.DOUONG";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            return dt;
        }
        public DataTable loadMaDotGia()
        {
            string SQL = "select * from dbo.GIATHEODOT where trangthaigia = 1";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            return dt;
        }
        public DataTable loadDMDouong()
        {
            string SQL = "select * from dbo.DANHMUCDOUONG";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            return dt;
        }
        public bool themChiTietDoUong(int madotgia, int madouong, double giaban)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_ThemDoUongVaoDot @madotgia , @madouong ,  @giaban", new object[] { madotgia , madouong , giaban });
            return result > 0;
        }
        public bool suaChiTietDoUong(int madotgia, int madouong, double giaban)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_SuaChiTietDoUong @madotgia , @madouong ,  @giaban ", new object[] { madotgia , madouong , giaban });
            return result > 0;
        }
        public bool xoaChiTietDoUong(int madotgia, int madouong)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_XoaChiTietDoUong @madotgia , @madouong ", new object[] {  madotgia , madouong });
            return result > 0;
        }
        public bool kiemTraMaDotGiaTonTai(int madotgia)
        {
            DataTable tb = clsDB.Instance.execQuery("select * from dbo.GIATHEODOT where madotgia=" + madotgia + "");//" or madouong=N'" + madouong + "'");
            if (tb.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
