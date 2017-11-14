using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_3.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"^<\[[^a-zA-Z0-9]{0,}\]\.(\.\[[a-zA-Z0-9]{0,}\].){0,}$";
            var resultList=new HashSet<string>();
         


            while (input != "Traincode!")
            {
                var regex = new Regex(pattern);
              
                if (regex.IsMatch(input))
                {
                    var matchedTrain = regex.Match(input).Value;
                    resultList.Add(matchedTrain);
                }
                

                input = Console.ReadLine();
            }

            foreach (var item in resultList)
            { 
        
                Console.WriteLine(item);
            }
        }
    }
}
