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
    public partial class frmDotkhuyenmai : Form
    {
        private int madotkm;

        public int Madotkm { get => madotkm; set => madotkm = value; }

        public frmDotkhuyenmai()
        {
            InitializeComponent();
            loadTenDoUong();
        }
        void loadDanhSachKM()
        {
            dgvDotkhuyenmai.DataSource = ChitietKMDAO.Instance.loadDanhSachKM(madotkm);
            txtKM.Text = madotkm.ToString();
        }
        //load ten dot km
        //void loadTenDotKM()
        //{
        //    cbbMadotkm.DataSource = ChitietKMDAO.Instance.loadTenDotKM();
        //    cbbMadotkm.DisplayMember = "tendotkm";
        //    cbbMadotkm.ValueMember = "madotkm";
        //}
        //load ten do uong
        void loadTenDoUong()
        {
            cbbMadouong.DataSource = ChitietKMDAO.Instance.loadTenDoUong();
            cbbMadouong.DisplayMember = "tendouong";
            cbbMadouong.ValueMember = "madouong";
        }
        //load xóa dữ liệu
        void loadXoadulieu()
        {
            cbbMadouong.SelectedIndex = 0;
            txtTilegiam.Clear();
        }
        //Tạo sự kiện thêm mới
        private void btnThemsanpham_Click(object sender, EventArgs e)
        {
            if (txtTilegiam.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                int madotkm = Int32.Parse(txtKM.Text);
                int madouong = Int32.Parse(cbbMadouong.SelectedValue.ToString());
                double tlgiamgia = double.Parse(txtTilegiam.Text);
                if (tlgiamgia < 0 || tlgiamgia > 100)
                {
                    MessageBox.Show("Vui lòng nhập tỷ lệ giảm giá lớn hơn 0 và nhỏ hơn 100 !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                 if (ChitietKMDAO.Instance.themSanPhamKM(madotkm, madouong, tlgiamgia))//Gọi phương thức thêm SPKM
                    {
                        MessageBox.Show("Thêm thành công");
                        loadDanhSachKM();
                        loadXoadulieu();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai ký tự hoặc đã tồn tại đồ uống trong đợt km đó !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        //Tạo sự kiện CellClick
        private void dgvDotkhuyenmai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;        
            cbbMadouong.Text = dgvDotkhuyenmai.Rows[e.RowIndex].Cells[1].Value + "";
            txtTilegiam.Text = dgvDotkhuyenmai.Rows[e.RowIndex].Cells[2].Value + "";
        }
        //Tạo sự kiện sửa thông tin
        private void btnSuasanpham_Click(object sender, EventArgs e)
        {
            if (txtTilegiam.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào đồ uống muốn sửa thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                int madotkm = Int32.Parse(txtKM.Text);
                int madouong = Int32.Parse(cbbMadouong.SelectedValue.ToString());
                double tlgiamgia = double.Parse(txtTilegiam.Text);
                if (tlgiamgia < 0 || tlgiamgia > 100)
                {
                    MessageBox.Show("Vui lòng nhập tỷ lệ giảm giá lớn hơn 0 và nhỏ hơn 100 !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ChitietKMDAO.Instance.suaSanPhamKM(madotkm, madouong, tlgiamgia))//Gọi phương thức sửa đồ uống km
                {
                    MessageBox.Show("Sửa thông tin thành công");
                    loadDanhSachKM();
                    loadXoadulieu();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Tạo sự kiện xóa sản phẩm
        private void btnXoasanpham_Click(object sender, EventArgs e)
        {
            if (txtTilegiam.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào đồ uống muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,//Hiển thị form xác nhận có muốn xóa bàn ?
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                int madotkm = Int32.Parse(txtKM.Text);
                int madouong = Int32.Parse(cbbMadouong.SelectedValue.ToString());
                try
                {
                    if (ChitietKMDAO.Instance.xoaSanPhamKM(madotkm, madouong))//Gọi phương thức xóa bàn từ DAO
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhSachKM();
                        loadXoadulieu();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Đợt khuyến mãi này đang được sử dụng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void bntLammoi_Click(object sender, EventArgs e)
        {
            loadXoadulieu();
        }

        private void frmDotkhuyenmai_Load(object sender, EventArgs e)
        {
            loadDanhSachKM();
        }
    }
}
