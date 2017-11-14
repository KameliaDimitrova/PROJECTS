using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = 0;
            while (true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                    numCount++;

                }
                catch (Exception)
                {
                    break;
                }
               
            }

            Console.WriteLine(numCount);

        }
    }
}
