using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Problem_1___Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = decimal.Parse(Console.ReadLine());
            var capacity = decimal.Parse(Console.ReadLine());
            var heavyMiles = decimal.Parse((Console.ReadLine()));
            var nonHeavyLiters=(distance-heavyMiles)*25;
            var heavyLiters = heavyMiles * 25 * (decimal)1.5;
            var tolerance=(nonHeavyLiters+heavyLiters)*(decimal) 0.05;
            var total = tolerance + nonHeavyLiters + heavyLiters;
            if (total <= capacity)
            {
                Console.WriteLine($"Fuel needed: {total:f2}L");
                Console.WriteLine($"Enough with {(capacity-total):f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"Fuel needed: {total:f2}L");
                Console.WriteLine($"We need {(total-capacity):f2}L more fuel.");
            }

        }
    }
}
