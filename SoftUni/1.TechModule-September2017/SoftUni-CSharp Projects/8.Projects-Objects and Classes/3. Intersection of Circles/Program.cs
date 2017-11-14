using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3.Intersection_of_Circles
{
   
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    public class Circle
    {
        public int radius { get; set; }
        public int center { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var circle1=new Point();
            var circle2=new Point();
            var radius1=new Circle();
            var radius2=new Circle();


            var input1 = Console.ReadLine()
                .Split(' ');
            circle1.x = int.Parse(input1[0]);
            circle1.y = int.Parse(input1[1]);
            radius1.radius = int.Parse(input1[2]);

            var input2 = Console.ReadLine()
                .Split(' ');
            circle2.x = int.Parse(input2[0]);
            circle2.y = int.Parse(input2[1]);
            radius2.radius = int.Parse(input2[2]);

            var result = PrintResult(circle1.x, circle2.x, circle1.y, circle2.y, radius1.radius, radius2.radius);
            Console.WriteLine(result);
        }

        static string PrintResult(int x1,int x2, int y1, int y2, int r1, int r2)
        {
            var dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            if (r1 + r2 >= dist)
                return "Yes";
            else
                return "No";
           
        }
    }
}
