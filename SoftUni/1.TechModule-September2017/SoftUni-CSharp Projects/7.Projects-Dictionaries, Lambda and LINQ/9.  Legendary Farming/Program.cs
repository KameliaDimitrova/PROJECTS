using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
      
            var collection = new Dictionary<string, int>();
            var junk =new SortedDictionary<string, int>();
            var result = "0";
            collection["shards"] = 0;
            collection["fragments"] = 0;
            collection["motes"] = 0;
      
            
                while (result == "0")
                {
                    var input = Console.ReadLine()
                        .ToLower()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                   for (int i = 1; i <= input.Count-1; i += 2)
                    {
                        if (input[i] != "shards" && input[i] != "fragments" && input[i] != "motes")
                        {
                            if (!junk.ContainsKey(input[i]))
                            {
                                junk[input[i]] = 0;
                            }
                            junk[input[i]] = junk[input[i]] + int.Parse(input[i - 1]);

                        }
                        else
                        {
                            collection[input[i]] +=int.Parse(input[i - 1]);

                            if (collection[input[i]] >= 250)
                            {
                                collection[input[i]] -= 250;
                            if (input[i] == "shards")
                                {
                                    result = "Shadowmourne obtained!";
                                    break;
                                }
                            else if (input[i] == "fragments")
                                {
                                    result = "Valanyr obtained!";
                                    break;
                                }
                            else 
                                {
                                    result = "Dragonwrath obtained!";
                                    break;
                                }
                            }
                        }

                    }
               }
            Console.WriteLine(result);
            foreach (var collect in collection.OrderByDescending(x=>x.Value).ThenBy(y=>y.Key))
            {
                Console.WriteLine($"{collect.Key}: {collect.Value}");
            }
            foreach (var junky in junk)
            {
                Console.WriteLine($"{junky.Key}: {junky.Value}");
            }
            
        }
    }
}

