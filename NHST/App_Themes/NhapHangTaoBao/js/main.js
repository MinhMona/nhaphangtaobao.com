jQuery(document).ready(function($){
    new WOW().init();

    $('.tab-wrapper').each(function() {
        let $tabWrapper, $tabID;
		$tabWrapper = $(this);
		$tabID = $tabWrapper.find('.tab-link.current').attr('data-tab');
        $tabWrapper.find($tabID).fadeIn().siblings().hide();
        $($tabWrapper).on('click', '.tab-link', function(e){
            e.preventDefault();
			$tabID = $(this).attr('data-tab');
			$(this).addClass('current').siblings().removeClass('current');
			$tabWrapper.find($tabID).fadeIn().siblings().hide();
        });
    });

    $('.main-menu-btn').on('click', function(){
        $(this).toggleClass('active');
        $('.main-menu').toggleClass('active');
    });

    $('.main-menu-overlay').on('click', function(){
        $('.main-menu-btn').removeClass('active');
        $('.main-menu').removeClass('active');
    });

    $(".acc-info-btn").on('click', function(e){
        e.preventDefault();
		$(".status-mobile").addClass("open");
        $(".overlay-status-mobile").show();
        $('body').css('overflow', 'hidden');
    });
    
	$(".overlay-status-mobile").on('click', function(){
		$(".status-mobile").removeClass("open");
        $(this).hide();
        $('body').css('overflow', '');
    });

    if ($('.scroll-top').length) {
		$(window).scroll(function() {
			$(this).scrollTop() > 100 ? $('.scroll-top').addClass('show') : $('.scroll-top').removeClass('show');
		});
    };
    
    $('.scroll-top').on('click', function(){
        $('html, body').animate({ scrollTop: 0 }, 'slow');
    });
    
    $('.main-menu-nav .dropdown > a').append('<i class="fa fa-angle-down" aria-hidden="true"></i>');
    $('.main-menu-nav .dropdown > a > .fa').on('click', function(e){
        e.preventDefault();
        $(this).closest('.dropdown').find('> .sub-menu-wrap').stop().slideToggle();
    });

    $('.faqs-item.active').find('.faqs-content').show();
    $('.faqs-title').on('click', function(){
        $(this).closest('.faqs-item').toggleClass('active');
        $(this).siblings('.faqs-content').stop().slideToggle();
    });

    $(window).on('load', function(){
        let $header = $('.main-header');
        let $height = $header.outerHeight();
        let $offset = $header.offset().top;
        let $main = $('.main');
        if($(window).scrollTop() > $offset + $height){
            $header.addClass('fixed');
            $main.css('margin-top', $height);
        }
        else{
            $header.removeClass('fixed');
            $main.css('margin-top', '');
        }
        $(window).on('scroll', function(){
            if($(window).scrollTop() > $offset + $height){
                $header.addClass('fixed');
                $main.css('margin-top', $height);
            }
            else{
                $header.removeClass('fixed');
                $main.css('margin-top', '');
            }
        });
    });
});