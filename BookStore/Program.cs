using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Classes;

namespace Bookstore
{
    class Program
    {
        static void Main(string[] args)
        {
            Book zeroBugs = new Book("Zero Bugs and Program Faster", "Kate Thompson", 24.98M, 297);
            Book cleanCode = new Book("Clean Code: A Handbook of Agile Crafmanship", "RObert C. Martin", 39.99M, 497);
            Book mythicalManMonth = new Book("The Mythical Man Month", "Frederick Brooks", 49.97M, 399);
            Movie officeSpace = new Movie("Office SPace", 19.99M, "Mike Judge", "Jennifer Aniston", 115);
            Movie tron = new Movie("Tron", 15.99M, "Steve Lisberger", "Jeff Bridges", 110);
            AudioBook jobs = new AudioBook("Steve Jobs", 49.99M, 510, "Dylan Baker");

            ShoppingCart cart = new ShoppingCart();
            cart.AddToCart(zeroBugs);
            cart.AddToCart(cleanCode);
            cart.AddToCart(mythicalManMonth);
            cart.AddToCart(officeSpace);
            cart.AddToCart(tron);
            cart.AddToCart(jobs);

            Console.WriteLine("Books");
            Console.WriteLine();
            foreach(Book item in cart.BookItems)
            {
                Console.WriteLine($"{item.Title} - {item.Author}");
                Console.WriteLine($"{item.Cost.ToString("C")}");
                Console.WriteLine();
            }


            Console.WriteLine("Movies");
            Console.WriteLine();
            foreach (Movie item in cart.MovieItems)
            {
                Console.WriteLine($"{item.Title} - starring {item.Starring} (len. {item.Length})");
                Console.WriteLine($"{item.Cost.ToString("C")}");
                Console.WriteLine();
            }

            Console.WriteLine("AudioBooks");
            Console.WriteLine();
            foreach (AudioBook item in cart.AudioBookItem)
            {
                Console.WriteLine($"{item.Title} - narrated by {item.Narrator} (len. {item.Length})");
                Console.WriteLine($"{item.Cost.ToString("C")}");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("GRAND TOTAL");
            Console.WriteLine(cart.GrandTotal.ToString("C"));

        }
    }
}
