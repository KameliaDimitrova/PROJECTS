using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern =
                @"(?<city>[A-Z]{2})(?<temp>[0-9]{1,}.[0-9]{1,2})(?<weather>([a-zA-Z]+))(?=\|)";
            var regex=new Regex(pattern);
            var dictionary=new Dictionary<string,Dictionary<decimal,string>>();
            while (input != "end")
            {
                var collectedMatches = regex.Matches(input);
                if (regex.IsMatch(input))
                {

                    foreach (Match item in collectedMatches)
                    {
                        var currCity = item.Groups["city"].Value;
                        var curWeather = item.Groups["weather"].Value;
                        var curTemp = (item.Groups["temp"].Value);
                        if (!dictionary.ContainsKey(currCity))
                        {
                            dictionary[currCity] = new Dictionary<decimal, string>();
                            dictionary[currCity][decimal.Parse(curTemp)] = curWeather;
                        }
                        else
                        {
                            dictionary[currCity].Clear();
                            dictionary[currCity][decimal.Parse(curTemp)] = curWeather;
                        }
                    }
                }
              
                input = Console.ReadLine();
            }
            
            foreach (var item1 in dictionary.OrderBy(x=>x.Value.Keys.Min()))
            {
                foreach (var item2 in item1.Value)
                 {
                    Console.WriteLine($"{item1.Key} => {item2.Key} => {item2.Value}");
                }
                
            }
       
        }
    }
}
