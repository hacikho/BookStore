using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Classes
{
    public class ShoppingCart
    {
        private List<Book> cartItems = new List<Book>();

        public Book[] CartItems
        {
            get { return cartItems.ToArray(); }
        }

        public decimal GrandTotal
        {
            get
            {
                decimal total = 0.0M;
                foreach(Book item in cartItems)
                {
                    total += item.Cost;
                }
                return total;
            }
        }

        public void AddToCart(Book bookToPurchase)
        {
            cartItems.Add(bookToPurchase);
        }
    }
}
