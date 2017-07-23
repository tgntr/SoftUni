<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if (isset($_GET['num'])) {
        $num = intval($_GET['num']);
        if ($num > 1) {
            $firstNum = 1;
            $secondNum = 1;
            echo "$firstNum $secondNum ";
            for ($i = 3; $i <= $num; $i++) {
                $save = $firstNum;
                $firstNum = $secondNum;
                $secondNum = $firstNum + $save;
                echo "$secondNum ";
            }
        }
        else {
            echo 1;
        }
    }
    ?>
</body>
</html>