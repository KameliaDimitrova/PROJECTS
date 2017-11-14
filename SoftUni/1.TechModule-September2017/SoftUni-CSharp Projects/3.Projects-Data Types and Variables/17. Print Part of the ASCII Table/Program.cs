using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFrom = int.Parse(Console.ReadLine());
            int numberTo = int.Parse(Console.ReadLine());


            for (int i = numberFrom; i <= numberTo; i++)
            {
                Console.Write((char)i+ " ");
            }
            Console.WriteLine();

        }
    }
}
