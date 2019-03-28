using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sach
{
    class Thongtinsach
    {
        String masach;
        String ngaynhap;
        public double dongia;
        public int soluong;
        public Thongtinsach()
        {
            this.masach = "AC197";
            this.ngaynhap = "28/03/2019";
            this.dongia = 50;
            this.soluong = 10;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap ma sach:");
            this.masach = Console.ReadLine();
            Console.WriteLine("Ngay nhap sach:");
            this.ngaynhap = Console.ReadLine();
            Console.WriteLine("Nhap don gia sach:");
            this.dongia = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong sach:");
            this.soluong = Int32.Parse(Console.ReadLine());
        }
        public void In()
        {
            Console.WriteLine("Ma sach sach: {0}\nNgay Nhap sach: {1}\nDon Gia sach: {2}\nSo Luong sach: {3} ", this.masach, this.ngaynhap, this.dongia, this.soluong);
        }
    }
}
