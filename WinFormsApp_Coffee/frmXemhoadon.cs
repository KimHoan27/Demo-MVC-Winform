using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp_Coffee.DAO;

namespace WinFormsApp_Coffee
{
    public partial class frmXemhoadon : Form
    {
        private int mahoadon;
        private DateTime ngay;
        private string tennv;
        private string tenban;
        public frmXemhoadon()
        {
            InitializeComponent();
        }

        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Tenban { get => tenban; set => tenban = value; }

        void loadChiTietHD()
        {
            dgvChitiethoadon.DataSource = QuanLyHoaDonDAO.Instance.loadDanhSachChiTietHD(mahoadon);
            txtMHD.Text = mahoadon.ToString();
            txtngay.Text = ngay.ToString("dd/MM/yyyy");
            txtNhanVien.Text = tennv;
            txtTenBan.Text = tenban;
        }

        private void frmXemhoadon_Load(object sender, EventArgs e)
        {
            loadChiTietHD();
        }
    }
}
