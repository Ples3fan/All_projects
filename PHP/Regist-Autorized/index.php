<?php
    session_start();
    require_once("config.php");
    require_once("functions.php");

    $posts = get_statti();
?>


<?php include_once "inc/header.php"; ?>
<div id="content">
    <div id="main">
        <? foreach ($posts as $item) :?>
        <h1 id="title"><?=$item['title'];?></h1>
        <p><?=$item['date'];?></p>
        <p><img align="left" src="<?=$item['img_src'];?>"><?=$item['discription'];?></p>
        <? endforeach; ?>
    </div>
    <?php include_once "inc/sidebar.php"; ?>

    <?php include_once "inc/footer.php"; ?>