using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class Hoadon
    {
        private int maHD;
        private string tentk;
        private DateTime ngaylap;
        private string tenban;
        private string trangthaihoadon;

        public int MaHD { get => maHD; set => maHD = value; }
        public string Tentk { get => tentk; set => tentk = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Trangthaihoadon { get => trangthaihoadon; set => trangthaihoadon = value; }
        public Hoadon(int mahd, string tentk, DateTime ngay, string tenban, string trangthai)
        {
            this.MaHD = mahd;
            this.Tentk = tentk;
            this.Ngaylap = ngay;
            this.Tenban = tenban;
            this.Trangthaihoadon = trangthai;
        }
        public Hoadon(DataRow row)
        {
            this.MaHD = (int)row["mahoadon"];
            this.Tentk = row["tennv"].ToString();
            this.Ngaylap = (DateTime)row["giolap"];
            this.Tenban = row["tenban"].ToString();
            this.Trangthaihoadon = row["trangthaihoadon"].ToString();
        }
    }
}
