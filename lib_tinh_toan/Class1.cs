using System;
using System.Collections.Generic;
using System.Text;

namespace lib_tinh_toan
{
    public class Class1
    {

        public int a, b, c;
        public double x, x1, x2;
        public double delta;
        public void tinh_nghiem()
        {
            delta = (Math.Pow(b, 2)) - 4 * a * c;
            if (delta < 0)
            {
                x = 0;
            }
            if (delta > 0)
            {
                x1 = ((0 - b) - Math.Sqrt(delta)) / 2 * a;
                x2 = ((0 - b) + Math.Sqrt(delta)) / 2 * a;
            }
            if (delta == 0)
            {
                x = (-b) / 2 * a;
            }
        }
    }
}
