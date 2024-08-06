<?php
require_once("db.php");
$mysql = $conn;
$IdOP = $_POST['IdOp'];
$IdUser = $_POST['IdUser'];
$UrlReport = $_POST['UrlReport'];
$result = $mysql->query("SELECT * FROM `users` WHERE `Id`='$IdUser'");
$user = $result->fetch_assoc();
$login= $user['Login'];
$pieces = explode("/", $UrlReport);
if(!is_dir('./UsersData/'.$login))
    mkdir('./UsersData/'.$login);
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
    move_uploaded_file($docs["tmp_name"],'./UsersData/'.$login.'/'.$pieces[2]);
    $a = date('Y-m-d');
    $name=$docs["name"];
    $mysql->query("UPDATE `report` SET `Signeded_User`='$IdOP',`Date_Signed`='$a',`Rejection_Reason`='' WHERE `User_From`='$IdUser' AND `Link_To`='$UrlReport'");    
}
header('Location:/OK.php');
?>