using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_4.NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var listInput=new List<string>();
            var collection=new Dictionary<string,Dictionary<string,int>>();
            var pattern = @"^[A-Za-z0-9]+\s->\s[A-Za-z0-9]+\s->\s[0-9]+$";
            var regex=new Regex(pattern);

            while (input != "quit")
            {
                if (regex.IsMatch(input))
                {
                    listInput = input
                        .Split(new char[] {'-', '>'}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToList();
                    var country = listInput[0];
                    var spy = listInput[1];
                    var days = int.Parse(listInput[2]);

                    if (!collection.ContainsKey(country))
                    {
                        collection[country] = new Dictionary<string, int>();
                    }
                    if (!collection[country].ContainsKey(spy))
                    {
                        collection[country][spy] = 0;
                    }
                    collection[country][spy] = days;
                }
                input = Console.ReadLine();
            }
            foreach (var country in collection.OrderByDescending(x=>x.Value.Keys.Count))
            {
                Console.WriteLine($"Country: {country.Key}");
                foreach (var spy in country.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }

        }
    }
}
