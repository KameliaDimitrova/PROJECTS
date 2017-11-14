using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
                var number = int.Parse(Console.ReadLine());
                Fib(number);
            }
            static void Fib(int n)
            {
                int numberHolderBefore = 0;
                int numberHolderNext = 1;
                int holder = n;
            if (holder == 1||holder==0)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 0; i <= holder - 1; i++)
                {

                    n = numberHolderBefore + numberHolderNext;
                    numberHolderBefore = numberHolderNext;
                    numberHolderNext = n;

                }
                Console.WriteLine(n);
            }



        }
        
    }
}
