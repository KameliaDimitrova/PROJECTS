using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            var flaps = int.Parse(Console.ReadLine());
            var disflaps = decimal.Parse(Console.ReadLine());
            var restDistance = int.Parse(Console.ReadLine());
            


            var distance = (flaps / 1000) * disflaps;
            var flapsTime = flaps / 100;
            var restTime = (flaps / restDistance)*5;

            var allTime = flapsTime + restTime;
            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{allTime} s.");

        }
    }
}
