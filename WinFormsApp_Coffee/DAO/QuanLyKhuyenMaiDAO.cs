using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    class QuanLyKhuyenMaiDAO
    {
        //Thiết kế PS cho QuanLyKhuyenMaiDAO
        private static QuanLyKhuyenMaiDAO instance;
        public static QuanLyKhuyenMaiDAO Instance
        {
            get { if (instance == null) instance = new QuanLyKhuyenMaiDAO(); return QuanLyKhuyenMaiDAO.instance; }
            private set { QuanLyKhuyenMaiDAO.instance = value; }
        }
        private QuanLyKhuyenMaiDAO() { }
        // Phương thức lấy Ds Km từ Datatable
        /*
         Trước hết phải tạo thủ tục
         CREATE PROC USP_LayDanhSachDotKM
         AS
        SELECT madotkm, tendotkm, ngaybatdau, ngayketthuc, 
        case trangthaidotkm
        when 0 then N'Chưa áp dụng ' 
        when 1 then N'Đang diễn ra' end as trangthaidotkm FROM dbo.DOTKHUYENMAI      
         */

        public List<KhuyenMai> loadDanhSachKhuyenMai()
        {
            List<KhuyenMai> danhSachKhuyenMai = new List<KhuyenMai>();
            DataTable data = clsDB.Instance.execQuery("USP_LayDanhSachDotKm");//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                KhuyenMai khuyenmai = new KhuyenMai(item);
                danhSachKhuyenMai.Add(khuyenmai);
            }
            return danhSachKhuyenMai;
        }

        //Phương thức thêm đợt KM vào cơ sở dữ liệu
        /*
         Trước hết phải tạo thủ tục
        CREATE PROC USP_ThemKhuyenMai
        @tendotkm nvarchar(100),
        @ngaybatdau datetime,
        @ngayketthuc datetime,
        @trangthaidotkm int
        AS
            BEGIN
                INSERT dbo.DOTKHUYENMAI (tendotkm,  ngaybatdau, ngayketthuc, trangthaidotkm) VALUES (@tendotkm , @ngaybatdau , @ngayketthuc , @trangthaidotkm)
            END
         */
        public bool themDotKhuyenMai(string tendotkm, DateTime ngaybatdau, DateTime ngayketthuc, int trangthaidotkm)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_ThemKhuyenMai @tendotkm , @ngaybatdau , @ngayketthuc , @trangthaidotkm", new object[] { tendotkm, ngaybatdau, ngayketthuc, trangthaidotkm });
            return result > 0;
        }
        //Phương thức kiểm tra có tồn tại trong csdl hay ko?
        public bool kiemTraKmTonTai(string tendot)
        {
            DataTable tb = clsDB.Instance.execQuery("select * from dbo.dotkhuyenmai where tendotkm=N'" + tendot + "'");
            if (tb.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Phương thức sửa thông tin bàn
        /*
         Muốn tạo phương thức này trước hết cần phải vào SQl Server tạo thủ tục
            create proc USP_SuaDotKhuyenMai
            @madotkm int,
            @tendotkm nvarchar(100),
            @ngaybatdau datetime,
            @ngayketthuc datetime,
            @trangthaidotkm int
            as 
                begin 
                    update dbo.DOTKHUYENMAI set tendotkm = @tendotkm , ngaybatdau = @ngaybatdau , ngayketthuc = @ngayketthuc , trangthaidotkm = @trangthaidotkm where madotkm = @madotkm
                end          
         sau đó tạo phương thức xác nhận sửa thông tin bàn  
         biến result dùng để trả số hàng khi thực thi câu lệnh truy vấn exec USP_SuaDotKhuyenMai
         */

        public bool suaDotKhuyenMai(int madotkm, string tendotkm, DateTime ngaybatdau, DateTime ngayketthuc, int trangthaidotkm)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_SuaDotKhuyenMai @madotkm , @tendotkm , @ngaybatdau , @ngayketthuc , @trangthaidotkm", new object[] { madotkm, tendotkm, ngaybatdau, ngayketthuc, trangthaidotkm });
            return result > 0;
        }
        //Phương thức xóa bàn
        /*
         Muốn tạo phương thức này trước hết cần phải vào SQl Server tạo
         create proc USP_XoaDotKhuyenMai
         @madotkm int
         as 
            begin 
                delete from dbo.dotkhuyenmai where madotkm = @madotkm
         end
         sau đó tạo phương thức xác nhận xóa đợt khuyến mãi USP_XoaDotKhuyenMai
         biến result dùng để trả số hàng khi thực thi câu lệnh truy vấn exec USP_Xoaban
         */
        public bool xoaDotKhuyenMai(int madotkm)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_XoaDotKhuyenMai @madotkm", new object[] {madotkm });
            return result > 0;
        }
    }
}
