using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var Numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var count = 1;
            var maxCount = 0;
            var mostFreq = 0;
            
                for (int i = 0; i < Numbers.Length; i++)
                {
                    for (int j = i; j < Numbers.Length; j++)
                    {
                        if (Numbers[j] == Numbers[i])
                        {
                            count++;
                        }
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        mostFreq = Numbers[i];
                    }
                    count = 1;
                }
                Console.WriteLine(mostFreq);
        }
    }
}
