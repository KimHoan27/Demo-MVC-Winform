using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class Bill
    {
        private int maHD;
        private int maTK;
        private DateTime? giolap;
        private int maBan;
        private int trangThai;
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaTK { get => maTK; set => maTK = value; }
        public DateTime? Giolap { get => giolap; set => giolap = value; }
        public int MaBan { get => maBan; set => maBan = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public Bill(int mahd, int matk, DateTime? giolap, int maban, int TT)
        {
            this.MaHD = mahd;
            this.MaTK = matk;
            this.Giolap = giolap;
            this.MaBan = maban;
            this.TrangThai = TT;
        }
        public Bill(DataRow row)
        {
            this.MaHD = (int)row["mahoadon"];
            this.MaTK = (int)row["mataikhoan"];
            this.Giolap = (DateTime?)row["giolap"];
            this.MaBan = (int)row["maban"];
            this.TrangThai = (int)row["trangthaihoadon"];
        }
    }
}
