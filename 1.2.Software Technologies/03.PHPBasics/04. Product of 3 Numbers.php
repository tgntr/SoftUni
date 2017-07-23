<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        X: <input type="text" name="num1" />
		Y: <input type="text" name="num2" />
        Z: <input type="text" name="num3" />
		<input type="submit" />
    </form>
    <?php
    if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
        $num1 =
        $numbers = [intval($_GET['num1']), intval($_GET['num2']), intval($_GET['num3'])];
        $negativeCount = 0;
        foreach($numbers as $num) {
            if ($num < 0) {
                $negativeCount ++;
            }
            else if ($num == 0) {
                echo "Positive";
                return;
            }
        }
        if ($negativeCount % 2 == 0) {
            echo "Positive";
        }
        else {
            echo "Negative";
        }
    }
    ?>
</body>
</html>