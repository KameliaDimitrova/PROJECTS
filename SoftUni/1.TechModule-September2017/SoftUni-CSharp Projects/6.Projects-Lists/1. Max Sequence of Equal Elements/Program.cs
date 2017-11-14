using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var register = 1;
            var maxRegister = 0;
            var number = 0;
            for (int i = 1; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] == listOfNumbers[i - 1])
                {
                    register++;
                    if (maxRegister < register)
                    {
                        number = listOfNumbers[i];
                        maxRegister = register;
                    }
                }
                else
                {
                    register = 1;
                }
              
            }
            if (register != 1)
            {
                for (int j = 0; j < maxRegister; j++)
                {
                    Console.Write($"{number} ");
                }
            }
            else
            {
                Console.WriteLine("1");
            }
            Console.WriteLine();
        }
    }
}
