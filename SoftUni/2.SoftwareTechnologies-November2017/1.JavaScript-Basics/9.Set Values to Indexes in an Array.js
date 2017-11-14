function setValueOnIndex(args) {
    let num=args[0];
    let index = 0;
    let result={};
    let maxIndex=0;
    for (let i = 1; i < args.length; i++) {
        let currArr=args[i]
            .split(' - ');
        index = currArr[0];
        result[index] = currArr[1];
        if(index>maxIndex)
            maxIndex=index;
    }
    for (let i=0;i<num;i++) {
        if(result[i]==undefined){
            console.log(0);
        }
        else
            console.log(result[i]);
    }
}


setValueOnIndex(['3','0 - 3','0 - -1','0 - 2']);