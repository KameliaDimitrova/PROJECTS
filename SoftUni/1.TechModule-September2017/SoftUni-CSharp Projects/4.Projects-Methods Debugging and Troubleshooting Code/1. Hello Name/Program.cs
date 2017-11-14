using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string YourName = Console.ReadLine();
            PrintHelloYourName(YourName);
        }

            static void PrintHelloYourName(string Name)
            {
            Console.WriteLine($"Hello, {Name}!");
            }
        
    }
}
