function addRemoveElements(args) {
    let finalArr = [];
    for(let command of args) {
        let newArr = command.split(' ');
        let action = newArr[0];
        let number = Number(newArr[1]);
        if (action === "add"){
            finalArr.push(number);
        }
        if (action === "remove"){
            finalArr.splice(number, 1);
        }
    }
    for (let obj of finalArr) {
        console.log(obj);
    }
}
