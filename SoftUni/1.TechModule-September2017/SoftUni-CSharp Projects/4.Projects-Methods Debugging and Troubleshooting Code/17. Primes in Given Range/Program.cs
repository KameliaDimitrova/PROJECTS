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
            var StartNumber = int.Parse(Console.ReadLine());
            var EndNumber = long.Parse(Console.ReadLine());
            for (int i = StartNumber; i <= EndNumber; i++)
            {
                IsPrime(i,0);
            }
        }

        static void IsPrime(long Number,int firstPrime)
        {
        
            var counter = 0;
            
            for (int i = 2; i < Math.Abs(Number); i++)
            {
                if (Math.Abs(Number) % i == 0)
                {
                    counter++;
                    
                }
            }
            if (counter > 0 || Number == 0 || Number == 1)
            {
                return;
            }
           
            else             
               Console.Write($"{Number}, ");
          


        }
        
    }
}