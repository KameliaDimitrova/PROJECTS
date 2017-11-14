using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            long IdNumber = long.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName}\nLast name: {secondName}\nAge: {age}\nGender: {sex}\nPersonal ID: {IdNumber}\nUnique Employee number: {employeeNumber}");


        }
    }
}
