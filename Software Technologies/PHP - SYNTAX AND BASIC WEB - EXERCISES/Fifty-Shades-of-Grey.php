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
        drawShadesOfGrey(0, 50);
        drawShadesOfGrey(51, 100);
        drawShadesOfGrey(102, 150);
        drawShadesOfGrey(153, 200);
        drawShadesOfGrey(204, 250);
        ?>
        <?php
function drawShadesOfGrey($shadeOfGrey, $lastIndex){

    for ($grey = $shadeOfGrey; $grey < $lastIndex; $grey += 5){
        $color = "rgb($grey, $grey, $grey)";
        echo "<div style='background-color: {$color}'></div>";
    }
    echo "<br>";
}
?>
</body>
</html>