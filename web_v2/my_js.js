$(document).ready(function () {
	function send_data() {
		var gui_di = {
			so_a: $('#a').val(),
			so_b: $('#b').val(),
			so_c: $('#c').val()
		};

		if (isNaN(gui_di.so_a)) {
			$('#kq').html('Chưa nhập số a');
			$('#a').focus();
			return;
		}
		if (isNaN(gui_di.so_b)) {
			$('#kq').html('Chưa nhập số b');
			$('#b').focus();
			return;
		}
		if (isNaN(gui_di.so_c)) {
			$('#kq').html('Chưa nhập số c');
			$('#c').focus();
			return;
		}

		//code gửi POST ở đây
		$.post("api.aspx", gui_di,
			function (data, status) {
				//alert("Data: " + data + "\nStatus: " + status);
				var kq = '';
				if (data.indexOf('Có lỗi') >= 0) {
					//có lỗi thật
					kq = "<span class='maudo'>" + data + "</span>";
				} else {
					kq = "Tổng thu nhập, áp thuế " + $('#c').val() + "%</span> là <b class='maudo'>" + data + "</b>";
				}
				$('#kq').html(kq);
			});
	}

	//khi bấm nút gửi thì gửi dữ liệu lên
	$("#giai").click(function () {
		send_data();
	});
});