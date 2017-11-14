using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string Proffession = Console.ReadLine();
            var quantite = int.Parse(Console.ReadLine());
            if (Proffession == "Athlete")
                Console.WriteLine($"The {Proffession} has to pay {(quantite * 0.7):F2}.");
            else if (Proffession == "Businessman" || Proffession == "Businesswoman")
                Console.WriteLine($"The {Proffession} has to pay {quantite:F2}.");
            else if (Proffession == "SoftUni Student")
                Console.WriteLine($"The {Proffession} has to pay {(quantite * 1.7):F2}.");
           else
                Console.WriteLine($"The {Proffession} has to pay {(quantite * 1.2):F2}.");

        }
    }
}
