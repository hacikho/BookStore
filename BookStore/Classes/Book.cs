using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Classes
{
    public class Book : BookStoreItem
    {
        private string author;
        public string Author
        {
            get { return this.author; }
        }

        private int pageCount;
        public int PageCount
        {
            get { return this.pageCount; }
        }

        public Book(string title, string author, decimal cost, int pageCount) : base(title, cost)
        {
            this.author = author;
            this.pageCount = pageCount;
        }


    }

}
