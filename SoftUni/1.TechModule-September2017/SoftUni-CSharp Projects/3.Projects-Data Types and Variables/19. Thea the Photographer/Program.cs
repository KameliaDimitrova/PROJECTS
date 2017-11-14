using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterPersentage = long.Parse(Console.ReadLine());
            long uploadingTime = long.Parse(Console.ReadLine());
            long remainPictures = 0;
            long seconds = 0;
            remainPictures = (long)Math.Ceiling((double)(N * filterPersentage / 100d));
            seconds = (long)(N * filterTime + remainPictures * uploadingTime);
            ConvertSecondsToDate(seconds);
        }

        static void ConvertSecondsToDate(long seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            Console.WriteLine(t.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
