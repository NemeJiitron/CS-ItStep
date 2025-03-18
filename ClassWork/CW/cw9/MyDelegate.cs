using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_9
{
    internal class MyDelegate
    {
        
        public delegate double BinaryDel(double x, double y);
        public delegate string IsEven(int x);
        public delegate bool IsWeekend(string day);
        public delegate int MaxMin(int[] arr);
        public delegate int[] Filter(int[] arr);
    }
}
