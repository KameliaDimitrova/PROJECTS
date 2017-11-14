function keyValuePairs(args) {
    let result={};
    for(let i=0;i<args.length-1;i++)
    {
        let currArg=args[i].split(' ');
        var wanted=args[args.length-1];
        let currKey=currArg[0];
        let currValue=currArg[1];
        result[currKey]= currValue;
    }


    if(wanted in result)
    {
        console.log(result[wanted]);
    }
    else
        console.log("None")

}

keyValuePairs(['key value','key eulav','test tset','key']);