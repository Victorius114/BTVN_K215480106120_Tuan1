using System;
using System.Web.UI;

namespace webABC
{
    public partial class _default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TextBox1.Text);
            double b = Convert.ToDouble(TextBox2.Text);
            double c = Convert.ToDouble(TextBox3.Text);

            double delta = b * b - 4 * a * c;
            string result;

            if (delta < 0)
            {
                result = "Phương trình vô nghiệm.";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                result = "Phương trình có nghiệm kép: x = " + x;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                result = $"Phương trình có hai nghiệm: x1 = {x1}, x2 = {x2}";
            }

            ketqua.InnerHtml = result; // Hiển thị kết quả trên trang
        }
    }
}
