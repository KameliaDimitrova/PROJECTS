using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var X1 = Double.Parse(Console.ReadLine());
            var Y1 = Double.Parse(Console.ReadLine());
            var X2 = Double.Parse(Console.ReadLine());
            var Y2 = Double.Parse(Console.ReadLine());
            if (NearestPointToTheCenterOfCoordinateSystem(X1, Y1) < NearestPointToTheCenterOfCoordinateSystem(X2, Y2))

            Console.WriteLine($"({X1}, {Y1})"); 
            
            else if (NearestPointToTheCenterOfCoordinateSystem(X1, Y1) > NearestPointToTheCenterOfCoordinateSystem(X2, Y2))

            Console.WriteLine($"({X2}, {Y2})"); 
            
            else
             Console.WriteLine($"({X1}, {Y1})");
        }

        
        static double NearestPointToTheCenterOfCoordinateSystem(double a, double b)
        {
            double c = 0;
            c = Math.Abs(a) * Math.Abs(a) + Math.Abs(b)*Math.Abs(b);
            return c;

        }
    }
}
