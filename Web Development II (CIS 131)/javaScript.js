$(function() {
	$("#expander h3").toggle(
		function() {
			$(this).toggleClass("minus");
		    $(this).next().show();
	    },
	    function() {
	        $(this).toggleClass("minus");
	        $(this).next().hide();
	    }
    ); // end toggle
});
