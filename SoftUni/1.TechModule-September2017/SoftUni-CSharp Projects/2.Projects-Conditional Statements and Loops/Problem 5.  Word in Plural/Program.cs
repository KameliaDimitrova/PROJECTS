using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string Noun= Console.ReadLine();
            if (Noun.EndsWith("y"))
            {
                Noun = Noun.Remove(Noun.Length - 1);
                Console.WriteLine($"{Noun}ies");
            }
            else if (Noun.EndsWith("o") || Noun.EndsWith("s")  || Noun.EndsWith("x") || Noun.EndsWith("z") )
            {
                
                Console.WriteLine($"{Noun}es");
            }
            else if (Noun.EndsWith("ch") || Noun.EndsWith("sh"))
            {
               
                Console.WriteLine($"{Noun}es");
            }
            else
            {
                Console.WriteLine($"{Noun}s");
            }
        


        }
    }
}
