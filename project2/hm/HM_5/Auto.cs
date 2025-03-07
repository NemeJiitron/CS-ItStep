using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_5
{
    internal class Auto : Device
    {
        public Auto() : base("Auto", "Auto desc")
        {
        }
        public void Sound()
        {
            Console.WriteLine("Auto sound");
        }
        public void Show()
        {
            Console.WriteLine(Name);
        }
        public void Desc()
        {
            Console.WriteLine(Description);
        }
    }
}
