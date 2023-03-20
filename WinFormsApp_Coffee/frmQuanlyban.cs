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
    public partial class frmQuanlyban : Form
    {
        public frmQuanlyban()
        {
            InitializeComponent();
            loadBan();
        }
        //phương thức load bàn lên datagridview
        void loadBan()
        {
            dgvQuanlyban.DataSource = QuanLyBanDAO.Instance.loadDanhSachBan();
            cbTrangThai.SelectedIndex = 0;
        }
        //phương thức xóa dữ liệu có trong textbox, dataTimePicker, Combobox
        void xoaDuLieu()
        {
            txtMaban.Clear();
            txtTenban.Clear();
            txtSoghe.Clear();
            dateBD.Value = DateTime.Now;
            cbTrangThai.SelectedIndex = 0;
            txtMaban.Focus();
        }
        //Tạo sự kiện thêm bàn
        private void btnThemban_Click(object sender, EventArgs e)
        {
            if (txtTenban.Text == "" || txtSoghe.Text == "" || cbTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                string tenban = txtTenban.Text;
                int soghe = Int32.Parse(txtSoghe.Text);
                DateTime ngay = dateBD.Value;
                int trangthai = cbTrangThai.SelectedIndex;
                if (soghe < 0)
                {
                    MessageBox.Show("Vui lòng nhập giá trị lớn hơn 0 !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (QuanLyBanDAO.Instance.kiemTraBanTonTai(tenban)) //Kiểm tra bàn tồn tại
                {
                    MessageBox.Show("Bàn này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {                   
                    if (QuanLyBanDAO.Instance.themBan(tenban, soghe, ngay, trangthai))//Gọi phương thức thêm bàn từ QuanLyBanDAO
                    {
                        MessageBox.Show("Thêm bàn thành công");
                        loadBan();
                        xoaDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Thêm bàn thất bại");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Tạo sự kiện sửa bàn
        private void btnSuaban_Click(object sender, EventArgs e)
        {
            if (txtMaban.Text == "" || txtTenban.Text == "" || txtSoghe.Text == "" || cbTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào bàn muốn sửa thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                int ma = Int32.Parse(txtMaban.Text);
                string tenban = txtTenban.Text;
                int soghe = Int32.Parse(txtSoghe.Text);
                DateTime ngay = dateBD.Value;
                int trangthai = cbTrangThai.SelectedIndex;
                if (soghe < 0)
                {
                    MessageBox.Show("Vui lòng nhập giá trị lớn hơn 0 !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (QuanLyBanDAO.Instance.suaThongTinBan(ma, tenban, soghe, ngay, trangthai))//Gọi phương thức sửa bàn từ QuanLyBanDAO
                {
                    MessageBox.Show("Sửa thông tin bàn thành công");
                    loadBan();
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
        //Phương thức xử lý khi kích chuột vào datagridview tự động dữ liệu sẽ hiện lên textbox
        private void dgvQuanlyban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMaban.Text = dgvQuanlyban.Rows[e.RowIndex].Cells[0].Value + "";
            txtTenban.Text = dgvQuanlyban.Rows[e.RowIndex].Cells[1].Value + "";
            txtSoghe.Text = dgvQuanlyban.Rows[e.RowIndex].Cells[2].Value + "";
            dateBD.Value = Convert.ToDateTime(dgvQuanlyban.Rows[e.RowIndex].Cells[3].Value);
            cbTrangThai.SelectedItem = dgvQuanlyban.Rows[e.RowIndex].Cells[4].Value + "";
        }
        //Tạo sự kiện xóa bàn
        private void btnXoaban_Click(object sender, EventArgs e)
        {
            if (txtMaban.Text == "" || txtTenban.Text == "" || txtSoghe.Text == "" || cbTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào bàn muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bàn không?", "Thông báo", MessageBoxButtons.YesNo,//Hiển thị form xác nhận có muốn xóa bàn ?
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                try
                {
                    int ma = Int32.Parse(txtMaban.Text);
                    if (QuanLyBanDAO.Instance.xoaBan(ma))//Gọi phương thức xóa bàn từ DAO
                    {
                        MessageBox.Show("Xóa bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadBan();
                        xoaDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Xóa bàn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn không thể xóa bàn này. Bàn này đang được dùng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void btnKhoaban_Click(object sender, EventArgs e)
        {
            if (txtMaban.Text == "" || txtTenban.Text == "" || txtSoghe.Text == "" || cbTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào bàn muốn khóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn khóa bàn không?", "Thông báo", MessageBoxButtons.YesNo,//Hiển thị form xác nhận có muốn xóa bàn ?
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                int ma = Int32.Parse(txtMaban.Text);
                if (QuanLyBanDAO.Instance.Khoaban(ma))//Gọi phương thức khóa bàn từ DAO
                {
                    MessageBox.Show("Khóa bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadBan();
                    xoaDuLieu();
                }
                else
                {
                    MessageBox.Show("Khóa bàn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            xoaDuLieu();
        }
    }
}
