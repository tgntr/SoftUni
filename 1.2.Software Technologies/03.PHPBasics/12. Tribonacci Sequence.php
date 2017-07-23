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
        $numbers = [ 1, 1, 2];
        $currentIndex= 0;
        for ($i = 0; $i < $num; $i ++) {
            if ($i < 3) {
                echo "$numbers[$i] ";
                continue;
            }
            $currentIndex = $i - 3;
            $sum = 0;
            if ($currentIndex < 0) {
                $currentIndex = 0;
            }
            for ($y = $i - 1; $y >= $currentIndex; $y--) {
                $sum += $numbers[$y];
            }
            echo "$sum ";
            array_push($numbers, $sum);
        }
    }
    ?>
</body>
</html>