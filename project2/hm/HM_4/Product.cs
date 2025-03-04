using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_4
{
    internal class Product
    {
        private string Name
        { get; set; }
        private int Amount
        { get; set; }
        private int Cost
        { get; set; }
        public Product(string name, int amount, int cost) 
        {
            Name = name;
            Amount = amount;
            Cost = cost;
        }
        public static Product operator +(Product a, int val)
        {
            return new Product(a.Name, a.Amount + val, a.Cost);   
        }
        public static Product operator -(Product a, int val)
        {
            return new Product(a.Name, a.Amount - val, a.Cost);
        }
        public static bool operator ==(Product a, Product b)
        {
            return a.Cost == b.Cost;
        }
        public static bool operator !=(Product a, Product b)
        {
            return a.Cost != b.Cost;
        }
        public static bool operator >(Product a, Product b)
        {
            return a.Amount > b.Amount;
        }
        public static bool operator <(Product a, Product b)
        {
            return a.Amount < b.Amount;
        }
    }
}
