using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _6.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToList();
            var sumOfReverstElements = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                char[] element = numbers[i]
                    .ToArray();
                char[] reversedElement = string.Join("", element)
                    .Reverse()
                    .ToArray();

                sumOfReverstElements = sumOfReverstElements + int.Parse(string.Join("", reversedElement));
            }
            Console.WriteLine(sumOfReverstElements);
        }



        //    List<int> reversedNumbers = new List<int>();
        //    var sumOfelements = 0;

        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        string eachElement = numbers[i];
        //        char[] element = eachElement
        //            .ToCharArray();
        //        char[] reversed = element
        //            .Reverse()
        //            .ToArray();

        //        reversedNumbers.Add(int.Parse(string.Join("", reversed)));
        //    }
        //    Console.WriteLine(reversedNumbers.Sum());
        //}
         


        }
    
}
