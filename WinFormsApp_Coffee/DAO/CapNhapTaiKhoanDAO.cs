using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
   public class CapNhapTaiKhoanDAO
    {
        private static CapNhapTaiKhoanDAO instance;
        public static CapNhapTaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new CapNhapTaiKhoanDAO(); return CapNhapTaiKhoanDAO.instance; }
            private set { CapNhapTaiKhoanDAO.instance = value; }
        }
        private CapNhapTaiKhoanDAO() { }
      
        public bool capnhapthongtincanhan(int mataikhoan, string tennv, DateTime ngaysinh, string gioitinh, string cmnd, string email, string sdt)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_CapNhapThongTin @mataikhoan , @tennv , @ngaysinh , @gioitinh , @cmnd , @email , @sdt ", new object[]{
                mataikhoan , tennv , ngaysinh ,gioitinh , cmnd , email , sdt  });
            return result > 0;
        }
        public bool doiMatKhau(int matk, string mk)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_DoiMatKhau @matk , @mk ", new object[] { matk, mk });
            return result > 0;
        }
        public bool kiemTraMK(string tendangnhap, string matkhau)
        {
            DataTable data = clsDB.Instance.execQuery("select * from dbo.TAIKHOAN where tendangnhap='" + tendangnhap + "' and matkhau='" + matkhau + "'");
            if (data.Rows.Count > 0)
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
