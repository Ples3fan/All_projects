<?php
    require_once("config.php");
    require_once("functions.php");

    if(isset($_GET['hash']))
    {
        $msg = confirm();
        if($msg === true)
        {
            $msg = "Your account activated!!";
        }
    }
    else
    {
        $msg = "Wrong link!";
    }
?>


<?php include_once "inc/header.php"; ?>
<div id="content">
    <div id="main">
            <?= $msg ?>
    </div>
<?php include_once "inc/sidebar.php"; ?>

<?php include_once "inc/footer.php"; ?>
