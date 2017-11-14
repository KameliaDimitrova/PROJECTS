using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] read = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger n = read[0];
            BigInteger number = read[1];
            BigInteger remainder;
            string result = string.Empty;
            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    remainder = number % n;
                    number /= n;
                    result = remainder.ToString() + result;
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}