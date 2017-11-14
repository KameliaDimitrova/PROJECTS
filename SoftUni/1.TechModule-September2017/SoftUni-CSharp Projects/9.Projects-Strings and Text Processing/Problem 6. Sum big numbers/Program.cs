using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_6.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = BigInteger.Parse(Console.ReadLine());
            var b = BigInteger.Parse(Console.ReadLine());
            var sum = a + b;
            Console.WriteLine(sum);

        }
    }
}
