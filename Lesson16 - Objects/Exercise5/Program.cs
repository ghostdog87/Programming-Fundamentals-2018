using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
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

                string author = input[1];
                decimal price = decimal.Parse(input[5]);

                Book book = new Book(author, price);

                library.Books.Add(book);



            }

            Dictionary<string, decimal> sortedLibrary = new Dictionary<string, decimal>();

            foreach (var book in library.Books)
            {
                if (!sortedLibrary.ContainsKey(book.Author))
                {
                    sortedLibrary.Add(book.Author, book.Price);
                }
                else
                {
                    sortedLibrary[book.Author] += book.Price;
                }
            }

            

            foreach (var author in sortedLibrary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
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
        public string ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public Book(string author,decimal price)
        {
            Author = author;
            Price = price;
        }
    }
}
