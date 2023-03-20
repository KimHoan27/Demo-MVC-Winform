using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    public class QuanLyDoUongDAO
    {
        //Thiết kế patern Singleton cho QuanLyBanDoUongDao
        private static QuanLyDoUongDAO instance;
        public static QuanLyDoUongDAO Instance
        {
            get { if (instance == null) instance = new QuanLyDoUongDAO(); return QuanLyDoUongDAO.instance; }
            private set { QuanLyDoUongDAO.instance = value; }
        }
        private QuanLyDoUongDAO() { }
        //Phương thức lấy danh sách đồ uống từ DataTable
        /*
         Trước hết phải tạo thủ tục
        CREATE PROC USP_LayDanhSachDoUong
          AS
        SELECT madouong, tendouong, 
        case trangthaidouong 
        when 0 then N'Hết' 
        when 1 then N'Còn' 
        when 2 then N'Đã khóa'
        end as trangthaidouong, c.tendanhmuc
        FROM dbo.DOUONG as a, dbo.DANHMUCDOUONG as c where a.madanhmuc = c.madanhmuc
         */
        public List<Douong> loadDanhSachDoUong()
        {
            List<Douong> danhSachDoUong = new List<Douong>();
            DataTable data = clsDB.Instance.execQuery("USP_LayDanhSachDoUong");//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                Douong douong = new Douong(item); 
                danhSachDoUong.Add(douong);
            }
            return danhSachDoUong;
        }
        //Phương thức thêm đồ uống vào cơ sở dữ liệu
        /*
         Trước hết phải tạo thủ tục
        CREATE PROC USP_ThemDoUong
            @tendouong nvarchar(100),
			@madanhmuc int,
              
            @trangthaidouong int
        AS
            BEGIN
                INSERT dbo.DOUONG (tendouong, madanhmuc, trangthaidouong) VALUES ( @tendouong, @madanhmuc, @trangthaidouong)
            END
         */
        public bool themDoUong(string tendouong, int madanhmuc, int trangthai)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_ThemDoUong @tendouong , @madanhmuc ,  @trangthaidouong", new object[] { tendouong, madanhmuc, trangthai });
            return result > 0;
        }
        //Phương thức kiểm tra bàn có tồn tại trong csdl hay ko?
        public bool kiemTraBanTonTai(string tendouong)
        {
            DataTable tb = clsDB.Instance.execQuery("select * from dbo.DOUONG where tendouong=N'" + tendouong + "'");
            if (tb.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
         create proc [dbo].[USP_Khoadouong]
         @madouong int
         as 
            begin 
	            update dbo.DOUONG set trangthaidouong = 2 where madouong = @madouong
         end
         */
        public bool Khoadouong(int madouong)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_Khoadouong @madouong", new object[] { madouong });
            return result > 0;
        }
        //Phương thức sửa thông tin đồ uống
        /*
         Muốn tạo phương thức này trước hết cần phải vào SQl Server tạo thủ tục
            create proc USP_SuaThongTinDoUong
            @madouong int,
            @tendouong nvarchar(100),
    		@madanhmuc int,
            
            @trangthai int
            as 
                begin 
                    update dbo.DOUONG set tendouong = @tendouong, madanhmuc = @madanhmuc , trangthaidouong = @trangthai where madouong = @madouong
                end     
         sau đó tạo phương thức xác nhận sửa thông tin đồ uống 
         biến result dùng để trả số hàng khi thực thi câu lệnh truy vấn exec USP_SuaThongTinDoUong
         */
        public bool suaThongTinDoUong(int madouong, string tendouong, int madanhmuc, int trangthai)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_SuaThongTinDoUong @madouong , @tendouong , @madanhmuc , @trangthai", new object[] { madouong, tendouong, madanhmuc, trangthai });
            return result > 0;
        }
        //Phương thức xóa đồ uống
        /*
         Muốn tạo phương thức này trước hết cần phải vào SQl Server tạo
         create proc USP_Xoadouong
         @madouong int
         as 
            begin 
	            delete from dbo.DOUONG where madouong = @madouong
         end
         sau đó tạo phương thức xác nhận xóa đồ uố USP_Xoadouong
         biến result dùng để trả số hàng khi thực thi câu lệnh truy vấn exec USP_Xoadouong
         */
        public bool xoaDoUong(int madouong)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_Xoadouong @madouong", new object[] { madouong});
            return result > 0;
        }
        //phương thức load danh mục đồ uống
        public DataTable loadDMDouong()
        {
            string SQL = "select * from dbo.DANHMUCDOUONG";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            return dt;
        }
        //phương thức load mã đợt giá
        public DataTable loadMaDotGia()
        {
            string SQL = "select * from dbo.GIATHEODOT";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            return dt;
        }
    }
}    


