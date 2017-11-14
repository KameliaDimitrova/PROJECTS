using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _5.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyWords = Console.ReadLine();
            var startPattern = @"(?<startKeyWord>(^[A-Za-z]+(?=<|\||\\)).*?)";
            var endPattern = @"(?<endKeyWord>(?<=<|\||\\)[A-Za-z]+(?=$))";
            var startRegex=new Regex(startPattern);
            var endRegex=new Regex(endPattern);
            var startMatch = startRegex.Match(keyWords);
            var valueStar = startMatch.Value;
            var endMatch = endRegex.Match(keyWords);
            var valueEnd = endMatch.Value;
            var input = Console.ReadLine();
            var exactPattern= $"(?<={valueStar}).*?(?={valueEnd})";//ей тука нз как да извикам стойностите на двете групи от регексите по-горе
            var exactRegex=new Regex(exactPattern);
            var result = exactRegex.Matches(input);
            if (exactRegex.IsMatch(input))
            {
                foreach (Match element in result)
                {
                    Console.Write(element);
                }
            }
            else
            {
                Console.WriteLine("Empty result");
            }
            Console.WriteLine();
        }
        //{
        //    string keys = Console.ReadLine();
        //    string text = Console.ReadLine();
        //    string pattern = @"(?<startKey>\w*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(?<endKey>\w*)";
        //    var keyMatch = Regex.Match(keys, pattern);

        //    if (keyMatch.Success)
        //    {
        //        var startKey = keyMatch.Groups["startKey"].Value;
        //        var endKey = keyMatch.Groups["endKey"].Value;

        //        var textPattern = $@"{startKey}(?<word>.*?){endKey}";
        //        var matches = Regex.Matches(text, textPattern);

        //        var result = new StringBuilder();
        //        foreach (Match match in matches)
        //        {
        //            result.Append(match.Groups["word"].Value);
        //        }
        //        Console.WriteLine(result.ToString().Length ==0 ? "Empty result" : result.ToString());
        //    }


    }
}
