using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var Name = Console.ReadLine();
            var Volume = double.Parse(Console.ReadLine());
            var EnergyContent100 = double.Parse(Console.ReadLine());
            var SugarContent100 = double.Parse(Console.ReadLine());
            var Energy = (EnergyContent100 / 100 )* Volume;
            var Sugar = (SugarContent100 / 100) * Volume;
            Console.WriteLine("{0}ml {1}:", Volume, Name);
            Console.WriteLine("{0}kcal, {1}g sugars", Energy, Sugar);
        }
    }
}
