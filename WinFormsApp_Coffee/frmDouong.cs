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
    public partial class frmDouong : Form
    {
        public frmDouong()
        {
            InitializeComponent();
            loadDouong();
            loadDMDouong();
            //loadMaDotGia();
        }
        //phương thức load bàn lên datagridview
        void loadDouong()
        {
            dgvDmdouong.DataSource = QuanLyDoUongDAO.Instance.loadDanhSachDoUong();
            cbbTrangthai.SelectedIndex = 0;
        }
        //phương thức xóa dữ liệu có trong textbox, dataTimePicker, Combobox
        void xoaDuLieu()
        {
            cbbMadanhmuc.SelectedIndex = 0;
            txtMadouong.Clear();
            txtTendouong.Clear();
            cbbTrangthai.SelectedIndex = 0;
            txtMadouong.Focus();
        }

        private void btnThemdouong_Click(object sender, EventArgs e)
        {
            if (cbbMadanhmuc.Text == "" || txtTendouong.Text == "" ||  cbbTrangthai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                int madanhmuc = Int32.Parse(cbbMadanhmuc.SelectedValue.ToString());
                string tendouong = txtTendouong.Text;
                
                int trangthai = cbbTrangthai.SelectedIndex;
                if (QuanLyDoUongDAO.Instance.kiemTraBanTonTai(tendouong)) //Kiểm tra đồ uống tồn tại
                {
                    MessageBox.Show("Đồ uống này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (QuanLyDoUongDAO.Instance.themDoUong(tendouong, madanhmuc, trangthai))//Gọi phương thức thêm bàn từ QuanLyBanDAO
                    {
                        MessageBox.Show("Thêm đồ uống thành công");
                        loadDouong();
                        xoaDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Thêm đồ uống thất bại");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuadouong_Click(object sender, EventArgs e)
        {
            //Tạo sự kiện sửa đồ uống                  
            if (cbbMadanhmuc.Text == "" || txtMadouong.Text == "" || txtTendouong.Text == "" || cbbTrangthai.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào đồ uống muốn sửa thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                int madouong = Int32.Parse(txtMadouong.Text);
                string tendouong = txtTendouong.Text;
                int madanhmuc = Int32.Parse(cbbMadanhmuc.SelectedValue.ToString());
                int trangthai = cbbTrangthai.SelectedIndex;
                if (QuanLyDoUongDAO.Instance.suaThongTinDoUong(madouong, tendouong, madanhmuc, trangthai))//Gọi phương thức sửa đồ uố từ QuanLyDoUongDAO
                {
                    MessageBox.Show("Sửa thông tin đồ uống thành công");
                    loadDouong();
                    xoaDuLieu();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin đồ uống thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoadouong_Click(object sender, EventArgs e)
        {
            if (cbbMadanhmuc.Text == "" || txtMadouong.Text == "" || txtTendouong.Text == "" ||  cbbTrangthai.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào đồ uống muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa đồ uống không?", "Thông báo", MessageBoxButtons.YesNo,//Hiển thị form xác nhận có muốn xóa đồ uống ?
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                try
                {
                    int madouong = Int32.Parse(txtMadouong.Text);
                    if (QuanLyDoUongDAO.Instance.xoaDoUong(madouong))//Gọi phương thức xóa đồ uống từ DAO
                    {
                        MessageBox.Show("Xóa đồ uống thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDouong();
                        xoaDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Xóa đồ uống không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn không thể xóa đồ uống này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

        }
        //phương thức load danh mục đồ uống
        void loadDMDouong()
        {
            cbbMadanhmuc.DataSource = QuanLyDoUongDAO.Instance.loadDMDouong();
            cbbMadanhmuc.DisplayMember = "tendanhmuc";
            cbbMadanhmuc.ValueMember = "madanhmuc";
        }
        //phương thức load mã đợt giá
        /*
        void loadMaDotGia()
        {
            cbbMadotgia.DataSource = QuanLyDoUongDAO.Instance.loadMaDotGia();
            cbbMadotgia.DisplayMember = "madotgia";
            cbbMadotgia.ValueMember = "madotgia";
            cbbMadotgia.SelectedIndex = 0;
        }
        */
        //phương thức load giá - 
        /*
        void loadGia()
        {
            if (cbbMadotgia.SelectedValue.ToString() == "System.Data.DataRowView") return;
            int id = Convert.ToInt32(cbbMadotgia.SelectedValue.ToString());
            string SQL = "select * from dbo.GIATHEODOT where madotgia = " + id + "";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            for (int i = 0; i < dt.Rows.Count; i++)// cái này nó sẽ duyệt từng dòng trong table tương ứng.
            {
                txtGiaban.Text = dt.Rows[i]["giaban"].ToString();
            }
        }
        */
        //phương thức xử lý khi nhấp chuột vào combobox mã đợt giá
        /*
        private void cbbMadotgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGia();
        }
        */
        //Phương thức khi nhấp chuột sẽ hiện dữ liệu lên textbox
        private void dgvdouong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMadouong.Text = dgvDmdouong.Rows[e.RowIndex].Cells[0].Value + "";
            txtTendouong.Text = dgvDmdouong.Rows[e.RowIndex].Cells[1].Value + "";
            
            cbbTrangthai.SelectedItem = dgvDmdouong.Rows[e.RowIndex].Cells[2].Value + "";
            cbbMadanhmuc.SelectedItem = dgvDmdouong.Rows[e.RowIndex].Cells[3].Value + "";
        }
        //Tạo sự kiện khóa đồ uống
        private void btnKhoadouong_Click(object sender, EventArgs e)
        {
            if (cbbMadanhmuc.Text == "" || txtMadouong.Text == "" || txtTendouong.Text == "" || cbbTrangthai.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào đồ uống muốn khóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn khóa đồ uống không?", "Thông báo", MessageBoxButtons.YesNo,//Hiển thị form xác nhận có muốn xóa đồ uống ?
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                int madouong = Int32.Parse(txtMadouong.Text);
                if (QuanLyDoUongDAO.Instance.Khoadouong(madouong))//Gọi phương thức xóa đồ uống từ DAO
                {
                    MessageBox.Show("Khóa đồ uống thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDouong();
                    xoaDuLieu();
                }
                else
                {
                    MessageBox.Show("Khóa đồ uống không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            xoaDuLieu();
        }
    }
}
