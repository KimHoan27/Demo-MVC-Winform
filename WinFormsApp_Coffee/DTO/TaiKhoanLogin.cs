using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class TaiKhoanLogin
    {
        private int maTaiKhoan;
        private string tenDangNhap;
        private string matKhau;
        private int maLoaiTK;
        private string tenNV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string cMnd;
        private string email;
        private string sdt;

        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int MaLoaiTK { get => maLoaiTK; set => maLoaiTK = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string CMnd { get => cMnd; set => cMnd = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        public TaiKhoanLogin(DataRow row)
        {
            this.MaTaiKhoan = (int)row["mataikhoan"];
            this.TenDangNhap = row["tendangnhap"].ToString();
            this.MatKhau = row["matkhau"].ToString();
            this.MaLoaiTK = (int)row["maloaitk"];
            this.TenNV = row["tennv"].ToString();
            this.NgaySinh = (DateTime)row["ngaysinh"];
            this.GioiTinh = row["gioitinh"].ToString();
            this.CMnd = row["cmnd"].ToString();
            this.Email = row["email"].ToString();
            this.Sdt = row["sdt"].ToString();

        }

        public TaiKhoanLogin(int maTaiKhoan, string tenDangNhap, string matKhau, int maLoaiTK, string tennv, DateTime ngaysinh, string gioitinh, string cmnd, string email, string sdt)
        {
            this.maTaiKhoan = maTaiKhoan;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.maLoaiTK = maLoaiTK;
            this.TenNV = tennv;
            this.NgaySinh = (DateTime)ngaySinh;
            this.GioiTinh = gioitinh;
            this.CMnd = cmnd;
            this.Email = email;
            this.Sdt = sdt;
        }
    }
}
