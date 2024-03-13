export default function ($) {
    'use strict';

    $('.select').niceSelect();

    $('.input-group.date').datepicker({ format: 'dd.mm.yyyy' });

    /*------------------------------------------
        = ALL ESSENTIAL FUNCTIONS
    -------------------------------------------*/

    // Toggle mobile navigation
    function toggleMobileNavigation() {
        var navbar = $('.navigation-holder');
        var openBtn = $('.navbar-header .open-btn');
        var closeBtn = $('.navigation-holder .close-navbar');
        var body = $('.page-wrapper');

        openBtn.on('click', function () {
            if (!navbar.hasClass('slideInn')) {
                navbar.addClass('slideInn');
                body.addClass('body-overlay');
            }
            return false;
        });

        closeBtn.on('click', function () {
            if (navbar.hasClass('slideInn')) {
                navbar.removeClass('slideInn');
            }
            body.removeClass('body-overlay');
            return false;
        });
    }

    toggleMobileNavigation();

    // Function for toggle class for small menu
    function toggleClassForSmallNav() {
        var windowWidth = window.innerWidth;
        var mainNav = $('#navbar > ul');

        if (windowWidth <= 991) {
            mainNav.addClass('small-nav');
        } else {
            mainNav.removeClass('small-nav');
        }
    }

    toggleClassForSmallNav();

    // Function for small menu
    function smallNavFunctionality() {
        var windowWidth = window.innerWidth;
        var mainNav = $('.navigation-holder');
        var smallNav = $('.navigation-holder > .small-nav');
        var subMenu = smallNav.find('.sub-menu');
        var megamenu = smallNav.find('.mega-menu');
        var menuItemWidthSubMenu = smallNav.find('.menu-item-has-children > a');

        if (windowWidth <= 991) {
            subMenu.hide();
            megamenu.hide();
            menuItemWidthSubMenu.on('click', function (e) {
                var $this = $(this);
                $this.siblings().slideToggle();
                e.preventDefault();
                e.stopImmediatePropagation();
            });
        } else if (windowWidth > 991) {
            mainNav.find('.sub-menu').show();
            mainNav.find('.mega-menu').show();
        }
    }

    smallNavFunctionality();

    // smooth-scrolling
    function smoothScrolling($scrollLinks, $topOffset) {
        var links = $scrollLinks;
        var topGap = $topOffset;

        links.on('click', function () {
            if (
                location.pathname.replace(/^\//, '') ===
                    this.pathname.replace(/^\//, '') &&
                location.hostname === this.hostname
            ) {
                var target = $(this.hash);
                target = target.length
                    ? target
                    : $('[name=' + this.hash.slice(1) + ']');
                if (target.length) {
                    $('html, body').animate(
                        {
                            scrollTop: target.offset().top - topGap,
                        },
                        1000,
                        'easeInOutExpo'
                    );
                    return false;
                }
            }
            return false;
        });
    }

    // Parallax background
    function bgParallax() {
        if ($('.parallax').length) {
            $('.parallax').each(function () {
                var height = $(this).position().top;
                var resize = height - $(window).scrollTop();
                var parallaxSpeed = $(this).data('speed');
                var doParallax = -(resize / parallaxSpeed);
                var positionValue = doParallax + 'px';
                var img = $(this).data('bg-image');

                $(this).css({
                    backgroundImage: 'url(' + img + ')',
                    backgroundPosition: '50%' + positionValue,
                    backgroundSize: 'cover',
                });

                if (window.innerWidth < 768) {
                    $(this).css({
                        backgroundPosition: 'center center',
                    });
                }
            });
        }
    }

    bgParallax();

    // Hero slider background setting
    function sliderBgSetting() {
        if ($('.hero-slider .slide').length) {
            $('.hero-slider .slide').each(function () {
                var $this = $(this);
                var img = $this.find('.slider-bg').attr('src');

                $this.css({
                    backgroundImage: 'url(' + img + ')',
                    backgroundSize: 'cover',
                    backgroundPosition: 'center center',
                });
            });
        }
    }

    //Setting hero slider
    function heroSlider() {
        if ($('.hero-slider').length) {
            $('.hero-slider').slick({
                autoplay: true,
                autoplaySpeed: 8000,
                arrows: true,
                prevArrow:
                    '<button type="button" class="slick-prev">Previous</button>',
                nextArrow:
                    '<button type="button" class="slick-next">Next</button>',
                dots: true,
                fade: true,
                cssEase: 'linear',
            });
        }
    }

    //Active heor slider
    heroSlider();

    function popupSaveTheDateCircle() {
        var saveTheDateCircle = $('.save-the-date');
        saveTheDateCircle.addClass('popup-save-the-date');
    }

    /*------------------------------------------
        = POST SLIDER
    -------------------------------------------*/
    if ($('.post-slider'.length)) {
        $('.post-slider').owlCarousel({
            mouseDrag: false,
            smartSpeed: 500,
            margin: 30,
            loop: true,
            nav: true,
            navText: [
                '<i class="fi ti-angle-left"></i>',
                '<i class="fi ti-angle-right"></i>',
            ],
            dots: false,
            items: 1,
        });
    }

    /*------------------------------------------
        = HIDE PRELOADER
    -------------------------------------------*/
    function preloader() {
        if ($('.preloader').length) {
            $('.preloader')
                .delay(100)
                .fadeOut(500, function () {
                    //active wow
                    wow.init();
                });
        }
    }

    /*------------------------------------------
        = WOW ANIMATION SETTING
    -------------------------------------------*/
    var wow = new WOW({
        boxClass: 'wow', // default
        animateClass: 'animated', // default
        offset: 0, // default
        mobile: true, // default
        live: true, // default
    });

    /*------------------------------------------
        = ACTIVE POPUP IMAGE
    -------------------------------------------*/
    if ($('.fancybox').length) {
        $('.fancybox').fancybox({
            openEffect: 'elastic',
            closeEffect: 'elastic',
            wrapCSS: 'project-fancybox-title-style',
        });
    }

    /*------------------------------------------
        = POPUP VIDEO
    -------------------------------------------*/
    if ($('.video-btn').length) {
        $('.video-btn').on('click', function () {
            $.fancybox({
                href: this.href,
                type: $(this).data('type'),
                title: this.title,
                helpers: {
                    title: { type: 'inside' },
                    media: {},
                },

                beforeShow: function () {
                    $('.fancybox-wrap').addClass('gallery-fancybox');
                },
            });
            return false;
        });
    }

    /*------------------------------------------
        = POPUP YOUTUBE, VIMEO, GMAPS
    -------------------------------------------*/
    $('.popup-youtube, .popup-vimeo, .popup-gmaps').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        fixedContentPos: false,
    });

    /*------------------------------------------
        = ACTIVE POPUP IMAGE
    -------------------------------------------*/
    if ($('.popup-image').length) {
        $('.popup-image').magnificPopup({
            type: 'image',
            zoom: {
                enabled: true,

                duration: 300,
                easing: 'ease-in-out',
                opener: function (openerElement) {
                    return openerElement.is('img')
                        ? openerElement
                        : openerElement.find('img');
                },
            },
        });
    }

    /*------------------------------------------
        = ACTIVE GALLERY POPUP IMAGE
    -------------------------------------------*/
    if ($('.popup-gallery').length) {
        $('.popup-gallery').magnificPopup({
            delegate: 'a',
            type: 'image',

            gallery: {
                enabled: true,
            },

            zoom: {
                enabled: true,

                duration: 300,
                easing: 'ease-in-out',
                opener: function (openerElement) {
                    return openerElement.is('img')
                        ? openerElement
                        : openerElement.find('img');
                },
            },
        });
    }

    /*------------------------------------------
        = FUNCTION FORM SORTING GALLERY
    -------------------------------------------*/
    function sortingGallery() {
        if ($('.sortable-gallery .gallery-filters').length) {
            var $container = $('.gallery-container');
            $container.isotope({
                filter: '*',
                animationOptions: {
                    duration: 750,
                    easing: 'linear',
                    queue: false,
                },
            });

            $('.gallery-filters li a').on('click', function () {
                $('.gallery-filters li .current').removeClass('current');
                $(this).addClass('current');
                var selector = $(this).attr('data-filter');
                $container.isotope({
                    filter: selector,
                    animationOptions: {
                        duration: 750,
                        easing: 'linear',
                        queue: false,
                    },
                });
                return false;
            });
        }
    }

    sortingGallery();

    /*------------------------------------------
        = MASONRY GALLERY SETTING
    -------------------------------------------*/
    function masonryGridSetting() {
        if ($('.masonry-gallery').length) {
            var $grid = $('.masonry-gallery').masonry({
                itemSelector: '.grid-item',
                columnWidth: '.grid-item',
                percentPosition: true,
            });

            $grid.imagesLoaded().progress(function () {
                $grid.masonry('layout');
            });
        }
    }

    // masonryGridSetting();

    /*------------------------------------------
        = STICKY HEADER
    -------------------------------------------*/

    // Function for clone an element for sticky menu
    function cloneNavForSticyMenu($ele, $newElmClass) {
        $ele.addClass('original')
            .clone()
            .insertAfter($ele)
            .addClass($newElmClass)
            .removeClass('original');
    }

    // clone home style 1 navigation for sticky menu
    if ($('.site-header .navigation').length) {
        cloneNavForSticyMenu($('.site-header .navigation'), 'sticky-header');
    }

    var lastScrollTop = '';

    function stickyMenu($targetMenu, $toggleClass) {
        var st = $(window).scrollTop();
        var mainMenuTop = $('.wpo-site-header .navigation');

        if ($(window).scrollTop() > 1000) {
            if (st > lastScrollTop) {
                // hide sticky menu on scroll down
                $targetMenu.removeClass($toggleClass);
            } else {
                // active sticky menu on scroll up
                $targetMenu.addClass($toggleClass);
            }
        } else {
            $targetMenu.removeClass($toggleClass);
        }

        lastScrollTop = st;
    }

    /*------------------------------------------
        = Header search toggle
    -------------------------------------------*/
    if ($('.header-search-form-wrapper').length) {
        var searchToggleBtn = $('.search-toggle-btn');
        var searchContent = $('.header-search-form');
        var body = $('body');

        searchToggleBtn.on('click', function (e) {
            searchContent.toggleClass('header-search-content-toggle');
            e.stopPropagation();
        });

        body.on('click', function () {
            searchContent.removeClass('header-search-content-toggle');
        })
            .find(searchContent)
            .on('click', function (e) {
                e.stopPropagation();
            });
    }

    /*------------------------------------------
        = Header shopping cart toggle
    -------------------------------------------*/
    if ($('.mini-cart').length) {
        var cartToggleBtn = $('.cart-toggle-btn');
        var cartContent = $('.mini-cart-content');
        var body = $('body');

        cartToggleBtn.on('click', function (e) {
            cartContent.toggleClass('mini-cart-content-toggle');
            e.stopPropagation();
        });

        body.on('click', function () {
            cartContent.removeClass('mini-cart-content-toggle');
        })
            .find(cartContent)
            .on('click', function (e) {
                e.stopPropagation();
            });
    }

    /*------------------------------------------
        = FUNFACE
    -------------------------------------------*/
    if ($('.odometer').length) {
        $('.odometer').appear();
        $(document.body).on('appear', '.odometer', function (e) {
            var odo = $('.odometer');
            odo.each(function () {
                var countNumber = $(this).attr('data-count');
                $(this).html(countNumber);
            });
        });
    }

    /*------------------------------------------
        = CONTACT FORM SUBMISSION
    -------------------------------------------*/
    if ($('#contact-form').length) {
        $('#contact-form').validate({
            rules: {
                name: {
                    required: true,
                    minlength: 2,
                },

                fname: 'required',

                lname: 'required',

                subject: 'required',

                email: 'required',

                address: 'required',
            },

            messages: {
                fname: 'Please enter your First name',
                lname: 'Please enter your Last name',
                subject: 'Please enter your Subject',
                email: 'Please enter your email address',
                address: 'Please enter your address',
            },

            submitHandler: function (form) {
                $.ajax({
                    type: 'POST',
                    url: 'mail.php',
                    data: $(form).serialize(),
                    success: function () {
                        $('#loader').hide();
                        $('#success').slideDown('slow');
                        setTimeout(function () {
                            $('#success').slideUp('slow');
                        }, 3000);
                        form.reset();
                    },
                    error: function () {
                        $('#loader').hide();
                        $('#error').slideDown('slow');
                        setTimeout(function () {
                            $('#error').slideUp('slow');
                        }, 3000);
                    },
                });
                return false; // required to block normal submit since you used ajax
            },
        });
    }

    /*------------------------------------------
        = BACK TO TOP BTN SETTING
    -------------------------------------------*/
    $('body').append(
        "<a href='#' class='back-to-top'><i class='ti-arrow-up'></i></a>"
    );

    function toggleBackToTopBtn() {
        var amountScrolled = 1000;
        if ($(window).scrollTop() > amountScrolled) {
            $('a.back-to-top').fadeIn('slow');
        } else {
            $('a.back-to-top').fadeOut('slow');
        }
    }

    $('.back-to-top').on('click', function () {
        $('html,body').animate(
            {
                scrollTop: 0,
            },
            700
        );
        return false;
    });

    /*------------------------------------------
        = TESTIMONIALS SLIDER
    -------------------------------------------*/
    if ($('.testimonial-slider'.length)) {
        $('.testimonial-slider').owlCarousel({
            mouseDrag: false,
            smartSpeed: 1500,
            margin: 30,
            autoplay: true,
            loop: true,
            nav: false,
            dots: false,
            items: 3,
            responsive: {
                0: {
                    items: 1,
                },

                650: {
                    items: 1,
                },

                768: {
                    items: 2,
                },

                992: {
                    items: 3,
                },
            },
        });
    }
    /*------------------------------------------
        destination-carousel
    -------------------------------------------*/
    if ($('.destination-carousel'.length)) {
        $('.destination-carousel').owlCarousel({
            loop: !0,
            autoplaySpeed: 3e3,
            navSpeed: 3e3,
            paginationSpeed: 3e3,
            slideSpeed: 3e3,
            smartSpeed: 3e3,
            autoplay: 3e3,
            margin: 30,
            nav: false,
            dots: !1,
            responsive: {
                0: { items: 1 },
                480: { items: 1 },
                600: { items: 2 },
                1024: { items: 2 },
                1200: { items: 3 },
            },
        });
    }
    /*------------------------------------------
        country-carousel
    -------------------------------------------*/
    if ($('.country-carousel'.length)) {
        $('.country-carousel').owlCarousel({
            loop: !0,
            autoplaySpeed: 3e3,
            navSpeed: 3e3,
            paginationSpeed: 3e3,
            slideSpeed: 3e3,
            smartSpeed: 3e3,
            autoplay: 3e3,
            margin: 30,
            nav: false,
            dots: !1,
            responsive: {
                0: { items: 1 },
                480: { items: 1 },
                600: { items: 2 },
                1024: { items: 2 },
                1200: { items: 3 },
            },
        });
    }

    /*------------------------------------------
        country-carousel
    -------------------------------------------*/
    if ($('.Room-carousel'.length)) {
        $('.Room-carousel').owlCarousel({
            loop: !0,
            autoplaySpeed: 3e3,
            navSpeed: 3e3,
            paginationSpeed: 3e3,
            slideSpeed: 3e3,
            smartSpeed: 3e3,
            autoplay: 3e3,
            margin: 30,
            nav: true,
            navText: [
                '<i class="ti-arrow-left"></i>',
                '<i class="ti-arrow-right"></i>',
            ],
            dots: !1,
            responsive: {
                0: { items: 1 },
                480: { items: 1 },
                600: { items: 2 },
                1024: { items: 2 },
                1200: { items: 3 },
            },
        });
    }

    /*==========================================================================
        WHEN DOCUMENT LOADING
    ==========================================================================*/
    $(window).on('load', function () {
        preloader();

        sliderBgSetting();

        toggleMobileNavigation();

        smallNavFunctionality();

        sortingGallery();

        smoothScrolling(
            $("#navbar > ul > li > a[href^='#']"),
            $('.site-header .navigation').innerHeight()
        );
    });

    /*==========================================================================
        WHEN WINDOW SCROLL
    ==========================================================================*/
    $(window).on('scroll', function () {
        if ($('.site-header').length) {
            stickyMenu($('.site-header .navigation'), 'sticky-on');
        }

        toggleBackToTopBtn();
    });

    /*==========================================================================
        WHEN WINDOW RESIZE
    ==========================================================================*/
    $(window).on('resize', function () {
        toggleClassForSmallNav();
        //smallNavFunctionality();

        clearTimeout($.data(this, 'resizeTimer'));
        $.data(
            this,
            'resizeTimer',
            setTimeout(function () {
                smallNavFunctionality();
            }, 200)
        );
    });
}
