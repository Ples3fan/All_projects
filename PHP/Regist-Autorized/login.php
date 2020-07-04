<?php
    session_start();
    require_once("config.php");
    require_once("functions.php");

    if(isset($_POST['btn_login']))
    {
        unset($_SESSION['msg']);
	
		//авторизацию
		$msg = login($_POST);
		
		if ($msg === true)
		{
			header("Location:admin.php");
			exit();
		} else
		{
			$_SESSION['msg'] = $msg;
			/* header("Location:{$_SERVER['PHP_SELF']}");
			exit(); */
		}
        
    }
    if(isset($_POST['logout']))
    {
        //exit from userpage
        $msg = logout();
        if($msg === true)
        {
            $_SESSION['msg'] = 'Your exit from system';
            header('Location:'.$_SERVER['PHP_SELF']);
            exit();
        }
    }
?>


<?php include_once "inc/header.php"; ?>
<div id="content">
    <div id="main">
        <h1>Авторизируйтесь</h1>
        <?= $_SESSION['msg'] ?>
        <form method='POST'>
            <label>
                login<br>
                <input type='text' name='login'>
            </label><br>
            Password<br>
            <label>
                <input type='password' name='password'>
            </label><br>
            <label>Remember me
                <input type="checkbox" name='member' value="1">
            </label><br>
            <input style="float:left" name='btn_login' type='submit' value='Вход'>
        </form>

        <form method='POST'>
            <input style="margin-top:-16px;" type='submit' name="loguot" value='Выход'>
        </form>
        <p>
            <a href="registration.php">Регистрация</a> | <a href="return_pass.php">Забыли пароль?</a>
        </p>
    </div>
    <?php include_once "inc/sidebar.php"; ?>

    <?php include_once "inc/footer.php"; ?>
    <? unset($_SESSION['msg']) ?>