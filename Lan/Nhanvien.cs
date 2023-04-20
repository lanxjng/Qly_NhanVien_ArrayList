using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lan
{
    class Nhanvien
    {
        public string Manv { get; set; }
        public string Hoten { get; set; }
        public float Luong { get; set; }
        public Nhanvien() { }
        public Nhanvien(string Manv, string Hoten, float Luong) {
            this.Manv = Manv;
            this.Hoten = Hoten;
            this.Luong = Luong;
        }

    }
}



