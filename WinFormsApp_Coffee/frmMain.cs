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
    public partial class frmMain : Form
    {
      
        private TaiKhoanLogin dntaikhoan;
        public TaiKhoanLogin DnTaiKhoan
        {
            get { return dntaikhoan; }
            set { dntaikhoan = value; PhanQuyen(dntaikhoan.MaLoaiTK); }
        }

        

        private double total;
        private double giamgia;
        private double thanhtien;
        public frmMain(TaiKhoanLogin tk)
        {
            InitializeComponent();
            this.DnTaiKhoan = tk;
            LoadBan();
            LoadCategory();
            LoadComboboxTable(cbChuyenBan);
        }
        //Phương thức phân quyền
        void PhanQuyen(int maloaitk)
        {
            adminToolStripMenuItem.Visible = maloaitk == 0;
        }
        //Hiển thị form ql danh mục đồ uống
        private void quảnLýDanhMụcĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDmdouong f = new frmDmdouong();
            f.ShowDialog();
            LoadCategory();
        }
        //Hiển thị form ql đồ uống
        private void quảnLýĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDouong f = new frmDouong();
            f.ShowDialog();
            LoadCategory();
        }
        //Hiển thị form ql bàn
        private void quảnLýBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlyban f = new frmQuanlyban();
            f.ShowDialog();
            LoadBan();
        }
        //Hiển thị form ql thống kê
        private void quảnLýThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlythongke f = new frmQuanlythongke();
            f.ShowDialog();
        }
        //Hiển thị form qltk
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlytaikhoan f = new frmQuanlytaikhoan();
            f.ShowDialog();
        }
        //Hiển thị form qlkm
        private void quảnLýKhuyễnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlykhuyenmai f = new frmQuanlykhuyenmai();
            f.ShowDialog();
        }
        //Hiển thị form qltk cá nhân
        private void quảnLýTàiKhoảnCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlytaikhoancanhan f = new frmQuanlytaikhoancanhan(DnTaiKhoan);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }
        //Cập nhật lại tài khoản
        void f_UpdateAccount(object sender, AccountEvent e)
        {
            DnTaiKhoan.MaTaiKhoan = e.Acc.MaTaiKhoan;
            DnTaiKhoan.TenNV = e.Acc.TenNV;
            DnTaiKhoan.NgaySinh = e.Acc.NgaySinh;
            DnTaiKhoan.GioiTinh = e.Acc.GioiTinh;
            DnTaiKhoan.CMnd = e.Acc.CMND;
            DnTaiKhoan.Email = e.Acc.Email;
            DnTaiKhoan.Sdt = e.Acc.SDT;
        }
        //Hiển thị form ql đợt giá
        private void quảnLýĐợtGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaapdung f = new frmGiaapdung();
            f.ShowDialog();
        }
        //Tạo sự kiện thanh toán
        private void button1_Click(object sender, EventArgs e)
        {
            Ban table = lvBill.Tag as Ban;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.MaBan);
            if (idBill > 0)//có bill thì mới xuất hiện form thanh toán
            {
                frmThanhToan f = new frmThanhToan();
                f.Idban = table.MaBan;
                f.Tenban = table.TenBan;
                f.TotalPrice = total;
                f.Tentk = DnTaiKhoan.TenNV;
                f.Giamgia = giamgia;
                f.Thanhtien = thanhtien;
                f.ShowDialog();
            }
            LoadBan();
            ShowBill(table.MaBan);
        }

        private void quảnLýHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanlyhoadon f = new frmQuanlyhoadon();
            f.ShowDialog();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemHoaDonChoNV f = new frmXemHoaDonChoNV();
            f.ShowDialog();
        }
        //Load bàn 
        void LoadBan()
        {
            flpBan.Controls.Clear();
            List<Ban> tableList = BanDAO.Instance.LoadDanhSachBan();
            foreach (Ban item in tableList)
            {
                Button btn = new Button() { Width = BanDAO.TableWidth, Height = BanDAO.TableHeight };//Tạo ra các button 

                btn.Text = item.TenBan + Environment.NewLine + item.TrangThai; //Gán dữ liệu vào các button
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua; //Tô màu 
                        break;
                    case "Đã khóa":
                        btn.BackColor = Color.Yellow;
                        break;
                    default:
                        btn.BackColor = Color.LightPink; //Tô màu
                        break;
                }
                flpBan.Controls.Add(btn);
            }
        }
        //Tạo sự kiện click bàn
        private void btn_Click(object sender, EventArgs e)
        {
            int maBan = ((sender as Button).Tag as Ban).MaBan;
            string tenban = ((sender as Button).Tag as Ban).TenBan;
            string trangthai = ((sender as Button).Tag as Ban).TrangThai;
            if(trangthai == "Đã khóa")
            {
                MessageBox.Show("Bàn đã bị khóa, vui lòng chọn bàn khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            lvBill.Tag = (sender as Button).Tag;
            textBox1.Text = tenban;
            ShowBill(maBan);
        }
        //Hiển thị bill trong listview
        void ShowBill(int id)
        {
            lvBill.Items.Clear();
            List<WinFormsApp_Coffee.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            double totalPrice = 0;
            double giam = 0;
            double tt = 0;
            foreach (WinFormsApp_Coffee.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Food.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("#,###"));
                lsvItem.SubItems.Add(item.Tlgiamgia.ToString());
                lsvItem.SubItems.Add(item.Totalprice.ToString("#,###"));
                giam += (((item.Price * item.Count) / 100) * item.Tlgiamgia);
                totalPrice += item.Totalprice;
                tt += (item.Price * item.Count);
                lvBill.Items.Add(lsvItem);
            }
            total = totalPrice;
            giamgia = giam;
            thanhtien = tt;
        }
        //Load danh mục đồ uống
        void LoadCategory()
        {
            List<DMDoUong> listCategory = DanhmucdouongDAO.Instance.GetListCategory();
            cbDMDouong.DataSource = listCategory;
            cbDMDouong.DisplayMember = "tendanhmuc";
        }
        //Load đồ uống trong combobox
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = DouongDAO.Instance.GetFoodByCategoryID(id);
            cbDouong.DataSource = listFood;
            cbDouong.DisplayMember = "tendouong";
        }
        //Tạo sự kiện danh mục đồ uống
        private void cbDMDouong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            cbDouong.Text = "";
            
            ComboBox cb = sender as ComboBox;           
            if (cb.SelectedItem == null)
                return;

            DMDoUong selected = cb.SelectedItem as DMDoUong;
            id = selected.MaDanhMuc;

            LoadFoodListByCategoryID(id);
        }
        //Tạo sự kiện đặt đồ uống
        private void btndatdouong_Click(object sender, EventArgs e)
        {           
                Ban table = lvBill.Tag as Ban;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }          
                if (cbDouong.SelectedItem == null)
                return;
          
                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.MaBan);
                int foodID = (cbDouong.SelectedItem as Food).Madouong;
                int count = (int)numupSL.Value;

                if (idBill == -1) //Không có bill thì nó sẽ tạo bill mới, còn nếu có thì nó chỉ thêm món
                {
                    BillDAO.Instance.InsertBill(dntaikhoan.MaTaiKhoan, table.MaBan);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
                }
                ShowBill(table.MaBan);
                LoadBan();                
        }
        //Tạo sự kiện xóa đồ uống
        private void button3_Click(object sender, EventArgs e)
        {
            Ban table = lvBill.Tag as Ban;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbDouong.SelectedItem == null)
                return;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.MaBan);
            int foodID = (cbDouong.SelectedItem as Food).Madouong;
            int count = (int)numupSL.Value;
            BillInfoDAO.Instance.DeleteBillInfo(idBill, foodID, count);
            ShowBill(table.MaBan);
            LoadBan();
        }
        //Load combobox table
        void LoadComboboxTable(ComboBox cb)
        {
            cbChuyenBan.DataSource = BanDAO.Instance.LoadDanhSachBan();
            cbChuyenBan.DisplayMember = "tenban";
        }
        //Tạo sự kiện chuyển bàn
        private void button2_Click(object sender, EventArgs e)
        {
            Ban table = lvBill.Tag as Ban;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.MaBan);
            int id1 = (lvBill.Tag as Ban).MaBan;
            int id2 = (cbChuyenBan.SelectedItem as Ban).MaBan;          
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lvBill.Tag as Ban).TenBan, (cbChuyenBan.SelectedItem as Ban).TenBan), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (idBill > 0)
                {
                    BanDAO.Instance.SwitchTable(id1, id2);
                }
                LoadBan();
                ShowBill(table.MaBan);
            }
        }

        private void flpBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
