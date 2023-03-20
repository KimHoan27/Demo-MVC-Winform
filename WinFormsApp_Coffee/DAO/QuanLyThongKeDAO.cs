using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    public class QuanLyThongKeDAO
    {
        private static QuanLyThongKeDAO instance;
        public static QuanLyThongKeDAO Instance
        {
            get { if (instance == null) instance = new QuanLyThongKeDAO(); return QuanLyThongKeDAO.instance; }
            private set { QuanLyThongKeDAO.instance = value; }
        }
        private QuanLyThongKeDAO() { }
        public DataTable loadTenNV()
        {
            string SQL = "select * from dbo.TAIKHOAN";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            return dt;
        }
        public DataTable loadDMDouong()
        {
            string SQL = "select * from dbo.DANHMUCDOUONG";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            return dt;
        }
        public List<Thongke> loadThongKe(DateTime ngay1, DateTime ngay2)
        {
            List<Thongke> danhSach = new List<Thongke>();
            DataTable data = clsDB.Instance.execQuery(" SELECT b.mahoadon, d.tenban, a.tendouong, b.soluong, b.tlgiamgia, b.tongtien, c.giolap, e.tennv FROM dbo.DOUONG as a, dbo.CHITIETHOADON as b, dbo.HOADON as c, dbo.BAN as d, dbo.TAIKHOAN as e WHERE  c.mataikhoan = e.mataikhoan and c.maban = d.maban and b.mahoadon = c.mahoadon and b.madouong = a.madouong and c.giolap >= '"+ngay1+"' and c.giolap <= '"+ngay2+"' and c.trangthaihoadon = 1");//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                Thongke tk = new Thongke(item);
                danhSach.Add(tk);
            }
            return danhSach;
        }
        public List<Thongke> loadThongKeTheoTenNV(int matk)
        {
            List<Thongke> danhSach = new List<Thongke>();
            DataTable data = clsDB.Instance.execQuery(" SELECT b.mahoadon, d.tenban, a.tendouong, b.soluong, b.tlgiamgia, b.tongtien, c.giolap, e.tennv FROM dbo.DOUONG as a, dbo.CHITIETHOADON as b, dbo.HOADON as c, dbo.BAN as d, dbo.TAIKHOAN as e WHERE  c.mataikhoan = e.mataikhoan and c.maban = d.maban and b.mahoadon = c.mahoadon and b.madouong = a.madouong and c.mataikhoan = " + matk + " and c.trangthaihoadon = 1");//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                Thongke tk = new Thongke(item);
                danhSach.Add(tk);
            }
            return danhSach;
        }
        public List<Thongke> loadThongKeTheoDMDouong(int madm)
        {
            List<Thongke> danhSach = new List<Thongke>();
            DataTable data = clsDB.Instance.execQuery(" SELECT b.mahoadon, d.tenban, a.tendouong, b.soluong, b.tlgiamgia, b.tongtien, c.giolap, e.tennv FROM dbo.DOUONG as a, dbo.CHITIETHOADON as b, dbo.HOADON as c, dbo.BAN as d, dbo.TAIKHOAN as e WHERE  c.mataikhoan = e.mataikhoan and c.maban = d.maban and b.mahoadon = c.mahoadon and b.madouong = a.madouong and a.madanhmuc = " + madm + " and c.trangthaihoadon = 1");//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                Thongke tk = new Thongke(item);
                danhSach.Add(tk);
            }
            return danhSach;
        }
        public List<Thongkebanchay> loadThongKeDoUongBanChay()
        {
            List<Thongkebanchay> danhSach = new List<Thongkebanchay>();
            DataTable data = clsDB.Instance.execQuery("select c.tendouong, sum(a.soluong) as soluong, SUM(a.tongtien) as tong, d.tendanhmuc from dbo.CHITIETHOADON as a, dbo.HOADON as b , dbo.DOUONG as c, dbo.DANHMUCDOUONG as d where a.mahoadon = b.mahoadon and a.madouong = c.madouong and c.madanhmuc = d.madanhmuc and b.trangthaihoadon = 1 group by c.tendouong, d.tendanhmuc order by sum(a.soluong) desc");//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                Thongkebanchay tk = new Thongkebanchay(item);
                danhSach.Add(tk);
            }
            return danhSach;
        }
    }
}
