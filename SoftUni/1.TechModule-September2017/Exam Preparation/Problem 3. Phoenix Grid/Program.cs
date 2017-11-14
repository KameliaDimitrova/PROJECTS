using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_3.Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(^[\x00-\x7F]{3}(\.([\x00-\x7F]){3}){0,})$";
           
            while (input!= "ReadMe")
            {
                var regex=new Regex(pattern);
                if (regex.IsMatch(input))
                {
                    var matchedItem= regex.Match(input).Value;
                    if (matchedItem.Length == 3)
                    {
                        if (matchedItem[0] == matchedItem[2]&&matchedItem[0]!='\t'&& matchedItem[0]!='_' && matchedItem[0] != ' ')//тука беше голяма заигравка с празните места, реално трябва да се използва и ' ' и '\t' -и двете са white space
                        {
                            Console.WriteLine("YES");
                        }
                        else
                            Console.WriteLine("NO");
                    }
                    else
                    {
                        var p = matchedItem.Length - 1;
                        var counter = 0;
                        
                            for (int i = 0; i < matchedItem.Length/2; i++)
                            {
                                if (matchedItem[i] == matchedItem[p]&& matchedItem[i]!='\t'&& matchedItem[i] != '_' && matchedItem[i] != ' ')
                                {
                                    counter++;
                                    p--;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        if (counter == matchedItem.Length / 2)
                        {
                            Console.WriteLine("YES");
                        }
                        else
                            Console.WriteLine("NO");
                  }
                }
                else
                    Console.WriteLine("NO");
                input = Console.ReadLine();
            }
        }
    }
}
