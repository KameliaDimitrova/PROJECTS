 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\b(\d{2})(\.|\/|\-)([A-Z]{1}[a-z]{2})\2([0-9]{4})";
            var regex=new Regex(pattern);
            var collectedMatches = regex.Matches(input);
            foreach (Match evryMatch in collectedMatches)
            {
                Console.WriteLine($"Day: {evryMatch.Groups[1]}, Month: {evryMatch.Groups[3]}, Year: {evryMatch.Groups[4]}");
            }

        }
    }
}
