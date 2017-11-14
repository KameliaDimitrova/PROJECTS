using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            var sum = 0;
            var combinationCounter = 0;
            for (int i = firstNum; i >= 1; i--)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    sum = sum + 3 * (i * j);
                    combinationCounter++;
                    if (sum >= maxSum)
                    {

                        Console.WriteLine($"{combinationCounter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        break;
                    }
                }
                if (sum > maxSum)
                {
              
                    break;
                }
                
              
            }
            if(sum<maxSum)
            {

                Console.WriteLine($"{combinationCounter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }

            }
    }
}
