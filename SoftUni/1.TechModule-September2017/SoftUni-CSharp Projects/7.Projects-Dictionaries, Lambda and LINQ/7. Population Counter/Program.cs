using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<string, SortedDictionary<string, long>>();

            var input = Console.ReadLine()
                .Split('|')
                .ToList();
            while (input[0] != "report")
            {
                var town = input[0];
                var country = input[1];
                var pop = long.Parse(input[2]);
                if (!dictionary.ContainsKey(country))
                {
                    dictionary[country] = new SortedDictionary<string, long>();
                }
                if (!dictionary[country].ContainsKey(town))
                {
                    dictionary[country][town] = pop;
                }
                input = Console.ReadLine()
                    .Split('|')
                    .ToList();
            }

            foreach (var dic in dictionary.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                var sum = dic.Value.Values.Sum();
                Console.WriteLine($"{dic.Key} (total population: {sum})");
                foreach (var dic2 in dic.Value.OrderByDescending(y=>y.Value))
                {
                    Console.WriteLine($"=>{dic2.Key}: {dic2.Value}");
                }

            }

        }
    }
}
