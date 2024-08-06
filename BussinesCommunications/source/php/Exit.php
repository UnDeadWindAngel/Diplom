<?php
    setcookie("login", "guest",time() + 3600*24,"/");
    header('Location:/');
?>