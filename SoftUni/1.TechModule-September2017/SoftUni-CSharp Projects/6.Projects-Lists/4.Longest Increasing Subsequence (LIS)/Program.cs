using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Increasing_Subsequence__LIS_
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var maxList = new List<int>();
            var currList = new List<int>();
            var counter = 0;
            var maxCounter = 0;
            var lastElement = 0;
            var index = 0;
            for (int i = 1; i < listOfNumbers.Count; i++)
            {
                lastElement = listOfNumbers[i - 1];
                for (int j = i; j < listOfNumbers.Count - j; j++)
                {
                    if (listOfNumbers[j] > lastElement)
                    {
                        counter++;
                        currList.Add(lastElement);
                        lastElement = listOfNumbers[j];
                        index++;
                    }
                }
                if (counter > maxList.Count)
                {
                    for (int k = 0; k < counter; k++)
                    {
                        maxList.Add(currList[k]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", maxList));
        }









        //    var listOfNumbers = Console.ReadLine()
            //        .Split(' ')
            //        .Select(int.Parse)
            //        .ToList();

            //    var mostLongInc = new int[listOfNumbers.Count];
            //    var curLength = 1;
            //    var maxLengthInc = 1;
            //    var startIndex = 0;
            //    var lastInc = 0;

            //    for (int i = 1; i < listOfNumbers.Count; i++)
            //    {
            //        if (listOfNumbers[i] > listOfNumbers[i - 1])
            //        {
            //            curLength++;
            //        }
            //        else
            //        {
            //            if (curLength > maxLengthInc)
            //            {
            //                maxLengthInc = curLength;
            //                curLength = 0;
            //                lastInc = i - 1;
            //            }
            //        }
            //    }

            //    for (int j = 0; j < maxLengthInc; j++)
            //    {
            //        mostLongInc[j] = listOfNumbers[lastInc-maxLengthInc+1];
            //        lastInc++;
            //    }
            //    for (int k = 0; k < maxLengthInc; k++)
            //        Console.Write(mostLongInc[k]);
            //}
        }
    }
