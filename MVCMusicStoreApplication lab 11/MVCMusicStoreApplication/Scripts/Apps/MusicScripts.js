﻿function searchFailed() {
	$("searchresults").html("Sorrym there was a problem with the search.");
}

$function() {
	$(".RemoveLink").click{
		function () {
			var id = $(this).attr("data-id");
			$.post("/ShoppingCart/RemoveFromCart", id, function (data) {
				$("#update-message").text(data.Message);
				$("#cart-total").text(data.CartTotal);
				$("#item-count-" + data.DeleteId).text(data.ItemCount);


				if (data.ItemCount < 1) {
					$"#record-" + data.DeleteId
				} fade.Out();
			}
	}):
	})
});
