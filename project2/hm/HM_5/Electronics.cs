using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_5
{
    internal class Electronics : Product2
    {
        public override int CalculateDiscount()
        {
            Console.WriteLine("Discount for Electronics");
            return 0;
        }
    }
}
