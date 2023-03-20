using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    class QuanLyDMDoUongDAO
    {
        //Thiết kế patern Singleton cho QuanLyDMDoUongDAO
        private static QuanLyDMDoUongDAO instance;
        public static QuanLyDMDoUongDAO Instance
        {
            get { if (instance == null) instance = new QuanLyDMDoUongDAO(); return QuanLyDMDoUongDAO.instance; }
            private set { QuanLyDMDoUongDAO.instance = value; }
        }
        private QuanLyDMDoUongDAO() { }
        //Phương thức lấy danh sách bàn từ DataTable
        /*
        Trước hết phải tạo thủ tục
        CREATE PROC USP_LDSDanhMuc
        AS
        SELECT madanhmuc, tendanhmuc
        FROM dbo.DANHMUCDOUONG      
         */
        public List<DMDoUong> loadDanhSachDanhMuc()
        {
            List<DMDoUong> danhSachDanhMuc = new List<DMDoUong>();
            DataTable data = clsDB.Instance.execQuery("USP_LDSDanhMuc");//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                DMDoUong dmdouong = new DMDoUong(item);
                danhSachDanhMuc.Add(dmdouong);
            }
            return danhSachDanhMuc;
        }
        //Phương thức kiểm tra danh mục có tồn tại trong csdl hay ko?
        public bool kiemTraDanhMucTonTai(string tendanhmuc)
        {
            DataTable tb = clsDB.Instance.execQuery("select * from dbo.DANHMUCDOUONG where tendanhmuc=N'" + tendanhmuc + "'");
            if (tb.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Phương thức thêm bàn vào cơ sở dữ liệu
        /*
         Trước hết phải tạo thủ tục
        CREATE PROC USP_Themdanhmuc
        @tendanhmuc nvarchar(100)
        AS
        BEGIN
        INSERT dbo.DANHMUCDOUONG(tendanhmuc) VALUES (@tendanhmuc)
        END
         */
        public bool themDanhMuc(string tendanhmuc)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_Themdanhmuc @tendanhmuc", new object[] { tendanhmuc });
            return result > 0;
        }
        //Phương thức sửa thông tin danh mục
        /*
         Muốn tạo phương thức này trước hết cần phải vào SQl Server tạo thủ tục
         CREATE PROC USP_SuaDanhMuc
            @madanhmuc int,
            @tendanhmuc nvarchar(100)
            AS
            BEGIN
            UPDATE dbo.DANHMUCDOUONG set tendanhmuc = @tendanhmuc where madanhmuc = @madanhmuc
            END         
         sau đó tạo phương thức xác nhận sửa thông tin danh mục
         biến result dùng để trả số hàng khi thực thi câu lệnh truy vấn exec USP_SuaDanhMuc
         */
        public bool suaDanhMuc(int madanhmuc, string tendanhmuc)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_SuaDanhMuc @madanhmuc , @tendanhmuc", new object[] { madanhmuc, tendanhmuc });
            return result > 0;
        }
        //Phương thức xóa danh mục
        /*
         Muốn tạo phương thức này trước hết cần phải vào SQl Server tạo
         CREATE PROC USP_XoaDanhMuc
            @madanhmuc int
            AS
            BEGIN
            DELETE FROM dbo.DANHMUCDOUONG where madanhmuc = @madanhmuc
            END
         sau đó tạo phương thức xác nhận xóa danh mục
         biến result dùng để trả số hàng khi thực thi câu lệnh truy vấn exec USP_XoaDanhMuc
         */
        public bool xoaDanhMuc(int madanhmuc)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_XoaDanhMuc @madanhmuc", new object[] { madanhmuc });
            return result > 0;
        }
    }
}
