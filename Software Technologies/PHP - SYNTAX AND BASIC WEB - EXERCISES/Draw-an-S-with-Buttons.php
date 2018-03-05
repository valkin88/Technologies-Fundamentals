<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php
   $buttonOne  = 1;
   $buttonZero = 0;

   linesOfOnes($buttonOne);
   firstHalfOfFigure($buttonOne, $buttonZero);
   linesOfOnes($buttonOne);
   secondHalfOfFigure($buttonOne, $buttonZero);
   linesOfOnes($buttonOne);


?>

<?php
function linesOfOnes(&$buttonOne){
for ($i = 0; $i < 5; $i++) {
    if ($i == 4) {
        echo "<button style='background-color: blue'>{$buttonOne}</button><br>";
    } else {
        echo "<button style='background-color: blue'>{$buttonOne}</button>";
    }
}
}
?>

<?php
function firstHalfOfFigure(&$buttonOne, &$buttonZero){
for ($i = 0; $i < 3; $i++){
        for ($j = 0; $j < 5; $j++){
            if ($j == 0){
                echo "<button style='background-color: blue'>{$buttonOne}</button>";
            }else if ($j < 4){
                echo "<button>{$buttonZero}</button>";
            }else {
                echo "<button>{$buttonZero}</button><br>";
            }
        }
    }
}
?>

<?php
function secondHalfOfFigure(&$buttonOne, &$buttonZero){
for ($i = 0; $i < 3; $i++){
        for ($j = 0; $j < 5; $j++){
            if ($j == 4){
                echo "<button style='background-color: blue'>{$buttonOne}</button><br>";
            }else {
                echo "<button>{$buttonZero}</button>";
            }
        }
    }
}
?>
</body>
</html>