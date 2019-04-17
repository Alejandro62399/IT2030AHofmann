$(function () {

	//hide button click
	$("#hide_btn").click(function () {
		$(".hide_content").hide();
	});

	//show button click
	$("#show_btn").click(function () {
		$(".hide_content").show();
	});

	//fun button click
	$("#fun_btn").click(function () {
		$("#mainJQ").find("a").toggleClass("fun");
	});
});