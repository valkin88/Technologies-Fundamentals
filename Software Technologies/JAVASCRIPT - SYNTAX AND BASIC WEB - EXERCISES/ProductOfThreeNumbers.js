function isNegativOrPositive(nums) {
    let counter = 0;
    for (let numberX of nums) {
        if (Number(numberX) < 0){
            counter++;
        }
    }
    if (counter == 1 || counter == 3){
        return "Negative";
    }else{
        return "Positive";
    }
}