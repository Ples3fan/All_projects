$(function(){
    $('.commento:contains("admin")').css({backgroundColor: 'black', color: 'white'});
    $('.commento strong:contains("admin")').css({backgroundColor: 'black', color: 'white'});
    $('.on').nextAll().hide();
    $('.text').hide();
    $('h3').click(function(){
        $(this).next('.text').show();
        $(this).next().next().show();
        $(this).hide(); 
    })
    $('div.im').hide();
    $('button').click(function () {
        if ($(this).text().indexOf("Открыть") > -1) $(this).html('Закрыть &#9650').prev().slideToggle(300);
        else $(this).html('Открыть &#9660').prev().slideToggle(300);
    })
});
