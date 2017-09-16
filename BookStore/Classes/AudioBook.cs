using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Classes
{
    public class AudioBook : BookStoreItem
    {
        private int length;
        public int Length
        {
            get { return this.length; }
        }

        private string narrator;
        public string Narrator
        {
            get { return this.narrator; }
        }

        public AudioBook(string title, decimal cost, int length, string narrator)
            :base(title, cost)
        {
            this.length = length;
            this.narrator = narrator;
        }
    }
}
