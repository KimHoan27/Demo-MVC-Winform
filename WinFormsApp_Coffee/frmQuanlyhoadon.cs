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
    public partial class frmQuanlyhoadon : Form
    {
        public frmQuanlyhoadon()
        {
            InitializeComponent();
            loadHD();
            loadTenNV();
            loadTenBan();
        }

        private void btnXemhd_Click(object sender, EventArgs e)
        {
            frmXemhoadon f = new frmXemhoadon();
            if (txtMahd.Text == "" || cbtenban.Text == "" || cbtennv.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào hóa đơn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            f.Mahoadon = Int32.Parse(txtMahd.Text);
            f.Ngay = dtNgaylap.Value;
            f.Tennv = cbtennv.Text;
            f.Tenban = cbtenban.Text;
            f.ShowDialog();
        }
        void loadHD()
        {
            dgvQlhoadon.DataSource = QuanLyHoaDonDAO.Instance.loadDanhSachHD();
            cbtrangthai.SelectedIndex = 0;
        }
        void loadTenNV()
        {
            cbtennv.DataSource = QuanLyHoaDonDAO.Instance.loadTenNV();
            cbtennv.DisplayMember = "tennv";
            cbtennv.ValueMember = "mataikhoan";
            cbtennv.SelectedIndex = 0;
        }
        void loadTenBan()
        {
            cbtenban.DataSource = QuanLyHoaDonDAO.Instance.loadTenBan();
            cbtenban.DisplayMember = "tenban";
            cbtenban.ValueMember = "maban";
            cbtenban.SelectedIndex = 0;
        }

        private void btnThemhd_Click(object sender, EventArgs e)
        {
            if (cbtennv.Text == "" || cbtrangthai.Text == "" || cbtenban.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                int matk = Int32.Parse(cbtennv.SelectedValue.ToString());
                DateTime ngay = dtNgaylap.Value;
                int maban = Int32.Parse(cbtenban.SelectedValue.ToString());
                int trangthai = cbtrangthai.SelectedIndex;
                if (QuanLyHoaDonDAO.Instance.themHoaDon(matk, ngay, maban, trangthai))//Gọi phương thức thêm hóa đơn
                {
                    MessageBox.Show("Thêm thành công");
                    loadHD();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
        }

        private void btnSuahd_Click(object sender, EventArgs e)
        {
            if (cbtennv.Text == "" || cbtrangthai.Text == "" || cbtenban.Text == "" || txtMahd.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào hóa đơn bạn muốn sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int mahd = Int32.Parse(txtMahd.Text);
            int matk = Int32.Parse(cbtennv.SelectedValue.ToString());
            DateTime ngay = dtNgaylap.Value;
            int maban = Int32.Parse(cbtenban.SelectedValue.ToString());
            int trangthai = cbtrangthai.SelectedIndex;
            if (QuanLyHoaDonDAO.Instance.suaHoaDon(mahd, matk, ngay, maban, trangthai))//Gọi phương thức thêm hóa đơn
            {
                MessageBox.Show("Sửa thành công");
                loadHD();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void dgvQlhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMahd.Text = dgvQlhoadon.Rows[e.RowIndex].Cells[0].Value + "";
            cbtennv.Text = dgvQlhoadon.Rows[e.RowIndex].Cells[1].Value + "";
            dtNgaylap.Value = Convert.ToDateTime(dgvQlhoadon.Rows[e.RowIndex].Cells[2].Value);
            cbtenban.Text = dgvQlhoadon.Rows[e.RowIndex].Cells[3].Value + "";
            cbtrangthai.SelectedItem = dgvQlhoadon.Rows[e.RowIndex].Cells[4].Value + "";
        }

        private void btnXoahd_Click(object sender, EventArgs e)
        {
            if (txtMahd.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào hóa đơn bạn muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,//Hiển thị form xác nhận có muốn xóa ?
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    int mahd = Int32.Parse(txtMahd.Text);
                    if (QuanLyHoaDonDAO.Instance.xoaHoaDon(mahd))//Gọi phương thức xóa từ DAO
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadHD();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn không thể xóa hóa đơn này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhoahd_Click(object sender, EventArgs e)
        {
            if (txtMahd.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào hóa đơn bạn muốn khóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                if (MessageBox.Show("Bạn có muốn khóa không?", "Thông báo", MessageBoxButtons.YesNo,//Hiển thị form xác nhận có muốn khóa ?
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    int mahd = Int32.Parse(txtMahd.Text);
                    if (QuanLyHoaDonDAO.Instance.KhoaHoaDon(mahd))//Gọi phương thức khóa từ DAO
                    {
                        MessageBox.Show("Khóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadHD();
                    }
                    else
                    {
                        MessageBox.Show("Khóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn không thể Khóa hóa đơn này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
