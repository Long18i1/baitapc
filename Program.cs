using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINHVIEN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so sinh vien :");
            n = Int32.Parse(Console.ReadLine());
            sinhvien[] sv = new sinhvien[n];
            for(int i = 0; i < n; i++)
            {
                sv[i] = new sinhvien();
                sv[i].nhap();
                sv[i].IN();
            }
            float min = sv[0].TB();
            for (int i = 1; i < n; i++)
            {
                if (sv[i].TB() < min) min = sv[i].TB();
            }
            Console.WriteLine("Sinh vien co diem thap nhat {0}", min);
            for(int i = 0; i < n; i++)
            {
                if (sv[i].maSV.Contains("IT")) ;
                Console.WriteLine("SV ma {0} co diem TB la {1}",sv[i].maSV,sv[i].TB());
            }
            for (int j = 0; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (sv[k].TB() < sv[j].TB())
                    {
                        sinhvien s = new sinhvien();
                        s = sv[j];
                        sv[j] = sv[k];
                        sv[k] = s;
                    }
                }
            }
            Console.WriteLine(" thong tin sinh vien sau khi xap sep la:");
            for (int j = 0; j < n; j++)
                Console.WriteLine("sinh vien ma {0} co diem TB la : {1}", sv[j].maSV, sv[j].TB());
            Console.ReadLine();
        }
    }
}
