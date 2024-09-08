using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_toan_dung_dll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GIAI PHUONG TRINH BAC 2");
            int a, b, c;
            double x, x1, x2, delta;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = int.Parse(Console.ReadLine());
            delta = (Math.Pow(b, 2)) - 4 * a * c;

            lib_tinh_toan.Class1 nghiem;
            nghiem = new lib_tinh_toan.Class1();
            nghiem.a = a;
            nghiem.b = b;
            nghiem.c = c;
            nghiem.tinh_nghiem();

            if (nghiem.delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }

            if (nghiem.delta > 0)
            {
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet " + nghiem.x1 + " va " + nghiem.x2);
            }    

            if (nghiem.delta == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep " + nghiem.x);
            }    
        }
    }
}
