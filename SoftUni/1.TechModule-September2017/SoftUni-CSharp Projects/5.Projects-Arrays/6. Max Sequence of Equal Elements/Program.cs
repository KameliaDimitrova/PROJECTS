using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var Numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
           
            var counter = 1;
            var keeperOfMaxCounter = 1;
            var number = 0;
            var numberKeeper = 0;
  
            for (int i = 1; i < Numbers.Length; i++)
            {
                if (Numbers[i] == Numbers[i - 1])
                {
                    counter++;
                    number = Numbers[i];
                    if (Numbers[i] == Numbers[Numbers.Length - 1])
                    {
                        if (counter > keeperOfMaxCounter)
                        {
                            keeperOfMaxCounter = counter;
                            numberKeeper = number;

                        }
                    }
                }
                else
                {
                    if (counter > keeperOfMaxCounter)
                    {
                        keeperOfMaxCounter = counter;
                        numberKeeper = number;
                        
                    }
                    counter = 1;
                }
            }
            for (int j = 0; j < keeperOfMaxCounter; j++)
            {
                Console.Write($"{numberKeeper} ");
            }
            Console.WriteLine();




        }
    }
}
