	$(function () {
	    var links = ["url('bg/bg0.gif')", "url('bg/bg1.jpg')", "url('bg/bg2.gif')", "url('bg/bg3.jpg')", "url('bg/bg4.gif')", "url('bg/bg5.gif')", "url('bg/bg6.gif')"];
	    var headers = ['О сайте ', 'Бизнес', 'Искусство', 'Живопись', 'Дизайн', 'Творчество', 'История']

	    $('.bg').each(function (ind, elem) {
	        $(elem).css('background-image', links[ind]);
	    });
	    $('.bg a').each(function (ind, elem) {
	        $(elem).append(headers[ind]);
	    });
	    $('.bg').hover(function () {
	        $(this).stop().animate({
	            width: 120,
	            height: 120
	        }, 500);
	    }, function () {
	        $(this).stop().animate({
	            width: 100,
	            height: 100
	        }, 500);
	    })
	    $('body').on('click', '.xxx', function () {
	            $(this).closest('.st').hide(600,);
	    })
	});
