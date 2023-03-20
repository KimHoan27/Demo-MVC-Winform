using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace WinFormsApp_Coffee.DTO
{
     public class Douong
     {   
        private int maDoUong;
        private string tenDoUong;
        
        private string trangThai;
        private string tendanhmuc;
        public int MaDoUong { get => maDoUong; set => maDoUong = value; }
        public string TenDoUong { get => tenDoUong; set => tenDoUong = value; }
      
        public string TrangThai { get => trangThai; set => trangThai = value; }
        
        public string Tendanhmuc { get => tendanhmuc; set => tendanhmuc = value; }

        public Douong( int madouong, string tendouong, string trangthai, string tendm)
        {          
            this.MaDoUong = madouong;
            this.TenDoUong = tendouong;
            
            this.TrangThai = trangthai;
            this.Tendanhmuc = tendanhmuc;
        }
        public Douong(DataRow row)
        {         
            this.MaDoUong = (int)row["madouong"];
            this.TenDoUong = row["tendouong"].ToString();
               
            this.TrangThai = row["trangthaidouong"].ToString();
            this.Tendanhmuc = row["tendanhmuc"].ToString();
        }
    }
}

