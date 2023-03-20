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
    public partial class frmDoimatkhau : Form
    {
        public frmDoimatkhau()
        {
            InitializeComponent();
        }
        private int matk;
        private string tendn;

        public int Matk { get => matk; set => matk = value; }
        public string Tendn { get => tendn; set => tendn = value; }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadThongtin()
        {
            txtdn.Text = tendn;
        }
        private void frmDoimatkhau_Load(object sender, EventArgs e)
        {
            loadThongtin();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if(txtmatkhaumoi.Text == "" || txtmkhientai.Text == "" || txtnhaplaimk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(CapNhapTaiKhoanDAO.Instance.kiemTraMK(txtdn.Text, txtmkhientai.Text))
            {
                if(txtmatkhaumoi.Text == txtnhaplaimk.Text)
                {
                    if (CapNhapTaiKhoanDAO.Instance.doiMatKhau(matk, txtnhaplaimk.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại !");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại bị sai. Vui lòng nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
