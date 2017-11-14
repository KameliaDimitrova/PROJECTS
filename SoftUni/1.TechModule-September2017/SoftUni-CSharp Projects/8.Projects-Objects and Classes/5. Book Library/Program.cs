using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Book_Library
{
    public class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Number { get; set; }
        public double Price { get; set; }
        
    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
       
    }
        

    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse((Console.ReadLine()));
            var myLibrary=new Library();
            myLibrary.Name = "SoftUni Library";
            var dictionary=new Dictionary<string,double>();

            for (int i = 0; i < number; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                var currentBook = new Book();
                currentBook.Title = inputLine[0];
                currentBook.Autor = inputLine[1];
                currentBook.Publisher = inputLine[2];
                currentBook.ReleaseDate =
                    DateTime.ParseExact(inputLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                currentBook.Number = inputLine[4];
                currentBook.Price = Double.Parse(inputLine[5]);
                if (!dictionary.ContainsKey(currentBook.Autor))
                {
                    dictionary[currentBook.Autor] = 0.0;
                }
                dictionary[currentBook.Autor] += currentBook.Price;
            }

            foreach (var autor in dictionary.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{autor.Key} -> {autor.Value:f2}");
                }
        }
        
    }
}
