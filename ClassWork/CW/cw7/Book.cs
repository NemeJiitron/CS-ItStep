using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw7
{
    internal class Book : System.IComparable
    {
        public string Name { get; set; }
        public Author author { get; set; }
        public int Pages { get; set; }

        public int CompareTo(object? obj)
        {
            if(obj is Book other)
            {
                return other.Name.CompareTo(Name);
            }
            throw new NotSupportedException("using of unsupported type");
        }

        public override string ToString()
        {
            return $"Title: {Name}. Author: {author.ToString()}. Pages: {Pages}\n";
        }
    }
}
