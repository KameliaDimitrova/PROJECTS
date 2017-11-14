using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            decimal thirdNumber = decimal.Parse(Console.ReadLine());
           
            Console.Write($"{firstNumber:f18} \n {secondNumber} \n {thirdNumber} ");

        }
    }
}
