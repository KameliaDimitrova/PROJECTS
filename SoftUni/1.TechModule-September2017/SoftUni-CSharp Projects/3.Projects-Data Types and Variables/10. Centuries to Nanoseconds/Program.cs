using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            var years = 0;
            var days = 0;
            var hours = 0;
            long minutes = 0;
            long seconds = 0;
            ulong miliseconds = 0;
            BigInteger mikroseconds = 0;
            BigInteger nanoseconds = 0;
            years = centuries * 100;
            days = (int)(years * 365.2422);
            hours = days * 24;
            minutes = hours * 60;
            seconds = minutes * 60;
            miliseconds = (ulong)(seconds * 1000);
            mikroseconds = (BigInteger)(miliseconds * 1000);
            nanoseconds = mikroseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {mikroseconds} microseconds = {nanoseconds} nanoseconds");


        }
    }
}
