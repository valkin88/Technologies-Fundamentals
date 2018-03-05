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
    if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])){
        $firstNumber = intval($_GET['num1']);
        $secondNumber = intval($_GET['num2']);
        $thirdNumber = intval($_GET['num3']);
        $myArr = [$firstNumber, $secondNumber, $thirdNumber];
        $counter = 0;
        for ($i=0; $i<3; $i++){
            if ($myArr[$i] < 0){
               $counter++;
            }
            if ($myArr[$i] == 0){
                $counter = 10;
            }
        }
        if ($counter > 3){
            echo 'Positive';
        }
        else if ($counter % 2 != 0){
            echo 'Negative';
        }else {
            echo 'Positive';
        }
    }
    ?>
</body>
</html>