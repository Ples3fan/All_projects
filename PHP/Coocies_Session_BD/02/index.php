<?php
    session_start();

    $_SESSION['my_name']='Daniil';
    $_SESSION['login'] = 'admin';

    //0
    //$_SESSION['my_name']='';
    //1
    //unset($_SESSION['my_name']);
    //2
    //session_unset();
    //3
    //session_destroy();delete file of sessions
    echo $_SESSION['my_name']."<br>";
    echo $_SESSION['login']."<br>";

    echo session_id()."<br>";
?>