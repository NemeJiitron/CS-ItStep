using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw7
{
    internal class Library : System.Collections.IEnumerable
    {
        Book[] books =
        {
            new Book()
            {
                Name = "The Witcher: Last wish",
                author = new Author("Angey", "Spkowski"),
                Pages = 300
            },
            new Book()
            {
                Name = "Harry potter",
                author = new Author("Joan", "Rowling"),
                Pages = 300
            },
            new Book()
            {
                Name = "Little prince",
                author = new Author("Kto to", "Tam"),
                Pages = 300
            }
        };
        public void Sort()
        {
            Array.Sort(books);
        }
        public void Sort(IComparer comparer)
        {
            Array.Sort(books, comparer);
        }
        public IEnumerator GetEnumerator()
        {
            return books.GetEnumerator();
        }
    }
}
