using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    class QuanLyTaiKhoanDAO
    {
        //Thiết kế patern Singleton cho QuanLyTaiKhoanDAO
        private static QuanLyTaiKhoanDAO instance;
        public static QuanLyTaiKhoanDAO Instance
        {
            get
            {
                if (instance == null) instance = new QuanLyTaiKhoanDAO();
                return QuanLyTaiKhoanDAO.instance;
            }
            private set
            {
                QuanLyTaiKhoanDAO.instance = value;
            }
        }
        private QuanLyTaiKhoanDAO()
        { }
        //Phương thức lấy danh sách bàn tư DataTable
        /*
         Trước hết phải tạo thủ tục
          CREATE PROC USP_LayDanhSachTaiKhoan
          AS 
          SELECT mataikhoan , tendangnhap , matkhau , tennv , ngaysinh ,
          gioitinh , cmnd , email , sdt ,
          case maloaitk
          when 0 then N'Admin'
         when 1 then N'Nhân viên' end as maloaitk,
          case trangthaitk
          when 0 then N'Bình thường'
         when 1 then N'Khóa' end as  trangthaitk FROM dbo.TAIKHOAN
         * */
        public List<TaiKhoan> loadDanhSachTaiKhoan()
        {
            List<TaiKhoan> danhSachTaiKhoan = new List<TaiKhoan>();
            DataTable data = clsDB.Instance.execQuery("USP_LayDanhSachTaiKhoan"); //Lấy thủ tục từ SQL server
            foreach(DataRow item in data.Rows)
            {
                TaiKhoan taikhoan = new TaiKhoan(item);
                danhSachTaiKhoan.Add(taikhoan);

            }
            return danhSachTaiKhoan;
        }
        //Phương thức thêm bàn vào csdl
        /*
         * Trước hết phải tạo thủ tục
         * CREATE PROC USP_ThemTaiKhoan
              @tendangnhap nvarchar(100),
              @matkhau nvarchar(100) , 
              @tennv nvarchar(100),
              @ngaysinh datetime,
              @gioitinh nvarchar(100),
              @cmnd nvarchar(100),
              @email nvarchar(100),
              @sdt nvarchar(100),
		      @maloaitk int,
              @trangthaitk int
          AS
               BEGIN
                   INSERT dbo.TAIKHOAN(tendangnhap , matkhau , tennv , ngaysinh ,gioitinh , cmnd , email , sdt , maloaitk , trangthaitk)
				   VALUES (@tendangnhap , @matkhau , @tennv , @ngaysinh ,@gioitinh , @cmnd , @email , @sdt  , @maloaitk , @trangthaitk)
          END
         */
        public bool themTaiKhoan(string tendangnhap , string matkhau , string tennv, DateTime ngaysinh, string gioitinh , string cmnd, string email , string sdt, int loaitk,  int trangthaitk)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_ThemTaiKhoan @tendangnhap , @matkhau , @tennv , @ngaysinh , @gioitinh , @cmnd , @email , @sdt , @maloaitk , @trangthaitk", new object[] {
                 tendangnhap , matkhau , tennv , ngaysinh , gioitinh , cmnd , email , sdt , loaitk , trangthaitk });
            return result > 0;
        }
        //Phương thức kiểm tra tài khoản có trong csdl hay không
        public bool kiemTraTaiKhoanTonTai(string tendn)
        {
            DataTable tb = clsDB.Instance.execQuery("select * from dbo.taikhoan where tendangnhap = '" + tendn + "'");
            return tb.Rows.Count > 0;
        }
        //Phương thức sửa tt tài khoản
        /*CREATE proc [dbo].[USP_SuaThongTinTaiKhoan]
        @mataikhoan int,
        @tendangnhap nvarchar(100),
        @matkhau nvarchar(100) , 
        @tennv nvarchar(100),
        @ngaysinh datetime,
        @gioitinh nvarchar(100),
        @cmnd nvarchar(100),
        @email nvarchar(100),
        @sdt nvarchar(100),
        @maloaitk int,
        @trangthaitk int
        as 
	    begin 
		update dbo.TAIKHOAN set tendangnhap = @tendangnhap , matkhau = @matkhau , tennv = @tennv , ngaysinh = @ngaysinh ,
		gioitinh = @gioitinh , cmnd = @cmnd, email = @email , sdt = @sdt , maloaitk = @maloaitk , trangthaitk = @trangthaitk
        where mataikhoan = @mataikhoan
        end   
         */
        public bool suaThongTinTaiKhoan(int mataikhoan, string tendangnhap, string matkhau, string tennv, DateTime ngaysinh, string gioitinh, string cmnd, string email, string sdt, int loaitk, int trangthaitk)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_SuaThongTinTaiKhoan @mataikhoan , @tendangnhap , @matkhau , @tennv , @ngaysinh , @gioitinh , @cmnd , @email , @sdt , @maloaitk , @trangthaitk", new object[]{
                mataikhoan , tendangnhap , matkhau , tennv , ngaysinh ,gioitinh , cmnd , email , sdt , loaitk , trangthaitk });
            return result > 0;
        }
        //Phương thức xóa tài khoản
        /*create proc USP_XoaTaiKhoan
        @mataikhoan int
        as
        begin
        delete from dbo.TAIKHOAN where mataikhoan = @mataikhoan
        end
        */
        public bool xoaTaiKhoan(int mataikhoan)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_XoaTaiKhoan @mataikhoan", new object[] { mataikhoan });
            return result>0;
        }
        /*
         create proc USP_KhoaTaiKhoan
        @mataikhoan int
        as 
        begin
        update dbo.TAIKHOAN set trangthaitk = 1 where mataikhoan = @mataikhoan
        end 
         */
        public bool KhoaTaiKhoan(int mataikhoan)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_KhoaTaiKhoan @mataikhoan", new object[] { mataikhoan });
            return result > 0;
        }
        public bool KiemTraTaiKhoanAdmin(int mataikhoan)
        {
            DataTable dt = clsDB.Instance.execQuery("select * from dbo.TAIKHOAN where mataikhoan = " + mataikhoan + " and maloaitk = 0");
            return dt.Rows.Count > 0;
        }
        //Load loại tk
        public DataTable loadLoaiTK()
        {
            string SQL = "select * from dbo.LOAITAIKHOAN";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            return dt;
        }
    }
}
