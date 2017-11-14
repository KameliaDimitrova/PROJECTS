using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
           
            var action = "0";
            var index = 0;
           
            do
            {
               var command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                action = command[0];

                if (action == "add")
                {
                    numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));

                }
                else if(action=="addMany")
                {
                   for(int i=command.Length-2;i>0;i--)
                        numbers.Insert(int.Parse(command[1]), int.Parse(command[i+1]));
                }
                else if (action == "contains")
                {
                    for (int i = 0; i <numbers.Count; i++)
                    {
                        if (int.Parse(command[1]) == numbers[i])
                        {
                            Console.WriteLine(i);
                            break;
                        }
                        else if (i == numbers.Count - 1)
                        {
                            Console.WriteLine("-1");
                        }
                    }
                }
                else if(action=="remove")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (action == "shift")
                {
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if (action == "sumPairs")
                {
                    
                    if (numbers.Count % 2 == 0)
                    {
                      for (int i = 0; i < numbers.Count; i =i+2)
                      {
                          numbers[index] = numbers[i] + numbers[i + 1];
                          index++;
                        }
                      for(int i=numbers.Count-1;i>index-1;i--)
                            numbers.RemoveAt(numbers.Count-1);
                    }
                    else
                    {
                        numbers.Add(0);
                        for (int i = 0; i < numbers.Count; i = i + 2)
                        {
                            numbers[index] = numbers[i] + numbers[i + 1];
                            index++;
                        }
                        for (int i = numbers.Count - 1; i > index - 1; i--)
                            numbers.RemoveAt(numbers.Count - 1);

                    }
                }

                index = 0;
            } while (action!="print");
            Console.WriteLine("[" + ((string.Join(", ", numbers)))+ "]");
        }
    }
}
