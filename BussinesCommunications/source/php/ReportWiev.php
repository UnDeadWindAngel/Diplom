<?php
include("db.php");
$login= $_COOKIE['login'];
$mysql = $conn;
$result = $mysql->query("SELECT `Id` FROM `users` WHERE `Login`='$login'");
$user = $result->fetch_assoc();
$id = $user['Id'];
$result2 = $mysql -> query("SELECT * FROM `report` LEFT JOIN `users` ON `report`.`Signeded_User`=`users`.`Id` WHERE `User_From` = '$id'");
$i=1;
    while($apl = $result2 -> fetch_assoc())
    {
        if($apl["First_Name"]!= null){
        $imias =  mb_substr($apl["Second_Name"], 0, 1,'UTF-8').'.';
        $otchestvos =  mb_substr($apl["Third_Name"], 0, 1,'UTF-8').'.';
        }
        else
        {
            $imias =  "";
            $otchestvos =""; 
        }
        echo '
        <tr id="tabl1" class="string'.$i.'">
        <th scope="row">'.$i.'</th>
        <td>'.$apl["Name_Report"].'</td>
        <td>'.$login.'</td>
        <td>'.$apl["First_Name"].' '.$imias.''.$otchestvos.'</td>
        <td>'.$apl["Send_Date"].'</td>
        <td>'.$apl["Date_Signed"].'</td>
        <td>'.$apl["Status_Report"].'</td>
        <td>'.$apl["Rejection_Reason"].'</td>
        </tr>';
        $i++;
    }
$mysql->close();
?>