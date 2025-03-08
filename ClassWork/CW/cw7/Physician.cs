using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw7
{
    internal class Physician : IResearcher
    {
        public void Invent()
        {
            Console.WriteLine("Phisician invententing invention");
        }

        public void Investigate()
        {
            Console.WriteLine("Phisician investigating investigation");
        }
    }
}
