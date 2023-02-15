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
        $(this).addClass('active');
        $('.main-menu').addClass('active');
    });

    $('.main-menu-overlay').on('click', function(){
        $('.main-menu-btn').removeClass('active');
        $('.main-menu').removeClass('active');
    });

    $(".acc-info-btn").on('click', function(e){
        e.preventDefault();
		$(".status-mobile").addClass("open");
		$(".overlay-status-mobile").show();
    });
    
	$(".overlay-status-mobile").on('click', function(){
		$(".status-mobile").removeClass("open");
		$(this).hide();
    });

    // if($('.banner-slider').length){
    //     $('.banner-slider').slick({
    //         dots: false,
    //         arrows: false,
    //         prevArrow: '<span class="prev-arrow"><i class="fa fa-angle-left" aria-hidden="true"></i></span>',
    //         nextArrow: '<span class="next-arrow"><i class="fa fa-angle-right" aria-hidden="true"></i></span>',
    //         infinite: true,
    //         autoplay: true,
    //         autoplaySpeed: 6000,
    //         pauseOnFocus: false,
    //         speed: 1000,
    //         slidesToShow: 1,
    //         slidesToScroll: 1,
    //     });
    // }

    if ($('.scroll-top').length) {
		$(window).scroll(function() {
			$(this).scrollTop() > 100 ? $('.scroll-top').addClass('show') : $('.scroll-top').removeClass('show');
		});
		$('.scroll-top').on('click', function(){
			$('html, body').animate({ scrollTop: 0 }, 'slow');
		})
    };

    $('.main-menu-nav .dropdown > a').append('<i class="fa fa-angle-down" aria-hidden="true"></i>');
    $(window).on('load resize', function(){
        if (window.matchMedia("(min-width: 992px)").matches) {
            $('.main-menu-nav .dropdown').hover(
                function() {
                    $(this).find('> .sub-menu-wrap').stop().slideDown('fast');
                }, function() {
                    $(this).find('> .sub-menu-wrap').stop().slideUp('fast');
                }
            );
        }
        else{
            $('.main-menu-nav .dropdown > a > .fa').on('click', function(e){
                e.preventDefault();
                $(this).closest('.dropdown').find('> .sub-menu-wrap').stop().slideToggle();
                $(this).hasClass('fa-angle-down') ? $(this).removeClass('fa-angle-down').addClass('fa-angle-up') : $(this).removeClass('fa-angle-up').addClass('fa-angle-down')
            });
        }
    });

    if($('.header').length){
        let $header = $('.header');
        $(window).scrollTop() > 0 ? $header.addClass('fixed') : $header.removeClass('fixed');
        $(window).on('scroll', function(){
            $(window).scrollTop() > 0 ? $header.addClass('fixed') : $header.removeClass('fixed');
        })
    };
});