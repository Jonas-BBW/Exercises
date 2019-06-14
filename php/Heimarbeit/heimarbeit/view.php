<?php
include("include/dbcon.php");

?>
<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" type="text/css" href="css/main.css"/>    
    <title>Titel</title>
    <meta name="description" content="Beschreibung">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/main.css">
    <script type='text/javascript' src='https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js'></script>
    <script type='text/javascript' src="js/jquery-3.4.1.js"></script>
    <script src="js/popper.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/scripts.js"></script>
</head>
<body>
    <main>
    <a href='index.php'><button class="btn btn-info" style="margin-left:10px; margin-top:10px;">Zurück zur Eingabe</button></a>
    <br><br>
<div class="row">
<?php    
$rollen_sql = " SELECT * FROM rollen order by id ASC";
$rollen_res = mysqli_query($con_this, $rollen_sql) or die(mysqli_error($con_this));
while(list($id, $name, $datum, $ort, $rolle, $img) = mysqli_fetch_row($rollen_res)){
    echo "<div class='col-sm-4'>";
    echo "<div class='card' style='width: 18rem;'>";
    echo "<img class='card-img-top' src='$img' alt='Card image cap'>";
    echo "<div class='card-body'>";
    echo "<h5 class='card-title'>$name</h5>";



    echo "<p class='card-text'>Datum: ".datum2deu($datum)."<br>Ort: $ort <br>Rolle: $rolle</p>";
    //echo "<a href='#' class='btn btn-primary'>Go somewhere</a>";
    echo "</div>";
    echo "</div>";
    echo "</div>";
}

function datum2deu($datum){
    $datumx = explode("-", $datum);
    $deuDatum = $datumx['2'].".".$datumx['1'].".".$datumx['0'];
    return $deuDatum;
}

?>
</div>
<br><br>
    <a href='index.php'><button class="btn btn-info" style="margin-left:10px;">Zurück zur Eingabe</button></a>
    </main>
    <footer>
    </footer>
</body>
</html>