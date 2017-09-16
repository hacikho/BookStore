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

            ShoppingCart cart = new ShoppingCart();
            cart.AddToCart(zeroBugs);
            cart.AddToCart(cleanCode);
            cart.AddToCart(mythicalManMonth);

            foreach(Book item in cart.CartItems)
            {
                Console.WriteLine($"{item.Title} - {item.Author}");
                Console.WriteLine($"{item.Cost.ToString("C")}");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("GRAND TOTAL");
            Console.WriteLine(cart.GrandTotal.ToString("C"));

        }
    }
}
