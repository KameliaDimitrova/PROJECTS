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
            sbyte firstNumber = sbyte.Parse(Console.ReadLine());
            short secondNumber = short.Parse(Console.ReadLine());
            short thirdNumber = short.Parse(Console.ReadLine());
          ushort fourthNumber = ushort.Parse(Console.ReadLine());
            long fifthNumber = long.Parse(Console.ReadLine());
           long sixthNumber = long.Parse(Console.ReadLine());
            long seventhNumber = long.Parse(Console.ReadLine());
            Console.Write($"{firstNumber} \n {secondNumber} \n {thirdNumber} \n {fourthNumber} \n {fifthNumber}\n {sixthNumber} \n {seventhNumber}");

        }
    }
}
