using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using System.Text.RegularExpressions;

namespace _02.Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stringArr = new string[input.Split(' ').Length];
            var pattern = @"[A-Z].*?\.";
            var counter = 1;
            var maxCounter = 1;
            var currChar = '.';
            var stringList=new List<string>();
            
            while (input != "Worm Ipsum")
            {
                var regex=new Regex(pattern);
                var collectedMatches = regex.Matches(input);
                if (collectedMatches.Count == 1)
                {
                    stringArr = input
                        .Split(' ',',')
                        .ToArray();

                    for (int i = 0; i < stringArr.Length; i++)
                    {
                       
                        for (int j = 0; j < stringArr[i].Length; j++)
                        {
                            for (int k = j+1; k < stringArr[i].Length; k++)
                            {
                                if (stringArr[i][j] == stringArr[i][k])
                                {
                                    counter++;
                                }
                            }
                            if (counter > maxCounter)
                            {
                                maxCounter = counter;
                                currChar = stringArr[i][j];
                                counter = 1;
                            }
                        }

                            if (maxCounter != 1)
                              {
                        for (int p = 0; p < stringArr[i].Length; p++)
                        {
                            var result=stringArr[i].Replace(stringArr[i][p],currChar);
                        }
                    }
                        maxCounter = 1;


                    }

                    
                    Console.WriteLine(string.Join(" ",stringArr));
                    
                }
                else
                {
                    input = Console.ReadLine();
                }
                input = Console.ReadLine();

            }

        }
    }
}
