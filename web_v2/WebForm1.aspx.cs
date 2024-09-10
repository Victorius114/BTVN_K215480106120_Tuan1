using lib_tinh_toan;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_v2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                try
                {
                    // Đọc dữ liệu từ body của request
                    string jsonString = new System.IO.StreamReader(Request.InputStream).ReadToEnd();
                    var data = JsonConvert.DeserializeObject<Dictionary<string, double>>(jsonString);

                    // Tạo đối tượng Class1 và gán giá trị a, b, c
                    Class1 equation = new Class1();
                    equation.a = (int)data["so_a"];
                    equation.b = (int)data["so_b"];
                    equation.c = (int)data["so_c"];

                    // Gọi phương thức tinh_nghiem() để tính nghiệm
                    equation.tinh_nghiem();

                    // Kiểm tra và xử lý kết quả dựa trên giá trị của delta
                    object result;
                    if (equation.delta > 0)
                    {
                        result = new
                        {
                            x1 = equation.x1,
                            x2 = equation.x2
                        };
                    }
                    else if (equation.delta == 0)
                    {
                        result = new
                        {
                            x = equation.x
                        };
                    }
                    else
                    {
                        result = new
                        {
                            message = "Phương trình vô nghiệm"
                        };
                    }

                    Response.ContentType = "application/json";
                    Response.Write(JsonConvert.SerializeObject(result));
                }
                catch (Exception ex)
                {
                    Response.ContentType = "application/json";
                    Response.Write(JsonConvert.SerializeObject(new { error = ex.Message }));
                }
            }
        }
    }
}