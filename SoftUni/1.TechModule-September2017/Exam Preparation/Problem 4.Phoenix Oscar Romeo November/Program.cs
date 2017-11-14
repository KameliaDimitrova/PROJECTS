using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputList=new List<string>();
            var collection=new Dictionary<string,HashSet<string>>();
            var result=new Dictionary<string,int>();


            while (input != "Blaze it!")
            {
                inputList = input
                    .Split(new char[] {'-', '>'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToList();
                var creature = inputList[0];
                var squard = inputList[1];

                if (!collection.ContainsKey(creature))
                {
                    collection[creature] = new HashSet<string>();
                }
                if (creature != squard)
                {
                    collection[creature].Add(squard);
                }

                input = Console.ReadLine();
            }
            var counter = 0;

            foreach (var item in collection)
            {
                foreach (var listItem in item.Value)
                {
                    if (item.Key != listItem&&!collection.ContainsKey(listItem)||!collection[listItem].Contains(item.Key))
                    {
                        counter++;
                    }
                }
                result[item.Key] = counter;
                counter = 0;
            }

            foreach (var item in result.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }






        }
        
    }
}
