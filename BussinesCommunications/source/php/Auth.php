<?php
    $login= $_POST['login2'];
    $pass = $_POST['password'];
    require_once("db.php");
    $captcha=$_POST['captcha'];
    $capthcarandom = $_POST['captcha-rand'];
    if($captcha!=$capthcarandom)
    { 
        ?>
        <script type="text/javascript">
          alert("Введен неверный код");
        </script>
        <?php
        header('Location:/');
    }
    else{
        if(mb_strlen($login)<5||mb_strlen($login)>60)
        {
            echo"Недопустимая длина логина";
            require_once("Exit.php");
        }
        else if(mb_strlen($pass)<5||mb_strlen($pass)>32)
        {
            echo"Недопустимая длина пароля";
            require_once("Exit.php");
        }
        else {
            $mysql = $conn;
            $result = $mysql->query("SELECT * FROM `users` WHERE `Login`='$login' AND `Password` = '$pass'");
            $user = $result->fetch_assoc();
            if(count($user)==0){
                echo "Такой пользователь не существует";
                require_once("Exit.php");
            }
            else{
                setcookie("login", $user["Login"],time() + 3600*24,"/");
                $IdUser=$user['Id'];
                $mysql->query("INSERT INTO `Logiong`(`IdUser`, `TypePlatform`) VALUES ('$IdUser','Web')");
                $mysql->close();
                header('Location:/News.php');
            }
        }
    }
?>