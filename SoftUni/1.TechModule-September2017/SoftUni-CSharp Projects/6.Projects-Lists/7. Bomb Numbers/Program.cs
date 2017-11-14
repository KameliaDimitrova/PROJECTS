using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var bomb = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var bombNumber = bomb[0];
            var bombPower = bomb[1];
            var sumOfNumbers = 0;
            if (bombPower != 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {

                    if (numbers[i] == bombNumber)
                    {
                        if (numbers.Count - 1 - i < bombPower)
                        {
                            for (int j = numbers.Count - 1; j > i; j--)
                            {
                                numbers.RemoveAt(j);
                            }
                        }
                        else
                        {
                            for (int j = i + bombPower; j > i; j--)
                            {
                                numbers.RemoveAt(j);
                            }
                        }
                        if (i - bombPower < 0)
                        {
                            for (int k = i; k >= 0; k--)
                            {
                                numbers.RemoveAt(k);
                            }
                        }
                        else
                        {
                            for (int k = i; k > i - bombPower - 1; k--)
                            {
                                numbers.RemoveAt(k);
                            }
                        }
                    }
                }


                for (int p = 0; p < numbers.Count; p++)
                {
                    sumOfNumbers = sumOfNumbers + numbers[p];
                }
            }
            else
            {
                for (int p = numbers.Count - 1; p >= 0; p--)
                {
                    if (numbers[p] == bombNumber)
                    {
                        numbers.RemoveAt(p);
                       
                    }
                }
                for (int p = 0; p < numbers.Count; p++)
                {
                    sumOfNumbers = sumOfNumbers + numbers[p];
                }

            }

            Console.WriteLine(sumOfNumbers);

        }

    }
}
