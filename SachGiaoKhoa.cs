using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sach
{
    class SachGiaoKhoa : Thongtinsach
    {
        String tinhtrangsach;
        public SachGiaoKhoa() : base()
        {
            this.tinhtrangsach = "moi";
        }
        public new void nhap()
        {
            base.nhap();
            Console.WriteLine("Tinh trang cua sach:");
            this.tinhtrangsach = Console.ReadLine();
        }
        public double tinhtien()
        {
            double tt;
            if (this.tinhtrangsach == "moi")
            {
                tt = this.soluong * this.dongia;
            }
            else
            {
                tt = this.soluong * this.dongia * 0.5;
            }
            return tt;
        }
        public void In()
        {
            base.In();
            Console.WriteLine("Tong so tien la {0}:",this.tinhtien());
        }
    } 
}
