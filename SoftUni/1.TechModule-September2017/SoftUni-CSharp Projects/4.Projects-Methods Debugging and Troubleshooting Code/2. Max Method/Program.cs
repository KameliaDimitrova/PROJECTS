using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
          
            if ((GetMax(a,b))>c)
            {
                Console.WriteLine(GetMax(a, b));
            }
            else
            Console.WriteLine(c);
        }

            static int GetMax(int a, int b)
            {
            if (a > b)
               return a;
            else
                return b;
               
            }

        
    }
}
