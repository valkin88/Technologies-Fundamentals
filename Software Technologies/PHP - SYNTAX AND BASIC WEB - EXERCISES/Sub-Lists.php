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
        <?php
        if (isset($_GET['num1']) && isset($_GET['num2'])) {
            $numberOne = intval($_GET['num1']);
            $numberTwo = intval($_GET['num2']);
            ?>
    <ul>
        <?php
            for ($i = 1; $i <= $numberOne; $i++){
                ?>
        <li>
            <?php
                echo "List {$i}";
            ?>
            <ul>
                <?php
                for ($j = 1; $j <= $numberTwo; $j++){
                ?>
                <li>
                    <?php
                    echo "Element {$i}.{$j}";
                    ?>
                </li>
                <?php
                }
                ?>
            </ul>
    	</li>
        <?php
            }

        }
        ?>
	</ul>
</body>
</html>