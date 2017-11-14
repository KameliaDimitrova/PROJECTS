using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _1.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var regex =new Regex(pattern);
            var maches = Regex.Matches(input,pattern);
            foreach (Match match in maches)
            {
                Console.Write(match.Value+ " ");
            }
            Console.WriteLine();

        }
    }
}
