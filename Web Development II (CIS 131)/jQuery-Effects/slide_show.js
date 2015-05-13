$(document).ready(function() {
	var nextSlide = $("#slides img:first-child");
	var nextCaption;
	var nextSlideSource;
		
	// Start slide show
    timer1 = setInterval(
        function () {   
        	$("#caption").slideUp(2000, function(){$(this).hide(1000);});
        	$("#slide").slideUp(2000,
           		function () {
           	     	if (nextSlide.next().length == 0) {
						nextSlide = $("#slides img:first-child");
					}
					else {
						nextSlide = nextSlide.next();
					}
					nextSlideSource = nextSlide.attr("src");
					nextCaption = nextSlide.attr("alt");
					$("#slide").attr("src", nextSlideSource).slideDown(2000);					
					$("#caption").text(nextCaption).slideDown(2000, function(){$(this).show(1000);});
				}
			)
		}, 
		5000
	);
})