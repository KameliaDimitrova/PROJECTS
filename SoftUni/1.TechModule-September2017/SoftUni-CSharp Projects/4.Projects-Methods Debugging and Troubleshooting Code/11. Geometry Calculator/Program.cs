using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var FigureType = Console.ReadLine();
            switch (FigureType)
            {
                case "triangle":
                    double Side = double.Parse(Console.ReadLine());
                    double Height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{PrintTriangleAres(Side, Height):f2}");
                    break;
                case "square":
                    double SideSquare = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{PrintSquareleAres(SideSquare):f2}");
                    break;
                case "rectangle":
                    double WidthRectriangle = double.Parse(Console.ReadLine());
                    double HeightRectriangle = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{PrintRectriangleAres(WidthRectriangle, HeightRectriangle):f2}");
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{PrintCircleleAres(r):f2}");
                    break;

            }
        }
        static double PrintTriangleAres(double Side, double height)
        {
            var area = (Side * height) / 2;
            return area;
        }

        static double PrintSquareleAres(double Side)
        {
            var area = (Side * Side);
            return area;
        }
        
        static double PrintRectriangleAres(double Width, double height)
        {
            var area = Width * height;
            return area;
        }

        static double PrintCircleleAres(double r)
        {
            var area = Math.PI * r * r;
            return area;
        }

    }
}
