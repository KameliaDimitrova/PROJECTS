using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Text.RegularExpressions;

namespace _3.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var mAndN = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var m = mAndN[0];
            var n = mAndN[1];
            var input = Console.ReadLine();
            var pattern = @"(?<=\|<)[A-Za-z0-9]+";
            var regex=new Regex(pattern);
            var collectedMatches = regex.Matches(input)
                .Cast<Match>()
                .Select(x=>x.Value.Trim())
                .ToArray();
            var newCollection=new StringBuilder();
            var wordCollector=new List<string>();
            foreach (var item in collectedMatches)
            {
                if (m + n <= item.Length)
                {
                    for (int i = m; i < m+n; i++)
                    {
                        newCollection.Append(item[i]);
                    }
                    wordCollector.Add(newCollection.ToString());
                }
                else if (m < item.Length && n + m > item.Length)
                {
                    for (int i = m; i < item.Length; i++)
                    {
                        newCollection.Append(item[i]);
                    }
                    wordCollector.Add(newCollection.ToString());
                }
                
                newCollection.Clear();
            }
            if(n!=0)
            Console.WriteLine(string.Join(", ",wordCollector));
        }
    }
}
