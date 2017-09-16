using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Classes
{
    public class Movie : BookStoreItem
    {
        private string director;
        public string Director
        {
            get { return this.director; }
        }

        private string starring;
        public string Starring
        {
            get { return this.starring; }
        }

        private int length;
        public int Length
        {
            get { return this.length; }
        }

        public Movie(string title, decimal cost, string director, string starring, int length)
            :base(title, cost)
        {
            this.director = director;
            this.starring = starring;
            this.length = length;
        }
    }
}
