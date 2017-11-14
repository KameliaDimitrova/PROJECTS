using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var handsOfCard=new Dictionary<string, List<string>>();

            var input = Console.ReadLine()
                .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (input[0] != "JOKER") 
            {
                var name = input[0];
                var cards = input[1]
                    .Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            
                if (!handsOfCard.ContainsKey(name))
                {
                    handsOfCard[name] = new List<string>();
                }

                handsOfCard[name].AddRange(cards);
                input = Console.ReadLine()
                    .Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();


            }
            Console.WriteLine(handsOfCard.Values);

        }
    }
}
