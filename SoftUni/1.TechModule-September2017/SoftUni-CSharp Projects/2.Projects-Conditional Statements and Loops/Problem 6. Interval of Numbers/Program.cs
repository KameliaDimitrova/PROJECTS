using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var Number1 = int.Parse(Console.ReadLine());
            var Number2 = int.Parse(Console.ReadLine());
            if (Number1 < Number2)
            {
                for (int i = Number1; i <= Number2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
                for (int i = Number2; i <= Number1; i++)
                {
                    Console.WriteLine(i);
                }
        }
    }
}
