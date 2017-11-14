using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            float hour = float.Parse(Console.ReadLine());
            float minute = float.Parse(Console.ReadLine());
            float second = float.Parse(Console.ReadLine());
            float hours;
            float minutes;
            float seconds;
            hours = (hour + minute / 60 + (second / 60) / 60);
            minutes = (hour * 60 + minute + second / 60) ;
            seconds = hour * 60 * 60 + minute * 60 + second;
            Console.WriteLine((float)(distance / seconds));
            Console.WriteLine((float)(distance/1000)/hours);
            Console.WriteLine((float)(distance* (0.0006215040273012)) / hours);

          
        }
    }
}
