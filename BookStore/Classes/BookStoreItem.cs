using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Classes
{
    public class BookStoreItem
    {
        private decimal cost;
        public decimal Cost
        {
            get { return this.cost; }
        }

        private string title;
        public string Title
        {
            get { return this.title; }
        }

        public BookStoreItem(string title, decimal cost)
        {
            this.title = title;
            this.cost = cost;
        }
    }
}
