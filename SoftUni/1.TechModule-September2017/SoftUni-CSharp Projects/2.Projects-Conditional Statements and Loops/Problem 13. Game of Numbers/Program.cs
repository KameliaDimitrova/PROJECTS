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
            var magicNum = int.Parse(Console.ReadLine());
            var maxFirstMagic = 0;
            var maxSecondMagic = 0;
            var combinationCounter = 0;
           
            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    if (i + j== magicNum)
                    {
                        maxFirstMagic = i;
                        maxSecondMagic = j;
                    }

                    combinationCounter++;
                }
            }
            if (maxFirstMagic != 0 && maxSecondMagic != 0)
            {
                Console.WriteLine($"Number found! {maxFirstMagic} + {maxSecondMagic} = { magicNum}");
            }
            else
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNum}");
                
            }


        }
    }
}
