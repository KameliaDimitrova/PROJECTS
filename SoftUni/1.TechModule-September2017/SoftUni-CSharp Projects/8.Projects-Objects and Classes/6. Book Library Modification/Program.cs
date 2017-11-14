using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Book_Library_Modification
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
                var myLibrary = new Library();
                myLibrary.Name = "SoftUni Library";
                var dictionary = new Dictionary<string, double>();
                var dictionaryDate=new Dictionary <string, DateTime>();
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
                    if (!dictionaryDate.ContainsKey(currentBook.Title))
                    {
                        dictionaryDate[currentBook.Title] =
                            DateTime.ParseExact("01.02.1991", "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    }
                    dictionaryDate[currentBook.Title] = currentBook.ReleaseDate;
                }
                var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);


            foreach (var dates in dictionaryDate.OrderBy(x => x.Value).ThenBy(x => x.Key))
                {
                    if(date<dates.Value)

                    Console.WriteLine($"{dates.Key} -> {dates.Value:dd.MM.yyyy}");
                }
            }

        }
    }


    

