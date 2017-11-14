using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _2.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyWord = Console.ReadLine();
            var input = Console.ReadLine();
            var pattern = @".*?(\.|!|\?)";
            var regex=new Regex(pattern);
            var allChars = new char() { };
            var collectedMatches = regex.Matches(input)
                .Cast<Match>()
                .Select(x=>x.Value.Trim().Trim('.','!','?'))
                .ToArray();
            
            foreach (var item in collectedMatches)
            {
                
                var wordResult = item
                    .Split(' ')
                    .ToArray();
                foreach (var word in wordResult)
                {
                    
                    if (word == keyWord)
                    {
                        Console.WriteLine(item);
                    }
                }
            }


        }
    }
}
