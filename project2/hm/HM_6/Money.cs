using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_6
{
    internal class Money
    {
        private int wholePart;
        public int WholePart
        {
            get
            {
                return wholePart;
            }
            set
            {
                if (value < 0)
                {
                    throw new BankrutException("Money is below 0 :(");
                }
                wholePart = value;
            }
        }
        private int pennies;
        public int Pennies
        {
            get
            {
                return pennies;
            }
            set
            {
                if (value > 100)
                {
                    WholePart += value / 100;
                    pennies = value % 100;
                    return;
                }
                else if (value < 0)
                {
                    WholePart += value / 100;
                    pennies = 100 + (value % 100);
                    WholePart--;
                    return;
                }
                pennies = value;
            }
        }
        public Money(int wholePart, int pennies)
        {
            WholePart = wholePart;
            Pennies = pennies;
        }

        public void Print()
        {
            Console.Write("Whole part - " + WholePart.ToString() + " ");
            Console.WriteLine("Pennies - " + Pennies.ToString());
        }
        public void SetValues(int wholePart, int pennies)
        {
            WholePart = wholePart;
            Pennies = pennies;
        }
        public static Money operator +(Money a, Money b)
        {
            return new Money(a.WholePart + b.WholePart, a.Pennies + b.Pennies);
        }
        public static Money operator -(Money a, Money b)
        {
            return new Money(a.WholePart - b.WholePart, a.Pennies - b.Pennies);
        }
        public static Money operator ++(Money a)
        {
            return new Money(a.WholePart, a.Pennies + 1);
        }
        public static Money operator --(Money a)
        {
            return new Money(a.WholePart, a.Pennies - 1);
        }

    }
}
