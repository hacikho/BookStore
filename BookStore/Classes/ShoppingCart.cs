using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Classes
{
    public class ShoppingCart
    {
        private List<Book> bookItems = new List<Book>();
        private List<Movie> movieItems = new List<Movie>();
        private List<AudioBook> audioBookItems = new List<AudioBook>();

        public Book[] BookItems
        {
            get { return this.bookItems.ToArray(); }
        }

        public Movie[] MovieItems
        {
            get { return this.movieItems.ToArray(); }
        }

        public AudioBook[] AudioBookItem
        {
            get { return this.audioBookItems.ToArray(); }
        }

        public decimal GrandTotal
        {
            get
            {
                decimal total = 0.0M;
                foreach(Book item in bookItems)
                {
                    total += item.Cost;
                }

                foreach(Movie item in this.movieItems)
                {
                    total += item.Cost;
                }

                foreach(AudioBook item in this.audioBookItems)
                {
                    total += item.Cost;
                }
                return total;
            }
        }

        public void AddToCart(Book bookToPurchase)
        {
            bookItems.Add(bookToPurchase);
        }

        public void AddToCart(Movie movieToPurchase)
        {
            movieItems.Add(movieToPurchase);
        }

        public void AddToCart(AudioBook audioBookToPurchase)
        {
            audioBookItems.Add(audioBookToPurchase);
        }
    }
}
