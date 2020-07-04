<?php
    require_once("config.php");
    require_once("functions.php");

	
	$head = get_menu();
	
?>
<!DOCTYPE html>
<html>
<head>
<link rel="stylesheet" href="style.css">
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
<title>Тест</title>
</head>
<body>
<div id="wrap">
	<div id="header">
	<h2>Тестовый сайт</h2>
	<ul align="right">
	<? foreach ($head as $item) :?>
		<?php if($item['npos']==5)
				$_SESSION['help'] = $item['content'];
			if($item['npos']==6)
				$_SESSION['contact'] = $item['content'];				
		?>
        <li style="list-style-type: none;"><a href="<?=$item['url'];?>"><?=$item['name'];?></a></li>
    <? endforeach; ?>
	</ul>
	</div>