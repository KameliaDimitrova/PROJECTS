function storingObject(args) {
    let persons=[];
    for(let i=0;i<args.length;i++) {
        let separated = args[i]
            .split('->')
            .filter(x=>x.trim());



        persons.push({
            name: separated[0],
            age: Number(separated[1]),
            grade: (separated[2])
        });

    }
  for(let key of persons){

      console.log(`Name: ${key.name}`)
      console.log(`Age: ${key.age}`)
      console.log(`Grade:${key.grade}`)
  }

}

storingObject(['Pesho -> 13 -> 6.00','Ivan -> 12 -> 5.57','Toni -> 13 -> 4.90']);