using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
         
            ushort EndNumber = ushort.Parse(Console.ReadLine());

            for (ushort i = 1; i <= EndNumber; i++)
            {
               if(IsPolindrome(i)== true && SumOfDigits(i)== true && ContainsEvenDigit(i)==true)
                {
                    Console.WriteLine(i);
                }

            }
        }
        static bool IsPolindrome(ushort CurrentNumber)
        {
            string CurrentNumberToString = Convert.ToString(CurrentNumber);
            var counter = 0;
            if ((CurrentNumberToString.Length) == 2 && CurrentNumberToString[0] == (CurrentNumberToString[1]))
                return true;

            else if ((CurrentNumberToString.Length) % 2 != 0)
            {
                for (int i = 1; i <= (CurrentNumberToString.Length - 1) / 2; i++)
                {

                    if (CurrentNumberToString[i - 1] == CurrentNumberToString[CurrentNumberToString.Length - counter - 1])
                    {
                        counter++;

                    }
                }
                if (counter == ((CurrentNumberToString.Length - 1) / 2))
                    return true;
                else
                    return false;
                
            }
            else
                return false;
        }

        static bool SumOfDigits(ushort number)
       
        {
            string str = number.ToString();
            ushort sumOfDigits = 0;
            for (ushort i = 0; i < str.Length; i++)
            {
                sumOfDigits += ushort.Parse(str[i].ToString());
            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ContainsEvenDigit(ushort number)
        {
            string str = number.ToString();
            ushort evenCounter = 0;
            for (ushort i = 0; i < str.Length; i++)
            {
                ushort currentDigit = ushort.Parse(str[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    evenCounter++;
                }
            }
            if (evenCounter > 0)
            {
                return true;
            }
            else
            {
                return false;
                
            }
        }








    }
}
