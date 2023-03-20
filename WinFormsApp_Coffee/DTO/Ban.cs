using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class Ban
    {   //Ctrl+R+E
        private int maBan;
        private string tenBan;
        private int soGhe;
        private DateTime ngayBatDauSD;
        private string trangThai;

        public int MaBan { get => maBan; set => maBan = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public int SoGhe { get => soGhe; set => soGhe = value; }
        public DateTime NgayBatDauSD { get => ngayBatDauSD; set => ngayBatDauSD = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public Ban(int maban, string tenban, int soghe ,DateTime ngaybd, string trangthai)
        {
            this.MaBan = maban;
            this.TenBan = tenban;
            this.SoGhe = soghe;
            this.NgayBatDauSD = ngaybd;
            this.TrangThai = trangthai;         
        }
        public Ban(DataRow row)
        {
            this.MaBan = (int)row["maban"];
            this.TenBan = row["tenban"].ToString();           
            this.SoGhe = (Int32)row["soghe"];
            this.NgayBatDauSD = (DateTime)row["ngaybdsudung"];
            this.TrangThai = row["trangthaiban"].ToString();
        }

    }
}
