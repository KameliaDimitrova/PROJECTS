using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] FirstArr = Console.ReadLine().Split(' ').ToArray();
            string[] SecondArr = Console.ReadLine().Split(' ').ToArray();
            var StartCounter = 0;
            var EndCounter = 0;
            int n = 0;
            int m = 0;
            n = SecondArr.Length - 1;
            m = FirstArr.Length - 1;
            if (FirstArr.Length < SecondArr.Length)
            {
                for (int i = 0; i < FirstArr.Length; i++)
                {
                    if (FirstArr[i] == SecondArr[i])
                    {
                        StartCounter++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int j = FirstArr.Length - 1; j >= 0; j--)
                {

                    if (FirstArr[j] == SecondArr[n])
                    {

                        EndCounter++;
                        n--;

                    }
                    else
                    {
                        break;
                    }

                }

                if (StartCounter > EndCounter)
                    Console.WriteLine(StartCounter);
                else
                    Console.WriteLine(EndCounter);
            }


            else if (FirstArr.Length >= SecondArr.Length)
            {
                for (int i = 0; i < SecondArr.Length; i++)
                {
                    if (FirstArr[i] == SecondArr[i])
                    {
                        StartCounter++;
                    }
                    else
                    {
                        break;
                    }
                 
                }

                for (int j = SecondArr.Length - 1; j >= 0; j--)
                {

                    if (FirstArr[m] == SecondArr[j])
                    {
                        EndCounter++;
                        m--;
                    }
                    else
                    {
                        break;
                    }

                }

                if (StartCounter > EndCounter)
                    Console.WriteLine(StartCounter);
                else
                    Console.WriteLine(EndCounter);
            }

            else
                Console.WriteLine(0);
        }
    }
}
