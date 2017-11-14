using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            ReverseTheNumberOrder(input);
        }

            static void ReverseTheNumberOrder(string input)
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    Console.Write(input[i]);
                }
                Console.WriteLine();
            }


        
    }
}
