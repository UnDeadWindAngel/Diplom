<?php
$login= $_COOKIE['login'];
require_once("db.php");
$mysql = $conn;
$result = $mysql->query("SELECT * FROM `users` WHERE `Login`='$login'");
$user = $result->fetch_assoc();
$_SESSION['id']= $user['Id'];
$_SESSION['login']= $user['Login'];
$_SESSION['FirstName']= $user['First_Name'];
$_SESSION['SecondName']= $user['Second_Name'];
$_SESSION['ThirdName']= $user['Third_Name'];
$mysql->close();
?>