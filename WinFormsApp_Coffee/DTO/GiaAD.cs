using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    class GiaAD
    {
        private int maDotgia;
        
        private DateTime ngayBatDauAD;
        private string trangThai;
        public int MaDotgia { get => maDotgia; set => maDotgia = value; }
       
        public DateTime NgayBatDauAD { get => ngayBatDauAD; set => ngayBatDauAD = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public GiaAD(int madotgia, DateTime ngaybd, string trangthai)
        {
            this.MaDotgia = madotgia;
           
            this.NgayBatDauAD = ngaybd;
            this.TrangThai = trangthai;
        }
        public GiaAD(DataRow row)
        {
            this.MaDotgia = (int)row["madotgia"];
            
            this.NgayBatDauAD = (DateTime)row["ngaybdban"];
            this.TrangThai = row["trangthaigia"].ToString();
        }
    }
}
