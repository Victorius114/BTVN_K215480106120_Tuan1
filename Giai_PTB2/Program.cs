using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN_tuan1_K215480106120
{
    //Họ và tên: La Đức Thắng
    //Bắt đầu làm bài toán: Giải phương trình bậc 2
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta, x, x1, x2;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = int.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            if (delta > 0)
            {
                x1 = ((0 - b) - Math.Sqrt(delta)) / 2 * a;
                x2 = ((0 - b) + Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet: ");
                Console.Write(x1 + " va " + x2);
            }
            if (delta == 0)
            {
                x = (0 - b) / 2 * a;
                Console.WriteLine("Phuong trinh co nghiem kep: x1 = x2 = " + x);
            }
        }
    }
}

