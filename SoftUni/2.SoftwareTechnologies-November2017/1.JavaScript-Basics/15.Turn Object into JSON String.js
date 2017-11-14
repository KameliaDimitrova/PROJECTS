function turnIntoJSON(args) {
    let obj = {};
    let values=args.forEach((p=> {
        let [key, value] = p.split(' -> ');
        if (Number.isInteger(Number(value)))
            value = Number(value);
        obj[key] = value;
    }));
    console.log(JSON.stringify(obj));
}

turnIntoJSON(['name -> Angel', 'surname -> Georgiev', 'age -> 20', 'grade -> 6.00','date -> 23/05/1995','town -> Sofia']);
