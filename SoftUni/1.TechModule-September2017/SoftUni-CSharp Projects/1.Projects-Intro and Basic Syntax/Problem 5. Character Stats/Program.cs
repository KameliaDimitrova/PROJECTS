using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", Name);
            Console.Write("Health: |");            
                for (int i = 0; i <= currentHealth-1; i++)
                {
                    Console.Write("|");
                }
                for (int i = 0; i <= (maxHealth - currentHealth)-1; i++)
                {
                    Console.Write(".");
                }
            Console.WriteLine("|");

            Console.Write("Energy: |");
            for(int i=0;i<=currentEnergy-1;i++)
            {
                Console.Write("|");
            }
            for(int i = 0; i<=maxEnergy-currentEnergy-1;i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");

            

        }
    }
}
