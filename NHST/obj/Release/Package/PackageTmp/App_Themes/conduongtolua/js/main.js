jQuery(document).ready(function($){
    new WOW().init();
    
    function stickySide(idString, closest, offset){
        if(!$(idString).length) return;
        if(!$(closest).length)  return;
        if(!$(offset))   offset = 0;
        let winTop = $(window).scrollTop();
        let mainHeight = $(closest).height();
        let mainHeightOff = $(closest).offset().top;
        if(winTop + offset >= mainHeightOff &&  winTop + offset + $(idString).height() <= mainHeightOff + mainHeight){
            $(idString).css({
                position : 'relative',
                top : offset+winTop-mainHeightOff+'px'
            });
        } else {
        if(winTop + offset < mainHeightOff){
            $(idString).attr('style','');
        }
            if( winTop + offset + $(idString).height() > mainHeightOff + mainHeight){
                $(idString).css({
                    top: mainHeight - $(idString).height() +'px'
                });
            }
        }
    }

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
        $('body').css('overflow', 'hidden');
    });

    $('.main-menu-overlay').on('click', function(){
        $('.main-menu-btn').removeClass('active');
        $('.main-menu').removeClass('active');
        $('body').css('overflow', '');
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
		$('.scroll-top').on('click', function(){
			$('html, body').animate({ scrollTop: 0 }, 'slow');
		})
    };

    $('.news-slider').slick({
        dots: false,
        arrows: true,
        prevArrow: '<span class="main-slide-arrow prev-arrow"><i class="fa fa-caret-left" aria-hidden="true"></i></span>',
        nextArrow: '<span class="main-slide-arrow next-arrow"><i class="fa fa-caret-right" aria-hidden="true"></i></span>',
        infinite: true,
        autoplay: true,
        autoplaySpeed: 6000,
        pauseOnFocus: false,
        speed: 1000,
        slidesToShow: 3,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 769,
                settings: {
                    slidesToShow: 2,
                    dots: true,
                    arrows: false,
                }
            },
            {
                breakpoint: 501,
                settings: {
                    slidesToShow: 1,
                    dots: true,
                    arrows: false,
                }
            }, 
        ]
    });

    $('.search-intro-slider').slick({
        dots: false,
        arrows: true,
        prevArrow: '<span class="main-slide-arrow prev-arrow"><i class="fa fa-caret-left" aria-hidden="true"></i></span>',
        nextArrow: '<span class="main-slide-arrow next-arrow"><i class="fa fa-caret-right" aria-hidden="true"></i></span>',
        infinite: true,
        autoplay: true,
        autoplaySpeed: 6000,
        pauseOnFocus: false,
        speed: 1000,
        slidesToShow: 5,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 992,
                settings: {
                    slidesToShow: 4,
                    dots: true,
                    arrows: false,
                }
            },
            {
                breakpoint: 769,
                settings: {
                    slidesToShow: 3,
                    dots: true,
                    arrows: false,
                }
            },
            {
                breakpoint: 501,
                settings: {
                    slidesToShow: 2,
                    dots: true,
                    arrows: false,
                }
            },
        ]
    });
    
    $('.intro-slider').slick({
        dots: false,
        arrows: true,
        prevArrow: '<span class="main-slide-arrow prev-arrow"><i class="fa fa-caret-left" aria-hidden="true"></i></span>',
        nextArrow: '<span class="main-slide-arrow next-arrow"><i class="fa fa-caret-right" aria-hidden="true"></i></span>',
        infinite: true,
        autoplay: true,
        autoplaySpeed: 6000,
        pauseOnFocus: false,
        speed: 1000,
        slidesToShow: 3,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 769,
                settings: {
                    slidesToShow: 2,
                    dots: true,
                    arrows: false,
                }
            },
            {
                breakpoint: 501,
                settings: {
                    slidesToShow: 1,
                    dots: true,
                    arrows: false,
                }
            }, 
        ]
    });

    $('.feedback-slider-wrapper').each(function(){
        let $slider = $(this).find('.feedback-slider');
        let $sliderAppend = $(this).find('.slider-append');
        $slider.slick({
            dots: false,
            arrows: true,
            prevArrow: '<span class="main-slide-arrow prev-arrow"><i class="fa fa-caret-left" aria-hidden="true"></i></span>',
            nextArrow: '<span class="main-slide-arrow next-arrow"><i class="fa fa-caret-right" aria-hidden="true"></i></span>',
            appendArrows: $sliderAppend,
            infinite: true,
            autoplay: true,
            autoplaySpeed: 6000,
            pauseOnFocus: false,
            speed: 1000,
            slidesToShow: 1,
            slidesToScroll: 1,
        });
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

    $(window).on('load resize', function(){
        const $header = $('.header')
        $(window).scrollTop() > 0 ? $header.addClass('fixed') : $header.removeClass('fixed');
        $(window).on('scroll', function(){
            $(window).scrollTop() > 0 ? $header.addClass('fixed') : $header.removeClass('fixed');
        });
    });
});