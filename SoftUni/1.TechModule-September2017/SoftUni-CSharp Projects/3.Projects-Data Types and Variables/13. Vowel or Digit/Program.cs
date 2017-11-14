using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var INT = Console.ReadLine();
            if (INT == "a" || INT == "e" || INT == "i" || INT == "o" || INT == "u")
            {
                Console.WriteLine("vowel");
            }
            else if (INT =="1" || INT=="2"|| INT == "3" || INT == "4" || INT == "5" || INT == "6" || INT == "7" || INT == "8" || INT == "9" || INT == "0")
            {
                Console.WriteLine("digit");
            }
            else
                Console.WriteLine("other");
        }
    }
}
