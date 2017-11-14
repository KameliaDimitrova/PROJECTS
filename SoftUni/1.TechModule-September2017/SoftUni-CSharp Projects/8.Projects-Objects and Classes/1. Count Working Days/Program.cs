using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = Console.ReadLine();
            var endDate = Console.ReadLine();

            DateTime firstDateTime= DateTime.ParseExact(startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDateTime = DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var counter = 0;

            DateTime[] holidays = new DateTime[11];
            {
                holidays[0] = new DateTime(4, 01, 01);
                holidays[1] = new DateTime(4, 03, 03);
                holidays[2] = new DateTime(4, 05, 01);
                holidays[3] = new DateTime(4, 05, 06);
                holidays[4] = new DateTime(4, 05, 24);
                holidays[5] = new DateTime(4, 09, 06);
                holidays[6] = new DateTime(4, 09, 22);
                holidays[7] = new DateTime(4, 11, 01);
                holidays[8] = new DateTime(4, 12, 24);
                holidays[9] = new DateTime(4, 12, 25);
                holidays[10] = new DateTime(4, 12, 26);
            }

            for (DateTime i = firstDateTime; i <= secondDateTime; i=i.AddDays(1))
                
            {
                var temp=new DateTime(4,i.Month,i.Day);
                if (!holidays.Contains(temp)&& !(i.DayOfWeek.Equals(DayOfWeek.Saturday))&& !(i.DayOfWeek.Equals(DayOfWeek.Sunday)))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
