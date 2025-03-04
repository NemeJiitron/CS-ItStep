using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw6
{
    internal class CreditCard
    {
        public readonly string _cardNumber;
        public readonly string _fullName;
        public readonly string _CVC;
        public CreditCard(string cardNumber, string fullName, string CVC)
        {
            long.Parse(cardNumber);
            if (CVC.Length != 3)
            {
                throw new ArgumentException("Invalid CVC input");
            }
            _cardNumber = cardNumber;
            _fullName = fullName;
            _CVC = CVC;
        }
        public void print()
        {
            Console.WriteLine(_cardNumber);
            Console.WriteLine(_fullName);
            Console.WriteLine(_CVC);
        }
    }
}
