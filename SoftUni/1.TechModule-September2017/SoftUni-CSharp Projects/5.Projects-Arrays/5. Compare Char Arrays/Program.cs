using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            var secondLine = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            var count = 0;
            var count2 = 0;

            if (firstLine.Length == secondLine.Length)
            {
                for (int i = 0; i < firstLine.Length; i++)
                {
                    if (firstLine[i] == secondLine[i])
                    {
                        count++;
                    }
                }
                if (count == firstLine.Length)
                {
                    Console.WriteLine(String.Join("", firstLine));
                    Console.WriteLine(String.Join("", secondLine));
                }
                else
                {
                    for (int k = 0; k < firstLine.Length; k++)
                    {
                        if (firstLine[k] == secondLine[k])
                        {

                        }
                        else
                        {
                            if (firstLine[k] < secondLine[k])
                            {
                                Console.WriteLine(String.Join("", firstLine));
                                Console.WriteLine(String.Join("", secondLine));
                                break;
                            }
                            else
                            {
                                Console.WriteLine(String.Join("", secondLine));
                                Console.WriteLine(String.Join("", firstLine));
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                for (int j = 0; j < Math.Min(firstLine.Length, secondLine.Length); j++)
                {
                    if (firstLine[j] == secondLine[j])
                        count2++;
                }
                if (count2 == Math.Min(firstLine.Length, secondLine.Length)&&count2!=0)
                {
                    if (firstLine.Length < secondLine.Length)
                    {
                        Console.WriteLine(String.Join("", firstLine));
                        Console.WriteLine(String.Join("", secondLine));
                    }
                    else
                    {
                        Console.WriteLine(String.Join("", secondLine));
                        Console.WriteLine(String.Join("", firstLine));
                    }
                }
                else
                    for (int k = 0; k < Math.Min(firstLine.Length, secondLine.Length); k++)
                    {
                        if (firstLine[k] == secondLine[k])
                        {

                        }
                        else
                        {
                            if (firstLine[k] < secondLine[k])
                            {
                                Console.WriteLine(String.Join("", firstLine));
                                Console.WriteLine(String.Join("", secondLine));
                                break;
                            }
                            else
                            {
                                Console.WriteLine(String.Join("", secondLine));
                                Console.WriteLine(String.Join("", firstLine));
                                break;
                            }

                        }
                    }
            }
            }
        }

        }


    



        
    

