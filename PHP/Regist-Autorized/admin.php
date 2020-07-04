<?php
    session_start();
    require_once("config.php");
    require_once("functions.php");
    if(!check_user())
    {
        header('Location:login.php');
        exit();
    }
?>


<?php include_once "inc/header.php"; ?>
<div id="content">
    <div id="main">
        <h1>Страница админа</h1>
    </div>

    <form method='POST' action="login.php">
        <input style="margin-top:-16px;" type='submit' name="logout" value='Выход'>
    </form>
    <?php include_once "inc/sidebar.php"; ?>

    <?php include_once "inc/footer.php"; ?>