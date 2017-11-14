using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Intro_and_Basic_Syntax___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstDigits = int.Parse(Console.ReadLine());
            var secondDigits = int.Parse(Console.ReadLine());
            var thirdDigits = int.Parse(Console.ReadLine());
            var fourtDigits = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", firstDigits, secondDigits, thirdDigits, fourtDigits);

        }
    }
}
