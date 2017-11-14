using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int sumOfLeftSide = 0;
            int sumOfRigthSide = 0;
            bool isExist = false;
            if (numbers.Length <= 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sumOfLeftSide = sumOfLeftSide + numbers[j];
                    }
                    for (int k = i + 1; k < numbers.Length; k++)
                    {
                        sumOfRigthSide = sumOfRigthSide + numbers[k];
                    }
                    if (sumOfRigthSide == sumOfLeftSide)
                    {
                        Console.WriteLine(i);
                        isExist = true;
                    }


                    sumOfRigthSide = 0;
                    sumOfLeftSide = 0;
                }
                if (isExist != true)
                {
                    Console.WriteLine("no");
                }
            }


        }
        
    }
}
