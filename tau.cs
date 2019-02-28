using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doantau
{
    class tau
    {
        string madoantau;
        int soluongkhach;
        
        public void doan()
        {
            Console.WriteLine("Nhap ma doan tau :");
            this.madoantau = Console.ReadLine();
            Console.WriteLine("Nhap so luong khach hang :");
            this.soluongkhach = Convert.ToInt32(Console.ReadLine());
        }
        public double tinhtien()
        {
            double tt;
            if (this.soluongkhach < 100)
                tt = (this.soluongkhach * 100000);
            else tt = (this.soluongkhach * 80000);
            return tt;
        }
        public void Inmadoantau()
        {
            Console.WriteLine("ma doan tau {0} co tong tien la {1}", this.soluongkhach, this.tinhtien());
        }

    }
}
