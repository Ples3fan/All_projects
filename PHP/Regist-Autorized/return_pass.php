<?php
    require_once("config.php");
    require_once("functions.php");
?>


<?php include_once "inc/header.php"; ?>
<div id="content">
    <div id="main">
        <h1>Введите свой почтовый адресс</h1>

        <form method='POST'>
            <label>
                EMAIL<br>
                <input type='text' name='email'>
            </label><br>
            <input style="float:left" type='submit' value='Вход'>
        </form>
    </div>
    <?php include_once "inc/sidebar.php"; ?>

    <?php include_once "inc/footer.php"; ?>