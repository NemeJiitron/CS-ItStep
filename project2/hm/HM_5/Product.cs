using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_5
{
    internal class Product : Money
    {
        public readonly string Name;
        public Product(string name, int whole, int pennies) : base(whole, pennies)
        {
            Name = name;
        }
        public void Add(int whole, int  pennies)
        {
            base.Add(whole, pennies);
        }
        public void Sub(int whole, int pennies)
        {
            base.Sub(whole, pennies);
        }
        public void Print()
        {
            Console.WriteLine(Name);
            Console.Write("Cost: ");
            base.Print();
        }
    }
}
