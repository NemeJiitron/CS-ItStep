using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_4
{ 
    internal class TemperatureArray
    {
        private int[] ints;
        public int this[int index]
        {
            get
            {
                if (index > 6 || index < 0)
                {
                    Console.WriteLine("Out of range");
                    return 0;
                }
                return ints[index];
            }
            set
            {
                if (index > 6 || index < 0)
                {
                    Console.WriteLine("Out of range");
                    return;
                }
                ints[index] = value;
            }
        }
        public TemperatureArray()
        {
            this.ints = new int[7];
        }

        public int Average()
        {
            int sum = 0;
            for (int i = 0; i < this.ints.Length; i++)
            {
                sum += this.ints[i];
            }
            return sum / 7;
        }

    }
}
