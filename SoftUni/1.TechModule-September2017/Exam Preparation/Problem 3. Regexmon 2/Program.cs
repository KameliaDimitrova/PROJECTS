using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_3.Regexmon_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var didiPattern = @"[^A-Za-z-]+";
            var bojiPattern = @"[A-Za-z]{1,}-[A-Za-z]{1,}";
            

            while (true)
            {
                var didiRegex=new Regex(didiPattern);
                if (didiRegex.IsMatch(input))
                {
                    var didiResult = didiRegex.Match(input);
                    Console.WriteLine(didiResult);
                    var currIndex=didiResult.Index + didiResult.Length;
                    input =input.Substring(currIndex);
                }
                else
                {
                    break;
                }
                var bojiRegex = new Regex(bojiPattern);
                if (bojiRegex.IsMatch((input)))
                {
                    var bojiResult = bojiRegex.Match(input);
                    Console.WriteLine(bojiResult);
                    var currIndex = bojiResult.Index + bojiResult.Length;
                    input = input.Substring(currIndex);
                }
                else
                {
                    break;
                }
            }
            
        }
    }
}
