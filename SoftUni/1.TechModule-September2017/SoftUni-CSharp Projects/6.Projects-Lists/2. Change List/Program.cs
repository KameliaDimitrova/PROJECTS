using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringOfnumbers = Console.ReadLine()
                .Split(' ')
                .ToList();
       
            var exit = "0";
       
            do
            {
                var command = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                if (command[0] == "Delete")
                {
                    for (int i = 0; i < stringOfnumbers.Count;)
                    {
                        if (command[1] == stringOfnumbers[i])
                        {
                            stringOfnumbers.Remove(command[1]);
                        }
                        else
                            i++;
                    }
                }
                else if (command[0] == "Insert")
                {
                    int possition = (int.Parse(command[2]));
                    stringOfnumbers.Insert(possition, command[1]);
                }
                exit = command[0];
            } while (exit != "Odd"&&exit!="Even");

            if (exit == "Odd")
            {
                for (int j = 0; j < stringOfnumbers.Count; j++)
                {
                    if (int.Parse(stringOfnumbers[j]) % 2 != 0)
                    {
                        Console.Write($"{stringOfnumbers[j]} ");
                    }

                }
            }
            else if (exit == "Even")
            {
                for (int j = 0; j < stringOfnumbers.Count; j++)
                {
                    if (int.Parse(stringOfnumbers[j]) % 2 == 0&& int.Parse(stringOfnumbers[j])!=0)
                    {
                        Console.Write($"{stringOfnumbers[j]} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
