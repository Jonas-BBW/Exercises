<?php
if (stristr(htmlentities($_SERVER['PHP_SELF']), "dbcon.php")){
	header("Location: ../index.php");
	exit();
}
define("HOST", "localhost");
define("USER", "root");
define("PASSWORD", "");
define("DATABASE", "datenbank");
$con_this = new mysqli(HOST, USER, PASSWORD, DATABASE);
?>