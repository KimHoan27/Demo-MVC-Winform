using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_Coffee.DAO;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Show hoặc Hide mật khẩu
        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShow.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }
        //Button Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Xác nhận thoát
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát không?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        //Button Đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {

            String tendangnhap = txtUserName.Text;
            String matkhau = txtPassWord.Text;
            if (txtUserName.Text == "" || txtPassWord.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(DangNhapDAO.Instance.KiemtrataikhoanBiKhoa(tendangnhap))
            {
                MessageBox.Show("Tài khoản này đã bị khóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DangNhapDAO.Instance.DangNhap(tendangnhap, matkhau))
            {
                TaiKhoanLogin dntaikhoan = DangNhapDAO.Instance.LayTaiKhoan(tendangnhap);
                frmMain f = new frmMain(dntaikhoan);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
