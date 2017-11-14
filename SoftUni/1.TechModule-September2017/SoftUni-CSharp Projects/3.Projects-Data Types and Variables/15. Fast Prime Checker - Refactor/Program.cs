using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 2; i <= number; i++)
            {
                counter = 0;
                for (int j = 2; j <= i; j++)
                {
                    if(i%j==0)
                    counter++;
                }
                if (counter > 1)
                    Console.WriteLine($"{i} -> False");
                else
                    Console.WriteLine(($"{i} -> True"));
            }

        }
    }
}
