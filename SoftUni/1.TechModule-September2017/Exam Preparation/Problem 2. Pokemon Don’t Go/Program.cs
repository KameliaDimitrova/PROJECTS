using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var currNum = 0;
            var sum = 0;
            

            while (input.Count > 0)
            {

                var index = int.Parse(Console.ReadLine());
                if (index >= 0 && index <= input.Count - 1)
                {
                    sum = sum + input[index];
                    currNum = input[index];
                    input.RemoveAt(index);
                }
                else if (index < 0)
                {
                    sum = sum + input[0];
                    currNum = input[0];
                    input.RemoveAt(0);
                    input.Insert(0, input[input.Count - 1]);
                }
                else
                {
                    sum = sum + input[input.Count - 1];
                    currNum = input[input.Count - 1];
                    input.RemoveAt(input.Count - 1);
                    input.Add(input[0]);
                }
                
                for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] > currNum)
                        {
                            input[i] = input[i] - currNum;
                        }
                        else
                        {
                            input[i] = input[i] + currNum;
                        }
                    }
                
              
            }
            Console.WriteLine(sum);
               



        }
    }
}
