using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _2.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input=Console.ReadLine();
            var pattern = @"\+359( |-)(2)\1[0-9]{3}\1[0-9]{4}\b";
            var regex=new Regex(pattern);
            var allMatches = regex.Matches(input)
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(String.Join(", ", allMatches));
                
            //var result = "";
            //foreach (Match everyMatch in allMatches)
            //{
            //   result =result+" " +everyMatch + ",";
            //}
            //Console.WriteLine(result.TrimEnd(','));

            



        }
    }
}
