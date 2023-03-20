using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class Chitiethoadon
    {
        private int maHD;
        private string tendouong;
        private int sl;
        private double giatien;
        private double giamgia;
        private double thanhtien;
        public int MaHD { get => maHD; set => maHD = value; }
        public string Tendouong { get => tendouong; set => tendouong = value; }
        public int Sl { get => sl; set => sl = value; }
        public double Giatien { get => giatien; set => giatien = value; }
        public double Giamgia { get => giamgia; set => giamgia = value; }
        public double Thanhtien { get => thanhtien; set => thanhtien = value; }
      
        public Chitiethoadon(int mahd, string tendou, int sl, double gia, double giam, double tt)
        {
            this.MaHD = mahd;
            this.Tendouong = tendou;
            this.Sl = sl;
            this.Giatien = gia;
            this.Giamgia = giam;
            this.Thanhtien = tt;
        }
        public Chitiethoadon(DataRow row)
        {
            this.MaHD = (int)row["mahoadon"];
            this.Tendouong = row["tendouong"].ToString();
            this.sl = (int)row["soluong"];
            this.Giatien = (double)row["giatien"];
            this.Giamgia = (double)row["tlgiamgia"];
            this.Thanhtien = (double)row["tongtien"];
        }
    }
}
