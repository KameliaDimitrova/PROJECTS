using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var power = BigInteger.Parse(Console.ReadLine());
            var range = int.Parse(Console.ReadLine());
            var factor = int.Parse(Console.ReadLine());
            var oldPower = power;
            var counter = 0;
            if (power - range < 0)
            {
                Console.WriteLine(power);
                Console.WriteLine(0);
            }

            while (power-range >=0)
            {
                power = power - range;
                if (power == oldPower/2)
                {
                    if (factor != 0)
                    {
                        power = power / factor;
                    }
                }

                counter++;
            }
            Console.WriteLine(power);
            Console.WriteLine(counter);

        }
    }
}
