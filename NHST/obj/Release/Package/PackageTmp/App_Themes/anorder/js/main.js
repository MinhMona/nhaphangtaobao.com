$(function() {
	//Smooth Scrolling
	$(".scroll").on("click", function(event) {
		if (this.hash !== "") {
			event.preventDefault();
			var hash = this.hash;
			$("html, body").animate(
				{
					scrollTop: $(hash).offset().top
				},
				"slow",
				"linear",
				function() {
					window.location.hash = hash;
				}
			);
		}
	});

	// Fixed menu on scroll
	var header = $(".main-header");
	var main = $("#main");
	if($("#header").length >=  1){
		var sticky = header.offset().top;
		$(window).scroll(function(){
			if($(this).scrollTop() > sticky){
				header.addClass("fixed");
				main.css("margin-top", header.height());
			}
			else{
				header.removeClass("fixed");
				main.css("margin-top", 0);
			}
		});
	}

	// Show scroll top btn on scroll
	if ("#scroll-top".length >= 1) {
		var scrollTopBtn = $("#scroll-top");
		$(window).scroll(function() {
			$(this).scrollTop() > 200
				? scrollTopBtn.addClass("show")
				: scrollTopBtn.removeClass("show");
		});
		scrollTopBtn.click(function(){
			$("html, body").animate({ scrollTop: 0 }, "slow");
		})
	}
});

$(function(){
	$(".tabs-main").each(function(){
		var tabs = $(this);
		tabs.find(".tab-nav li").first().addClass("current");
		tabs.find(".tab-content").first().addClass("current");
		tabs.find(".tab-nav li").click(function(){
			var tab_id = $(this).attr('data-tab');
			tabs.find(".tab-nav li").removeClass("current");
			tabs.find(".tab-content").removeClass("current");
			$(this).addClass('current');
			tabs.find(tab_id).addClass('current');
		})
	})
})
$(function () {
    $(".tabs-main1").each(function () {
        var tabs = $(this);
        tabs.find(".tab-nav li").first().addClass("current");
        tabs.find(".tab-nav li").first().addClass("current");
        
        tabs.find(".tab-content").first().addClass("current");
        tabs.find(".tab-nav li").click(function () {
            var tab_id = $(this).attr('data-tab');
            tabs.find(".tab-nav li").removeClass("current");
            tabs.find(".tab-content").removeClass("current");
            tabs.find(".tab-nav li").find(".indicator").removeClass("btn");
            $(this).addClass('current');
            tabs.find(tab_id).addClass('current');
            $(this).find(".indicator").addClass("btn");
        })
    })
})
$(function(){
	$(".acc-info-btn").click(function(){
		$(".status-mobile").addClass("open");
		$(".overlay-status-mobile").show();
		return false;
	})
	$(".overlay-status-mobile").click(function(){
		$(".status-mobile").removeClass("open");
		$(this).hide();
	})
	$(".mobile-menu-btn").click(function(){
		$(this).addClass("active")
		$(".main-menu").addClass("open");
	})
	$(".main-menu").click(function(){
		$(".mobile-menu-btn").removeClass("active");
		$(this).removeClass("open");
	})
})