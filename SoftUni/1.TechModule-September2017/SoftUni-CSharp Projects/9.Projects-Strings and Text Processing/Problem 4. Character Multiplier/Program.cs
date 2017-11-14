using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ');
            var firstEl = input[0];
            var secEl = input[1];
            var smaller = Math.Min(firstEl.Length, secEl.Length);
            var bigger = "0";
            var sum = 0;
            for (int i = 0; i < smaller; i++)
            {
                sum = sum +(int) firstEl[i] * (int) secEl[i];
            }

            if (firstEl.Length > secEl.Length)
            {
                bigger = firstEl;
            }
            else
            {
                bigger = secEl;
            }
            for (int i = smaller; i < bigger.Length; i++)
            {
                sum = sum + (int) bigger[i];
            }
            Console.WriteLine(sum);
        }
    }
}
