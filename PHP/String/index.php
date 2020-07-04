<?php
    //Работа с регистром символов
    $a = 'php';
    echo 'До: '.$a.' После: '.strtoupper($a);
    echo '<br>';
    $a = 'PHP';
    echo 'До: '.$a.' После: '.strtolower($a);
    echo '<br>';
    $a = 'london';
    echo 'До: '.$a.' После: '.ucfirst($a);
    echo '<br>';
    $a = 'London';
    echo 'До: '.$a.' После: '.lcfirst($a);
    echo '<br>';
    $a = 'london is the capital of great britain';
    echo 'До: '.$a.' После: '. mb_convert_case($a, MB_CASE_TITLE);
    echo '<br>';
    $a = 'LONDON';
    echo 'До: '.$a.' После: '.mb_convert_case($a, MB_CASE_TITLE);
    echo '<br>';
    echo '<br>';
    //Работа с strlen
    $b = 'html css php';
    echo 'Длинна строки: '.$b.' = '.strlen($b).' символов';
    echo '<br>';
    echo '<br>';
    //Работа с substr
    $b = 'html css php';
    $b1 = explode(" ",$b);
    foreach ($b1 as $item) {
        echo $item.'<br>';
    }
    $b = 'manual';
    echo 'До: '.$b.' После: '.substr($b, -3);
    echo '<br>';
    $b = 'http://worldbyte.com';
    $b1 = 'http://';
    if (substr($b, 0, 7)==$b1) {
        echo 'Да!';
    }
    else
        echo 'Нет!';
    echo '<br>';
    if (substr($b, 0, 7)=='http://' || substr($b, 0, 8)=='https://') {
        echo 'Да!';
    }
    else
        echo 'Нет!';
    echo '<br>';
    $b = 'Clown.png';
    if (substr($b, -4)=='.png') {
        echo 'Да!';
    }
    else
        echo 'Нет!';
    echo '<br>';
    if (substr($b, -4)=='.png' || substr($b, -4)=='.jpg') {
        echo 'Да!';
    }
    else
        echo 'Нет!';
    echo '<br>';
    $b = 'Intermediate';
    if (strlen($b)>5) {
        echo substr($b, 0, 5).'...';
    }
    else
        echo $b;
        echo '<br>';
        echo '<br>';
    //Работа с str_replace
    $c = '31.12.2013';
    echo str_replace('.', '-', $c);
    echo '<br>';
    $str = 'aambrostacca';
    $str1 = str_replace('a','1',$str);
    $str2 = str_replace('b','2',$str1);
    $str3 = str_replace('c','3', $str2);
    echo 'До: '.$str.' После: '.$str3;
    echo '<br>';
    $c = '1a2b3c4b5d6e7f8g9h0';
    $num = array('1','2','3','4','5','6','7','8','9','0');
    echo 'До: '.$c.' После: '.str_replace($num, '', $c);
    echo '<br>';
    echo '<br>';
    //Работа с strtr
    $str = 'aambrostacca';
    $tmp = array('a'=>'1','b'=>'2','c'=>'3');
    echo 'До: '.$str.' После: '.strtr($str, $tmp);
    echo '<br>';
    echo '<br>';
    //Работа с substr_replace
    $str = 'liqud more';
    echo 'До: '.$str.' После: '.substr_replace($str, '!!!', 3, 8);
    echo '<br>';
    echo '<br>';
    //Работа с strpos, strrpos
    $str =  'abc abc abc';
    echo strpos($str, 'b');
    echo '<br>';
    echo strrpos($str, 'b');
    echo '<br>';
    echo strpos($str, 'b', 3);
    echo '<br>';
    $str = 'aaa aaa aaa aaa aaa';
    echo strpos($str, ' ', 4);
    echo '<br>';
    echo '<br>';
    //Работа с explode, implode
    $b = 'html css php';
    $b1 = explode(" ",$b);
    foreach ($b1 as $item) {
        echo $item.'<br>';
    }
    $b2 = implode(',',$b1);
    echo $b2;
    echo '<br>';
    $date = '2013-12-31';
    $date1 = explode('-',$date);
    $tmp = array($date1[2],$date1[1],$date1[0]);
    $date2 = implode('.',$tmp);
    echo $date2;
    echo '<br>';
    echo '<br>';
    //Работа с str_split
    $str = '1234567890';
    $str1 = str_split($str, 2);
    print_r($str1);
    echo '<br>';
    $str1 = str_split($str);
    print_r($str1);
    echo '<br>';
    $str1 = str_split($str, 2);
    $str2 = implode('-',$str1);
    echo $str2;
    echo '<br>';
    echo '<br>';
    //Работа с trim, ltrim, rtrim
    $str = 'Hello PHP              ';
    echo 'До: '.$str.' После: '.rtrim($str);
    echo '<br>';
    $str = '/php/';
    echo 'До: '.$str.' После: '.trim($str, '/');
    echo '<br>';
    echo '<br>';
    //Работа с strrev
    $str = '12345';
    echo 'До: '.$str.' После: '.strrev($str);
    echo '<br>';
    $str = 'level';
    if($str==strrev($str)){
        echo 'Yes it polindrom';
    } 
    else 
        echo 'No is not polindrom';
        echo '<br>';
        echo '<br>';
    //Работа с str_shuffle
    $str = 'qwerty';
    echo 'До: '.$str.' После: '.str_shuffle($str);
    echo '<br>';
    echo '<br>';
    //Работа с number_format
    $str = '12345678';
    echo 'До: '.$str.' После: '.number_format($str, 3, ' ', ' ');
    echo '<br>';
    echo '<br>';
    //Работа с str_repeat
    $str = 'X';
    for($i=1;$i<=9;$i++){
        echo str_repeat($str, $i);
        echo '<br>';
    }
    for($i=1;$i<=9;$i++){
        echo str_repeat($i, $i);
        echo '<br>';
    }
    echo '<br>';
    //Работа с strip_tags и htmlspecialchars
    $str = 'html, <b>php</b>, js';
    echo 'До: '.$str.' После: '.strip_tags($str);
    echo '<br>';
    
    echo 'До: '.$str.' После: '.strip_tags($input, '<b>', '<i>');
    echo '<br>';


    





?>