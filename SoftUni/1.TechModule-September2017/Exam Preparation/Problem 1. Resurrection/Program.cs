using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_1.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            var years = 0.0m;
            for (int i = 0; i < amount; i++)
            {
                var bodyLen = BigInteger.Parse(Console.ReadLine());
                var bodyWidth = decimal.Parse(Console.ReadLine());
                var wingsLen = int.Parse(Console.ReadLine());
                years = (decimal)(bodyLen*bodyLen) * (bodyWidth + 2 * (wingsLen));
                Console.WriteLine(years);
            }
        }
    }
}
