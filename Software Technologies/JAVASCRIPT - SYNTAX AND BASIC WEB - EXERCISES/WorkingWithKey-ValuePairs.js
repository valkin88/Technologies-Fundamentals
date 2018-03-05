function printingKeys(args) {
    let newDict = {};
    for (let i = 0; i < args.length - 1; i++){
        let arr = args[i].split(' ');
        let keyOfDict = arr[0];
        let valueOfDict = arr[1];
        newDict[keyOfDict] = valueOfDict;

    }
    if (newDict.hasOwnProperty(args[args.length - 1])){
        console.log(newDict[args[args.length - 1]]);
    }else{
        console.log("None");
    }
}
