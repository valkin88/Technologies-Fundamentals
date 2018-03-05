function printingKeys(args) {
    let newDict = {};
    for (let i = 0; i < args.length - 1; i++){
        let arr = args[i].split(' ');
        let keyOfDict = arr[0];
        let valueOfDict = arr[1];
        if (!newDict.hasOwnProperty(keyOfDict)){
            newDict[keyOfDict] = [valueOfDict];
        }else{
            newDict[keyOfDict].push(valueOfDict);
        }

    }
        if (newDict.hasOwnProperty([args[args.length - 1]]))
        {
        for (let value of newDict[args[args.length - 1]]) {
            console.log(value);
        }
    }else{
        console.log("None");
    }
}