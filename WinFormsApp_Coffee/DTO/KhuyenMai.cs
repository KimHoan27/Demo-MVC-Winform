using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WinFormsApp_Coffee.DTO
{
    public class KhuyenMai
    {
        private int maDot;
        private string tenDot;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string trangThai;


        public int MaDot { get => maDot; set => maDot = value; }
        public string TenDot { get => tenDot; set => tenDot = value; }

        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public KhuyenMai(int madot, string tendot, DateTime ngaybatdau, DateTime ngayketthuc, string trangthai)
        {
            MaDot = madot;
            TenDot = tendot;
            NgayBatDau = ngaybatdau;
            NgayKetThuc = ngayketthuc;
            TrangThai = trangthai;
        }

        public KhuyenMai(DataRow row)
        {
            this.MaDot = (int)row["madotkm"];
            this.TenDot = row["tendotkm"].ToString();
            this.NgayBatDau = (DateTime)row["ngaybatdau"];
            this.NgayKetThuc = (DateTime)row["ngayketthuc"];
            this.TrangThai = row["trangthaidotkm"].ToString();
        }
    }
}