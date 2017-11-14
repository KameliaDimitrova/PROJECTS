function inputLine(text) {
   let index=0;
    let currText=text[index];
    while(currText!="Stop")
    {
        console.log(currText)
        index++;
        currText=text[index];
    }
}
inputLine(['fdskjfdsk','fgdgfd','Stop'])