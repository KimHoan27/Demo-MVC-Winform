using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class ChiTietDotGia
    {
        private string tenDoUong;
        private int maDotGia;
        private double giaBan;

        public int MaDotGia { get => maDotGia; set => maDotGia = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public string TenDoUong { get => tenDoUong; set => tenDoUong = value; }

        public ChiTietDotGia(string tendouong, int madotgia, float giaban)
        {
            this.MaDotGia = madotgia;
            this.TenDoUong = tendouong;  
            this.GiaBan = giaban;
        }
        public ChiTietDotGia(DataRow row)
        {
            this.MaDotGia = (int)row["madotgia"];
            this.TenDoUong = row["tendouong"].ToString();
            this.GiaBan = (double)row["giaban"];
        }
    }
}
