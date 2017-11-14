using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            var powerOflLocomotive = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var listOfWagons=new List<int>();

            while (input != "All ofboard!")
            {
                var weigthOfcurrVagon = int.Parse(input);
                listOfWagons.Add(weigthOfcurrVagon);
                if (listOfWagons.Sum() > powerOflLocomotive)
                {
                    var avarege = listOfWagons.Sum()/listOfWagons.Count;
                    var closest = listOfWagons.OrderBy(item => Math.Abs(avarege - item)).First();
                    listOfWagons.Remove(closest);

                }

                input = Console.ReadLine();
            }
            listOfWagons.Reverse();

          Console.Write(string.Join(" ",listOfWagons));
            Console.WriteLine($" {powerOflLocomotive}");


        }
    }
}
