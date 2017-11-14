using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string Month = Console.ReadLine();
            var Nights = int.Parse(Console.ReadLine());


            if (Month == "May" || Month == "October")
            {
                if (Nights > 7)
                {
                    if (Month == "October")
                    {
                        Console.WriteLine($"Studio: {(50 * (Nights-1) - 50 * (Nights-1) * 0.05):F2} lv.");
                        Console.WriteLine($"Double: {(65 * Nights):F2} lv.");
                        Console.WriteLine(($"Suite: {(75 * Nights):F2} lv."));
                    }
                   else
                    {
                        Console.WriteLine($"Studio: {(50 * Nights - 50 * Nights * 0.05):F2} lv.");
                        Console.WriteLine($"Double: {(65 * Nights):F2} lv.");
                        Console.WriteLine(($"Suite: {(75 * Nights):F2} lv."));
                    }

                }
                else
                {
                    Console.WriteLine($"Studio: {(50 * Nights):F2} lv.");
                    Console.WriteLine($"Double: {(65 * Nights):F2} lv.");
                    Console.WriteLine(($"Suite: {(75 * Nights):F2} lv."));
                }
            }


            else if (Month == "June" || Month == "September")
            {
                if (Nights > 14)
                {
                    Console.WriteLine($"Studio: {(60 * (Nights - 1)):F2} lv.");
                    Console.WriteLine($"Double: {(72 * Nights - 0.1 * 72 * Nights):F2} lv.");
                    Console.WriteLine(($"Suite: {(82 * Nights):F2} lv."));
                }
                else if (Nights > 7 && Nights <= 14)
                {
                    if (Month == "September")
                    {
                        Console.WriteLine($"Studio: {(60 * (Nights - 1)):F2} lv.");
                        Console.WriteLine($"Double: {(72 * Nights):F2} lv.");
                        Console.WriteLine(($"Suite: {(82 * Nights):F2} lv."));

                    }
                    else
                    {
                        Console.WriteLine($"Studio: {(60 * Nights):F2} lv.");
                        Console.WriteLine($"Double: {(72 * Nights):F2} lv.");
                        Console.WriteLine(($"Suite: {(82 * Nights):F2} lv."));
                    }
                }
                else if (Nights <= 7)
                {
                    Console.WriteLine($"Studio: {(60 * Nights):F2} lv.");
                    Console.WriteLine($"Double: {(72 * Nights):F2} lv.");
                    Console.WriteLine(($"Suite: {(82 * Nights):F2} lv."));
                }
            }
            
        

            else if (Month == "July" || Month == "August" || Month == "December")
            {

                Console.WriteLine($"Studio: {(68 * Nights):F2} lv.");
                Console.WriteLine($"Double: {(77 * Nights):F2} lv.");
                if (Nights > 14)
                {
                    Console.WriteLine($"Suite: {(89 * Nights - 0.15 * 89 * Nights):F2} lv.");
                }
                else
                    Console.WriteLine($"Suite: {(89 * Nights):F2} lv.");

            }
        }

    }
}


