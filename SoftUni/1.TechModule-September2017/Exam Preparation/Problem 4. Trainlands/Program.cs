using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputItems= new List<string>();
            var collection=new Dictionary<string,Dictionary<string, int>>();

            while (input != "It's Training Men!")
            {
                inputItems = input
                    .Split(new char[] {'-', ':', '>', '='}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x=>x.Trim())
                    .ToList();

                if (inputItems.Count !=2)
                {
                    var trainName = inputItems[0];
                    var wagonName = inputItems[1];
                    var wagonPower = int.Parse(inputItems[2]);
                    if (!collection.ContainsKey(trainName))
                    {
                        collection[trainName]=new Dictionary<string, int>();
                    }
                    if (!collection[trainName].ContainsKey(wagonName))
                    {
                        collection[trainName][wagonName] = 0;
                    }
                    collection[trainName][wagonName] = wagonPower;
                }
                else if (inputItems.Count == 2)
                {
                    var helperInput = input
                        .Split(new char[] {'-', '>'}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToList();
                    if (helperInput.Count == 2)
                    {
                        var firstTrain = inputItems[0];
                        var secondTrain = inputItems[1];
                        if (!collection.ContainsKey(firstTrain))
                        {
                            collection[firstTrain] = new Dictionary<string, int>();
                        }
                        foreach (var wagon in collection[secondTrain])
                        {
                            collection[firstTrain][wagon.Key] = wagon.Value;
                        }
                        collection.Remove(secondTrain);
                    }
                    else
                    {
                        var firstTrain = inputItems[0];
                        var secondTrain = inputItems[1];
                        if (!collection.ContainsKey(firstTrain))
                        {
                            collection[firstTrain] = new Dictionary<string, int>();
                        }
                        else
                        {
                            collection[firstTrain].Clear();
                        }

                        foreach (var wagon in collection[secondTrain])
                        {
                            collection[firstTrain][wagon.Key] = wagon.Value;
                        }
                    
                    }

                }


                input = Console.ReadLine();
            }
            foreach (var wagon in collection.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Value.Keys.Count))
            {
                Console.WriteLine($"Train: {wagon.Key}");
                foreach (var train in wagon.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"###{train.Key} - {train.Value}");
                    
                }
            }
            
        }

    }
}
