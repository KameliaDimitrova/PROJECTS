using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            for (string Product = "1"; Product != "Bake!";)
            {
                Product = Console.ReadLine();
                if(Product !="Bake!")
                Console.WriteLine($"Adding ingredient {Product}.");
                counter++;
            }
            Console.WriteLine($"Preparing cake with {counter-1} ingredients.");


        }
    }
}
