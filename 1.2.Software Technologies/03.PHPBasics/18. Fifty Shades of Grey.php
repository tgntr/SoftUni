<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style> 
</head>
<body>
<?php
for ($i = 0; $i<=255; $i+=51) {
    for ($y = 0; $y < 50; $y += 5) {
        $rgb=$i+$y;
        echo "<div style=\"background-color: rgb($rgb,$rgb,$rgb)\"></div>";
    }
    echo "<br>";
}
?>
</body>
</html>