using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_sum_v2
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //code c# để nhận dữ liệu POST gửi lên
            int ok = 0;
            try
            {
                int a, b, c;
                a = int.Parse(this.Request["so_a"]);
                ok = 1;
                b = int.Parse(this.Request["so_b"]);
                ok = 2;
                c = int.Parse(this.Request["so_c"]);
                ok = 3;

                lib_tinh_toan.Class1 nghiem;         //khai báo đối tượng
                nghiem = new lib_tinh_toan.Class1();  //cấp phát đối tượng
                nghiem.a = a;                 //gán input cho đối tượng
                nghiem.b = b;                 //gán input cho đối tượng
                nghiem.c = c;
                nghiem.tinh_nghiem();           //gọi 1 method of đối tượng

                string kq = "";
                //kq.InnerHtml = $"Tổng thu nhập, áp <span title = \"Thuế VAT={nghiem.thue * 100}%\">thuế {nghiem.thue * 100}%</span> là <b class='maudo'>{nghiem.sum}</b>";
                //string kq = $"Tổng thu nhập, áp <span title = \"Thuế VAT={nghiem.thue * 100}%\">thuế {nghiem.thue * 100}%</span> là <b class='maudo'>{nghiem.sum}</b>";
                //trả về 217 bytes, vẫn to,  cần bé hơn
                if (nghiem.delta < 0)
                {

                    kq = $"Phương trình vô nghiệm";
                }

                if (nghiem.delta > 0)
                {
                    kq = $"Phương trình có 2 nghiệm phân biệt: " + $"{nghiem.x1}" + " và " + $"{nghiem.x2}";
                }

                if (nghiem.delta == 0)
                {
                    kq = $"Phương trình có nghiệm kép: " + $"{nghiem.x}";
                }
                this.Response.Write(kq);
            }
            catch (Exception ex)
            {
                string kq;
                if (ok == 0)
                {
                    kq = $"Có lỗi khi nhập số a";
                }
                else if (ok == 1)
                {
                    kq = $"Có lỗi khi nhập số b";
                }
                else if (ok == 2)
                {
                    kq = $"Có lỗi khi nhập số c";
                }
                else
                {
                    kq = $"Có lỗi gì đó: " + ex.Message;
                }
                this.Response.Write(kq);
            }
        }
    }
}