using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINHVIEN
{
    class sinhvien
    {
        public String maSV;
        float toan;
        float ly;
        float hoa;
        //default constructor
        public sinhvien()
        {
            this.maSV = "01";
            this.toan = (float)8.5;
            this.ly = (float)9.5;
            this.hoa = (float)7.5;
        }
        //tham so hoa constructor
        public sinhvien(String maSV, float toan, float ly, float hoa)
        {
            this.maSV = maSV;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap ma sinh vien :");
            this.maSV = Console.ReadLine();
            Console.WriteLine("Nhap diem toan :");
            this.toan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly :");
            this.ly = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa");
            this.hoa = float.Parse(Console.ReadLine());
        }
        public float TB()
        {
            float tinhTB = (this.toan + this.ly + this.hoa) / 3;
            return tinhTB;
        }
        public void IN()
        {
            Console.WriteLine("Ket Qua :{0}, Toan: {1}, Ly: {2}, Hoa: {3}",this.maSV,this.toan,this.ly,this.hoa);
            Console.WriteLine("Diem trung binh la : "+TB());
            
        
        }
    }
}
