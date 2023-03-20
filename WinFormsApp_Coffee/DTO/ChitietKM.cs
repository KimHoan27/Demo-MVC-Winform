using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
     public class ChitietKM
    {
        private string tendotkm;
        private string tendouong;
        private double tlgiamgia;

        public string Tendotkm { get => tendotkm; set => tendotkm = value; }
        public string Tendouong { get => tendouong; set => tendouong = value; }
        public double Tlgiamgia { get => tlgiamgia; set => tlgiamgia = value; }
        public ChitietKM(string tendot, string tendouong, double tyle)
        {
            this.Tendotkm = tendot;
            this.Tendouong = tendouong;
            this.Tlgiamgia = tyle;
        }
        public ChitietKM(DataRow row)
        {
            this.Tendotkm = row["tendotkm"].ToString();
            this.Tendouong = row["tendouong"].ToString();
            this.Tlgiamgia = (double)row["tilegiamgia"];
        }
    }
}
