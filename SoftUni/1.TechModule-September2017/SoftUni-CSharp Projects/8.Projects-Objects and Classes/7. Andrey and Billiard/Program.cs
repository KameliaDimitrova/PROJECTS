using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Andrey_and_Billiard
{
  
class Program

    {
    static void Main(string[] args)
    {
        var Number = int.Parse(Console.ReadLine());
        var priceList=new Dictionary<string,decimal>();
                for (int i = 0; i < Number; i++)
                {
                    var input = Console.ReadLine()
                        .Split('-')
                        .ToList();
                    var product = input[0];
                    var price = input[1];
                    if (!priceList.ContainsKey(product))
                    {
                        priceList[product] = 0;
                    }
                    priceList[product] = decimal.Parse(price);
                }

        var bill = new SortedDictionary<string, Dictionary <string, decimal>>();
        var currClient = Console.ReadLine()
                    .Split('-',',')
                    .ToList();
        
        while (currClient[0] != "end of clients")
        {
            var name = currClient[0];
            var currproduct = currClient[1];
            var quont = int.Parse(currClient[2]);
                if (priceList.ContainsKey(currproduct))
            {
                if (!bill.ContainsKey(name))
                {
                    bill[name] = new Dictionary<string, decimal>();
                    
                }
                if (!bill[name].ContainsKey(currproduct))
                {
                    bill[name][currproduct] = 0;
                    }
                bill[name][currproduct] = quont + bill[name][currproduct];
                }

            currClient = Console.ReadLine()
                .Split('-', ',')
                .ToList();
                
        }
        decimal total = 0;
        decimal subTotal = 0;
            
        foreach (var client in bill)
        {
            Console.WriteLine($"{client.Key}");
            foreach (var product in client.Value)
            {
                    
               
                Console.WriteLine($"-- {product.Key} - {product.Value}");
                total = total + product.Value * priceList[product.Key];
            }
            subTotal = subTotal + total;
            Console.WriteLine($"Bill: {total:f2}");
            total = 0;
        }

        {
            Console.WriteLine($"Total bill: {subTotal:f2}");
        }

    }










            //public class Customer
            //{
            //    public string Name { get; set; }
            //    public Dictionary<string, int> ProductsAndQuont { get; set; }
            //    public decimal Bill { get; set; }
            //}
            //class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        var Number = int.Parse(Console.ReadLine());
            //        var dictionary=new Dictionary<string,decimal>();
            //        for (int i = 0; i < Number; i++)
            //        {
            //            var input = Console.ReadLine()
            //                .Split('-')
            //                .ToList();
            //            var product = input[0];
            //            var price = input[1];
            //            if (!dictionary.ContainsKey(product))
            //            {
            //                dictionary[product] = 0;
            //            }
            //            dictionary[product] = decimal.Parse(price);
            //        }

            //        var inputClient = Console.ReadLine()
            //            .Split('-',',')
            //            .ToList();
            //        while (inputClient[0]!= "end of clients")
            //        {
            //            var newKClient=new Customer();
            //            var curName = inputClient[0];
            //            var curProduct = inputClient[1];
            //            var curQuont = inputClient[2];
            //            newKClient.Name = curName;
            //            newKClient.ProductsAndQuont[curProduct]= int.Parse(curQuont);

            //                           if(dictionary.ContainsKey(inputClient[1]))
            //            {
            //                newKClient.Bill = newKClient.ProductsAndQuont[inputClient[1]] * dictionary[inputClient[1]];
            //                Console.WriteLine(newKClient.Bill);
            //            }
            //        }



        
    }
    
}
