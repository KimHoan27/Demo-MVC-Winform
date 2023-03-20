using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using WinFormsApp_Coffee.DAO;

namespace WinFormsApp_Coffee
{
    public partial class frmThanhToan : Form
    {
        private int idban;
        private string tenban;
        private double thanhtien;
        private double totalPrice;
        private string tentk;
        private double giamgia;
        public frmThanhToan()
        {
            InitializeComponent();
        }
        //Lấy dữ liệu bên form chính
        public int Idban { get => idban; set => idban = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Tentk { get => tentk; set => tentk = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public double Giamgia { get => giamgia; set => giamgia = value; }
        public double Thanhtien { get => thanhtien; set => thanhtien = value; }

        //Load lên datagrid
        void load()
        {
            dgvThanhToan.DataSource = MenuDAO.Instance.GetListMenuByTable(idban);
            txtTongTien.Text = totalPrice.ToString("#,###");
        }
        //Tạo sự kiện thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(idban);

            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn này không ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill);
                    this.Hide();
                }
            }

        }
        private void frmThanhToan_Load_1(object sender, EventArgs e)
        {
            load();
        }

        private void btnInBill_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(200, 40));
            e.Graphics.DrawString(Tenban.Trim(), new Font("Arial", 19, FontStyle.Bold), Brushes.Black, new Point(380, 99));
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString("Nhân viên: " + Tentk.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 190));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));
            e.Graphics.DrawString("Tên món", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 255));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 255));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(480, 255));
            e.Graphics.DrawString("KM", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 255));
            e.Graphics.DrawString("T.Tiền", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(690, 255));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));
            int yPos = 295;
            List<WinFormsApp_Coffee.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(Idban);
            foreach (WinFormsApp_Coffee.DTO.Menu item in listBillInfo)
            {
                e.Graphics.DrawString(item.Food.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                e.Graphics.DrawString(item.Count.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(375, yPos));
                e.Graphics.DrawString(item.Price.ToString("#,###"), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(480, yPos));
                e.Graphics.DrawString(item.Tlgiamgia.ToString()+"%", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(601, yPos));
                e.Graphics.DrawString(item.Totalprice.ToString("#,###"), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(688, yPos));
                yPos += 30;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));
            e.Graphics.DrawString("Thành tiền:    " + Thanhtien.ToString("#,###"), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(479, yPos + 30));
            e.Graphics.DrawString("Giảm giá:       - " + Giamgia.ToString("#,###"), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(480, yPos + 70));
            e.Graphics.DrawString("Tổng cộng:     " + TotalPrice.ToString("#,###"), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(479, yPos + 110));
            e.Graphics.DrawString("Cảm ơn quý khách, hẹn gặp lại !", new Font("Arial", 20, FontStyle.Italic), Brushes.Black, new Point(220, yPos + 170));
        }
    }
}
