$(document).ready(function () {
	function send_data() {
		var gui_di = {
			so_a: $('#txt_a').val(),
			so_b: $('#txt_b').val(),
			so_c: $('#txt_c').val()
		};

		if (isNaN(gui_di.so_a)) {
			$('#ketqua').html('Số a chưa nhập đúng!');
			$('#txt_a').focus();
			return;
		}
		if (isNaN(gui_di.so_b)) {
			$('#ketqua').html('Số b chưa nhập đún!');
			$('#txt_b').focus();
			return;
		}
		if (isNaN(gui_di.so_c)) {
			$('#ketqua').html('Số c chưa nhập đúng!');
			$('#txt_so_c').focus();
			return;
		}
		
		$.post("api.aspx", gui_di,
			function (data, status) {
				var kq = '';
				if (data.indexOf('Có lỗi') >= 0) {
					kq = "<span class='maudo'>" + data + "</span>";
				} else {
					kq = "Tổng thu nhập, áp thuế " + $('#txt_so_c').val() + "%</span> là <b class='maudo'>" + data + "</b>";
				}
				$('#ketqua').html(kq);
			});
	}


	$("#giai").click(function () {
		send_data();
	});
});