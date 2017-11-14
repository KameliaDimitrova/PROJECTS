using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberInput = int.Parse(Console.ReadLine());
            var legAndAct=new Dictionary<string, long>();
            var legAndTypeAndCount=new Dictionary<string, Dictionary<string,long>>();
            for (int i = 0; i < numberInput; i++)
            {
                var input = Console.ReadLine()
                    .Split(new []{'=','-','>',':',' '},StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var activity = long.Parse(input[0]);
                var legion = input[1];
                var type = input[2];
                var count = long.Parse(input[3]);

                if (!legAndAct.ContainsKey(legion))
                {
                    legAndAct[legion] = activity;
                }
                if (activity > legAndAct[legion])
                {
                    legAndAct[legion] = activity;
                }

                if (!legAndTypeAndCount.ContainsKey(legion))
                {
                    legAndTypeAndCount[legion]=new Dictionary<string, long>();
                }
                if (!legAndTypeAndCount[legion].ContainsKey(type))
                {
                    legAndTypeAndCount[legion][type] = 0;
                }
                legAndTypeAndCount[legion][type] += count;
            }
            var command = Console.ReadLine()
                .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            if (command.Count > 1)
            {
                var maxAct = long.Parse(command[0]);
                var wantedTy = command[1];

                foreach (var currlegion in legAndTypeAndCount
                    .Where(x => x.Value.ContainsKey(wantedTy))
                    .OrderByDescending(x => x.Value[wantedTy])) //голям проблем стана тук, опитах се да сортирам с x=>x.Value.Values.Max(), но винаги даваше грешка
                        {
                            if (currlegion.Value.ContainsKey(wantedTy))
                            {
                                if (maxAct > legAndAct[currlegion.Key])
                                {
                                    Console.WriteLine($"{currlegion.Key} -> {currlegion.Value[wantedTy]}");
                                }
                            }
                        }
             }
             else if(command.Count==1)
             {
                var wantedType = command[0];
                foreach (var currlegion in legAndAct.OrderByDescending(x => x.Value))
                {
                    if (legAndTypeAndCount[currlegion.Key].ContainsKey(wantedType))
                    {
                        Console.WriteLine($"{legAndAct[currlegion.Key]} : {currlegion.Key}");
                    }
                }
            }
        }
    }
}
