using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMuch = int.Parse(Console.ReadLine());
            var random = new Random();
            string[] phrase = new string[6];
            string[] events= new string[6];
            string[] autors = new string[8];
            string[] cities = new string[5];

            phrase[0] = "Excellent product.";
            phrase[1] = "Such a great product.";
            phrase[2] = "I always use that product.";
            phrase[3] = "Best product of its category.";
            phrase[4] = "Exceptional product.";
            phrase[5] = "I can’t live without this product.";

            events[0] = "Now I feel good.";
            events[1] = "I have succeeded with this product.";
            events[2] = "Makes miracles. I am happy of the results!";
            events[3] = "I cannot believe but now I feel awesome.";
            events[4] = "Try it yourself, I am very satisfied.";
            events[5] = "I feel great!";

            autors[0] = "Diana";
            autors[1] = "Petya";
            autors[2] = "Stella";
            autors[3] = "Elena";
            autors[4] = "Katya";
            autors[5] = "Iva";
            autors[6] = "Annie";
            autors[7] = "Eva";

            cities[0] = "Burgas";
            cities[1] = "Sofia";
            cities[2] = "Plovdiv";
            cities[3] = "Varna";
            cities[4] = "Ruse";

          

            for (int i = 0; i <= howMuch - 1; i++)
            {
                var randomPhrase = random.Next(0, phrase.Length);
                var randomEvent = random.Next(0, events.Length);
                var randomautors = random.Next(0, autors.Length);
                var randomcities = random.Next(0, cities.Length);
                Console.WriteLine($"{phrase[randomPhrase]} {events[randomEvent]} {autors[randomautors]} - {cities[randomcities]}.");
            }






        }
    }
}


