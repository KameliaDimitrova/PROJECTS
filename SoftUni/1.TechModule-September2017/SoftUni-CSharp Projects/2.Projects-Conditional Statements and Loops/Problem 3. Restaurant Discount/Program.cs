using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var People = int.Parse(Console.ReadLine());
            string Pakage = Console.ReadLine();
            var HallPrice = 0.1;
            var PriceperPerson = 0.1;
            if (People <= 50)
            {
                HallPrice = 2500;
                if (Pakage == "Normal")
                {
                    PriceperPerson = (((HallPrice + 500) - (HallPrice + 500) * 0.05)) / People;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {PriceperPerson:F2}$");
                }
                else if (Pakage == "Gold")
                {
                    PriceperPerson = (((HallPrice + 750) - (HallPrice + 750) * 0.1)) / People;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {PriceperPerson:F2}$");
                }
                else
                {
                    PriceperPerson = (((HallPrice + 1000) - (HallPrice + 1000) * 0.15)) / People;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {PriceperPerson:F2}$");
                }
            }
            else if (People > 50 && People <= 100)
            {
                HallPrice = 5000;
                if (Pakage == "Normal")
                {
                    PriceperPerson = (((HallPrice + 500) - (HallPrice + 500) * 0.05)) / People;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {PriceperPerson:F2}$");
                }
                else if (Pakage == "Gold")
                {
                    PriceperPerson = (((HallPrice + 750) - (HallPrice + 750) * 0.1)) / People;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {PriceperPerson:F2}$");
                }
                else
                {
                    PriceperPerson = (((HallPrice + 1000) - (HallPrice + 1000) * 0.15)) / People;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {PriceperPerson:F2}$");
                }
            }
            else if (People > 100 && People <= 120)
            {

                HallPrice = 7500;
                if (Pakage == "Normal")
                {
                    PriceperPerson = (((HallPrice + 500) - (HallPrice + 500) * 0.05)) / People;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {PriceperPerson:F2}$");
                }
                else if (Pakage == "Gold")
                {
                    PriceperPerson = (((HallPrice + 750) - (HallPrice + 750) * 0.1)) / People;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {PriceperPerson:F2}$");
                }
                else
                {
                    PriceperPerson = (((HallPrice + 1000) - (HallPrice + 1000) * 0.15)) / People;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {PriceperPerson:F2}$");
                }

            }
            else if(People>120)
                Console.WriteLine("We do not have an appropriate hall.");

             

                }
            }
        
        }


