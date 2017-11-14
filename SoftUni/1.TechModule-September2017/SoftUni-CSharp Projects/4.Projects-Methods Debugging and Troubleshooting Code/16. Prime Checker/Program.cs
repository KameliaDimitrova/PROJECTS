using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var InputNumber = long.Parse(Console.ReadLine());
           IsPrime(InputNumber);
        }

        static void IsPrime(long Number)
        {
            long counter = 0;
            if (Math.Abs(Number) == 1 || Number == 0|| Number == 4)
            {
                Console.WriteLine("False");
            }
            else
            {

                for (int i = 2; i < Math.Sqrt(Math.Abs(Number)); i++)
                {
                    if (Math.Abs(Number) % i == 0)
                    {
                        counter++;
                    }
                    if (counter > 0)
                    {
                        Console.WriteLine("False");
                        return; 
                    }
                   

                }

                Console.WriteLine("True");
            }





        }
    }
}
