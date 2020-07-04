<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calculator</title>
</head>
<body>
<form method="POST" action=''>
   a=<input TYPE="text" name="a"/><br>
   <input TYPE="radio" name="operation" checked value='+'/>+
   <input TYPE="radio" name="operation" value='-'/>-
   <input TYPE="radio" name="operation" value='*'/>*
   <input TYPE="radio" name="operation" value='/'/>/<br>  
   b=<input TYPE="text" name="b"/><br>
   <input type='submit' name='=' value='=' style='margin: 20px 20px 0 20px;'> 
   </form> 
   <?php
  $a = $_POST['a'];
  $b = $_POST['b'];
  $radio=$_POST['operation'];
  if ($_POST['='])
  {
      if ($radio=='+'){$c = $a + $b; echo "<p style='font-size: 22pt; color: red;'>" . $c."</p>".'<br>';}
      if ($radio=='-'){$d = $a - $b; echo "<p style='font-size: 22pt; color: red;'>" . $d."</p>".'<br>';}
      if ($radio=='*'){$e = $a *$b;  echo  "<p style='font-size: 22pt; color: red;'>" . $e."</p>".'<br>';}
      if ($radio=='/'){
      if($b == '0'){echo "<p style='font-size: 22pt; color: red;'>На ноль делить нельзя</p>";
      }else{
      $f = $a / $b; echo "<p style='font-size: 22pt; color: red;'>" . $f."</p>";
      }}
}
    ?> 
</body>
</html>