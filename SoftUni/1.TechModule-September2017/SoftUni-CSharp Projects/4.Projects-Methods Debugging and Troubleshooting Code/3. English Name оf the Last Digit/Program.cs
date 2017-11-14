using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3.English_Name_оf_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            
                var Number = long.Parse(Console.ReadLine());

                Console.WriteLine(ReturnLastDigitToString(Number));

        }

            static string ReturnLastDigitToString (long Number)
            {
                switch (Math.Abs(Number)%10)
                   {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "fife";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "Error";
                    }
            }
        
    }
}
