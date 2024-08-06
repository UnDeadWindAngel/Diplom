<?php
$servername ="www.db4free.net";
$username = "undeadwindangel";
$password = "Bravo930804";
$dbname ="undeadwindbd";

$conn = mysqli_connect($servername,$username,$password,$dbname);
if(!$conn){
    die("Connection failed" . mysqli_connect_error());
}
?>