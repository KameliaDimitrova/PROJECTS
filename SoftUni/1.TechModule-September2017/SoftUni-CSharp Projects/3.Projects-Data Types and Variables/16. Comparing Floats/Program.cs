using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            var eps = 0.000001;
            if (secondNumber > firstNumber)
            {
                if (secondNumber - firstNumber < eps)

                    Console.WriteLine("True");

                else
                    Console.WriteLine("False");
            }
            else if (firstNumber>secondNumber)
            {
                if (firstNumber-secondNumber < eps)

                    Console.WriteLine("True");

                else
                    Console.WriteLine("False");
            }


        }
    }
}
