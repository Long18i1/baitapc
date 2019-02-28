using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtra
{
    class Tinhtong
    {
  
        int i = 0;
        int n = 0;
        double a ,b, c;
        public void tinh()
        {
            Console.WriteLine("Nhap n =");
            this.n = Convert.ToInt32(Console.ReadLine());
        }
        public double cauA()
        {
            for (int i = 1; i <= n; i++)
            
                if (i % 2 == 0)
                    a -= i;
                else
                    a += i;

            return a;

        }
        public double cauB()
        {
            for ( i = 1; i <= n; i++)
            {
                b += i / (float)i;
            }
            return b;
            
        }
        public double cauC()
        {
            for (i = 1; i <= n; i++)
            {
                c += i;
            }
            return c;
        }

        public void inra()
        {
            Console.WriteLine(" Tong cua cau A = {0}\n Tong cua cau B = {1}\n Tong cua cau C = {2}", this.cauA(),this.cauB(),this.cauC());
        }

    }
}
