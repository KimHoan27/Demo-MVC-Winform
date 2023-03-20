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
    public partial class frmGiaapdung : Form
    {
        public frmGiaapdung()
        {
            InitializeComponent();
            loadGia();       
        }

        //phương thức load bàn lên datagridview
        void loadGia()
        {
            dgvGiaapdung.DataSource = GiaApDungDAO.Instance.loadGiaAD();
            cbtrangthai.SelectedIndex = 0;
        }
        //phương thức xóa dữ liệu có trong textbox, dataTimePicker, Combobox
        void xoaDuLieu()
        {
            txtMadotgia.Clear();
            
            dateBD.Value = DateTime.Now;
            cbtrangthai.SelectedIndex = 0;
            txtMadotgia.Focus();
        }
        //Tạo sự kiện thêm dot gia
        private void btnThemdotgia_Click(object sender, EventArgs e)
        {
            if (cbtrangthai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                
                DateTime ngay = dateBD.Value;
                int trangthai = cbtrangthai.SelectedIndex;
                    if (GiaApDungDAO.Instance.themgiaad( ngay, trangthai))//Gọi phương thức thêm bàn từ GiaApDungDAO
                    {
                        MessageBox.Show("Thêm đợt giá thành công");
                        loadGia();
                        xoaDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Thêm đợt giá thất bại");
                    }               
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Phương thức xử lý khi kích chuột vào datagridview tự động dữ liệu sẽ hiện lên textbox
        private void dgvGiaapdung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMadotgia.Text = dgvGiaapdung.Rows[e.RowIndex].Cells[0].Value + "";
            dateBD.Value = Convert.ToDateTime(dgvGiaapdung.Rows[e.RowIndex].Cells[1].Value);
            cbtrangthai.SelectedItem = dgvGiaapdung.Rows[e.RowIndex].Cells[2].Value + "";
        }

        private void btnKhoadotgia_Click(object sender, EventArgs e)
        {

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            xoaDuLieu();
        }

        private void btnXemdotgia_Click(object sender, EventArgs e)
        {
            frmChiTietDotGia f = new frmChiTietDotGia();
            if (txtMadotgia.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào mã !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            f.Madotgia = Int32.Parse(txtMadotgia.Text);
            f.ShowDialog();
        }

        private void btnSuadotgia_Click(object sender, EventArgs e)
        {
            if (txtMadotgia.Text == "" || dateBD.Text == "" || cbtrangthai.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào mã muốn sửa thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                int madotgia = Int32.Parse(txtMadotgia.Text);
                DateTime ngaybd = dateBD.Value;
                int trangthai = cbtrangthai.SelectedIndex;

                if (GiaApDungDAO.Instance.suaDotGia(madotgia, ngaybd, trangthai))//Gọi phương thức sửa bàn từ QuanLyBanDAO
                {
                    MessageBox.Show("Sửa thông tin bàn thành công");
                    loadGia();
                    xoaDuLieu();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin bàn thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
