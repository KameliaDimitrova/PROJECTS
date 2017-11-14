using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] {'-', '>'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();
            var collection = new Dictionary<string, Dictionary<string, List<int>>>();
            var name = input[0];
   
            var specialIndex = 0;
            var helperList=new List<string>();

            while (name != "wubbalubbadubdub")
            {
               if(input.Count!=1)
                {
                    var evolution = input[1];
                    var index = int.Parse(input[2]);
                    
                    if (!collection.ContainsKey(name))
                    {
                        collection[name] = new Dictionary<string, List<int>>();
                    }
                    if (!collection[name].ContainsKey(evolution))
                    {
                        collection[name][evolution] = new List<int>();

                    }
                    collection[name][evolution].Insert(specialIndex,index);
                    helperList.Add(name);
                    helperList.Add(evolution);
                    helperList.Add(index.ToString());

                    //collection[name][evolution].Sort();
                    //collection[name][evolution].Reverse();


                }
               else if(collection.ContainsKey(name)&&input.Count==1)
               {
                   Console.WriteLine($"# {name}");
                    for (int i = 0; i < helperList.Count; i = i + 3)
                   {
                       if (helperList[i] == name)
                       {
                           Console.WriteLine($"{helperList[i+1]} <-> {helperList[i + 2]}");
                       }
                   }
                }
                input = Console.ReadLine()
                    .Split(new char[] {'-', '>'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToList();
                
                name = input[0];
              
            }
            foreach (var element in collection)
            {
                Console.WriteLine($"# {element.Key}");
               
                foreach (var evol in element.Value.OrderByDescending(x=>x.Value[0]))
                {
                    evol.Value.Sort();
                    evol.Value.Reverse();
                  for (int i = 0; i < evol.Value.Count; i  ++)
                        {
                            Console.WriteLine($"{evol.Key} <-> {evol.Value[i]}");
                        }
                    
                 
                }
            }
        }

    }
    
}
