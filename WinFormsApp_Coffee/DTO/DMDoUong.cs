using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class DMDoUong
    {
        private int maDanhMuc;
        private string tenDanhMuc;

        public int MaDanhMuc { get => maDanhMuc; set => maDanhMuc = value; }
        public string TenDanhMuc { get => tenDanhMuc; set => tenDanhMuc = value; }

        public DMDoUong(int madanhmuc, string tendanhmuc)
        {
            this.maDanhMuc = madanhmuc;
            this.tenDanhMuc = tendanhmuc;
            
        }
        public DMDoUong(DataRow row)
        {
            this.MaDanhMuc = (int)row["madanhmuc"];
            this.TenDanhMuc = row["tendanhmuc"].ToString();
        }
    }
}
