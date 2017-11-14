using System;

namespace Problem_15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var PeshoDamage = int.Parse(Console.ReadLine());
            var GoshoDamage = int.Parse(Console.ReadLine());
            var currentPeshoHealth = 100;
            var currentGoshoHealth = 100;
            var counterPesho = 0;
            var counterGosho = 0;
            var round = 0;
            for (int i = 1; currentPeshoHealth - GoshoDamage > 0 || currentGoshoHealth - PeshoDamage > 0; i++)
            {
                               if (i % 2 != 0)
                    {
                       
                        if (i % 3 != 0)
                        {
                            currentGoshoHealth = currentGoshoHealth - PeshoDamage;
                            if (currentGoshoHealth == 0)
                                break;
                            else
                                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {currentGoshoHealth} health.");
                        }
                        else
                        {
                            currentGoshoHealth = currentGoshoHealth - PeshoDamage;
                            if (currentGoshoHealth==0)
                                break;
                            else
                            {
                                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {currentGoshoHealth} health.");
                                currentGoshoHealth = currentGoshoHealth + 10;
                                currentPeshoHealth = currentPeshoHealth + 10;
                            }
                        }
                    counterPesho++;

                }
                    else
                    {
                      
                        if (i % 3 != 0)
                        {
                            currentPeshoHealth = currentPeshoHealth - GoshoDamage;
                            if (currentPeshoHealth == 0)
                                break;
                            else
                                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {currentPeshoHealth} health.");
                        }
                        else
                        {
                            currentPeshoHealth = currentPeshoHealth - GoshoDamage;
                            if (currentPeshoHealth==0)
                                break;
                            else
                            {
                                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {currentPeshoHealth} health.");
                                currentPeshoHealth = currentPeshoHealth + 10;
                                currentGoshoHealth = currentGoshoHealth + 10;
                            }
                        }
                    counterGosho++;
                }

                    round++;
                }
                if (counterPesho>counterGosho)
                {
                    Console.WriteLine($"Gosho won in {round + 1}th round.");
                }
                else
                    Console.WriteLine($"Pesho won in {round + 1}th round.");
            
        }
    }
}

