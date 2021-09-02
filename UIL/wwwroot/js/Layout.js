$(window).scroll(function () {
    var height = $(window).scrollTop();
    if (height > 1) {
        $('header').addClass('border-bottom');
    } else {
        $('header').removeClass('border-bottom');
    }
});