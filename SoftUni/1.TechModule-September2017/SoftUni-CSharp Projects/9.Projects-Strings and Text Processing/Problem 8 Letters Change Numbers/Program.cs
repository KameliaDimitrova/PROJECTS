using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_8_Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] {' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            decimal result = 0;
            decimal sum = 0;
            var firstChar = ' ';
            var secChar = ' ';
            var number = new StringBuilder();
            var alpabet = new List<char>();
            

            for (int i = 0; i < input.Length; i++)
            {
                var currWord = input[i];
                for(int j=0;j<currWord.Length;j++)
                {
                    if (currWord[j] >= 48 && currWord[j] <= 57)
                    {
                        number.Append(currWord[j]);
                        if (currWord[j+1] < 48 || currWord[j+1] > 57)
                        {
                            secChar = currWord[j + 1];
                            break;
                        }
                    }
                    else
                    {
                        alpabet.Add(currWord[j]);
                    }
                    firstChar = alpabet[alpabet.Count - 1];
                   
                }
                decimal theNumber = decimal.Parse(number.ToString());
                var firstCharNum = ((int)firstChar - 64);
                var secCharNum = (int)secChar-64;
                if (firstChar >= 65 && firstChar <= 90)
                {
                    result = result + theNumber / firstCharNum;
                }
                else if (firstChar >= 97 && firstChar <= 122)
                {
                    firstCharNum = (int)firstChar- 96;
                    result = result + theNumber * firstCharNum;
                }
                if (secChar >= 65 && secChar <= 90)
                {
                    sum = sum + result - secCharNum;
                }
                else if(secChar >= 97 && secChar <= 122)
                {
                    secCharNum = (int)secChar - 96;
                    sum = sum+ result + secCharNum;
                }
               
                result = 0;
                number.Clear();
                
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
