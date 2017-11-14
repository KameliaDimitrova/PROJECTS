using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_2___Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var massagePattern = @"([0-9]+)\s<->\s([A-Za-z0-9]+)$";
            var broadPattern = @"([^0-9]+)\s<->\s([A-Za-z0-9]+)$";
            var massageList=new List<string>();
            var broadcastList=new List<string>();
            var massageRegex = new Regex(massagePattern);
            var broadRegex = new Regex(broadPattern);

            while (input!= "Hornet is Green")
            {
      

                if (massageRegex.IsMatch(input))
                {
                   
                    var recipient = massageRegex.Match(input).Groups[1].Value;
                    var massage= massageRegex.Match(input).Groups[2].Value;
                    char[] charArray = recipient.ToCharArray();
                    Array.Reverse(charArray);

                    massageList.Add(string.Join("",charArray));
                    massageList.Add(massage);
                    
                }

                if (broadRegex.IsMatch((input)))
                {
                    var frequency = broadRegex.Match(input).Groups[1].Value;
                    var massage = broadRegex.Match(input).Groups[2].Value;
                    var changedMass = new StringBuilder();
                    for (int i = 0; i < massage.Length; i++)
                    {
                        if (massage[i] >= 65 && massage[i] <= 90)
                        {
                            changedMass.Append(massage[i].ToString().ToLower());
                        }
                        else if (massage[i] >= 97 && massage[i] <= 122)
                        {
                            changedMass.Append(massage[i].ToString().ToUpper());
                        }
                        else
                        {
                            changedMass.Append(massage[i]);
                        }
                    }
                    broadcastList.Add(changedMass.ToString());
                    broadcastList.Add(frequency);
                    changedMass.Clear();
                }
                input = Console.ReadLine();
            }
            if (broadcastList.Count > 0 && massageList.Count > 0)
            {
                Console.WriteLine("Broadcasts:");
                for (int i = 0; i < broadcastList.Count-1; i+=2)
                {
                    Console.WriteLine($"{broadcastList[i]} -> {broadcastList[i+1]}");
                }
                Console.WriteLine("Messages:");
                for (int i = 0; i < massageList.Count - 1; i+=2)
                {
                    Console.WriteLine($"{massageList[i]} -> {massageList[i + 1]}");
                }
            }
            else if (broadcastList.Count == 0 && massageList.Count > 0)
            {
                Console.WriteLine("Broadcasts:");
                Console.WriteLine("None");
                Console.WriteLine("Messages:");
                for (int i = 0; i < massageList.Count - 1; i+=2)
                {
                    Console.WriteLine($"{massageList[i]} -> {massageList[i + 1]}");
                }
            }
            else if (broadcastList.Count > 0 && massageList.Count == 0)
            {
                Console.WriteLine("Broadcasts:");
                for (int i = 0; i < broadcastList.Count - 1; i+=2)
                {
                    Console.WriteLine($"{broadcastList[i]} -> {broadcastList[i + 1]}");
                }
          
                Console.WriteLine("Messages:");
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine("Broadcasts:");
                Console.WriteLine("None");
                Console.WriteLine("Messages:");
                Console.WriteLine("None");
            }
            

        }
    }
}
