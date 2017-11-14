using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int difference = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                for (int j = 0; j <= numbers.Length - 1; j++)
                {
                    if (numbers[i] - numbers[j] == difference)
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine(count);
        }
    }
}
    

