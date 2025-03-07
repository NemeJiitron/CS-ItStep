using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_5
{
    internal class MusicalInstrument
    {
        public readonly string Name;
        public readonly string Description;

        public MusicalInstrument(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
