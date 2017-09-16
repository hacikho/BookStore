using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Classes
{
    public class Book
    {
        private string title;
        public string Title
        {
            get { return this.title; }
        }

        private string author;
        public string Author
        {
            get { return this.author; }
        }

        private decimal cost;
        public decimal Cost
        {
            get { return this.cost; }
        }

        private int pageCount;
        public int PageCount
        {
            get { return this.pageCount; }
        }

        public Book(string title, string author, decimal cost, int pageCount)
        {
            this.title = title;
            this.author = author;
            this.cost = cost;
            this.pageCount = pageCount;
        }


    }

}
