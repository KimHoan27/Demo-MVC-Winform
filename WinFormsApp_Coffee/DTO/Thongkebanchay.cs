using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class Thongkebanchay
    {
        private string tendouong;
        private int soluong;
        private double tong;
        private string tendm;

        public string Tendouong { get => tendouong; set => tendouong = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Tong { get => tong; set => tong = value; }
        public string Tendm { get => tendm; set => tendm = value; }

        public Thongkebanchay(string tendu, int sl, double tong, string tendm)
        {
            this.Tendouong = tendu;
            this.Soluong = sl;
            this.Tong = tong;
            this.Tendm = tendm;
        }
        public Thongkebanchay(DataRow row)
        {
            this.Tendouong = row["tendouong"].ToString();
            this.Soluong = (int)row["soluong"];
            this.Tong = (double)row["tong"];
            this.Tendm = row["tendanhmuc"].ToString();
        }
    }
}
