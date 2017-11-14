using System;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
      
            var didiCollection=new List<char>();
            var leftSide=new List<char>();
            var rightSide = new List<char>();
            var counter = 0;
            //var helpCounter = 0;
            var index = 1;
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
            var currentChar = '0';
            for (int i = 0; i < input.Length; i++)
            {
                currentChar = input[i];
                if (!alpha.Contains(currentChar)&&currentChar!='-')
                {
                    didiCollection.Add(currentChar);
                    if (i == input.Length - 1)
                    {
                        Console.WriteLine(string.Join("",didiCollection));
                        didiCollection.Clear();

                    }
                    else if (alpha.Contains(input[i + 1]))
                    {
                        Console.WriteLine(string.Join("", didiCollection));
                        input=input.Substring(i+1);
                        i = -1;
                        didiCollection.Clear();
                    }

                    counter = 0;
                    leftSide.Clear();
                    rightSide.Clear();

                }
              
                    else if (alpha.Contains(currentChar) || currentChar == '-')
                    {
                      if (input[i] == '-' && !alpha.Contains(input[i + counter + 1]))
                        {
                            for (int j = i + 1; j <= i + counter; j++)
                            {
                                if (input[j] != '-')
                                {
                                    rightSide.Add(input[j]);
                                }
                            }
                            if (leftSide.ToString() == rightSide.ToString())
                            {
                                Console.WriteLine($"{string.Join("", leftSide)}-{string.Join("", rightSide)}");
                            }

                            input = input.Substring(i + counter + 1);
                            i = -1;
                            counter = 0;
                            leftSide.Clear();
                            rightSide.Clear();
                        }
                        leftSide.Add(currentChar);
                        counter++;

                    
                }




            }

                

            
      
        }
    }
}
