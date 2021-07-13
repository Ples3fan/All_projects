<?php

define("HOST","127.0.0.1");
define("USER","root");
define("PASSWORD","");
define("DB","parser_db");



$db = mysqli_connect(HOST,USER,PASSWORD);
if (!$db) {
  exit('WRONG CONNECTION');
}
if(!mysqli_select_db($db, DB)) {
  exit(DB);
}

mysqli_set_charset($db, "utf8") or die('Не установлена кодировка!');
?>