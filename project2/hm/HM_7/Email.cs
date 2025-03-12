using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_7
{
    internal class Email : IValidator
    {
        private string Mail { get; set; }
        public Email(string email)
        {
            Mail = email;
            if (Validate())
            {
                Console.WriteLine("Mail is correct");
            }
            else
            {
                throw new Exception("Incorrect email input");
            }
        }

        public bool Validate()
        {
            return Mail.Contains("@");
        }
    }
}
