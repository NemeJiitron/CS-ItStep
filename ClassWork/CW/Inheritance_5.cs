using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW
{
    internal class cw5
    {
        private three thr;
        public cw5() { thr = new(); }
        public void print()
        {
            thr.print();
        }
        
        private class one
        {
            public one()
            { Console.WriteLine("one constr"); }
            public void print()
            {
                Console.WriteLine("one print");
            }
        }
        private class two : one
        {
            public two()
            { Console.WriteLine("one constr"); }
            public void print()
            {
                base.print();
                Console.WriteLine("two print");
            }
        }
        private class three : two
        {
            public three()
            { Console.WriteLine("one constr"); }
            public void print()
            {
                base.print();
                Console.WriteLine("three print");
            }
        }
    }
    

}
