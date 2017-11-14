function productOf3Nums(nums){
    let firstNum=Number(nums[0]);
    let secondNum=Number(nums[1]);
    let thirdNum=Number(nums[2]);
    let counter=0;
    if(firstNum<0)
        counter++;
    if(secondNum<0)
        counter++;
    if(thirdNum<0)
        counter++;
    if(firstNum===0||secondNum===0||thirdNum===0||counter%2===0)
        console.log("Positive")
    else if(counter%2!=0)
        console.log("Negative");
}
productOf3Nums(['1','-1','2'])