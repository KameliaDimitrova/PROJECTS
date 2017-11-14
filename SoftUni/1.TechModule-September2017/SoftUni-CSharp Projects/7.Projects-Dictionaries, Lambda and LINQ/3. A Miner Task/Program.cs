using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var collectGoods = new Dictionary<string, BigInteger>();
            var goods = Console.ReadLine();
            if (goods == "stop")
                return;
            BigInteger quantity = 0;
            
            do
            {
                quantity = BigInteger.Parse(Console.ReadLine());
                if (collectGoods.ContainsKey(goods))
                {
                    collectGoods[goods] = collectGoods[goods] + quantity;
                }
                else
                {
                    collectGoods.Add(goods,quantity);
                }
                goods = Console.ReadLine();
               
            } while (goods!= "stop");

            foreach (var collect in collectGoods)
            {
                Console.WriteLine($"{collect.Key} -> {collect.Value}");
            }
        }
    }
}
