<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num1" />
        M: <input type="text" name="num2" />
        <input type="submit" />
    </form>
	<ul>
        <?php
        if (isset($_GET['num1']) && isset($_GET['num2'])) :
            $num1 = intval($_GET['num1']);
            $num2 = intvaL($_GET['num2']);?>
            <ul>
                <?php for ($i = 1; $i <= $num1; $i ++) : ?>
                    <li><?="List $i"?>
                    <ul>
                    <?php for ($y = 1; $y <= $num2; $y ++) : ?>
                        <li><?="    Element $i.$y"?></li>
                    <?php endfor;?>
                    </ul>
                    </li>
                <?php endfor;?>
            </ul>
        <?php endif;?>
    </ul>
</body>
</html>