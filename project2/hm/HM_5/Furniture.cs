using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_5
{    internal class Furniture : Product2
    {
        public override int CalculateDiscount()
        {
            Console.WriteLine("Discount for Furniture");
            return 0;
        }
    }
}
