using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
                .Split(' ')
                .ToList();

            var arrayOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool isItTrue = false;
            var maxLenDel = arrayOfNumbers[0];
            var curLenDel = arrayOfNumbers[1];
            var searchNum = arrayOfNumbers[2];

            if (maxLenDel>=curLenDel)
            {
                for (int i = 0; i < curLenDel;i++)
                {
                    listOfNumbers.RemoveAt(0);
                }
            }
            else
            {
                for (int i = 0; i < maxLenDel; i++)
                {
                    listOfNumbers.RemoveAt(0);
                }
            }
            for (int j = 0; j < listOfNumbers.Count; j++)
            {
                if (searchNum == int.Parse(listOfNumbers[j]))
                {
                   
                    isItTrue = true;
                }
        }
            if (isItTrue == true)
            {
                Console.WriteLine("YES!");

            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
