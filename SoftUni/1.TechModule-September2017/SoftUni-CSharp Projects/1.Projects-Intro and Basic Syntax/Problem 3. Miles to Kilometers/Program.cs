using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var Miles = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", Miles * 1.60934);
        }
    }
}
