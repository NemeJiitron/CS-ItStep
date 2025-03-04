using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_4
{
    internal class BookList
    {
        private string[] books;
        public string[] Books
            { get { return books; } }
        public int Length
        {
            get { return books.Length; }
        }
        public BookList() : this(0) {}
        private BookList(int length)
        {
            books = new string[length];
        }
        public string this[int index]
        { 
            get 
            {
                if (index >= books.Length || index < 0)
                {
                    Console.WriteLine("Index out of range");
                    return "NULL";
                }
                return books[index]; 
            } 
            set 
            {
                if (index >= books.Length || index < 0)
                {
                    Console.WriteLine("Index out of range");
                    return;
                }
                books[index] = value; 
            } 
        }
        public static BookList operator +(BookList booklist, string book)
        {
            BookList newList = new BookList(booklist.Length + 1);
            for (int i = 0; i < booklist.Length; i++)
            {
                newList[i] = booklist[i];
            }
            newList[booklist.Length] = book;
            return newList;
        }
        public void Print()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
        public void Erase(int index)
        {
            string[] newBooks = new string[this.Length - 1];
            for (int i = 0, j = 0; i < this.Length; i++)
            {
                if(i == index)
                {
                    continue;
                }
                newBooks[j] = this[i];
                j++;
            }
            books = newBooks;        
        }
    }
}
