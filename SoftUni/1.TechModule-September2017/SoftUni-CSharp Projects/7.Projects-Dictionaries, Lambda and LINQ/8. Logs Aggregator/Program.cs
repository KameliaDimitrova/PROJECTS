using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var usersAndIpsTimes= new SortedDictionary<string, SortedDictionary<string, int>>();
  
            for (int i = 0; i < number; i++)
            {
                var line = Console.ReadLine()
                    .Split(' ');
                var iP = line[0];
                var user = line[1];
                var time = int.Parse(line[2]);

                if (!usersAndIpsTimes.ContainsKey(user))
                {
                    usersAndIpsTimes[user]= new SortedDictionary<string, int>();
                }
                if (!usersAndIpsTimes[user].ContainsKey(iP))
                {
                    usersAndIpsTimes[user][iP] = time;
                }
                else
                {
                   usersAndIpsTimes[user][iP] = usersAndIpsTimes[user][iP]+time;
                }

            }
            
            foreach (var user in usersAndIpsTimes)
            {
               // var sum = user.Value.Values.Sum();
                 Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} [{String.Join(", ", user.Value.Keys)}]");

            }
            



        }




        
    }
}
