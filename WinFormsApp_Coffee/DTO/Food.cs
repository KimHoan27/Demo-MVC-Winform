using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class Food
    {
        private int madouong;
        private string tendouong;
        private int madanhmuc;
        private int trangthai;

        public int Madouong { get => madouong; set => madouong = value; }
        public string Tendouong { get => tendouong; set => tendouong = value; }
        public int Madanhmuc { get => madanhmuc; set => madanhmuc = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
        public Food(int madouong, string ten, int madanhmuc, int trangthai)
        {
            this.Madouong = madouong;
            this.Tendouong = ten;
            this.Madanhmuc = madanhmuc;
            this.Trangthai = trangthai;
        }
        public Food(DataRow row)
        {
            this.Madouong = (int)row["madouong"];
            this.Tendouong = row["tendouong"].ToString();
            this.Madanhmuc = (int)row["madanhmuc"];
            this.Trangthai = (int)row["trangthaidouong"];
        }
    }
}
