using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
    
            for (int i = 1; i < input.Count; i++)
            {
                if (i == 1 && input.Count == 2&&input[1]==input[0])
                {
                    input.RemoveAt(1);
                        break;
                }
                else if(i == 1 && input[1] == input[0])
                {
                    input.RemoveAt(1);
                    i = 0;
                }
                else if (i != input.Count - 1)
                {

                    if (input[i] == input[i - 1] + input[i + 1])
                    {

                        input.RemoveAt(i + 1);
                        input.RemoveAt(i - 1);
                        i = 0;

                    }
                }
                else if (i == input.Count - 1 && input[input.Count - 1] == input[input.Count - 2])
                {
                    input.RemoveAt(input.Count-1);
                }

            }


            Console.Write(string.Join(" ", input));
            Console.WriteLine();
        }
    }
}
