using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();
            var dictionary=new SortedDictionary<string,Dictionary<string,int>>();

            while (input[0] != "end")

            {
                var helpiP = input[0]
                    .Split('=')
                    .ToList();
                var massage = input[1];
                var helpuser = input[2]
                    .Split('=')
                    .ToList();
                var iP = helpiP[1];
                var user = helpuser[1];

                if (!dictionary.ContainsKey(user))
                {
                    dictionary[user] = new Dictionary<string, int>();
                }
                if (!dictionary[user].ContainsKey(iP))
                {
                    dictionary[user][iP] = 0;
                }
                dictionary[user][iP]++;
                input = Console.ReadLine()
                    .Split(' ')
                    .ToList();
            }

            foreach (var user in dictionary)
            {
                Console.WriteLine($"{user.Key}:");
                string result=""; //стринг, в който ще се съхранява стойността, която ще се птпечата
                char[] trimChars = new char[] { ',', ' ' }; // чар арей, в който се съхраняват символите, които искаме да премахнем накрая
                foreach (var user2 in user.Value)
                {
                    result =$"{result}{user2.Key} => {user2.Value}, "; // съхраняваме всички стойности, които после да отпечатаме
               
                }
               string reduced = result.TrimEnd(trimChars).TrimStart(trimChars);// махаме последната запетая и празно място и слагаме точка
               Console.WriteLine( $"{reduced}.");

            }
           }
    }
}
