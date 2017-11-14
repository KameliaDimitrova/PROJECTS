function devideAndMultiply(nums) {
    let N=Number(nums[0]);
    let X=Number(nums[1]);
    if(X>=N)
    {
        console.log(X*N);
    }
    else if(X!=0)
    {
        console.log(N/X);
    }

}
devideAndMultiply(['5','0'])