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
    public partial class frmQuanlykhuyenmai : Form
    {
        public frmQuanlykhuyenmai()
        {
            InitializeComponent();
            loadKm();
        }
        // phương thức load ds km trên datagridview
        void loadKm()
        {
            dgvQuanlykhuyenmai.DataSource = QuanLyKhuyenMaiDAO.Instance.loadDanhSachKhuyenMai();
            cbbTrangthai.SelectedIndex = 0;
        }
        //phương thức xoaa dữ liệu có trong textbox, combobox, dataPicker
        void xoaDuLieu()
        {
            txtMadot.Clear();
            txtTendot.Clear();

            dateNgaybd.Value = DateTime.Now;
            dateNgaykt.Value = DateTime.Now;
            cbbTrangthai.SelectedIndex = 0;
            txtMadot.Focus();
        }
        //Tạo sự kiện thêm đợt khuyến mãi
        private void btnThemdotkhuyenmai_Click(object sender, EventArgs e)
        {
            if (txtTendot.Text == "" || cbbTrangthai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try//try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                string tendot = txtTendot.Text;
                DateTime ngaybd = dateNgaybd.Value;
                DateTime ngaykt = dateNgaykt.Value;
                int trangthai = cbbTrangthai.SelectedIndex;
                if (QuanLyKhuyenMaiDAO.Instance.kiemTraKmTonTai(tendot)) //Kiểm tra tồn tại
                {
                    MessageBox.Show("Đợt khuyến mãi đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (QuanLyKhuyenMaiDAO.Instance.themDotKhuyenMai(tendot, ngaybd, ngaykt, trangthai))//Gọi phương thức thêm  từ DAO
                    {
                        MessageBox.Show("Thêm thành công");
                        loadKm();
                        xoaDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Không thành công");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemdotkm_Click(object sender, EventArgs e)
        {
            frmDotkhuyenmai f = new frmDotkhuyenmai();
            if (txtMadot.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            f.Madotkm = Int32.Parse(txtMadot.Text);
            f.ShowDialog();
        }
        //Phương thức xử lý khi kích chuột vào datagridview tự động dữ liệu sẽ hiện lên textbox

        private void dgvQuanlykhuyenmai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMadot.Text = dgvQuanlykhuyenmai.Rows[e.RowIndex].Cells[0].Value + "";
            txtTendot.Text = dgvQuanlykhuyenmai.Rows[e.RowIndex].Cells[1].Value + "";
            dateNgaybd.Value = Convert.ToDateTime(dgvQuanlykhuyenmai.Rows[e.RowIndex].Cells[2].Value);
            dateNgaykt.Value = Convert.ToDateTime(dgvQuanlykhuyenmai.Rows[e.RowIndex].Cells[3].Value);
            cbbTrangthai.SelectedItem = dgvQuanlykhuyenmai.Rows[e.RowIndex].Cells[4].Value + "";
        }

        private void btnSuathongtin_Click(object sender, EventArgs e)
        {
            if (txtMadot.Text == "" || txtTendot.Text == "" || cbbTrangthai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi muốn sửa  !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                int ma = Int32.Parse(txtMadot.Text);
                string tendot = txtTendot.Text;
                DateTime ngaybd = dateNgaybd.Value;
                DateTime ngaykt = dateNgaykt.Value;
                int trangthai = cbbTrangthai.SelectedIndex;
                if (QuanLyKhuyenMaiDAO.Instance.suaDotKhuyenMai(ma, tendot, ngaybd, ngaykt, trangthai))//Gọi phương thức sửa bàn từ QuanLyKhuyenMaiDAO
                {
                    MessageBox.Show("Sửa thông tin thành công");
                    loadKm();
                    xoaDuLieu();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin không thành công");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoadotkhuyenmai_Click(object sender, EventArgs e)
        {
            if (txtMadot.Text == "" || txtTendot.Text == "" || cbbTrangthai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,//Hiển thị form xác nhận có muốn xóa  ?
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
                {
                    int ma = Int32.Parse(txtMadot.Text);
                    if (QuanLyKhuyenMaiDAO.Instance.xoaDotKhuyenMai(ma))//Gọi phương thức xóa km từ DAO
                    {
                        MessageBox.Show("Xóa bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadKm();
                        xoaDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Xóa bàn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Đợt giá này đang được sử dụng !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            xoaDuLieu();
        }
    }
}
