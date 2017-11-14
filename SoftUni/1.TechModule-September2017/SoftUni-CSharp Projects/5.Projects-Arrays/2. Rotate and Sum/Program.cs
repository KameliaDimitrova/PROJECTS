using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NumberArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] rotatedArr = new int[NumberArr.Length];
            int[] NewArray = new int[NumberArr.Length];
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i <= k; i++)
            { 
                for (int j = 0; j < NumberArr.Length; j++)
                {
                    if (j == 0)
                    {
                        rotatedArr[0] = NumberArr[NumberArr.Length - 1];
                    }
                    else
                    {
                        rotatedArr[j] = NumberArr[j - 1];
                    }
                }

                for (int m = 0; m < rotatedArr.Length; m++)
                {
                    NewArray[m] += rotatedArr[m];
                }
                NumberArr = rotatedArr.ToArray();
          }
            Console.WriteLine(string.Join(" ", NewArray));

        }
    }
}


    
    

