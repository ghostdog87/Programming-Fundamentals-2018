using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Library library = new Library("Pesho");

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split();

                string title = input[0];
                string author = input[1];
                decimal price = decimal.Parse(input[5]);
                DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                Book book = new Book(title,author, price, releaseDate);

                library.Books.Add(book);
            }

            DateTime someDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);



            foreach (var title in library.Books.Where(x => x.ReleaseDate > someDate).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                Console.WriteLine($"{title.Title} -> {title.ReleaseDate:dd.MM.yyyy}");
            }
        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Library(string name)
        {
            Name = name;
            Books = new List<Book>();
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public Book(string title,string author, decimal price, DateTime releaseDate)
        {
            Title = title;
            Author = author;
            Price = price;
            ReleaseDate = releaseDate;
        }
    }
}
