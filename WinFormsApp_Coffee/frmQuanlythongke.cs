using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp_Coffee.DAO;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee
{
    public partial class frmQuanlythongke : Form
    {
        public frmQuanlythongke()
        {
            InitializeComponent();
            loadTenNV();
            loadDMDoUong();
        }
        //load ten nv
        void loadTenNV()
        {
            cbbtennhanvien.DataSource = QuanLyThongKeDAO.Instance.loadTenNV();
            cbbtennhanvien.DisplayMember = "tennv";
            cbbtennhanvien.ValueMember = "mataikhoan";
            cbbtennhanvien.SelectedIndex = 0;
        }
        //load dm
        void loadDMDoUong()
        {
            cbbtendouong.DataSource = QuanLyThongKeDAO.Instance.loadDMDouong();
            cbbtendouong.DisplayMember = "tendanhmuc";
            cbbtendouong.ValueMember = "madanhmuc";
        }
        //Tạo sự kiện thống kê
        private void btnthongke_Click(object sender, EventArgs e)
        {
            double tongcong = 0;
            List<Thongke> danhSach = new List<Thongke>();           
            DateTime ngay1 = dateTimePicker1.Value;
            DateTime ngay2 = dateTimePicker2.Value;
            dgvQuanlythongke.DataSource = QuanLyThongKeDAO.Instance.loadThongKe(ngay1, ngay2);
            string SQL = "SELECT b.mahoadon, d.tenban, a.tendouong, b.soluong, b.tlgiamgia, b.tongtien, c.giolap, e.tennv FROM dbo.DOUONG as a, dbo.CHITIETHOADON as b, dbo.HOADON as c, dbo.BAN as d, dbo.TAIKHOAN as e WHERE  c.mataikhoan = e.mataikhoan and c.maban = d.maban and b.mahoadon = c.mahoadon and b.madouong = a.madouong and c.giolap >= '" + ngay1 + "' and c.giolap <= '" + ngay2 + "' and c.trangthaihoadon = 1";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            foreach (DataRow item in dt.Rows)
            {
                Thongke tk = new Thongke(item);
                tongcong += tk.Thanhtien;
            }
            txtTong.Text = tongcong.ToString("#,###"); 
        }
        //Tạo sự kiện khi click cb
        private void cbbtennhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            double tongcong = 0;
            List<Thongke> danhSach = new List<Thongke>();
            if (cbbtennhanvien.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            int id = Convert.ToInt32(cbbtennhanvien.SelectedValue.ToString());
            dgvQuanlythongke.DataSource = QuanLyThongKeDAO.Instance.loadThongKeTheoTenNV(id);
            string SQL = "SELECT b.mahoadon, d.tenban, a.tendouong, b.soluong, b.tlgiamgia, b.tongtien, c.giolap, e.tennv FROM dbo.DOUONG as a, dbo.CHITIETHOADON as b, dbo.HOADON as c, dbo.BAN as d, dbo.TAIKHOAN as e WHERE  c.mataikhoan = e.mataikhoan and c.maban = d.maban and b.mahoadon = c.mahoadon and b.madouong = a.madouong and c.mataikhoan = " + id + " and c.trangthaihoadon = 1";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            foreach (DataRow item in dt.Rows)
            {
                Thongke tk = new Thongke(item);
                tongcong += tk.Thanhtien;
            }
            txtTong.Text = tongcong.ToString("#,###");

        }
        //Tạo sự kiện khi click cb
        private void cbbtendouong_SelectedIndexChanged(object sender, EventArgs e)
        {
            double tongcong = 0;
            List<Thongke> danhSach = new List<Thongke>();
            if (cbbtendouong.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            int id = Convert.ToInt32(cbbtendouong.SelectedValue.ToString());
            dgvQuanlythongke.DataSource = QuanLyThongKeDAO.Instance.loadThongKeTheoDMDouong(id);
            string SQL = "SELECT b.mahoadon, d.tenban, a.tendouong, b.soluong, b.tlgiamgia, b.tongtien, c.giolap, e.tennv FROM dbo.DOUONG as a, dbo.CHITIETHOADON as b, dbo.HOADON as c, dbo.BAN as d, dbo.TAIKHOAN as e WHERE  c.mataikhoan = e.mataikhoan and c.maban = d.maban and b.mahoadon = c.mahoadon and b.madouong = a.madouong and a.madanhmuc = " + id + " and c.trangthaihoadon = 1";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            foreach (DataRow item in dt.Rows)
            {
                Thongke tk = new Thongke(item);
                tongcong += tk.Thanhtien;
            }
            txtTong.Text = tongcong.ToString("#,###");
        }

        private void btnthongkebanchay_Click(object sender, EventArgs e)
        {
            double tongcong = 0;
            List<Thongkebanchay> danhSach = new List<Thongkebanchay>();
            dgvdouongbanchay.DataSource = QuanLyThongKeDAO.Instance.loadThongKeDoUongBanChay();
            string SQL = "select c.tendouong, sum(a.soluong) as soluong, SUM(a.tongtien) as tong, d.tendanhmuc from dbo.CHITIETHOADON as a, dbo.HOADON as b , dbo.DOUONG as c, dbo.DANHMUCDOUONG as d where a.mahoadon = b.mahoadon and a.madouong = c.madouong and c.madanhmuc = d.madanhmuc and b.trangthaihoadon = 1 group by c.tendouong, d.tendanhmuc";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            foreach (DataRow item in dt.Rows)
            {
                Thongkebanchay tk = new Thongkebanchay(item);
                tongcong += tk.Tong;
            }
            txtTongbanbc.Text = tongcong.ToString("#,###");
        }
    }
}
