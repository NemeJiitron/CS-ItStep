using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_5
{
    internal class Microwave : Device
    {
        public Microwave() : base("Microwave", "Microwave desc")
        {
        }
        public void Sound()
        {
            Console.WriteLine("Microwave sound");
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
