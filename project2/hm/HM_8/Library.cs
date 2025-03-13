using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_8
{
    internal class Library : IDisposable
    {
        public Book[] Books { get; set; }
        public Library(params Book[] books) 
        {
            Books = books;
        }

        public void Append(Book book)
        {
            Books.Append(book);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Library:\n");
            foreach (Book book in Books)
            {
                sb.Append(book.ToString());
            }
            return sb.ToString();
        }
        public void Dispose()
        {
            Console.WriteLine("Library dispose");
            foreach (Book book in Books)
            {
                book.Dispose();
            }
        }
    }
}
