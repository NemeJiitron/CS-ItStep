using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw7
{
    internal class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Author(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
