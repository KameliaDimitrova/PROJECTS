using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var exchanged = 0;
            Console.WriteLine($"Before: \n a = {a} \n b = {b}");
            exchanged = b;
            b = a;
            Console.WriteLine(($"After: \n a = {exchanged} \n b = {a}"));
        }
    }
}
