<?php
    //не формировать заголовки после формирования тела
    setcookie('my_name', 'Daniil', time()+60*60, '/');
    setcookie('login','Bla-bla-bla', time()+60*60, '/');

    //setcookie('login','Bla-bla-bla', time()-60*60, '/'); удаление куки

    echo $_COOKIE['my_name']."<br>";
    echo $_COOKIE['login']."<br>";
?>