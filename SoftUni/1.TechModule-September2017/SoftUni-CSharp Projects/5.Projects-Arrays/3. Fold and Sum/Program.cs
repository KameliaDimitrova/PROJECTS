using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var k = items.Length / 4;
            var keeperRigthSide = 0;
            var keeperMiddle = 0;
            var kHoldings = 2 * k;
            int[] middleArray = new int[kHoldings];
            int [] leftSide= new int[kHoldings/2];
            int[] rightSide = new int[kHoldings/2];
            int[] mergedSides=new int[kHoldings];
            int []sum=new int[kHoldings];


            for (int i = 0; i < items.Length; i++)
            {
                if (i < k)
                {
                    leftSide[i] = items[i];
                }
                else if (i >= 3 * k)
                {
                    rightSide[keeperRigthSide] = items[i];
                    keeperRigthSide++;
                }
                else
                {
                    middleArray[keeperMiddle] = items[i];
                    keeperMiddle++;
                }

            }

            Array.Reverse(leftSide);
            Array.Reverse(rightSide);
            mergedSides = leftSide.Union(rightSide).ToArray();
         

            for (int j = 0; j < kHoldings; j++)
            {
                sum[j] = mergedSides[j] + middleArray[j];
            }

            Console.WriteLine(String.Join(" ", sum));


        }
    }
}
