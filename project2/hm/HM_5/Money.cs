using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_5
{
    internal class Money
    {
        public int WholePart { get; set; }
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
        public void Add(int wholePart, int pennies)
        {
            WholePart = WholePart + wholePart;
            Pennies = Pennies + pennies;
        }
        public void Sub(int wholePart, int pennies)
        {
            WholePart = WholePart - wholePart;
            Pennies = Pennies - pennies;
        }

    }
}
