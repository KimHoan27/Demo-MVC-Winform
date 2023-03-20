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
    public partial class frmDmdouong : Form
    {
        public frmDmdouong()
        {
            InitializeComponent();
            loadDanhMuc();
        }
        //phương thức load danh mục lên datagridview
        void loadDanhMuc()
        {
            dgvDmdouong.DataSource = QuanLyDMDoUongDAO.Instance.loadDanhSachDanhMuc();
        }
        //Phương thức xử lý khi kích chuột vào datagridview tự động dữ liệu sẽ hiện lên textbox
        private void dgvDmdouong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMadanhmuc.Text = dgvDmdouong.Rows[e.RowIndex].Cells[0].Value + "";
            txtTendanhmuc.Text = dgvDmdouong.Rows[e.RowIndex].Cells[1].Value + "";
        }
        //phương thức xóa dữ liệu có trong textbox, dataTimePicker, Combobox
        void xoaDuLieu()
        {
            txtMadanhmuc.Clear();
            txtTendanhmuc.Clear();
            txtMadanhmuc.Focus();
        }
        //Tạo sự kiện thêm danh mục
        private void btnThemdm_Click(object sender, EventArgs e)
        {
            if (txtTendanhmuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                string tendm = txtTendanhmuc.Text;              
                if (QuanLyDMDoUongDAO.Instance.kiemTraDanhMucTonTai(tendm)) //Kiểm tra danh mục tồn tại
                {
                    MessageBox.Show("Danh mục này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (QuanLyDMDoUongDAO.Instance.themDanhMuc(tendm))//Gọi phương thức thêm bàn từ QuanLyDMDoUongDAO
                    {
                        MessageBox.Show("Thêm danh mục thành công");
                        loadDanhMuc();
                        xoaDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Thêm danh mục thất bại");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Tạo sự kiện sửa danh mục
        private void btnSuadm_Click(object sender, EventArgs e)
        {
            if (txtMadanhmuc.Text == "" || txtTendanhmuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào danh mục muốn sửa thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                int madm = Int32.Parse(txtMadanhmuc.Text);
                string tendm = txtTendanhmuc.Text;
                if (QuanLyDMDoUongDAO.Instance.suaDanhMuc(madm, tendm))//Gọi phương thức sửa danh mục từ QuanLyDMDoUongDAO
                {
                    MessageBox.Show("Sửa thông tin danh mục thành công");
                    loadDanhMuc();
                    xoaDuLieu();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin danh mục thất bại");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Tạo sự kiện xóa danh mục
        private void btnXoadm_Click(object sender, EventArgs e)
        {
            if (txtMadanhmuc.Text == "" || txtTendanhmuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào danh mục muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa danh mục không?", "Thông báo", MessageBoxButtons.YesNo,//Hiển thị form xác nhận có muốn xóa bàn ?
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                try
                {
                    int madm = Int32.Parse(txtMadanhmuc.Text);
                    if (QuanLyDMDoUongDAO.Instance.xoaDanhMuc(madm))//Gọi phương thức xóa danh mục từ DAO
                    {
                        MessageBox.Show("Xóa danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhMuc();
                        xoaDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Xóa danh mục không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Danh mục này đang được sử dụng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            xoaDuLieu();
        }
    }
}
