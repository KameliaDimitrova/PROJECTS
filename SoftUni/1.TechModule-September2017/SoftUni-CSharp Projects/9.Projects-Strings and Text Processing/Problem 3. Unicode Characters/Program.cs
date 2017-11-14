using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
          
          var input=Console.ReadLine();
            foreach (var ch in input)
            {
                Console.Write($"\\u{(int)ch:x4}");
            }
            Console.WriteLine();
        }
    }
}
