function commandAddOrDelete(args) {
    let result=[];
    for(let i=0;i<args.length;i++)
    {
        let currArg=args[i].split(' ');
        let command=currArg[0];
        let num=Number(currArg[1])

        if(command=="add")
        {
            result.push(num);
        }
        if(command=="remove")
        {
          if(result[num]!=undefined)
            result.splice(num,1)
        }
    }
    for (let i=0;i<result.length;i++)
    {
        console.log(result[i]);
    }
}

commandAddOrDelete(['add 3','add 5','add 7']);