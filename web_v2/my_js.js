$(document).ready(function () {
    function send_data() {
        var gui_di = {
            so_a: $('#txt_a').val(),
            so_b: $('#txt_b').val(),
            so_c: $('#txt_c').val()
        };

        // Kiểm tra các giá trị nhập vào có phải là số hay không
        if (isNaN(gui_di.so_a)) {
            $('#trave').html('Số a chưa nhập đúng!');
            $('#txt_a').focus();
            return;
        }
        if (isNaN(gui_di.so_b)) {
            $('#trave').html('Số b chưa nhập đúng!');
            $('#txt_b').focus();
            return;
        }
        if (isNaN(gui_di.so_c)) {
            $('#trave').html('Số c chưa nhập đúng!');
            $('#txt_c').focus();
            return;
        }

        // Gửi dữ liệu qua Ajax
        $.ajax({
            url: "WebForm1.aspx",  // Đảm bảo đường dẫn đúng tới file xử lý server
            type: "POST",
            data: JSON.stringify(gui_di),  // Chuyển dữ liệu thành JSON string
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                console.log(response);  // In ra console để kiểm tra

                // Kiểm tra và hiển thị kết quả
                if (response.x1 !== undefined && response.x2 !== undefined) {
                    $("#trave").text("Nghiệm của phương trình là x1: " + response.x1 + ", x2: " + response.x2);
                } else if (response.x !== undefined) {
                    $("#trave").text("Phương trình có nghiệm kép: x = " + response.x);
                } else if (response.message !== undefined) {
                    $("#trave").text(response.message);
                } else {
                    $("#trave").text("Không nhận được kết quả hợp lệ.");
                }
            },
            error: function (xhr, status, error) {
                console.log('Lỗi:', status, error);  // In ra lỗi trong console
                $("#trave").text('Có lỗi xảy ra: ' + xhr.responseText);
            }
        });
    }

    // Gọi hàm send_data() khi người dùng nhấn nút "Giải"
    $("#giai").click(function () {
        send_data();
    });
});
