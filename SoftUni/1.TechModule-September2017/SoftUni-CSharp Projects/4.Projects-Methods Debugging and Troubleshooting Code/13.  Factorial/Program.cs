using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintFactorielOfNumber(Number));

        }
        static BigInteger PrintFactorielOfNumber(int n)
        {
            BigInteger CurrentSum = 1;
            for (int i = 1; i <= n; i++)
                CurrentSum= CurrentSum * i;

            return CurrentSum;
        }
    }
}
