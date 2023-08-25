using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerMethods
{
    class BookCollection
    {
        private string[] bookTitles;

        public BookCollection(int size)
        {
            bookTitles = new string[size];
        }

        public string this[int index]
        {
            get { return bookTitles[index]; }
            set { bookTitles[index] = value; }
        }
    }
}
