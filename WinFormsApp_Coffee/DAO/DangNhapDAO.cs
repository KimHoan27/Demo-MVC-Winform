using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    class DangNhapDAO
    {
        private static DangNhapDAO instance;
        public static DangNhapDAO Instance
        {
            get { if (instance == null) instance = new DangNhapDAO(); return DangNhapDAO.instance; }
            private set { DangNhapDAO.instance = value; }
        }
        private DangNhapDAO() { }
        /*
        CREATE PROC USP_DangNhap
        @tendangnhap nvarchar(100),
        @matkhau nvarchar(100)
        AS
        BEGIN
        SELECT * FROM dbo.TAIKHOAN where tendangnhap = @tendangnhap and matkhau = @matkhau and trangthaitk = 0
        END
         */
        public bool DangNhap(string tendangnhap, string matkhau)
        {
            DataTable dt = clsDB.Instance.execQuery("USP_Dangnhap @tendangnhap , @matkhau ", new object[] { tendangnhap, matkhau });
            return dt.Rows.Count > 0;
        }

        public TaiKhoanLogin LayTaiKhoan(string tendangnhap)
        {
            DataTable dt = clsDB.Instance.execQuery("select * from TAIKHOAN where tendangnhap = '" + tendangnhap + "'");

            foreach (DataRow item in dt.Rows)
            {
                return new TaiKhoanLogin(item);
            }
            return null;
        }
        public TaiKhoan Laymataikhoan(int matk)
        {
            DataTable data = clsDB.Instance.execQuery("Select * from TAIKHOAN where mataikhoan = " + matk + "");

            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }

            return null;
        }
        public bool KiemtrataikhoanBiKhoa(string tendn)
        {
            DataTable dt = clsDB.Instance.execQuery("select * from dbo.TAIKHOAN where tendangnhap = '" + tendn + "' and trangthaitk = 1");
            return dt.Rows.Count > 0;
        }
    }
}
