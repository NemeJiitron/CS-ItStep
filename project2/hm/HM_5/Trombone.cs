using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_5
{
    internal class Trombone : MusicalInstrument
    {
        public Trombone() : base("Trombone", "Trombone desc") { }

        public void Sound()
        {
            Console.WriteLine("Trombone sound");
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
            Console.WriteLine("The trombone history");
        }
    }
}
