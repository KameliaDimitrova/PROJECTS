using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var regex = new Regex(pattern);
            var collectedMatches = regex.Matches(input)
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();
            Console.WriteLine(String.Join(" ",collectedMatches));
        }
    }
}
