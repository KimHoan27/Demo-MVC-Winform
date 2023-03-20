using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class BillInfo
    {
        private int mahoadon;
        private int madouong;
        private int soluong;
        private double giatien;
        private double tlgiamgia;
        private double tongtien;
        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public int Madouong { get => madouong; set => madouong = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Giatien { get => giatien; set => giatien = value; }
        public double Tlgiamgia { get => tlgiamgia; set => tlgiamgia = value; }
        public double Tongtien { get => tongtien; set => tongtien = value; }
        public BillInfo(int mahoadon, int madouong, int sl, double gia, double tl, double tong)
        {
            this.Mahoadon = mahoadon;
            this.Madouong = madouong;
            this.Soluong = sl;
            this.Giatien = gia;
            this.Tlgiamgia = tl;
            this.Tongtien = tong;
        }
        public BillInfo(DataRow row)
        {
            this.Mahoadon = (int)row["mahoadon"];
            this.Madouong = (int)row["madouong"];
            this.Soluong = (int)row["soluong"];
            this.Giatien = (double)row["giatien"];
            this.Tlgiamgia = (double)row["tlgiamgia"];
            this.Tongtien = (double)row["tongtien"];
        }
    }
}
