using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double x, x1, x2, delta;
            a = int.Parse(A.Text);
            b = int.Parse(B.Text);
            c = int.Parse(C.Text);
            delta = Math.Pow(b, 2) - 4 * a * c;

            lib_tinh_toan.Class1 nghiem;
            nghiem = new lib_tinh_toan.Class1();
            nghiem.a = a;
            nghiem.b = b;
            nghiem.c = c;
            nghiem.tinh_nghiem();

            if (nghiem.delta < 0)
            {
                kq.Text = "Phương trình vô nghiệm";
            }

            if (nghiem.delta > 0)
            {
                kq.Text = "Phương trình có 2 nghiệm phân biệt " + nghiem.x1 + " và " + nghiem.x2;
            }

            if (nghiem.delta == 0)
            {
                kq.Text = "Phương trình có nghiệm kép " + nghiem.x;
            }
        }
    }
}
