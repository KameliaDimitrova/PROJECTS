using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var CubeSide = double.Parse(Console.ReadLine());
            string CubeParameter = Console.ReadLine();
            switch(CubeParameter)
            {
                case "volume":
                    Console.WriteLine($"{FindVolumeOfACub(CubeSide):f2}");
                    break;
                case "face":
                    Console.WriteLine($"{Math.Sqrt(((FindVolumeOfACub(CubeSide)) / CubeSide) * 2):f2}");
                    break;
                case "space":
                    Console.WriteLine($"{Math.Sqrt(((FindVolumeOfACub(CubeSide)) / CubeSide) * 3):f2}");
                    break;
                case "area":
                    Console.WriteLine($"{((FindVolumeOfACub(CubeSide)) / CubeSide) * 6:f2}");
                    break;

            }

        }
        static double FindVolumeOfACub(double s)
        {
            var Volume = s * s * s;
            return Volume;
        }
    }
}
