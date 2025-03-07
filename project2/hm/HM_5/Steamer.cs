using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_5
{
    internal class Steamer : Device
    {
        public Steamer() : base("Steamer", "Steamer desc")
        {
        }
        public void Sound()
        {
            Console.WriteLine("Steamer sound");
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
