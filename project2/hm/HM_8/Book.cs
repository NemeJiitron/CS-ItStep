using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using project2.hm.HM_5;

namespace project2.hm.HM_8
{
    internal class Book : IDisposable
    {
        public readonly string _name;
        public readonly string _author;
        public readonly string _date;
        public readonly int _pages;

        public Book(string name, string author, string date, int pages)
        {
            this._name = name;
            this._author = author;
            this._date = date;
            this._pages = pages;
        }

        public override string ToString()
        {
            return $"Title: {_name}. Author: {_author.ToString()}. Date of release: {_date}. Pages: {_pages}.\n";
        }
        public void CreateGarbage()
        {
            for(int i = 0; i < 100; i++) 
            {
                Book b = new Book("", "", "", 0);
            }
        }
        public void Dispose()
        {
            Console.WriteLine("Book dispose");
        }

        ~Book() 
        {
            Console.WriteLine("Book finalizier");
        }

    }
}
