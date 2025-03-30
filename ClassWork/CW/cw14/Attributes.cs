using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw14
{
    internal class Attributes
    {
        [Obsolete(message:("Old, bad method"))]
        public static void OldMethod()
        {
            Console.WriteLine("bad method");
        }



    }
}
