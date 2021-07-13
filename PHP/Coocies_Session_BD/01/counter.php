<?php
    isset($_COOKIE['counter'])
    ? 
    setcookie('counter', ++$_COOKIE['counter'], time()+60*60*24, '/')
    :
    setcookie('counter',1, time()+60*60*24,'/');

    echo isset($_COOKIE['counter']) ? $_COOKIE['counter'] : 1;
?>