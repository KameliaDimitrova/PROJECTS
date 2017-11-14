using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var collectedTeams=new Dictionary<string,decimal>();

            for (int i = 0; i < number; i++)
            {
                var milesDistance = long.Parse(Console.ReadLine());
                var metersDistance = milesDistance * 1600;
                var tonesCargo = decimal.Parse(Console.ReadLine());
                var kilogramCargo = tonesCargo * 1000;
                var currentTeam = Console.ReadLine();
                var fuelExpences= (decimal)0.7 * metersDistance*(decimal)2.5;//decimal
                var cargoWort = (decimal)1.5 * kilogramCargo;

                var earnedMonety = cargoWort - (decimal)fuelExpences;
                
                    if (!collectedTeams.ContainsKey(currentTeam))
                    {
                        collectedTeams[currentTeam] = 0;
                    }
                    collectedTeams[currentTeam] = collectedTeams[currentTeam] + earnedMonety;
                
            }
            
            foreach (var team in collectedTeams.OrderByDescending(x=>x.Value))
            {
                    Console.WriteLine($"The {team.Key} Trainers win with ${team.Value:f3}.");
                break;
                    
                
            }
        }
    }
}
