using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var width = decimal.Parse(Console.ReadLine());
            var reminder = 0m;
            var per = 0m;
            length = length * 100;
            if (width != 0m)
            {
                reminder = length % width;
            }

            if (reminder == 0||width==0&&length==0)
                {
                    Console.WriteLine($"{(length * width):f2}");

                }
                else
                {
                    per = (length / width) * 100;
                    Console.WriteLine($"{per:f2}%");
                }
            }

        }
    
}
