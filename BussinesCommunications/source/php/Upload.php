<?php
require_once("db.php");
$mysql = $conn;
$login= $_COOKIE['login'];
$result = $mysql->query("SELECT * FROM `users` WHERE `Login`='$login'");
$user = $result->fetch_assoc();
$id= $user['Id'];
if(!is_dir('./UsersData/'.$_COOKIE['login']))
    mkdir('./UsersData/'.$_COOKIE['login']);
$docss=$_FILES["file_name"];
$normaldocs = [];
foreach($docss as $key_name => $value)
{
    foreach($value as $key => $item){
        $normaldocs[$key][$key_name]=$item;
    }
}
foreach ($normaldocs as $docs) {
    // получаем информацию о файале из ключа image
    move_uploaded_file($docs["tmp_name"],'./UsersData/'.$_COOKIE['login'].'/'.time().'_'.$docs["name"]);
    $TempPath = './UsersData/'.$_COOKIE['login'].'/'.time().'_'.$docs["name"];
    $a = date('Y-m-d');
    $name=$docs["name"];
    $link='UsersData/'.$_COOKIE['login'].'/'.time().'_'.$docs["name"];
    $mysql->query("INSERT INTO `report`(`Link_To`, `Name_Report` , `User_From`, `Send_Date`,`Status_Report`) VALUES ('$link','$name','$id','$a','Отправлено')");
    $TempHash=hash_file('sha256', $TempPath);
    $result=$mysql->query("SELECT `Id` FROM `report` WHERE `Link_To`='$link'");
    $Report = $result->fetch_assoc();
    $idReport=$Report['Id'];
    $mysql->query("INSERT INTO `HashReport`(`ReportId`, `HashReport`) VALUES ('$idReport','$TempHash')");  
}
header('Location:/Message.php');
?>