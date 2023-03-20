using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class Thongke
    {
        private int maHD;
        private string tenban;
        private string tendouong;
        private int sl;
        private double giamgia;
        private double thanhtien;
        private DateTime ngaylap;
        private string tennhanvien;
        public int MaHD { get => maHD; set => maHD = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Tendouong { get => tendouong; set => tendouong = value; }
        public int Sl { get => sl; set => sl = value; }
        public double Giamgia { get => giamgia; set => giamgia = value; }
        public double Thanhtien { get => thanhtien; set => thanhtien = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Tennhanvien { get => tennhanvien; set => tennhanvien = value; }

        public Thongke(int mahd, string tenban, string tendou, int sl, double giam, double tt, DateTime ngay, string tennv)
        {
            this.MaHD = mahd;
            this.Tenban = tenban;
            this.Tendouong = tendou;
            this.Sl = sl;
            this.Giamgia = giam;
            this.Thanhtien = tt;
            this.Ngaylap = ngay;
            this.Tennhanvien = tennhanvien;
        }
        public Thongke(DataRow row)
        {
            this.MaHD = (int)row["mahoadon"];
            this.Tenban = row["tenban"].ToString();
            this.Tendouong = row["tendouong"].ToString();
            this.sl = (int)row["soluong"];
            this.Giamgia = (double)row["tlgiamgia"];
            this.Thanhtien = (double)row["tongtien"];
            this.Ngaylap = (DateTime)row["giolap"];
            this.Tennhanvien = row["tennv"].ToString();
        }
    }
}
