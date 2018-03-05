function MultiplyOrDivideANumber(nums) {
    let numberOne = Number(nums[0]);
    let numberTwo = Number(nums[1]);
    if (numberOne <= numberTwo){
    return numberOne * numberTwo;
    }
    else{
        let divide = numberOne / numberTwo;
        return numberOne / numberTwo;
    }
}
