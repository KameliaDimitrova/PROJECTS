using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _6.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input=Console.ReadLine()
                .Split(new char[]{' ','/','\\', ')','('})
                .Select(x=>x.Trim())
                .ToArray();
            var pattern = @"^\w{3,25}$";
            var resultList=new List<string>();
            var sumedList=new List<int>();
            var regex=new Regex(pattern);
            var sum = 0;
            foreach (var word in input)
            {
                if (regex.IsMatch(word))
                {
                    resultList.Add(word);
                 
                }
            }

            for (int i = 1; i < resultList.Count; i++)
            {
                
            }
            if (resultList.Count > 1)
            {
                    Console.WriteLine(resultList[0]);
                    Console.WriteLine(resultList[1]);
                
            }
            else if (resultList.Count == 1)
            {
                Console.WriteLine(resultList[0]);
            }

           
        }
    }
}
