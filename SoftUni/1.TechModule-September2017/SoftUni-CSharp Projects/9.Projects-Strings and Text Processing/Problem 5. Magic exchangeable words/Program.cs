using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ');
           
            var firstWord = input[0];
            var secondWord = input[1];
            if (firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                   firstWord = firstWord.Replace(firstWord[i], secondWord[i]);
                }
            }
            if(firstWord==secondWord)
                Console.WriteLine("true");
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
