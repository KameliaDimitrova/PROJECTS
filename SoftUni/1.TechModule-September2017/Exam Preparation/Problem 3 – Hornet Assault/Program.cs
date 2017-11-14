using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_3___Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<long>();
            var hornetIndex = 0;
            var bees = Console.ReadLine()
                    .Split(' ')
                    .Select(long.Parse)
                    .ToList();
               var hornet = Console.ReadLine()
                    .Split(' ')
                    .Select(long.Parse)
                    .ToList();
                var hornetPower = (long)(hornet.Sum());
                for (int i = 0; i < bees.Count; i++)
                {

                if (bees[i] > hornetPower)
                    {
                        result.Add(bees[i] - hornetPower);
                        if (hornet.Count > 0)
                        {
                            hornet.RemoveAt(hornetIndex);
                        }
                    }
                    else if (bees[i] == hornetPower)
                    {
                    if (hornet.Count > 0)
                    {
                        hornet.RemoveAt(hornetIndex);
                    }
                    bees.RemoveAt(i);
                        i--;

                    }
                    else if (bees[i] < hornetPower)
                    {
                        bees.RemoveAt(i);
                        i--;
                    }
                    hornetPower = (long)(hornet.Sum());
            }
            
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else if (hornet.Count > 0)
            {
                Console.WriteLine(string.Join(" ", hornet));
            }
       
        }
    }
}
