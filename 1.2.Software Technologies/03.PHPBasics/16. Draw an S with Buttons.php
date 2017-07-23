<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php
for ($i = 1; $i <= 9; $i ++) {
    for ($y = 1; $y <= 5; $y++) {
        if (($i == 1 || $i == 5 || $i == 9)) {
            echo "<button style=\"background-color:blue\">1</button>";
        }
        else if($i < 5 && $y == 1) {
            echo "<button style=\"background-color:blue\">1</button>";

        }
        else if($i > 5 && $y == 5) {
            echo "<button style=\"background-color:blue\">1</button>";

        }
        else {
            echo "<button>0</button>";

        }
    }
    echo "<br>";
}
?>
</body>
</html>