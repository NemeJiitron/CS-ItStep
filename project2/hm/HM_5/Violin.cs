using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_5
{
    internal class Violin : MusicalInstrument
    {
        public Violin() :base("Violin", "Violin desc") { }
        public void Sound()
        {
            Console.WriteLine("Violin sound");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }

        public void Desc()
        {
            Console.WriteLine(Description);
        }

        public void History()
        {
            Console.WriteLine("The violin history");
        }
    }
}
