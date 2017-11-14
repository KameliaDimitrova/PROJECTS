using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _5.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var regex=new Regex(pattern);
            var collectionMatches = regex.Matches(input)
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();
            Console.WriteLine(string.Join(" ",collectionMatches));
        }
    }
}
