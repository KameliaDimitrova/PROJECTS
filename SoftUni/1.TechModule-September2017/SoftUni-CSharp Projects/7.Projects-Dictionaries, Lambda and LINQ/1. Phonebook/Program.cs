using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = new string[3];
            string phone;
            var phonebook = new Dictionary<string, string>();
          
            do
            {
                commands = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                if (commands[0] == "A")
                {
                   
                    phonebook[commands[1]] = commands[2];
                }
                else if (commands[0]=="S")
                {
                    if (phonebook.ContainsKey(commands[1]))
                    {
                        phonebook.TryGetValue(commands[1], out phone);
                        Console.WriteLine("{0} -> {1}", commands[1],phone);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {commands[1]} does not exist.");
                    }
                }
                
            } while (commands[0] != "END");


        }
    }
}
